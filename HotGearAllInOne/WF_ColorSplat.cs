using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotGearAllInOne
{
	public class WF_ColorSplat : Form
	{
		private IContainer components = null;

		private TextBox textBox1;

		private CheckBox HalfTone;

		private Label SurfaceTransparency;

		private Label label1;

		private Button button2;

		private Button button1;

		private ToolTip toolTip1;

		private Label label2;

		private GroupBox groupBox1;

		private CheckBox TempIsolate;

		private Label label3;

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
			this.components = new Container();
			this.textBox1 = new TextBox();
			this.HalfTone = new CheckBox();
			this.SurfaceTransparency = new Label();
			this.label1 = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.groupBox1 = new GroupBox();
			this.label2 = new Label();
			this.toolTip1 = new ToolTip(this.components);
			this.TempIsolate = new CheckBox();
			this.label3 = new Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.textBox1.Location = new Point(134, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(35, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "80";
			this.textBox1.TextChanged += this.textBox1_TextChanged;
			this.HalfTone.AutoSize = true;
			this.HalfTone.Location = new Point(136, 55);
			this.HalfTone.Name = "HalfTone";
			this.HalfTone.Size = new Size(15, 14);
			this.HalfTone.TabIndex = 1;
			this.HalfTone.UseVisualStyleBackColor = true;
			this.HalfTone.CheckedChanged += this.HalfTone_CheckedChanged;
			this.SurfaceTransparency.AutoSize = true;
			this.SurfaceTransparency.Location = new Point(15, 24);
			this.SurfaceTransparency.Name = "SurfaceTransparency";
			this.SurfaceTransparency.Size = new Size(115, 13);
			this.SurfaceTransparency.TabIndex = 2;
			this.SurfaceTransparency.Text = "SurfaceTransparency :";
			this.toolTip1.SetToolTip(this.SurfaceTransparency, "Control Transparency of Other Element on the View. ");
			this.label1.AutoSize = true;
			this.label1.Location = new Point(70, 55);
			this.label1.Name = "label1";
			this.label1.Size = new Size(60, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Half Tone :";
			this.toolTip1.SetToolTip(this.label1, "Control Half Tone of Other Element on the View. ");
			this.button1.Location = new Point(73, 119);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.button2.Location = new Point(154, 119);
			this.button2.Name = "button2";
			this.button2.Size = new Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += this.button2_Click;
			this.groupBox1.Controls.Add(this.TempIsolate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.HalfTone);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.SurfaceTransparency);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = DockStyle.Fill;
			this.groupBox1.Location = new Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new Padding(5);
			this.groupBox1.Size = new Size(260, 154);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(177, 24);
			this.label2.Name = "label2";
			this.label2.Size = new Size(52, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "( 0 - 100 )";
			this.TempIsolate.AutoSize = true;
			this.TempIsolate.Location = new Point(136, 78);
			this.TempIsolate.Name = "TempIsolate";
			this.TempIsolate.Size = new Size(15, 14);
			this.TempIsolate.TabIndex = 7;
			this.TempIsolate.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(33, 78);
			this.label3.Name = "label3";
			this.label3.Size = new Size(97, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Temporary Isolate :";
			this.toolTip1.SetToolTip(this.label3, "Control Half Tone of Other Element on the View. ");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(260, 154);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "WF_ColorSplat";
			this.Text = "Color Splat";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		public WF_ColorSplat()
		{
			this.InitializeComponent();
			this.textBox1.Text = GlobalVar.ColorSplatTransparency.ToString();
			this.HalfTone.Checked = GlobalVar.HalfTone;
			this.TempIsolate.Checked = GlobalVar.TempIsolate;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GlobalVar.ColorSplatTransparency = int.Parse(this.textBox1.Text);
			GlobalVar.HalfTone = this.HalfTone.Checked;
			GlobalVar.TempIsolate = this.TempIsolate.Checked;
			base.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (int.Parse(this.textBox1.Text) > 100 || int.Parse(this.textBox1.Text) < 0)
			{
				MessageBox.Show("Transparency Value Available from 0 - 100 Only.");
				this.textBox1.Text = 80.ToString();
			}
		}

		private void HalfTone_CheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
