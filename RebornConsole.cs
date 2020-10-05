using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Interfaces;
using ff14bot.Managers;
using ff14bot.Objects;
using ff14bot.Settings;
using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;
using Newtonsoft.Json;
using CSharpCodeProvider = Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider;
using Logger = ff14bot.Helpers.Logging;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ff14bot.Managers;
using ff14bot.AClasses;
using System.Windows;
using System.Windows.Controls;
using Application = System.Windows.Application;
using Button = System.Windows.Controls.Button;
using ComboBox = System.Windows.Controls.ComboBox;
using HorizontalAlignment = System.Windows.HorizontalAlignment;

namespace RebornConsoleMod
{
	public class RebornConsole : BotPlugin
	{
		public static string TempFolder = Path.Combine(GlobalSettings.Instance.PluginsPath, @"RebornConsoleMod\Temp\");//Utils.AssemblyDirectory + @"\Plugins\RebornConsole\Temp\";
		internal static AppDomainDriver CodeDriver = new AppDomainDriver();
		private readonly Version _version = new Version(1, 10);
		private Thread newThread;
		public RebornConsole()
		{
			Instance = this;
			if (!_init)
			{
				//logr = Logger.GetLoggerInstanceForType();
				// using ctor so plugin doesn't need to be 'Enabled' to initialize..
				try
				{
					WipeTempFolder();
				}
				catch (Exception ex)
				{
					//logr.Debug(ex.ToString());
				}
				_init = true;
			}

		}


		public override string Author
		{
			get { return "akira0245"; }
		}

		public override string Name
		{
			get
			{
				return "RebornConsoleMod";
			}
		}

		public override bool WantButton
		{
			get { return true; }
		}

		public override string ButtonText
		{
			get { return "meow"; }
		}


		public override void OnShutdown()
		{
			CloseForm();

		}

		private Button btn;
		public override void OnEnabled()
		{
			System.Windows.Forms.Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
			System.Windows.Forms.Application.EnableVisualStyles();

			if (!Application.Current.MainWindow.CheckAccess())
			{
				Logger.Write("Current Thread {0} '{1}' cannot access MainWindow Dispatcher",
					Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name);

				return;
			}
			Application.Current.MainWindow.Dispatcher.Invoke(() =>
			{
				var mainWindow = Application.Current.MainWindow;
				var buttons = mainWindow.FindName("BotBox") as ComboBox;
				var Grid = buttons.Parent as Grid;
				btn = new Button
				{
					Margin = new Thickness(0, 169, 10, 0),
					IsEnabled = true,
					HorizontalAlignment = HorizontalAlignment.Right,
					Width = 129,
					Height = 18,
					VerticalAlignment = VerticalAlignment.Top,
#if RB_CN
                    Content = "¿ØÖÆÌ¨",
#else
					Content = "Console",
#endif
					Name = "Console",
					Visibility = Visibility.Visible,
				};
				btn.Click += ClickEvent;
				Grid.Children.Insert(4, btn);
			});
			//ToggleRBConsole();
		}
		private void ClickEvent(object sender, RoutedEventArgs e)
		{
			ToggleRBConsole();
		}

		public override void OnDisabled()
		{
			Application.Current.MainWindow.Dispatcher.Invoke(() =>
			{
				var mainWindow = Application.Current.MainWindow;
				var buttons = mainWindow.FindName("BotBox") as ComboBox;
				var Grid = buttons.Parent as Grid;
				if (btn == null || Grid == null)
					return;
				Grid.Children.Remove(btn);
			});
			//CloseForm();
		}



		public override Version Version
		{
			get
			{
				return new Version(0, 0, 1);
			}
		}


		private static bool _init;


		public static RebornConsole Instance { get; private set; }



		private void WipeTempFolder()
		{
			if (!Directory.Exists(TempFolder))
			{
				Directory.CreateDirectory(TempFolder);
			}
			foreach (string file in Directory.GetFiles(TempFolder, "*.*", SearchOption.AllDirectories))
			{
				try
				{
					File.Delete(file);
				}
				// ReSharper disable EmptyGeneralCatchClause
				catch
				{
				}
				// ReSharper restore EmptyGeneralCatchClause
			}
		}

		public override void OnButtonPress()
		{
			ToggleRBConsole();
		}


		internal Thread _guiThread;
		internal MainForm remoteForm;
		public void ToggleRBConsole()
		{
			if (_guiThread == null || !_guiThread.IsAlive)
			{
				_guiThread = new Thread(() =>
				{
					remoteForm = new MainForm();


					HotkeyManager.Unregister("RebornConsoleMod");
					HotkeyManager.Register("RebornConsoleMod", RebornConsoleSettings.Instance.Key, RebornConsoleSettings.Instance.ModifierKey, hotkey => { remoteForm.invokeCompile(); });

					remoteForm.ShowDialog();
				})
				{ IsBackground = true };
				_guiThread.SetApartmentState(ApartmentState.STA);
				_guiThread.Start();
			}
			else
			{
				CloseForm();
			}
		}
		private void CloseForm()
		{
			if (remoteForm != null && remoteForm.Visible)
			{
				// close the form on the forms thread
				remoteForm.Invoke((MethodInvoker)delegate { remoteForm.Close(); });
			}
		}

		public static void Api(string apiName)
		{
			Type[] types = Assembly.GetEntryAssembly().GetExportedTypes().Where(t => t.Name.Contains(apiName)).ToArray();

			foreach (Type t in types)
			{
				Log(Colors.DarkGreen, "\n  *** {0} ***", t.FullName);
				foreach (MemberInfo mi in t.GetMembers())
				{
					Log("{0}", mi);
				}
			}
		}

		public static void Log(string text, params object[] arg)
		{
			if (arg.Length == 0)
			{
				LogNoFormat(Colors.Black, text);
				return;
			}

			if (!string.IsNullOrEmpty(text))
				Log(Colors.Black, text, arg);
		}
		public static void Log(string text)
		{
			if (!string.IsNullOrEmpty(text))
				Log(Colors.Black, text);
		}
		public static void Logi(IntPtr obj)
		{
			//logr.Debug(text.ToString());
			try
			{
#if RB_X64
                Log(Colors.Black, "{0:X}", (ulong)obj);
#else
				Log(Colors.Black, "{0:X}", (int)obj);
#endif
			}
			catch (System.Exception)
			{

			}

		}
		public static void Log(object obj)
		{
			//logr.Debug(text.ToString());
			try
			{
				if (obj == null)
				{
					Log(Colors.Black, "null");
				}
				else
				{
					LogNoFormat(Colors.Black, obj.ToString());
				}

			}
			catch (System.Exception)
			{

			}

		}

		public static void ClearLog()
		{
			if (MainForm.Instance.OutputTextBox.InvokeRequired)
				MainForm.Instance.OutputTextBox.BeginInvoke(new Action(() => MainForm.Instance.OutputTextBox.Clear()));
			else
				MainForm.Instance.OutputTextBox.Clear();
		}


		public static void LogNoFormat(Color c, string text)
		{
			try
			{
				if (string.IsNullOrEmpty(text))
					return;
				if (MainForm.IsValid)
				{
					try
					{
						if (MainForm.Instance.OutputTextBox.InvokeRequired)
							MainForm.Instance.OutputTextBox.BeginInvoke(new UpdateLogCallback(UpdateLog), c, text);
						else
						{
							MainForm.Instance.OutputTextBox.SelectionStart = MainForm.Instance.OutputTextBox.TextLength;
							MainForm.Instance.OutputTextBox.SelectionColor = System.Drawing.Color.FromArgb(c.A, c.R, c.G, c.B);
							MainForm.Instance.OutputTextBox.SelectedText = text + Environment.NewLine;
							MainForm.Instance.OutputTextBox.ScrollToCaret();
						}
					}
					// ReSharper disable EmptyGeneralCatchClause
					catch
					{
					}
					// ReSharper restore EmptyGeneralCatchClause
				}
				else
				{
					Logging.Write(text);
				}
			}
			catch (Exception e)
			{
				Logging.WriteException(e);
				//logr.Error(e);
				//logr.DebugFormat(text,arg);
			}
		}

		public static void Log(Color c, string text, params object[] arg)
		{
			try
			{
				if (string.IsNullOrEmpty(text))
					return;
				string newtext;
				try
				{
					newtext = string.Format(text, arg);
					text = newtext;
				}
				catch (System.Exception)
				{

				}

				if (MainForm.IsValid)
				{
					try
					{
						if (MainForm.Instance.OutputTextBox.InvokeRequired)
							MainForm.Instance.OutputTextBox.BeginInvoke(new UpdateLogCallback(UpdateLog), c, text);
						else
						{
							MainForm.Instance.OutputTextBox.SelectionStart = MainForm.Instance.OutputTextBox.TextLength;
							MainForm.Instance.OutputTextBox.SelectionColor = System.Drawing.Color.FromArgb(c.A, c.R, c.G, c.B);
							MainForm.Instance.OutputTextBox.SelectedText = text + Environment.NewLine;
							MainForm.Instance.OutputTextBox.ScrollToCaret();
						}

						Logging.WriteToFileSync(LogLevel.Normal, $"[Console] {text}");
					}
					// ReSharper disable EmptyGeneralCatchClause
					catch
					{
					}
					// ReSharper restore EmptyGeneralCatchClause
				}
				else
				{
					Logging.Write(text, arg);
				}
			}
			catch (Exception e)
			{
				Logging.WriteException(e);
				//logr.Error(e);
				//logr.DebugFormat(text,arg);
			}
		}

		internal static void UpdateLog(Color c, string text)
		{
			MainForm.Instance.csharpOutput.SelectionStart = MainForm.Instance.csharpOutput.TextLength;
			MainForm.Instance.csharpOutput.SelectionColor = System.Drawing.Color.FromArgb(c.A, c.R, c.G, c.B);
			MainForm.Instance.csharpOutput.SelectedText = text + Environment.NewLine;
			MainForm.Instance.csharpOutput.ScrollToCaret();
		}

		#region Nested type: UpdateLogCallback

		internal delegate void UpdateLogCallback(Color color, string text);

		#endregion


	}


	public class AppDomainDriver
	{
		public bool CompileAndRun(string code)
		{
			try
			{
				var codeDriver = (CodeDriver)Activator.CreateInstance(typeof(CodeDriver));
				if (MainForm.Instance.PulseCheckbox.Checked)
				{
					Pulsator.Pulse(PulseFlags.All);
				}
				//FateManager.Update();
				return codeDriver.CompileAndRun(code);
			}
			catch (Exception ex)
			{
				RebornConsole.Log(Colors.Red, ex.ToString());
				Logging.Write(ex);
				return false;
			}
		}
	}


	public class CodeDriver
	{
		#region Strings

		private const string Prefix = @"
            using System;   
            using System.Reflection;   
            using System.Data;   
            using System.Threading;   
            using System.Diagnostics;   
            using System.Drawing;   
            using System.Collections.Generic;   
            using System.Collections;    
            using System.Linq;    
            using System.Text;    
            using System.IO;    
            using System.Windows.Forms;   
            using System.Text.RegularExpressions;   
            using System.Globalization;   
            using System.Xml.Linq;  
            using System.Runtime.InteropServices; 
            using System.Reflection.Emit;
            using System.Threading.Tasks;

			using ff14bot;
            using ff14bot.Objects;
            using ff14bot.Managers;
            using ff14bot.NeoProfiles;
            using ff14bot.RemoteWindows;
			using ff14bot.RemoteAgents;
            using ff14bot.Navigation;
            using ff14bot.Enums;
            using Clio.Utilities;
            using ff14bot.BotBases;
			using ff14bot.Helpers;

            public static class Driver   
            {
				public static void Run()
				{
                    //using (Core.Memory.AcquireFrame(true))
                    {";


		private const string PrefixWithFrameLock = @"
            using System;   
            using System.Reflection;   
            using System.Data;   
            using System.Threading;   
            using System.Diagnostics;   
            using System.Drawing;   
            using System.Collections.Generic;   
            using System.Collections;    
            using System.Linq;    
            using System.Text;    
            using System.IO;    
            using System.Windows.Forms;   
            using System.Text.RegularExpressions;   
            using System.Globalization;   
            using System.Xml.Linq;  
            using System.Runtime.InteropServices; 
            using System.Reflection.Emit;
            using System.Threading.Tasks;

			using ff14bot;
            using ff14bot.Objects;
            using ff14bot.Managers;
            using ff14bot.NeoProfiles;
            using ff14bot.RemoteWindows;
			using ff14bot.RemoteAgents;
            using ff14bot.Navigation;
            using ff14bot.Enums;
            using Clio.Utilities;
            using ff14bot.BotBases;
			using ff14bot.Helpers;

            public static class Driver   
            {
				public static void Run()
				{
                    using (Core.Memory.AcquireFrame(true))
                    {";

		private const string Postfix = @"
			        }
                } 
	
		        static void Log (string format, params object[] arg) 
			    { 
				   RebornConsoleMod.RebornConsole.Log(format, arg); 
				} 

	            static void Log(IntPtr format) 
		        { 
			       RebornConsoleMod.RebornConsole.Logi(format); 
				}

	            static void Log(object format) 
		        { 
			       RebornConsoleMod.RebornConsole.Log(format); 
				}

	            static void Api(string format) 
		        { 
			       RebornConsoleMod.RebornConsole.Api(format); 
				}

	            static void ClearLog() 
		        { 
				   RebornConsoleMod.RebornConsole.ClearLog(); 
			    }

				static void fLog(IEnumerable x)
	            {
		       		var sb = new StringBuilder();
					foreach (var item in x)
					{
						sb.AppendLine(item.ToString());
					}
					RebornConsoleMod.RebornConsole.Log(sb.ToString());
				}
			}";
		/*              static List<WoWGameObject> GameObjects {get{return ObjectManager.GetObjectsOfType<WoWGameObject>();}} 
                         static List<WoWObject> Objects {get{return ObjectManager.ObjectList;}} 
                         static List<WoWUnit> Units {get{return ObjectManager.GetObjectsOfType<WoWUnit>();}} 
                         static List<WoWPlayer> Players {get{return ObjectManager.GetObjectsOfType<WoWPlayer>();}} 
                         static List<WoWItem> Items {get{return ObjectManager.GetObjectsOfType<WoWItem>();}} 
                         static List<WoWDynamicObject> DynamicObjects {get{return ObjectManager.GetObjectsOfType<WoWDynamicObject>();}} */

		//private static IEnumerable<GameObject> GameObjects => GameObjectManager.GameObjects;
		//private static IEnumerable<Character> Characters => GameObjectManager.GetObjectsOfType<Character>(true);
		//private static IEnumerable<BattleCharacter> BattleCharacters => GameObjectManager.GetObjectsOfType<BattleCharacter>(true);
		//private static IEnumerable<EventObject> EventObjects => GameObjectManager.GetObjectsOfType<EventObject>(true);
		//private static IEnumerable<HousingObject> HousingObjects => GameObjectManager.GetObjectsOfType<HousingObject>(true);
		//private static IEnumerable<Treasure> Treasures => GameObjectManager.GetObjectsOfType<Treasure>(true);

		#endregion



		static Lazy<CSharpCodeProvider> CodeProvider { get; } = new Lazy<CSharpCodeProvider>(() =>
		{
			var csc = new CSharpCodeProvider();
			var settings = csc
				.GetType()
				.GetField("_compilerSettings", BindingFlags.Instance | BindingFlags.NonPublic)
				.GetValue(csc);

			var path = settings
				.GetType()
				.GetField("_compilerFullPath", BindingFlags.Instance | BindingFlags.NonPublic);

			path.SetValue(settings, ((string)path.GetValue(settings)).Replace(@"bin\roslyn\", @"roslyn\"));

			return csc;
		});

		private static string Input;
		private static CompilerResults Results;
		private static bool FrameLockChecked = true;

		// returns true if compiled sucessfully
		public bool CompileAndRun(string input)
		{
			if (Input != input || FrameLockChecked != MainForm.Instance.FrameLockCheckBox.Checked)
			{
				Input = input;
				FrameLockChecked = MainForm.Instance.FrameLockCheckBox.Checked;

				using (CSharpCodeProvider provider = CodeProvider.Value)
				{
					CompilerParameters options = new CompilerParameters();
					// most recent assembly

					Assembly myAssembly = AppDomain.CurrentDomain.GetAssemblies()
						.Where(a => a.GetName().Name.Contains(RebornConsole.Instance.Name))
						.OrderByDescending(a => new FileInfo(a.Location).CreationTime).FirstOrDefault();

					options.ReferencedAssemblies.Add(myAssembly.Location);
					foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
					{
						if (!asm.GetName().Name.Contains(RebornConsole.Instance.Name) && !asm.IsDynamic)
							options.ReferencedAssemblies.Add(asm.Location);
					}

					options.GenerateExecutable = false;
					options.IncludeDebugInformation = true;
					options.TempFiles = new TempFileCollection(RebornConsole.TempFolder, false);
					options.OutputAssembly = string.Format("{0}\\CodeAssembly{1:N}.dll", RebornConsole.TempFolder, Guid.NewGuid());
					//options.CompilerOptions = "/d:DEBUG /optimize /unsafe";
					options.CompilerOptions = "/optimize /unsafe";

					var sb = new StringBuilder();
					sb.Append(MainForm.Instance.FrameLockCheckBox.Checked ? PrefixWithFrameLock : Prefix);
					sb.Append(input);
					sb.Append(Postfix);
					Results = provider.CompileAssemblyFromSource(options, sb.ToString());
				}
			}

			if (Results.Errors.HasErrors)
			{
				var errorMessage = new StringBuilder();
				var errLineOffset = Prefix.Count(c => c == '\n');
				foreach (CompilerError error in Results.Errors)
				{
					errorMessage.AppendFormat("{0}) {1}\n", error.Line - errLineOffset, error.ErrorText);
				}
				RebornConsole.Log(Colors.Red, errorMessage.ToString());
				return false;
			}
			Type driverType = Results.CompiledAssembly.GetType("Driver");
			try
			{
				driverType.InvokeMember("Run", BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public, null, null, null);
			}
			catch (Exception e)
			{
				RebornConsole.Log(Colors.OrangeRed, e.ToString());
			}

			return true;
		}
	}

	internal class RebornConsoleSettings : JsonSettings
	{
		internal static readonly RebornConsoleSettings Instance = new RebornConsoleSettings();
		private bool _useFrameLock;
		private bool _pulse;

		public RebornConsoleSettings() : base(GetSettingsFilePath("Global", "RebornConsoleMod.json"))
		{
			if (CSharpSniplets == null)
				CSharpSniplets = new[] { "" };

			if (CSharpSnipletNames == null)
				CSharpSnipletNames = new[] { "Untitled1" };

			if (LuaSniplets == null)
				LuaSniplets = new[] { "" };

			if (LuaSnipletNames == null)
				LuaSnipletNames = new[] { "Untitled1" };

			//CSharpSelectedIndex = 0;
			if (Keybind == Keys.None)
				Keybind = Keys.F4;
		}

		[Setting]
		public string[] CSharpSniplets { get; set; }

		[Setting]
		public string[] CSharpSnipletNames { get; set; }

		[Setting]
		public string[] LuaSniplets { get; set; }

		[Setting]
		public string[] LuaSnipletNames { get; set; }

		[Setting]
		public int CSharpSelectedIndex { get; set; }
		[Setting]
		public int LuaSelectedIndex { get; set; }

		[Setting]
		public int TabIndex { get; set; }

		[Setting]
		[DefaultValue(false)]
		public bool ShowLuaTab_ThisCanBeDangerous { get; set; }

		[Setting]
		[DefaultValue(null)]
		public Keys Keybind { get; set; }

		[JsonIgnore]
		public Keys Key
		{
			get
			{
				return (Keys)((int)Keybind & 0x0000FFFF);
			}

		}

		[JsonIgnore]
		public ModifierKeys ModifierKey
		{
			get
			{
				var key = (Keys)((int)Keybind & 0xFFFF0000);
				return (ModifierKeys)Enum.Parse(typeof(ModifierKeys), key.ToString());
			}
		}
	}
}