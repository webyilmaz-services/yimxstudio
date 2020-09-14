using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XanderUI;
using Yim_Studio_2020.Properties;

namespace Yim_Studio_2020
{
	public class Form1 : Form
	{
		public static string ProjectName;

		private IContainer components;

		private XUIFormDesign xuiFormDesign1;

		private TextBox projectNameBox;

		private XUIButton createProjectButton;

		private XUIButton openProjectButton;

		private FormDropShadow formDropShadow1;

		private MaterialLabel materialLabel1;

		private XUICustomPictureBox xuiCustomPictureBox1;

		private MaterialLabel materialLabel2;

		public Form1()
		{
			this.InitializeComponent();
		}

		private void CreateProjectButton_Click(object sender, EventArgs e)
		{
			Form1.ProjectName = this.projectNameBox.Text;
			Directory.CreateDirectory(string.Concat("Projects/", Form1.ProjectName));
			Directory.CreateDirectory(string.Concat("Projects/", Form1.ProjectName, "/yimxjar/"));
			Directory.CreateDirectory(string.Concat("Projects/", Form1.ProjectName, "/bin/"));
			Directory.CreateDirectory(string.Concat("Projects/", Form1.ProjectName, "/build/"));
			
			File.Create(string.Concat("Projects/", Form1.ProjectName, "/main.yimx")).Close();
			
			File.Copy("yimxjar/yimx.jar", string.Concat("Projects/", Form1.ProjectName, "/yimxjar/yimx.jar"));
			File.Copy("bin/yim", string.Concat("Projects/", Form1.ProjectName, "/bin/yimx"));
			File.Copy("bin/yim.bat", string.Concat("Projects/", Form1.ProjectName, "/bin/yimx.bat"));
			(new Editor()).Show();
			base.Hide();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.xuiFormDesign1 = new XUIFormDesign();
			this.openProjectButton = new XUIButton();
			this.materialLabel1 = new MaterialLabel();
			this.projectNameBox = new TextBox();
			this.createProjectButton = new XUIButton();
			this.formDropShadow1 = new FormDropShadow();
			this.xuiCustomPictureBox1 = new XUICustomPictureBox();
			this.materialLabel2 = new MaterialLabel();
			this.xuiFormDesign1.WorkingArea.SuspendLayout();
			this.xuiFormDesign1.SuspendLayout();
			base.SuspendLayout();
			this.xuiFormDesign1.BackColor = Color.FromArgb(236, 236, 236);
			this.xuiFormDesign1.Dock = DockStyle.Fill;
			this.xuiFormDesign1.ExitApplication = true;
			this.xuiFormDesign1.FormStyle = XUIFormDesign.Style.MacOS;
			this.xuiFormDesign1.Location = new Point(0, 0);
			this.xuiFormDesign1.MaterialBackColor = Color.DodgerBlue;
			this.xuiFormDesign1.MaterialForeColor = Color.White;
			this.xuiFormDesign1.Name = "xuiFormDesign1";
			this.xuiFormDesign1.ShowMaximize = false;
			this.xuiFormDesign1.ShowMinimize = true;
			this.xuiFormDesign1.Size = new System.Drawing.Size(680, 365);
			this.xuiFormDesign1.TabIndex = 0;
			this.xuiFormDesign1.TitleText = "YIM STUDIO 2020 - Project Manager";
			this.xuiFormDesign1.WorkingArea.BackColor = Color.FromArgb(236, 236, 236);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.materialLabel2);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCustomPictureBox1);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.openProjectButton);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.materialLabel1);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.projectNameBox);
			this.xuiFormDesign1.WorkingArea.Controls.Add(this.createProjectButton);
			this.xuiFormDesign1.WorkingArea.Dock = DockStyle.Fill;
			this.xuiFormDesign1.WorkingArea.Location = new Point(0, 39);
			this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
			this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(680, 326);
			this.xuiFormDesign1.WorkingArea.TabIndex = 0;
			this.xuiFormDesign1.WorkingArea.Paint += new PaintEventHandler(this.XuiFormDesign1_WorkingArea_Paint);
			this.xuiFormDesign1.Paint += new PaintEventHandler(this.XuiFormDesign1_Paint);
			this.openProjectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.openProjectButton.BackgroundColor = Color.White;
			this.openProjectButton.ButtonImage = null;
			this.openProjectButton.ButtonStyle = XUIButton.Style.MacOS;
			this.openProjectButton.ButtonText = "Open Project";
			this.openProjectButton.ClickBackColor = Color.FromArgb(195, 195, 195);
			this.openProjectButton.ClickTextColor = Color.DodgerBlue;
			this.openProjectButton.CornerRadius = 5;
			this.openProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.openProjectButton.Horizontal_Alignment = StringAlignment.Center;
			this.openProjectButton.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
			this.openProjectButton.HoverTextColor = Color.DodgerBlue;
			this.openProjectButton.ImagePosition = XUIButton.imgPosition.Left;
			this.openProjectButton.Location = new Point(468, 264);
			this.openProjectButton.Name = "openProjectButton";
			this.openProjectButton.Size = new System.Drawing.Size(200, 50);
			this.openProjectButton.TabIndex = 3;
			this.openProjectButton.TextColor = Color.Black;
			this.openProjectButton.Vertical_Alignment = StringAlignment.Center;
			this.openProjectButton.Click += new EventHandler(this.OpenProjectButton_Click);
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11f);
			this.materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
			this.materialLabel1.Location = new Point(50, 209);
			this.materialLabel1.MouseState = MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(126, 23);
			this.materialLabel1.TabIndex = 4;
			this.materialLabel1.Text = "Project Name";
			this.projectNameBox.Location = new Point(12, 236);
			this.projectNameBox.Margin = new System.Windows.Forms.Padding(1);
			this.projectNameBox.Name = "projectNameBox";
			this.projectNameBox.Size = new System.Drawing.Size(200, 22);
			this.projectNameBox.TabIndex = 1;
			this.projectNameBox.Text = "Enter Project Name Here....";
			this.createProjectButton.BackgroundColor = Color.White;
			this.createProjectButton.BackgroundImageLayout = ImageLayout.None;
			this.createProjectButton.ButtonImage = null;
			this.createProjectButton.ButtonStyle = XUIButton.Style.MacOS;
			this.createProjectButton.ButtonText = "Create Project";
			this.createProjectButton.ClickBackColor = Color.FromArgb(195, 200, 185);
			this.createProjectButton.ClickTextColor = Color.FromArgb(195, 200, 185);
			this.createProjectButton.CornerRadius = 5;
			this.createProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.createProjectButton.Horizontal_Alignment = StringAlignment.Center;
			this.createProjectButton.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
			this.createProjectButton.HoverTextColor = Color.FromArgb(65, 70, 75);
			this.createProjectButton.ImagePosition = XUIButton.imgPosition.Left;
			this.createProjectButton.Location = new Point(12, 264);
			this.createProjectButton.Name = "createProjectButton";
			this.createProjectButton.Size = new System.Drawing.Size(200, 50);
			this.createProjectButton.TabIndex = 0;
			this.createProjectButton.TextColor = Color.Black;
			this.createProjectButton.Vertical_Alignment = StringAlignment.Center;
			this.createProjectButton.Click += new EventHandler(this.CreateProjectButton_Click);
			this.formDropShadow1.EffectedForm = this;
			this.formDropShadow1.ShadowAngle = 2;
			this.xuiCustomPictureBox1.BackgroundImage = Resources.YimLogo;
			this.xuiCustomPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			this.xuiCustomPictureBox1.Color1 = Color.DodgerBlue;
			this.xuiCustomPictureBox1.Color2 = Color.DodgerBlue;
			this.xuiCustomPictureBox1.FilterAlpha = 200;
			this.xuiCustomPictureBox1.FilterEnabled = true;
			this.xuiCustomPictureBox1.Image = null;
			this.xuiCustomPictureBox1.IsElipse = false;
			this.xuiCustomPictureBox1.IsParallax = false;
			this.xuiCustomPictureBox1.Location = new Point(54, 23);
			this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
			this.xuiCustomPictureBox1.Size = new System.Drawing.Size(150, 150);
			this.xuiCustomPictureBox1.TabIndex = 5;
			this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
			this.materialLabel2.Location = new Point(210, 90);
			this.materialLabel2.MouseState = MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(270, 29);
			this.materialLabel2.TabIndex = 6;
			this.materialLabel2.Text = "Yim Studio 2020 (1.1)";
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(680, 365);
			base.Controls.Add(this.xuiFormDesign1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Form1";
			this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
			this.xuiFormDesign1.WorkingArea.PerformLayout();
			this.xuiFormDesign1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void OpenProjectButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
			{
				Description = "Select Your Yim Project Folder!",
				SelectedPath = "C:\\YIMX\\Projects"
			};
			folderBrowserDialog.ShowDialog();
			Form1.ProjectName = Path.GetFileName(folderBrowserDialog.SelectedPath);
			(new Editor()).Show();
			base.Hide();
		}

		private void XuiFormDesign1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void XuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}