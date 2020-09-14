using FastColoredTextBoxNS;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using XanderUI;

namespace Yim_Studio_2020
{
	public class Editor : Form
	{
		public static string ProjectName;

		private IContainer components;

		private XUIFormDesign xuiFormDesign1;

		private Label label1;

		private XUIFlatMenuStrip xuiFlatMenuStrip1;

		private ToolStripMenuItem projectToolStripMenuItem;

		private ToolStripMenuItem saveToolStripMenuItem;

		private ToolStripMenuItem runToolStripMenuItem;

		private ToolStripMenuItem exitToolStripMenuItem;

		private ToolStripMenuItem examplesToolStripMenuItem;

		private ToolStripMenuItem helloWorldToolStripMenuItem;

		private ToolStripMenuItem addToolStripMenuItem;

		private ToolStripMenuItem runToolStripMenuItem1;

		private ToolStripMenuItem saveAndRunToolStripMenuItem;

		private FastColoredTextBox codeText;

		public Editor()
		{
			this.InitializeComponent();
		}



        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeText.Text = @"
        import "+'"'+"stdsx"+'"'+"" +
                            "println "+'"'+"Hello World"+'"'


            
            
            
            ;



        }

		public static string Base64Decode(string base64EncodedData)
		{
			byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(base64EncodedBytes);
		}

		public static string Base64Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		private void BuildEXEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void CodeText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				File.WriteAllText(string.Concat("Projects/", Editor.ProjectName, "/main.yimx"), this.codeText.Text, Encoding.Default);
				
				e.SuppressKeyPress = true;
			}
		}

		private void CodeText_Load(object sender, EventArgs e)
		{
		}

		private void CodeText_Load_1(object sender, EventArgs e)
		{
		}

		private void CodeText_TextChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Editor_Load(object sender, EventArgs e)
		{
			Editor.ProjectName = Form1.ProjectName;
			this.label1.Text = string.Concat("Current Project : ", Editor.ProjectName);
			StreamReader streamReader = File.OpenText(string.Concat("Projects/", Editor.ProjectName, "/main.yimx"));
			string code = streamReader.ReadToEnd();
			this.codeText.Text = code;
			this.codeText.Language = Language.VB;
			streamReader.Close();
			this.xuiFormDesign1.TitleText = string.Concat("Yim Studio 2020 - ", Editor.ProjectName);
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.codeText = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeText)).BeginInit();
            this.xuiFlatMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = false;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1280, 720);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Yim Studio 2020";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.codeText);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiFlatMenuStrip1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1280, 681);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            this.xuiFormDesign1.WorkingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.XuiFormDesign1_WorkingArea_Paint);
            // 
            // codeText
            // 
            this.codeText.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeText.AutoScrollMinSize = new System.Drawing.Size(161, 18);
            this.codeText.BackBrush = null;
            this.codeText.CharHeight = 18;
            this.codeText.CharWidth = 10;
            this.codeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeText.IsReplaceMode = false;
            this.codeText.Location = new System.Drawing.Point(15, 65);
            this.codeText.Name = "codeText";
            this.codeText.Paddings = new System.Windows.Forms.Padding(0);
            this.codeText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeText.ServiceColors = null;
            this.codeText.Size = new System.Drawing.Size(1253, 604);
            this.codeText.TabIndex = 3;
            this.codeText.Text = "ERROR CODE 01";
            this.codeText.Zoom = 100;
            this.codeText.Load += new System.EventHandler(this.CodeText_Load_1);
            this.codeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeText_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Project:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.runToolStripMenuItem,
            this.examplesToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.DarkOrchid;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.xuiFlatMenuStrip1.TabIndex = 1;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save (CTRL + S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem1,
            this.saveAndRunToolStripMenuItem});
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.RunToolStripMenuItem1_Click);
            // 
            // saveAndRunToolStripMenuItem
            // 
            this.saveAndRunToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAndRunToolStripMenuItem.Name = "saveAndRunToolStripMenuItem";
            this.saveAndRunToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAndRunToolStripMenuItem.Text = "Save and Run";
            this.saveAndRunToolStripMenuItem.Click += new System.EventHandler(this.SaveAndRunToolStripMenuItem_Click);
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem});
            this.examplesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.helloWorldToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helloWorldToolStripMenuItem.Text = "Hello World";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.xuiFlatMenuStrip1;
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeText)).EndInit();
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		private void Label1_Click(object sender, EventArgs e)
		{
		}

		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void RunToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("cmd.exe", string.Concat("/k@cd C:/YIMXStudio/Projects/", Editor.ProjectName, "&bin\\yimx -f main.yimx"));
		}

		private void SaveAndRunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			File.WriteAllText(string.Concat("Projects/", Editor.ProjectName, "/main.yim"), this.codeText.Text, Encoding.Default);
			Process.Start("cmd.exe", string.Concat("/k@cd C:/YIMXStudio/Projects/", Editor.ProjectName, "&bin\\yimx -f main.yimx"));
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			File.WriteAllText(string.Concat("Projects/", Editor.ProjectName, "/main.yimx"), this.codeText.Text, Encoding.Default);
			
		}

		private void XuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}