using ff14bot;

namespace RebornConsoleMod
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.csharpCode = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.自动换行ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.布局切换ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.csharpOutput = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.布局切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.luaCode = new System.Windows.Forms.RichTextBox();
			this.luaOutput = new System.Windows.Forms.RichTextBox();
			this.btnCompile = new System.Windows.Forms.Button();
			this.NewSnipletButton = new System.Windows.Forms.Button();
			this.savedSnipletsCombo = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.btnKeybind = new System.Windows.Forms.Button();
			this.RenameButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.FrameLockCheckBox = new System.Windows.Forms.CheckBox();
			this.PulseCheckbox = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 36);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1091, 657);
			this.tabControl1.TabIndex = 26;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1083, 628);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "C#";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.csharpCode);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.csharpOutput);
			this.splitContainer1.Size = new System.Drawing.Size(1083, 628);
			this.splitContainer1.SplitterDistance = 254;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 0;
			// 
			// csharpCode
			// 
			this.csharpCode.AcceptsTab = true;
			this.csharpCode.AutoWordSelection = true;
			this.csharpCode.ContextMenuStrip = this.contextMenuStrip2;
			this.csharpCode.DetectUrls = false;
			this.csharpCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.csharpCode.EnableAutoDragDrop = true;
			this.csharpCode.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.csharpCode.HideSelection = false;
			this.csharpCode.Location = new System.Drawing.Point(0, 0);
			this.csharpCode.Margin = new System.Windows.Forms.Padding(0);
			this.csharpCode.Name = "csharpCode";
			this.csharpCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.csharpCode.Size = new System.Drawing.Size(1083, 254);
			this.csharpCode.TabIndex = 25;
			this.csharpCode.Text = "";
			this.csharpCode.WordWrap = false;
			this.csharpCode.TextChanged += new System.EventHandler(this.csharpCode_TextChanged);
			this.csharpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行ToolStripMenuItem1,
            this.布局切换ToolStripMenuItem1});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(183, 52);
			// 
			// 自动换行ToolStripMenuItem1
			// 
			this.自动换行ToolStripMenuItem1.Name = "自动换行ToolStripMenuItem1";
			this.自动换行ToolStripMenuItem1.Size = new System.Drawing.Size(182, 24);
			this.自动换行ToolStripMenuItem1.Text = "Word wrap";
			this.自动换行ToolStripMenuItem1.Click += new System.EventHandler(this.自动换行ToolStripMenuItem1_Click);
			// 
			// 布局切换ToolStripMenuItem1
			// 
			this.布局切换ToolStripMenuItem1.Name = "布局切换ToolStripMenuItem1";
			this.布局切换ToolStripMenuItem1.Size = new System.Drawing.Size(182, 24);
			this.布局切换ToolStripMenuItem1.Text = "Change layout";
			this.布局切换ToolStripMenuItem1.Click += new System.EventHandler(this.布局切换ToolStripMenuItem1_Click);
			// 
			// csharpOutput
			// 
			this.csharpOutput.ContextMenuStrip = this.contextMenuStrip1;
			this.csharpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.csharpOutput.EnableAutoDragDrop = true;
			this.csharpOutput.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.csharpOutput.Location = new System.Drawing.Point(0, 0);
			this.csharpOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.csharpOutput.MaxLength = 2100000;
			this.csharpOutput.Name = "csharpOutput";
			this.csharpOutput.ReadOnly = true;
			this.csharpOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.csharpOutput.Size = new System.Drawing.Size(1083, 373);
			this.csharpOutput.TabIndex = 25;
			this.csharpOutput.Text = "";
			this.csharpOutput.WordWrap = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行ToolStripMenuItem,
            this.布局切换ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(183, 52);
			// 
			// 自动换行ToolStripMenuItem
			// 
			this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
			this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
			this.自动换行ToolStripMenuItem.Text = "Word wrap";
			this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
			// 
			// 布局切换ToolStripMenuItem
			// 
			this.布局切换ToolStripMenuItem.Name = "布局切换ToolStripMenuItem";
			this.布局切换ToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
			this.布局切换ToolStripMenuItem.Text = "Change layout";
			this.布局切换ToolStripMenuItem.Click += new System.EventHandler(this.布局切换ToolStripMenuItem_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1083, 628);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Lua";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.luaCode);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.luaOutput);
			this.splitContainer2.Size = new System.Drawing.Size(1083, 628);
			this.splitContainer2.SplitterDistance = 254;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 1;
			// 
			// luaCode
			// 
			this.luaCode.AcceptsTab = true;
			this.luaCode.ContextMenuStrip = this.contextMenuStrip2;
			this.luaCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.luaCode.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.luaCode.HideSelection = false;
			this.luaCode.Location = new System.Drawing.Point(0, 0);
			this.luaCode.Margin = new System.Windows.Forms.Padding(0);
			this.luaCode.Name = "luaCode";
			this.luaCode.Size = new System.Drawing.Size(1083, 254);
			this.luaCode.TabIndex = 25;
			this.luaCode.Text = "";
			this.luaCode.WordWrap = false;
			this.luaCode.TextChanged += new System.EventHandler(this.csharpCode_TextChanged);
			// 
			// luaOutput
			// 
			this.luaOutput.ContextMenuStrip = this.contextMenuStrip1;
			this.luaOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.luaOutput.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.luaOutput.Location = new System.Drawing.Point(0, 0);
			this.luaOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.luaOutput.MaxLength = 2100000;
			this.luaOutput.Name = "luaOutput";
			this.luaOutput.ReadOnly = true;
			this.luaOutput.Size = new System.Drawing.Size(1083, 371);
			this.luaOutput.TabIndex = 25;
			this.luaOutput.Text = "";
			this.luaOutput.WordWrap = false;
			// 
			// btnCompile
			// 
			this.btnCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompile.Location = new System.Drawing.Point(987, 4);
			this.btnCompile.Margin = new System.Windows.Forms.Padding(2);
			this.btnCompile.Name = "btnCompile";
			this.btnCompile.Size = new System.Drawing.Size(100, 30);
			this.btnCompile.TabIndex = 24;
			this.btnCompile.Text = "Run (F5)";
			this.btnCompile.UseVisualStyleBackColor = true;
			this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
			// 
			// NewSnipletButton
			// 
			this.NewSnipletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewSnipletButton.Location = new System.Drawing.Point(388, 4);
			this.NewSnipletButton.Margin = new System.Windows.Forms.Padding(2);
			this.NewSnipletButton.Name = "NewSnipletButton";
			this.NewSnipletButton.Size = new System.Drawing.Size(80, 30);
			this.NewSnipletButton.TabIndex = 19;
			this.NewSnipletButton.Text = "New";
			this.NewSnipletButton.UseVisualStyleBackColor = true;
			this.NewSnipletButton.Click += new System.EventHandler(this.NewSnipletButton_Click);
			// 
			// savedSnipletsCombo
			// 
			this.savedSnipletsCombo.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.savedSnipletsCombo.FormattingEnabled = true;
			this.savedSnipletsCombo.ItemHeight = 20;
			this.savedSnipletsCombo.Location = new System.Drawing.Point(4, 5);
			this.savedSnipletsCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.savedSnipletsCombo.MaxDropDownItems = 36;
			this.savedSnipletsCombo.Name = "savedSnipletsCombo";
			this.savedSnipletsCombo.Size = new System.Drawing.Size(378, 28);
			this.savedSnipletsCombo.TabIndex = 18;
			this.savedSnipletsCombo.SelectedIndexChanged += new System.EventHandler(this.savedSnipletsCombo_SelectedIndexChanged);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(474, 4);
			this.saveButton.Margin = new System.Windows.Forms.Padding(2);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(80, 30);
			this.saveButton.TabIndex = 21;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// btnKeybind
			// 
			this.btnKeybind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnKeybind.Location = new System.Drawing.Point(642, 4);
			this.btnKeybind.Margin = new System.Windows.Forms.Padding(2);
			this.btnKeybind.Name = "btnKeybind";
			this.btnKeybind.Size = new System.Drawing.Size(80, 30);
			this.btnKeybind.TabIndex = 25;
			this.btnKeybind.Text = "Keybind";
			this.btnKeybind.UseVisualStyleBackColor = true;
			this.btnKeybind.Click += new System.EventHandler(this.btnKeybind_Click);
			this.btnKeybind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKeybind_KeyDown);
			this.btnKeybind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnKeybind_KeyUp);
			// 
			// RenameButton
			// 
			this.RenameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RenameButton.Location = new System.Drawing.Point(726, 4);
			this.RenameButton.Margin = new System.Windows.Forms.Padding(2);
			this.RenameButton.Name = "RenameButton";
			this.RenameButton.Size = new System.Drawing.Size(80, 30);
			this.RenameButton.TabIndex = 20;
			this.RenameButton.Text = "Rename";
			this.RenameButton.UseVisualStyleBackColor = true;
			this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(558, 4);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(80, 30);
			this.DeleteButton.TabIndex = 22;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearButton.Location = new System.Drawing.Point(883, 4);
			this.clearButton.Margin = new System.Windows.Forms.Padding(2);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(100, 30);
			this.clearButton.TabIndex = 27;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrameLockCheckBox
			// 
			this.FrameLockCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FrameLockCheckBox.AutoSize = true;
			this.FrameLockCheckBox.Checked = true;
			this.FrameLockCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.FrameLockCheckBox.Location = new System.Drawing.Point(958, 37);
			this.FrameLockCheckBox.Name = "FrameLockCheckBox";
			this.FrameLockCheckBox.Size = new System.Drawing.Size(133, 19);
			this.FrameLockCheckBox.TabIndex = 1;
			this.FrameLockCheckBox.Text = "Use FrameLock";
			this.FrameLockCheckBox.UseVisualStyleBackColor = true;
			this.FrameLockCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// PulseCheckbox
			// 
			this.PulseCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PulseCheckbox.AutoSize = true;
			this.PulseCheckbox.Checked = true;
			this.PulseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.PulseCheckbox.Location = new System.Drawing.Point(811, 37);
			this.PulseCheckbox.Name = "PulseCheckbox";
			this.PulseCheckbox.Size = new System.Drawing.Size(141, 19);
			this.PulseCheckbox.TabIndex = 28;
			this.PulseCheckbox.Text = "Pulse when run";
			this.PulseCheckbox.UseVisualStyleBackColor = true;
			this.PulseCheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1091, 691);
			this.Controls.Add(this.PulseCheckbox);
			this.Controls.Add(this.FrameLockCheckBox);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnCompile);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.RenameButton);
			this.Controls.Add(this.btnKeybind);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NewSnipletButton);
			this.Controls.Add(this.savedSnipletsCombo);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(1037, 85);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Rebornconsole";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox csharpCode;
        internal System.Windows.Forms.RichTextBox csharpOutput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox luaCode;
        internal System.Windows.Forms.RichTextBox luaOutput;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Button NewSnipletButton;
        private System.Windows.Forms.ComboBox savedSnipletsCombo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button btnKeybind;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 布局切换ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 布局切换ToolStripMenuItem;
		internal System.Windows.Forms.CheckBox FrameLockCheckBox;
		internal System.Windows.Forms.CheckBox PulseCheckbox;
	}
}