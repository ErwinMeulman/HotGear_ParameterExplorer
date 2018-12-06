using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace HotGearAllInOne
{
	public class HotGear_Parameter_Explorer : Form
	{
		public class TabPageComparer : IComparer<TabPage>
		{
			public int Compare(TabPage x, TabPage y)
			{
				return string.Compare(x.Text, y.Text);
			}
		}

		private IContainer components = null;

		private ToolTip MyToolTip;

		private GroupBox groupBox1;

		private TextBox textBox1;

		private StatusStrip statusStrip1;

		private ToolStripStatusLabel toolStripStatusLabel1;

		private ToolStripStatusLabel toolStripStatusLabel2;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem menuToolStripMenuItem;

		private ToolStripMenuItem exportCurrentTabToolStripMenuItem;

		private ToolStripMenuItem exportAllTabToolStripMenuItem;

		private ToolStripMenuItem dataToolStripMenuItem;

		private ToolStripMenuItem copySelectedDataToolStripMenuItem;

		private TreeView treeView1;

		private ComboBox comboBox1;

		private Button SelectOnRevit;

		private TabControl tabControl2;

		private Button ApplyFilter;

		private ToolStripMenuItem selectionToolStripMenuItem;

		private ToolStripMenuItem selectAllOnRevitToolStripMenuItem;

		private ToolStripStatusLabel toolStripStatusLabel3;

		private Button ResetFilter;

		private GroupBox groupBox2;

		private TabControl tabControl1;

		private Button ReflashTable;

		private Button Mark;

		private Button Reject_Change;

		private Button Accept_Change;

		private ToolStripMenuItem importExcelDataToolStripMenuItem;

		private Button ColorSplat;

		private ProgressBar progressBar1;

		private ProgressBar progressBar2;

		private TabControl tabControl3;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private TextBox textBox2;

		private ToolStripMenuItem colorSplatToolStripMenuItem1;

		private ToolStripMenuItem settingToolStripMenuItem;

		private ToolStripMenuItem resetElementColorSplatToolStripMenuItem;

		private ToolStripMenuItem saveColorSplatToolStripMenuItem;

		private ToolStripMenuItem loadColorSplatToolStripMenuItem;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private RadioButton radioButton2;

		private RadioButton radioButton1;

		private ToolStripMenuItem helpToolStripMenuItem;

		private ToolStripStatusLabel toolStripStatusLabel4;

		private ToolStripStatusLabel toolStripStatusLabel5;

		private ExternalEvent m_ExEvent = GlobalVar.G_exEvent;

		private ParameterEventHandler m_Handler = GlobalVar.G_handler;

		private ExternalEvent m_ExEvent1 = GlobalVar.G_exEvent1;

		private ElementOverrideEventHandler m_Handler1 = GlobalVar.G_handler1;

		private ExternalEvent m_ExEvent3 = GlobalVar.G_exEvent3;

		private ResetElementOverrideEventHandler m_Handler3 = GlobalVar.G_handler3;

		internal ExternalCommandData cmddata;

		internal Document HGDoc;

		internal UIApplication HGUiApp;

		internal Application HGApp;

		internal UIDocument HGUiDoc;

		internal View HGActiveView;

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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HotGear_Parameter_Explorer));
			this.MyToolTip = new ToolTip(this.components);
			this.comboBox1 = new ComboBox();
			this.SelectOnRevit = new Button();
			this.ReflashTable = new Button();
			this.ColorSplat = new Button();
			this.Mark = new Button();
			this.groupBox1 = new GroupBox();
			this.Reject_Change = new Button();
			this.Accept_Change = new Button();
			this.tabControl1 = new TabControl();
			this.ResetFilter = new Button();
			this.tabControl2 = new TabControl();
			this.ApplyFilter = new Button();
			this.treeView1 = new TreeView();
			this.textBox1 = new TextBox();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel3 = new ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new ToolStripStatusLabel();
			this.menuStrip1 = new MenuStrip();
			this.menuToolStripMenuItem = new ToolStripMenuItem();
			this.exportCurrentTabToolStripMenuItem = new ToolStripMenuItem();
			this.exportAllTabToolStripMenuItem = new ToolStripMenuItem();
			this.importExcelDataToolStripMenuItem = new ToolStripMenuItem();
			this.dataToolStripMenuItem = new ToolStripMenuItem();
			this.copySelectedDataToolStripMenuItem = new ToolStripMenuItem();
			this.selectionToolStripMenuItem = new ToolStripMenuItem();
			this.selectAllOnRevitToolStripMenuItem = new ToolStripMenuItem();
			this.colorSplatToolStripMenuItem1 = new ToolStripMenuItem();
			this.settingToolStripMenuItem = new ToolStripMenuItem();
			this.resetElementColorSplatToolStripMenuItem = new ToolStripMenuItem();
			this.saveColorSplatToolStripMenuItem = new ToolStripMenuItem();
			this.loadColorSplatToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.groupBox2 = new GroupBox();
			this.radioButton2 = new RadioButton();
			this.radioButton1 = new RadioButton();
			this.progressBar1 = new ProgressBar();
			this.progressBar2 = new ProgressBar();
			this.tabControl3 = new TabControl();
			this.tabPage1 = new TabPage();
			this.tabPage2 = new TabPage();
			this.textBox2 = new TextBox();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.MyToolTip.AutoPopDelay = 1500;
			this.MyToolTip.InitialDelay = 500;
			this.MyToolTip.ReshowDelay = 100;
			this.MyToolTip.UseAnimation = false;
			this.comboBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox1.DropDownWidth = 250;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(748, 7);
			this.comboBox1.MaxDropDownItems = 100;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = RightToLeft.No;
			this.comboBox1.Size = new Size(250, 21);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 11;
			this.comboBox1.Tag = "";
			this.comboBox1.Text = "Search Tab Pages";
			this.MyToolTip.SetToolTip(this.comboBox1, "Tab Pages Quick Select Drop Down");
			this.comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
			this.SelectOnRevit.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.SelectOnRevit.FlatStyle = FlatStyle.Popup;
			this.SelectOnRevit.Location = new Point(334, 470);
			this.SelectOnRevit.Name = "SelectOnRevit";
			this.SelectOnRevit.Size = new Size(120, 23);
			this.SelectOnRevit.TabIndex = 11;
			this.SelectOnRevit.Text = "Select On Revit";
			this.MyToolTip.SetToolTip(this.SelectOnRevit, "Select Element On Revit By Selected Cells");
			this.SelectOnRevit.UseVisualStyleBackColor = true;
			this.SelectOnRevit.Click += this.SelectOnRevit_Click;
			this.ReflashTable.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ReflashTable.FlatStyle = FlatStyle.Flat;
			this.ReflashTable.Location = new Point(8, 470);
			this.ReflashTable.Name = "ReflashTable";
			this.ReflashTable.Size = new Size(105, 23);
			this.ReflashTable.TabIndex = 13;
			this.ReflashTable.Text = "Refresh Data";
			this.MyToolTip.SetToolTip(this.ReflashTable, "Refresh Table Data From Revit DB.");
			this.ReflashTable.UseVisualStyleBackColor = true;
			this.ReflashTable.Click += this.Update_Click;
			this.ColorSplat.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ColorSplat.FlatStyle = FlatStyle.Flat;
			this.ColorSplat.Location = new Point(216, 470);
			this.ColorSplat.Name = "ColorSplat";
			this.ColorSplat.Size = new Size(105, 23);
			this.ColorSplat.TabIndex = 17;
			this.ColorSplat.Text = "Color Splat";
			this.MyToolTip.SetToolTip(this.ColorSplat, "Color Splat By Sorted Parameter.");
			this.ColorSplat.UseVisualStyleBackColor = true;
			this.ColorSplat.Click += this.ColorIsolate_Click;
			this.Mark.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Mark.FlatStyle = FlatStyle.Flat;
			this.Mark.Location = new Point(112, 470);
			this.Mark.Name = "Mark";
			this.Mark.Size = new Size(105, 23);
			this.Mark.TabIndex = 14;
			this.Mark.Text = "Mark Nos.";
			this.MyToolTip.SetToolTip(this.Mark, "Numerical Order Start With 1");
			this.Mark.UseVisualStyleBackColor = true;
			this.Mark.Click += this.button1_Click;
			this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.groupBox1.BackgroundImageLayout = ImageLayout.None;
			this.groupBox1.Controls.Add(this.ColorSplat);
			this.groupBox1.Controls.Add(this.Reject_Change);
			this.groupBox1.Controls.Add(this.Accept_Change);
			this.groupBox1.Controls.Add(this.Mark);
			this.groupBox1.Controls.Add(this.ReflashTable);
			this.groupBox1.Controls.Add(this.SelectOnRevit);
			this.groupBox1.Controls.Add(this.tabControl1);
			this.groupBox1.FlatStyle = FlatStyle.Flat;
			this.groupBox1.Location = new Point(286, 3);
			this.groupBox1.Margin = new Padding(15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new Padding(5, 5, 5, 35);
			this.groupBox1.RightToLeft = RightToLeft.No;
			this.groupBox1.Size = new Size(703, 499);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parameter Table";
			this.groupBox1.Enter += this.groupBox1_Enter;
			this.Reject_Change.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Reject_Change.FlatStyle = FlatStyle.Popup;
			this.Reject_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Reject_Change.Location = new Point(572, 470);
			this.Reject_Change.Name = "Reject_Change";
			this.Reject_Change.Size = new Size(120, 23);
			this.Reject_Change.TabIndex = 16;
			this.Reject_Change.Text = "Reject Changes";
			this.Reject_Change.UseVisualStyleBackColor = true;
			this.Reject_Change.Click += this.Reject_Click;
			this.Accept_Change.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Accept_Change.FlatStyle = FlatStyle.Popup;
			this.Accept_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Accept_Change.Location = new Point(453, 470);
			this.Accept_Change.Name = "Accept_Change";
			this.Accept_Change.Size = new Size(120, 23);
			this.Accept_Change.TabIndex = 15;
			this.Accept_Change.Text = "Accept Changes";
			this.Accept_Change.UseVisualStyleBackColor = true;
			this.Accept_Change.Click += this.Accept_Click;
			this.tabControl1.AccessibleRole = AccessibleRole.PageTab;
			this.tabControl1.Dock = DockStyle.Fill;
			this.tabControl1.HotTrack = true;
			this.tabControl1.Location = new Point(5, 18);
			this.tabControl1.Margin = new Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new Point(0, 0);
			this.tabControl1.RightToLeft = RightToLeft.No;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(693, 446);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.SelectedIndexChanged += this.TabControl1_SelectedIndexChanged;
			this.ResetFilter.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ResetFilter.Enabled = false;
			this.ResetFilter.FlatStyle = FlatStyle.Popup;
			this.ResetFilter.Location = new Point(194, 470);
			this.ResetFilter.Name = "ResetFilter";
			this.ResetFilter.Size = new Size(80, 23);
			this.ResetFilter.TabIndex = 13;
			this.ResetFilter.Text = "Reset Filter";
			this.ResetFilter.UseVisualStyleBackColor = true;
			this.ResetFilter.Click += this.ResetFilter_Click;
			this.tabControl2.Location = new Point(619, 7);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new Size(88, 19);
			this.tabControl2.TabIndex = 12;
			this.tabControl2.Visible = false;
			this.ApplyFilter.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ApplyFilter.FlatStyle = FlatStyle.Popup;
			this.ApplyFilter.Location = new Point(115, 470);
			this.ApplyFilter.Name = "ApplyFilter";
			this.ApplyFilter.Size = new Size(80, 23);
			this.ApplyFilter.TabIndex = 12;
			this.ApplyFilter.Text = "Apply Filter";
			this.ApplyFilter.UseVisualStyleBackColor = true;
			this.ApplyFilter.Click += this.ApplyFilter_Click;
			this.treeView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.treeView1.BackColor = Color.White;
			this.treeView1.BorderStyle = BorderStyle.FixedSingle;
			this.treeView1.CheckBoxes = true;
			this.treeView1.FullRowSelect = true;
			this.treeView1.HotTracking = true;
			this.treeView1.Location = new Point(6, 19);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new Size(268, 449);
			this.treeView1.TabIndex = 10;
			this.treeView1.AfterCheck += this.treeView1_AfterCheck;
			this.treeView1.AfterSelect += this.treeView1_AfterSelect;
			this.textBox1.Location = new Point(713, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(29, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "ID Filter";
			this.textBox1.TextAlign = HorizontalAlignment.Right;
			this.textBox1.Visible = false;
			this.textBox1.Click += this.textBox1IsClick;
			this.statusStrip1.BackColor = SystemColors.Control;
			this.statusStrip1.BackgroundImageLayout = ImageLayout.None;
			this.statusStrip1.GripStyle = ToolStripGripStyle.Visible;
			this.statusStrip1.Items.AddRange(new ToolStripItem[5]
			{
				this.toolStripStatusLabel3,
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel1,
				this.toolStripStatusLabel5,
				this.toolStripStatusLabel4
			});
			this.statusStrip1.Location = new Point(5, 561);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new Size(998, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += this.statusStrip1_ItemClicked;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new Size(69, 17);
			this.toolStripStatusLabel3.Text = "Tab Pages : ";
			this.toolStripStatusLabel3.ToolTipText = "How much Tab in current View.";
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new Size(104, 17);
			this.toolStripStatusLabel2.Text = "Rows :  Columns : ";
			this.toolStripStatusLabel2.ToolTipText = "How much Rows and Coulmns on current tab.";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new Size(60, 17);
			this.toolStripStatusLabel1.Text = "Selected : ";
			this.toolStripStatusLabel1.ToolTipText = "How many cells on current Tab selected.";
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new Size(34, 17);
			this.toolStripStatusLabel4.Text = "Doc :";
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new Size(138, 17);
			this.toolStripStatusLabel5.Text = "Sum of Column Selected";
			this.toolStripStatusLabel5.Click += this.toolStripStatusLabel5_Click;
			this.menuStrip1.AccessibleRole = AccessibleRole.MenuBar;
			this.menuStrip1.Dock = DockStyle.None;
			this.menuStrip1.Items.AddRange(new ToolStripItem[6]
			{
				this.menuToolStripMenuItem,
				this.dataToolStripMenuItem,
				this.selectionToolStripMenuItem,
				this.colorSplatToolStripMenuItem1,
				this.aboutToolStripMenuItem,
				this.helpToolStripMenuItem
			});
			this.menuStrip1.Location = new Point(5, 4);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new Size(336, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			this.menuToolStripMenuItem.AutoToolTip = true;
			this.menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
			{
				this.exportCurrentTabToolStripMenuItem,
				this.exportAllTabToolStripMenuItem,
				this.importExcelDataToolStripMenuItem
			});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new Size(45, 20);
			this.menuToolStripMenuItem.Text = "Excel";
			this.menuToolStripMenuItem.ToolTipText = "Export Data To Excel";
			this.exportCurrentTabToolStripMenuItem.Name = "exportCurrentTabToolStripMenuItem";
			this.exportCurrentTabToolStripMenuItem.Size = new Size(181, 22);
			this.exportCurrentTabToolStripMenuItem.Text = "Export Current Table";
			this.exportCurrentTabToolStripMenuItem.ToolTipText = "Export Current Parameter Table Data To Excel";
			this.exportCurrentTabToolStripMenuItem.Click += this.CurrentTab2Excel_Click;
			this.exportAllTabToolStripMenuItem.Name = "exportAllTabToolStripMenuItem";
			this.exportAllTabToolStripMenuItem.Size = new Size(181, 22);
			this.exportAllTabToolStripMenuItem.Text = "Export All Table";
			this.exportAllTabToolStripMenuItem.ToolTipText = "Export All Parameter Table Data To Excel";
			this.exportAllTabToolStripMenuItem.Click += this.AllTab2Excel_Click;
			this.importExcelDataToolStripMenuItem.Name = "importExcelDataToolStripMenuItem";
			this.importExcelDataToolStripMenuItem.Size = new Size(181, 22);
			this.importExcelDataToolStripMenuItem.Text = "Import Excel Data";
			this.importExcelDataToolStripMenuItem.ToolTipText = "Import Excel Data To Revit";
			this.importExcelDataToolStripMenuItem.Click += this.importExcelDataToolStripMenuItem_Click;
			this.dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
			{
				this.copySelectedDataToolStripMenuItem
			});
			this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
			this.dataToolStripMenuItem.Size = new Size(43, 20);
			this.dataToolStripMenuItem.Text = "Data";
			this.copySelectedDataToolStripMenuItem.Name = "copySelectedDataToolStripMenuItem";
			this.copySelectedDataToolStripMenuItem.ShowShortcutKeys = false;
			this.copySelectedDataToolStripMenuItem.Size = new Size(169, 22);
			this.copySelectedDataToolStripMenuItem.Text = "Copy Selected Data";
			this.copySelectedDataToolStripMenuItem.ToolTipText = "Copy Current Selected Data to Clipboard";
			this.copySelectedDataToolStripMenuItem.Click += this.CopyToClipboard_Click;
			this.selectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
			{
				this.selectAllOnRevitToolStripMenuItem
			});
			this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
			this.selectionToolStripMenuItem.Size = new Size(67, 20);
			this.selectionToolStripMenuItem.Text = "Selection";
			this.selectAllOnRevitToolStripMenuItem.Name = "selectAllOnRevitToolStripMenuItem";
			this.selectAllOnRevitToolStripMenuItem.Size = new Size(122, 22);
			this.selectAllOnRevitToolStripMenuItem.Text = "Select All";
			this.selectAllOnRevitToolStripMenuItem.ToolTipText = "Select All Parameter Table Elements On Revit";
			this.selectAllOnRevitToolStripMenuItem.Click += this.AllSelectOnRevit_Click;
			this.colorSplatToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[4]
			{
				this.settingToolStripMenuItem,
				this.resetElementColorSplatToolStripMenuItem,
				this.saveColorSplatToolStripMenuItem,
				this.loadColorSplatToolStripMenuItem
			});
			this.colorSplatToolStripMenuItem1.Name = "colorSplatToolStripMenuItem1";
			this.colorSplatToolStripMenuItem1.Size = new Size(77, 20);
			this.colorSplatToolStripMenuItem1.Text = "Color Splat";
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new Size(148, 22);
			this.settingToolStripMenuItem.Text = "Setting";
			this.settingToolStripMenuItem.ToolTipText = "Control the Color Splat Elements Transparency, Half Tone and Temporary Isolate";
			this.settingToolStripMenuItem.Click += this.colorSplatSettingToolStripMenuItem_Click;
			this.resetElementColorSplatToolStripMenuItem.Name = "resetElementColorSplatToolStripMenuItem";
			this.resetElementColorSplatToolStripMenuItem.Size = new Size(148, 22);
			this.resetElementColorSplatToolStripMenuItem.Text = "Reset Element";
			this.resetElementColorSplatToolStripMenuItem.ToolTipText = "Reset Elements Color Splat Override";
			this.resetElementColorSplatToolStripMenuItem.Click += this.resetElementColorToolStripMenuItem_Click;
			this.saveColorSplatToolStripMenuItem.Name = "saveColorSplatToolStripMenuItem";
			this.saveColorSplatToolStripMenuItem.Size = new Size(148, 22);
			this.saveColorSplatToolStripMenuItem.Text = "Save";
			this.saveColorSplatToolStripMenuItem.ToolTipText = "Save Current Color Splat Elements to file";
			this.saveColorSplatToolStripMenuItem.Click += this.saveColorSplatToolStripMenuItem_Click;
			this.loadColorSplatToolStripMenuItem.Name = "loadColorSplatToolStripMenuItem";
			this.loadColorSplatToolStripMenuItem.Size = new Size(148, 22);
			this.loadColorSplatToolStripMenuItem.Text = "Load";
			this.loadColorSplatToolStripMenuItem.ToolTipText = "Load Elements and recreate Color Splat from file";
			this.loadColorSplatToolStripMenuItem.Click += this.loadColorSplatToolStripMenuItem_Click;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.ToolTipText = "About Current Add-in Version, License, Copyright and Support Email";
			this.aboutToolStripMenuItem.Click += this.aboutToolStripMenuItem_Click;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += this.helpToolStripMenuItem_Click;
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.ResetFilter);
			this.groupBox2.Controls.Add(this.treeView1);
			this.groupBox2.Controls.Add(this.ApplyFilter);
			this.groupBox2.Dock = DockStyle.Left;
			this.groupBox2.FlatStyle = FlatStyle.Flat;
			this.groupBox2.Location = new Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(280, 499);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filter";
			this.radioButton2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(68, 473);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new Size(41, 17);
			this.radioButton2.TabIndex = 17;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "OR";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new Point(14, 473);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new Size(48, 17);
			this.radioButton1.TabIndex = 16;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "AND";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.progressBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.progressBar1.Location = new Point(637, 565);
			this.progressBar1.Margin = new Padding(5);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(350, 16);
			this.progressBar1.Step = 25;
			this.progressBar1.TabIndex = 13;
			this.progressBar1.Visible = false;
			this.progressBar2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.progressBar2.Location = new Point(541, 565);
			this.progressBar2.Margin = new Padding(5);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new Size(75, 16);
			this.progressBar2.Step = 25;
			this.progressBar2.TabIndex = 14;
			this.progressBar2.Visible = false;
			this.tabControl3.Controls.Add(this.tabPage1);
			this.tabControl3.Controls.Add(this.tabPage2);
			this.tabControl3.Dock = DockStyle.Fill;
			this.tabControl3.HotTrack = true;
			this.tabControl3.Location = new Point(5, 30);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new Size(998, 531);
			this.tabControl3.TabIndex = 15;
			this.tabControl3.SelectedIndexChanged += this.TabControl3_SelectedIndexChanged;
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new Padding(3);
			this.tabPage1.Size = new Size(990, 505);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Parameter Data";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new Padding(3);
			this.tabPage2.Size = new Size(990, 505);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Log";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.textBox2.Dock = DockStyle.Fill;
			this.textBox2.Location = new Point(3, 3);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ScrollBars = ScrollBars.Both;
			this.textBox2.Size = new Size(984, 499);
			this.textBox2.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(1008, 588);
			base.Controls.Add(this.tabControl3);
			base.Controls.Add(this.progressBar2);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.tabControl2);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.statusStrip1);
			this.DoubleBuffered = true;
			this.ForeColor = SystemColors.ControlText;
			base.HelpButton = true;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new Size(1024, 480);
			base.Name = "HotGear_Parameter_Explorer";
			base.Padding = new Padding(5, 30, 5, 5);
			this.Text = "HotGear Parameter Explorer";
			base.Shown += this.TabControl1_SelectedIndexChanged;
			this.groupBox1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl3.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public HotGear_Parameter_Explorer()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			this.InitializeComponent();
			base.Load += this.Form_Load;
		}

		public void InitializeComponent(ExternalCommandData cmdData, Document S_Doc)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			string text = GlobalVar.G_revitversion = S_Doc.get_Application().get_VersionNumber();
			this.cmddata = cmdData;
			this.HGUiApp = cmdData.get_Application();
			this.HGDoc = S_Doc;
			this.HGUiDoc = this.HGUiApp.get_ActiveUIDocument();
			this.HGActiveView = this.HGDoc.get_ActiveView();
			this.HGApp = cmdData.get_Application().get_Application();
			this.HGDoc.add_DocumentClosing((EventHandler<DocumentClosingEventArgs>)this.HGDoc_DocumentClosing);
		}

		private void Update_Click(object sender, EventArgs e)
		{
			this.GetUpdate();
			this.ApplyFilter_Click(sender, e);
			this.ReflashTable.BackColor = Control.DefaultBackColor;
		}

		private void Form_Load(object sender, EventArgs e)
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			GlobalVar.CM_GetUpdata += this.GetUpdate;
			DataSet myDataSet = GlobalVar.MyDataSet;
			this.loadDataGridToTab(myDataSet);
			this.loadDataGridToTreeView(this.tabControl1);
			HotGear_Parameter_Explorer.TabSort(this.tabControl1);
			this.ComboBoxData(this.tabControl1);
			this.radioButton2.Checked = true;
			if (this.HGDoc.get_IsLinked())
			{
				this.Mark.Visible = false;
				this.ColorSplat.Visible = false;
				this.SelectOnRevit.Visible = false;
				this.Accept_Change.Visible = false;
				this.Reject_Change.Visible = false;
			}
			GlobalVar.ColorSplatTransparency = 80;
			GlobalVar.HalfTone = false;
		}

		private void HGDoc_DocumentClosing(object sender, DocumentClosingEventArgs e)
		{
			base.Dispose();
		}

		public void GetUpdate()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			Document hGDoc = this.HGDoc;
			DataSet dataSet = new DataSet();
			DataSet dataSet2 = new DataSet();
			List<Element> list = new List<Element>();
			List<ElementId> list2 = new List<ElementId>();
			string text = this.tabControl1.SelectedTab.Text;
			foreach (TabPage tabPage3 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage3.Controls)
				{
					for (int i = 0; i < control.Rows.Count; i++)
					{
						try
						{
							int num = int.Parse(control[0, i].Value.ToString());
							ElementId val = new ElementId(num);
							Element element = hGDoc.GetElement(val);
							list.Add(element);
							list2.Add(val);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
					}
				}
			}
			this.tabControl1.Controls.Clear();
			if (GlobalVar.TypeORInstance == "Family Instance")
			{
				List<ElementId> list3 = new List<ElementId>();
				foreach (Element item in list)
				{
					try
					{
						list3.Add(item.get_Category().get_Id());
					}
					catch
					{
					}
				}
				List<ElementId> list4 = ((IEnumerable<ElementId>)list3).Distinct<ElementId>().ToList<ElementId>();
				foreach (ElementId item2 in list4)
				{
					FilteredElementCollector val2 = new FilteredElementCollector(hGDoc, (ICollection<ElementId>)list2).OfCategoryId(item2);
					IList<Element> eleList = val2.ToElements();
					DataTable table = Method.ElementParameter2Table(this.cmddata, eleList);
					DataTable table2 = Method.ParameterIsRead(this.cmddata, eleList, hGDoc);
					dataSet.Tables.Add(table);
					dataSet2.Tables.Add(table2);
				}
			}
			else
			{
				ICollection<ElementId> collection = new List<ElementId>();
				foreach (ElementId item3 in list2)
				{
					try
					{
						Element element2 = hGDoc.GetElement(item3);
						collection.Add(item3);
						list.Add(element2);
					}
					catch
					{
					}
				}
				if (list.Count > 0)
				{
					List<ElementId> list5 = new List<ElementId>();
					foreach (Element item4 in list)
					{
						try
						{
							list5.Add(item4.get_Category().get_Id());
						}
						catch
						{
						}
					}
					List<ElementId> list6 = ((IEnumerable<ElementId>)list5).Distinct<ElementId>().ToList<ElementId>();
					foreach (ElementId item5 in list6)
					{
						FilteredElementCollector val3 = new FilteredElementCollector(hGDoc, collection).OfCategoryId(item5);
						IList<Element> eleList2 = val3.ToElements();
						DataTable table3 = Method.ElementParameter2Table(this.cmddata, eleList2);
						DataTable table4 = Method.ParameterIsRead(this.cmddata, eleList2, hGDoc);
						dataSet.Tables.Add(table3);
						dataSet2.Tables.Add(table4);
					}
				}
			}
			this.loadDataGridToTab(dataSet);
			HotGear_Parameter_Explorer.TabSort(this.tabControl1);
			this.ComboBoxData(this.tabControl1);
			GlobalVar.Is_Read_Only = dataSet2;
			foreach (TabPage tabPage4 in this.tabControl1.TabPages)
			{
				if (tabPage4.Text == text)
				{
					this.tabControl1.SelectedTab = tabPage4;
				}
			}
			this.CellFormatting();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			GlobalVar.CM_GetUpdata -= this.GetUpdate;
			this.m_ExEvent.Dispose();
			this.m_ExEvent = null;
			this.m_Handler = null;
			this.m_ExEvent1.Dispose();
			this.m_ExEvent1 = null;
			this.m_Handler1 = null;
			this.m_ExEvent3.Dispose();
			this.m_ExEvent3 = null;
			this.m_Handler3 = null;
			foreach (Control control in this.tabControl1.Controls)
			{
				foreach (DataGridView control2 in control.Controls)
				{
					(control2.DataSource as DataTable).Clear();
				}
			}
		}

		private void loadDataGridToTab(DataSet dset)
		{
			int num = 0;
			DataSet is_Read_Only = GlobalVar.Is_Read_Only;
			foreach (DataTable table in dset.Tables)
			{
				string text = table.Rows[0][2].ToString();
				TabPage tabPage = new TabPage(text);
				this.tabControl1.TabPages.Add(tabPage);
				DataGridView dataGridView = new DataGridView();
				tabPage.Controls.Add(dataGridView);
				dataGridView.Name = text;
				dataGridView.ReadOnly = false;
				dataGridView.Visible = true;
				dataGridView.AllowDrop = true;
				dataGridView.AllowUserToAddRows = false;
				dataGridView.AllowUserToDeleteRows = false;
				dataGridView.AllowUserToResizeColumns = true;
				dataGridView.GridColor = Color.Black;
				dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
				dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
				dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				dataGridView.TabIndex = num;
				dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
				dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				dataGridView.Dock = DockStyle.Fill;
				dataGridView.Location = new Point(3, 3);
				dataGridView.Name = text;
				dataGridView.Size = new Size(858, 245);
				dataGridView.SelectionChanged += this._SelectionChanged;
				dataGridView.CellDoubleClick += this._CellDoubleClick;
				dataGridView.KeyDown += this._KeyDown;
				dataGridView.MouseLeave += this.Grid_MouseLeave;
				dataGridView.CellValueChanged += this.Grid_CellValueChanged;
				dataGridView.CellEndEdit += this.Grid_CellEndEdit;
				dataGridView.Sorted += this.Grid_Sorted;
				dataGridView.Dock = DockStyle.Fill;
				dataGridView.DataSource = table;
				dataGridView.ColumnHeaderMouseClick += this.Grid_ColumnHeaderMouseClick;
				dataGridView.AllowUserToResizeRows = false;
				dataGridView.Columns["ElementGUID"].Visible = false;
				dataGridView.AllowUserToOrderColumns = true;
				table.AcceptChanges();
				num++;
			}
		}

		private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		private void Grid_MouseLeave(object sender, EventArgs e)
		{
			foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
			{
				control.EndEdit();
			}
		}

		private void Grid_Sorted(object sender, EventArgs e)
		{
			this.CellFormatting();
		}

		private void CellFormattingWithDGV(DataGridView dgv)
		{
			DataSet is_Read_Only = GlobalVar.Is_Read_Only;
			try
			{
				DataTable dataTable = is_Read_Only.Tables[dgv.TabIndex];
				for (int i = 0; i < dataTable.Columns.Count; i++)
				{
					for (int j = 0; j < dataTable.Rows.Count; j++)
					{
						if (j < dgv.RowCount)
						{
							try
							{
								DataGridViewCell dataGridViewCell = dgv[i, j];
								string key = dgv[0, j].Value.ToString();
								DataRow row = dataTable.Rows.Find(key);
								int index = dataTable.Rows.IndexOf(row);
								if (dgv[0, j].Value.ToString() == dataTable.Rows[index][0].ToString())
								{
									if (dataTable.Rows[index][i].ToString() == "")
									{
										dataGridViewCell.Style.BackColor = Color.DarkGray;
										dataGridViewCell.ReadOnly = true;
									}
									else if (i == 0 || i == 1 || i == 2)
									{
										dataGridViewCell.Style.BackColor = Color.WhiteSmoke;
										dataGridViewCell.ReadOnly = true;
									}
									else if (dataTable.Rows[index][i].ToString().Substring(0, 4) == "True")
									{
										dataGridViewCell.Style.BackColor = Color.WhiteSmoke;
										dataGridViewCell.ReadOnly = true;
									}
									else if (dataTable.Rows[index][i].ToString() == "False")
									{
										dataGridViewCell.Style.BackColor = Color.LightGreen;
										dataGridViewCell.ReadOnly = false;
									}
									else if (dataTable.Rows[index][i].ToString() == "False,ElementId")
									{
										dataGridViewCell.Style.BackColor = Color.LightYellow;
										dataGridViewCell.ReadOnly = false;
									}
									else if (dataTable.Rows[index][i].ToString() == "False,Double")
									{
										dataGridViewCell.Style.BackColor = Color.LightCyan;
										dataGridViewCell.ReadOnly = false;
									}
									else if (dataTable.Rows[index][i].ToString() == "False,Integer")
									{
										dataGridViewCell.Style.BackColor = Color.LightPink;
										dataGridViewCell.ReadOnly = false;
									}
									else
									{
										dataGridViewCell.Style.BackColor = Color.Black;
										dataGridViewCell.ReadOnly = true;
									}
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		private void CellFormatting()
		{
			DataSet is_Read_Only = GlobalVar.Is_Read_Only;
			try
			{
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					DataTable dataTable = is_Read_Only.Tables[control.TabIndex];
					for (int i = 0; i < dataTable.Columns.Count; i++)
					{
						for (int j = 0; j < dataTable.Rows.Count; j++)
						{
							if (j < control.RowCount)
							{
								try
								{
									DataGridViewCell dataGridViewCell = control[i, j];
									string key = control[0, j].Value.ToString();
									DataRow row = dataTable.Rows.Find(key);
									int index = dataTable.Rows.IndexOf(row);
									if (control[0, j].Value.ToString() == dataTable.Rows[index][0].ToString())
									{
										if (i == 0 || i == 1 || i == 2)
										{
											dataGridViewCell.Style.BackColor = Color.WhiteSmoke;
											dataGridViewCell.ReadOnly = true;
										}
										else if (dataTable.Rows[index][i].ToString() == string.Empty)
										{
											dataGridViewCell.Style.BackColor = Color.DarkGray;
											dataGridViewCell.ReadOnly = true;
										}
										else if (dataTable.Rows[index][i].ToString().Substring(0, 4) == "True")
										{
											dataGridViewCell.Style.BackColor = Color.WhiteSmoke;
											dataGridViewCell.ReadOnly = true;
										}
										else if (dataTable.Rows[index][i].ToString() == "False")
										{
											dataGridViewCell.Style.BackColor = Color.LightGreen;
											dataGridViewCell.ReadOnly = false;
										}
										else if (dataTable.Rows[index][i].ToString() == "False,ElementId")
										{
											dataGridViewCell.Style.BackColor = Color.LightYellow;
											dataGridViewCell.ReadOnly = false;
										}
										else if (dataTable.Rows[index][i].ToString() == "False,Double")
										{
											dataGridViewCell.Style.BackColor = Color.LightCyan;
											dataGridViewCell.ReadOnly = false;
										}
										else if (dataTable.Rows[index][i].ToString() == "False,Integer")
										{
											dataGridViewCell.Style.BackColor = Color.LightPink;
											dataGridViewCell.ReadOnly = false;
										}
										else
										{
											dataGridViewCell.Style.BackColor = Color.Black;
											dataGridViewCell.ReadOnly = true;
										}
									}
								}
								catch
								{
								}
							}
						}
					}
					for (int k = 0; k < control.RowCount; k++)
					{
						control[control.SortedColumn.Index, k].Style.ForeColor = Color.Navy;
						control[control.SortedColumn.Index, k].Style.BackColor = Color.WhiteSmoke;
						control[control.SortedColumn.Index, k].ReadOnly = true;
					}
				}
			}
			catch
			{
			}
		}

		private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
			{
				foreach (DataGridViewCell selectedCell in control.SelectedCells)
				{
					int columnIndex = e.ColumnIndex;
					int rowIndex = e.RowIndex;
					control[columnIndex, rowIndex].Style.ForeColor = Color.Red;
				}
				foreach (DataGridViewColumn column in control.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.Programmatic;
				}
			}
			this.Accept_Change.BackColor = Color.LightGreen;
			this.Reject_Change.BackColor = Color.Red;
		}

		private void Reject_Click(object sender, EventArgs e)
		{
			foreach (TabPage tabPage3 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage3.Controls)
				{
					foreach (DataGridViewRow item in (IEnumerable)control.Rows)
					{
						foreach (DataGridViewCell cell in item.Cells)
						{
							if (cell.Style.ForeColor == Color.Red)
							{
								cell.Style.ForeColor = Control.DefaultForeColor;
							}
						}
					}
					(control.DataSource as DataTable).RejectChanges();
					foreach (DataGridViewColumn column in control.Columns)
					{
						column.SortMode = DataGridViewColumnSortMode.Automatic;
					}
				}
			}
			this.CellFormatting();
			this.Accept_Change.BackColor = Control.DefaultBackColor;
			this.Reject_Change.BackColor = Control.DefaultBackColor;
		}

		private void Accept_Click(object sender, EventArgs e)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			this.tabControl1.Visible = false;
			Document hGDoc = this.HGDoc;
			string text = "Change Log :\n";
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<Element> list3 = new List<Element>();
			foreach (TabPage tabPage3 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage3.Controls)
				{
					foreach (DataGridViewRow item in (IEnumerable)control.Rows)
					{
						foreach (DataGridViewCell cell in item.Cells)
						{
							if (cell.Style.ForeColor == Color.Red)
							{
								int rowIndex = cell.RowIndex;
								int columnIndex = cell.ColumnIndex;
								string name = control.Columns[columnIndex].Name;
								list.Add(name);
								string text2 = control[columnIndex, rowIndex].Value.ToString();
								list2.Add(text2);
								cell.Value = text2;
								cell.Style.ForeColor = Control.DefaultForeColor;
								int num = int.Parse(control[0, rowIndex].Value.ToString());
								ElementId val = new ElementId(num);
								Element element = hGDoc.GetElement(val);
								list3.Add(element);
								text = text + "Parameter Name : " + name + " Parameter Value : " + text2 + " ElementId : " + num.ToString() + "\n";
							}
						}
					}
					foreach (DataGridViewColumn column in control.Columns)
					{
						column.SortMode = DataGridViewColumnSortMode.Automatic;
					}
					(control.DataSource as DataTable).AcceptChanges();
				}
			}
			if (list3.Count == 0)
			{
				this.CellFormatting();
				this.tabControl1.Visible = true;
				MessageBox.Show("Nothing Change", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.Accept_Change.BackColor = Control.DefaultBackColor;
				this.Reject_Change.BackColor = Control.DefaultBackColor;
				GlobalVar.G_ParameterName = list;
				GlobalVar.G_ParameterValue = list2;
				GlobalVar.G_ElementList = list3;
				this.m_ExEvent.Raise();
				this.tabControl1.Visible = true;
			}
		}

		private void Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			List<string> list = new List<string>();
			string value = "";
			foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
			{
				value = control[e.ColumnIndex, e.RowIndex].Value.ToString();
				foreach (DataGridViewCell selectedCell in control.SelectedCells)
				{
					int rowIndex = selectedCell.RowIndex;
					list.Add(control[0, rowIndex].Value.ToString());
				}
			}
			foreach (DataGridView control2 in this.tabControl1.SelectedTab.Controls)
			{
				for (int i = 0; i < control2.RowCount; i++)
				{
					if (control2[e.ColumnIndex, i].Style.BackColor != Color.WhiteSmoke && control2[e.ColumnIndex, i].Style.BackColor != Color.DarkGray)
					{
						int columnIndex = e.ColumnIndex;
						int rowIndex2 = e.RowIndex;
						foreach (string item in list)
						{
							if (control2[0, i].Value.ToString() == item)
							{
								try
								{
									control2[e.ColumnIndex, i].Value = value;
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.ToString());
								}
							}
						}
					}
				}
			}
		}

		private void loadDataGridToTreeView(TabControl TabControl)
		{
			TreeNode treeNode = new TreeNode("Category");
			this.treeView1.Nodes.AddRange(new TreeNode[1]
			{
				treeNode
			});
			foreach (Control control in TabControl.Controls)
			{
				foreach (DataGridView control2 in control.Controls)
				{
					string text = (control2.DataSource as DataTable).Rows[0][2].ToString();
					TreeNode treeNode2 = treeNode.Nodes.Add(text);
					List<string> list = new List<string>();
					foreach (DataColumn column in (control2.DataSource as DataTable).Columns)
					{
						list.Add(column.ColumnName);
					}
					List<string> list2 = list.Distinct().ToList();
					foreach (string item in list2)
					{
						TreeNode treeNode3 = treeNode2.Nodes.Add(item);
						List<string> list3 = new List<string>();
						foreach (DataRow row in (control2.DataSource as DataTable).Rows)
						{
							list3.Add(row.Field<string>(item));
						}
						List<string> list4 = list3.Distinct().ToList();
						foreach (string item2 in list4)
						{
							try
							{
								TreeNode treeNode4 = treeNode3.Nodes.Add(item2);
							}
							catch
							{
							}
						}
					}
				}
			}
			this.treeView1.Sort();
			treeNode.Expand();
		}

		private void _KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.ToString() == "F2")
			{
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					foreach (DataGridViewCell selectedCell in control.SelectedCells)
					{
						int rowIndex = selectedCell.RowIndex;
						int columnIndex = selectedCell.ColumnIndex;
						control.BeginEdit(true);
					}
				}
			}
		}

		private void CopyToClipboard_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					if (control.GetCellCount(DataGridViewElementStates.Selected) > 0)
					{
						try
						{
							Clipboard.SetDataObject(control.GetClipboardContent());
						}
						catch (ExternalException)
						{
						}
					}
					else
					{
						MessageBox.Show("Nothing Selected.", "Notice.");
					}
				}
			}
			catch
			{
				MessageBox.Show("Not have any data on programme please restart HotGear Parameter Explorer.");
			}
		}

		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpDateStatusStrip();
			this.CellFormatting();
		}

		private void _SelectionChanged(object sender, EventArgs e)
		{
			this.UpDateStatusStrip();
		}

		private void textBox1IsClick(object sender, EventArgs e)
		{
			this.textBox1.Clear();
		}

		private void CurrentTab2Excel_Click(object sender, EventArgs e)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				this.progressBar1.Visible = true;
				UIApplication hGUiApp = this.HGUiApp;
				Document hGDoc = this.HGDoc;
				string versionName = hGUiApp.get_Application().get_VersionName();
				string versionNumber = hGUiApp.get_Application().get_VersionNumber();
				string versionBuild = hGUiApp.get_Application().get_VersionBuild();
				string name = WindowsIdentity.GetCurrent().Name;
				string pathName = hGDoc.get_PathName();
				string text = DateTime.Now.ToString();
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Excel WorkBook|*.xlsx";
				saveFileDialog.Title = "Save To Excel";
				saveFileDialog.CheckPathExists = true;
				saveFileDialog.ShowDialog();
				string fileName = saveFileDialog.FileName;
				if (saveFileDialog.FileName != "")
				{
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					application.Visible = false;
					Workbook workbook = application.Workbooks.Add(Missing.Value);
					int num = 1;
					int num2 = 2;
					int num3 = 1;
					if (_003C_003Eo__84._003C_003Ep__0 == null)
					{
						_003C_003Eo__84._003C_003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
					}
					Worksheet worksheet = _003C_003Eo__84._003C_003Ep__0.Target(_003C_003Eo__84._003C_003Ep__0, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
					worksheet.Name = "WorkSheet Index";
					foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
					{
						try
						{
							this.CellFormattingWithDGV(control);
							string cell = "A" + num2.ToString();
							string cell2 = "B" + num2.ToString();
							string cell3 = "C" + num2.ToString();
							if (_003C_003Eo__84._003C_003Ep__1 == null)
							{
								_003C_003Eo__84._003C_003Ep__1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
							}
							Worksheet worksheet2 = _003C_003Eo__84._003C_003Ep__1.Target(_003C_003Eo__84._003C_003Ep__1, workbook.Sheets["WorkSheet Index"]);
							worksheet2.Cells[1, 1] = "Index";
							worksheet2.Cells[1, 2] = "Category";
							worksheet2.Cells[1, 3] = "Read/Skip";
							((_Worksheet)worksheet2).get_Range((object)"A1", (object)"C1").Cells.Interior.Color = ColorTranslator.ToOle(Color.WhiteSmoke);
							((_Worksheet)worksheet2).get_Range((object)"A2", (object)cell2).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
							((_Worksheet)worksheet2).get_Range((object)"C2", (object)cell3).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
							((_Worksheet)worksheet2).get_Range((object)cell, Type.Missing).Value2 = num3.ToString();
							((_Worksheet)worksheet2).get_Range((object)"C2", (object)cell3).Value2 = "Read";
							worksheet2.Cells[num2, 2] = control[2, 0].Value.ToString();
							worksheet2.Columns.AutoFit();
							((_Worksheet)worksheet2).get_Range((object)"C2", (object)cell3).Locked = false;
							num3++;
							num3++;
							Range usedRange = worksheet2.UsedRange;
							Borders borders = usedRange.Borders;
							borders.LineStyle = XlLineStyle.xlContinuous;
							borders.Weight = 2.0;
							worksheet2.Protect(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
							control.SelectAll();
							Clipboard.SetDataObject(control.GetClipboardContent());
							if (_003C_003Eo__84._003C_003Ep__2 == null)
							{
								_003C_003Eo__84._003C_003Ep__2 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
							}
							Worksheet worksheet3 = _003C_003Eo__84._003C_003Ep__2.Target(_003C_003Eo__84._003C_003Ep__2, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
							worksheet3.Name = num.ToString();
							num++;
							worksheet3.Columns.NumberFormat = "@";
							if (_003C_003Eo__84._003C_003Ep__3 == null)
							{
								_003C_003Eo__84._003C_003Ep__3 = CallSite<Func<CallSite, object, Range>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(HotGear_Parameter_Explorer)));
							}
							Range range = _003C_003Eo__84._003C_003Ep__3.Target(_003C_003Eo__84._003C_003Ep__3, worksheet3.Cells[1, 1]);
							range.Select();
							worksheet3.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
							range.Select();
							if (_003C_003Eo__84._003C_003Ep__4 == null)
							{
								_003C_003Eo__84._003C_003Ep__4 = CallSite<Func<CallSite, object, Range>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(HotGear_Parameter_Explorer)));
							}
							Range range2 = _003C_003Eo__84._003C_003Ep__4.Target(_003C_003Eo__84._003C_003Ep__4, worksheet3.Columns["A", Type.Missing]);
							range2.EntireColumn.Delete(Missing.Value);
							int num4 = 0;
							for (int i = 1; i < control.Columns.Count + 1; i++)
							{
								if (control.Columns[i - 1].Visible)
								{
									if (_003C_003Eo__84._003C_003Ep__6 == null)
									{
										_003C_003Eo__84._003C_003Ep__6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									Func<CallSite, object, bool, object> target = _003C_003Eo__84._003C_003Ep__6.Target;
									CallSite<Func<CallSite, object, bool, object>> _003C_003Ep__ = _003C_003Eo__84._003C_003Ep__6;
									if (_003C_003Eo__84._003C_003Ep__5 == null)
									{
										_003C_003Eo__84._003C_003Ep__5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									target(_003C_003Ep__, _003C_003Eo__84._003C_003Ep__5.Target(_003C_003Eo__84._003C_003Ep__5, worksheet3.Cells[1, num4 + 1]), true);
									if (_003C_003Eo__84._003C_003Ep__8 == null)
									{
										_003C_003Eo__84._003C_003Ep__8 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
										}));
									}
									Func<CallSite, object, int, object> target2 = _003C_003Eo__84._003C_003Ep__8.Target;
									CallSite<Func<CallSite, object, int, object>> _003C_003Ep__2 = _003C_003Eo__84._003C_003Ep__8;
									if (_003C_003Eo__84._003C_003Ep__7 == null)
									{
										_003C_003Eo__84._003C_003Ep__7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									target2(_003C_003Ep__2, _003C_003Eo__84._003C_003Ep__7.Target(_003C_003Eo__84._003C_003Ep__7, worksheet3.Cells[1, num4 + 1]), ColorTranslator.ToOle(Color.WhiteSmoke));
									num4++;
								}
							}
							this.progressBar1.Maximum = control.Rows.Count;
							for (int j = 0; j < control.Rows.Count; j++)
							{
								int num5 = 0;
								this.progressBar1.Value = j;
								for (int k = 0; k < control.Columns.Count; k++)
								{
									if (control.Columns[k].Visible)
									{
										if (control[num5, j].Style.BackColor == Color.WhiteSmoke)
										{
											if (_003C_003Eo__84._003C_003Ep__10 == null)
											{
												_003C_003Eo__84._003C_003Ep__10 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target3 = _003C_003Eo__84._003C_003Ep__10.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__3 = _003C_003Eo__84._003C_003Ep__10;
											if (_003C_003Eo__84._003C_003Ep__9 == null)
											{
												_003C_003Eo__84._003C_003Ep__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target3(_003C_003Ep__3, _003C_003Eo__84._003C_003Ep__9.Target(_003C_003Eo__84._003C_003Ep__9, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else if (control[num5, j].Style.BackColor == Color.DarkGray)
										{
											if (_003C_003Eo__84._003C_003Ep__12 == null)
											{
												_003C_003Eo__84._003C_003Ep__12 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target4 = _003C_003Eo__84._003C_003Ep__12.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__4 = _003C_003Eo__84._003C_003Ep__12;
											if (_003C_003Eo__84._003C_003Ep__11 == null)
											{
												_003C_003Eo__84._003C_003Ep__11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target4(_003C_003Ep__4, _003C_003Eo__84._003C_003Ep__11.Target(_003C_003Eo__84._003C_003Ep__11, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else if (control[num5, j].Style.BackColor == Color.LightYellow)
										{
											if (_003C_003Eo__84._003C_003Ep__14 == null)
											{
												_003C_003Eo__84._003C_003Ep__14 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target5 = _003C_003Eo__84._003C_003Ep__14.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__5 = _003C_003Eo__84._003C_003Ep__14;
											if (_003C_003Eo__84._003C_003Ep__13 == null)
											{
												_003C_003Eo__84._003C_003Ep__13 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target5(_003C_003Ep__5, _003C_003Eo__84._003C_003Ep__13.Target(_003C_003Eo__84._003C_003Ep__13, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else if (control[num5, j].Style.BackColor == Color.LightCyan)
										{
											if (_003C_003Eo__84._003C_003Ep__16 == null)
											{
												_003C_003Eo__84._003C_003Ep__16 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target6 = _003C_003Eo__84._003C_003Ep__16.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__6 = _003C_003Eo__84._003C_003Ep__16;
											if (_003C_003Eo__84._003C_003Ep__15 == null)
											{
												_003C_003Eo__84._003C_003Ep__15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target6(_003C_003Ep__6, _003C_003Eo__84._003C_003Ep__15.Target(_003C_003Eo__84._003C_003Ep__15, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else if (control[num5, j].Style.BackColor == Color.LightPink)
										{
											if (_003C_003Eo__84._003C_003Ep__18 == null)
											{
												_003C_003Eo__84._003C_003Ep__18 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target7 = _003C_003Eo__84._003C_003Ep__18.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__7 = _003C_003Eo__84._003C_003Ep__18;
											if (_003C_003Eo__84._003C_003Ep__17 == null)
											{
												_003C_003Eo__84._003C_003Ep__17 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target7(_003C_003Ep__7, _003C_003Eo__84._003C_003Ep__17.Target(_003C_003Eo__84._003C_003Ep__17, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else if (control[num5, j].Style.BackColor == Color.LightGreen)
										{
											if (_003C_003Eo__84._003C_003Ep__20 == null)
											{
												_003C_003Eo__84._003C_003Ep__20 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target8 = _003C_003Eo__84._003C_003Ep__20.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__8 = _003C_003Eo__84._003C_003Ep__20;
											if (_003C_003Eo__84._003C_003Ep__19 == null)
											{
												_003C_003Eo__84._003C_003Ep__19 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target8(_003C_003Ep__8, _003C_003Eo__84._003C_003Ep__19.Target(_003C_003Eo__84._003C_003Ep__19, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(control[k, j].Style.BackColor));
										}
										else
										{
											if (_003C_003Eo__84._003C_003Ep__22 == null)
											{
												_003C_003Eo__84._003C_003Ep__22 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target9 = _003C_003Eo__84._003C_003Ep__22.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__9 = _003C_003Eo__84._003C_003Ep__22;
											if (_003C_003Eo__84._003C_003Ep__21 == null)
											{
												_003C_003Eo__84._003C_003Ep__21 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target9(_003C_003Ep__9, _003C_003Eo__84._003C_003Ep__21.Target(_003C_003Eo__84._003C_003Ep__21, worksheet3.Cells[j + 2, num5 + 1]), ColorTranslator.ToOle(Color.Black));
										}
										num5++;
									}
								}
							}
							this.progressBar1.Value = control.Rows.Count;
							worksheet3.Application.ActiveWindow.SplitRow = 1;
							worksheet3.Application.ActiveWindow.FreezePanes = true;
							Range usedRange2 = worksheet3.UsedRange;
							Borders borders2 = usedRange2.Borders;
							borders2.LineStyle = XlLineStyle.xlContinuous;
							borders2.Weight = 2.0;
							usedRange2.AutoFilter(1, Type.Missing, XlAutoFilterOperator.xlAnd, Type.Missing, true);
							worksheet3.Columns.AutoFit();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
						control.ClearSelection();
					}
					if (_003C_003Eo__84._003C_003Ep__23 == null)
					{
						_003C_003Eo__84._003C_003Ep__23 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
					}
					Worksheet worksheet4 = _003C_003Eo__84._003C_003Ep__23.Target(_003C_003Eo__84._003C_003Ep__23, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
					worksheet4.Name = "Export Info";
					if (_003C_003Eo__84._003C_003Ep__24 == null)
					{
						_003C_003Eo__84._003C_003Ep__24 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
					}
					Worksheet worksheet5 = _003C_003Eo__84._003C_003Ep__24.Target(_003C_003Eo__84._003C_003Ep__24, workbook.Sheets["Export Info"]);
					worksheet5.Cells[1, 1] = "Revit Version";
					worksheet5.Cells[1, 2] = "Revit Version Number";
					worksheet5.Cells[1, 3] = "Revit Version Build";
					worksheet5.Cells[1, 4] = "Username";
					worksheet5.Cells[1, 5] = "Document Path";
					worksheet5.Cells[1, 6] = "Time";
					worksheet5.Cells[2, 1] = versionName;
					worksheet5.Cells[2, 2] = versionNumber;
					worksheet5.Cells[2, 3] = versionBuild;
					worksheet5.Cells[2, 4] = name;
					worksheet5.Cells[2, 5] = pathName;
					worksheet5.Cells[2, 6] = text;
					worksheet5.Cells[4, 1] = "Color Code";
					worksheet5.Cells[4, 2] = "Color Name";
					worksheet5.Cells[4, 3] = "Remark";
					worksheet5.Cells[5, 1] = "245,245,245";
					worksheet5.Cells[5, 2] = "White Smoke";
					worksheet5.Cells[5, 3] = "Data Read Only";
					worksheet5.Cells[6, 1] = "169,169,169";
					worksheet5.Cells[6, 2] = "Dark Gray";
					worksheet5.Cells[6, 3] = "Parameter Not Exist";
					worksheet5.Cells[7, 1] = "255,182,193";
					worksheet5.Cells[7, 2] = "Light Pink";
					worksheet5.Cells[7, 3] = "Parameter Store with Integer";
					worksheet5.Cells[8, 1] = "255,255,224";
					worksheet5.Cells[8, 2] = "Light Yellow";
					worksheet5.Cells[8, 3] = "Parameter Store with ElementId";
					worksheet5.Cells[9, 1] = "144,238,144";
					worksheet5.Cells[9, 2] = "Light Green";
					worksheet5.Cells[9, 3] = "Parameter Store with String";
					worksheet5.Cells[10, 1] = "224,255,255";
					worksheet5.Cells[10, 2] = "Light Cyan";
					worksheet5.Cells[10, 3] = "Parameter Store with Double";
					Range usedRange3 = worksheet5.UsedRange;
					((_Worksheet)worksheet5).get_Range((object)"A1", (object)"F1").Cells.Font.Bold = true;
					((_Worksheet)worksheet5).get_Range((object)"A4", (object)"C4").Cells.Font.Bold = true;
					((_Worksheet)worksheet5).get_Range((object)"A5", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.WhiteSmoke);
					((_Worksheet)worksheet5).get_Range((object)"A6", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.DarkGray);
					((_Worksheet)worksheet5).get_Range((object)"A7", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightPink);
					((_Worksheet)worksheet5).get_Range((object)"A8", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightYellow);
					((_Worksheet)worksheet5).get_Range((object)"A9", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
					((_Worksheet)worksheet5).get_Range((object)"A10", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightCyan);
					Range range3 = ((_Worksheet)worksheet5).get_Range((object)"A5", (object)"A10");
					Borders borders3 = range3.Borders;
					borders3.LineStyle = XlLineStyle.xlContinuous;
					borders3.Weight = 2.0;
					worksheet5.Columns.AutoFit();
					worksheet5.Protect(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					this.progressBar1.Visible = false;
					try
					{
						workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
						workbook.Close(Type.Missing, Type.Missing, Type.Missing);
						Process.Start(fileName);
					}
					catch (Exception ex2)
					{
						MessageBox.Show(ex2.Message.ToString(), "Exception");
					}
					stopwatch.Stop();
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show(ex3.Message.ToString(), "Exception");
			}
		}

		private void AllTab2Excel_Click(object sender, EventArgs e)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			this.progressBar1.Visible = true;
			this.progressBar2.Visible = true;
			this.progressBar1.Value = 0;
			this.progressBar2.Value = 0;
			UIApplication hGUiApp = this.HGUiApp;
			Document hGDoc = this.HGDoc;
			string versionName = hGUiApp.get_Application().get_VersionName();
			string versionNumber = hGUiApp.get_Application().get_VersionNumber();
			string versionBuild = hGUiApp.get_Application().get_VersionBuild();
			string name = WindowsIdentity.GetCurrent().Name;
			string pathName = hGDoc.get_PathName();
			string text = DateTime.Now.ToString();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel WorkBook|*.xlsx";
			saveFileDialog.Title = "Save To Excel";
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.ShowDialog();
			string fileName = saveFileDialog.FileName;
			if (saveFileDialog.FileName != "")
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				application.Visible = false;
				Workbook workbook = application.Workbooks.Add(Missing.Value);
				int num = 1;
				this.progressBar2.Maximum = this.tabControl1.Controls.Count;
				foreach (Control control3 in this.tabControl1.Controls)
				{
					TabPage tabPage = (TabPage)control3;
					foreach (DataGridView control4 in tabPage.Controls)
					{
						this.progressBar2.Value++;
						try
						{
							this.CellFormattingWithDGV(control4);
							control4.SelectAll();
							Clipboard.SetDataObject(control4.GetClipboardContent());
							if (_003C_003Eo__85._003C_003Ep__0 == null)
							{
								_003C_003Eo__85._003C_003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
							}
							Worksheet worksheet = _003C_003Eo__85._003C_003Ep__0.Target(_003C_003Eo__85._003C_003Ep__0, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
							worksheet.Name = num.ToString();
							num++;
							worksheet.Columns.NumberFormat = "@";
							if (_003C_003Eo__85._003C_003Ep__1 == null)
							{
								_003C_003Eo__85._003C_003Ep__1 = CallSite<Func<CallSite, object, Range>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(HotGear_Parameter_Explorer)));
							}
							Range range = _003C_003Eo__85._003C_003Ep__1.Target(_003C_003Eo__85._003C_003Ep__1, worksheet.Cells[1, 1]);
							range.Select();
							worksheet.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
							range.Select();
							if (_003C_003Eo__85._003C_003Ep__2 == null)
							{
								_003C_003Eo__85._003C_003Ep__2 = CallSite<Func<CallSite, object, Range>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(HotGear_Parameter_Explorer)));
							}
							Range range2 = _003C_003Eo__85._003C_003Ep__2.Target(_003C_003Eo__85._003C_003Ep__2, worksheet.Columns["A", Type.Missing]);
							range2.EntireColumn.Delete(Missing.Value);
							int num2 = 0;
							for (int i = 1; i < control4.Columns.Count + 1; i++)
							{
								if (control4.Columns[i - 1].Visible)
								{
									if (_003C_003Eo__85._003C_003Ep__4 == null)
									{
										_003C_003Eo__85._003C_003Ep__4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									Func<CallSite, object, bool, object> target = _003C_003Eo__85._003C_003Ep__4.Target;
									CallSite<Func<CallSite, object, bool, object>> _003C_003Ep__ = _003C_003Eo__85._003C_003Ep__4;
									if (_003C_003Eo__85._003C_003Ep__3 == null)
									{
										_003C_003Eo__85._003C_003Ep__3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									target(_003C_003Ep__, _003C_003Eo__85._003C_003Ep__3.Target(_003C_003Eo__85._003C_003Ep__3, worksheet.Cells[1, num2 + 1]), true);
									if (_003C_003Eo__85._003C_003Ep__6 == null)
									{
										_003C_003Eo__85._003C_003Ep__6 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
										}));
									}
									Func<CallSite, object, int, object> target2 = _003C_003Eo__85._003C_003Ep__6.Target;
									CallSite<Func<CallSite, object, int, object>> _003C_003Ep__2 = _003C_003Eo__85._003C_003Ep__6;
									if (_003C_003Eo__85._003C_003Ep__5 == null)
									{
										_003C_003Eo__85._003C_003Ep__5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									target2(_003C_003Ep__2, _003C_003Eo__85._003C_003Ep__5.Target(_003C_003Eo__85._003C_003Ep__5, worksheet.Cells[1, num2 + 1]), ColorTranslator.ToOle(Color.WhiteSmoke));
									num2++;
								}
							}
							this.progressBar1.Maximum = control4.Rows.Count;
							for (int j = 0; j < control4.Rows.Count; j++)
							{
								int num3 = 0;
								this.progressBar1.Value = j;
								for (int k = 0; k < control4.Columns.Count; k++)
								{
									if (control4.Columns[k].Visible)
									{
										if (control4[num3, j].Style.BackColor == Color.WhiteSmoke)
										{
											if (_003C_003Eo__85._003C_003Ep__8 == null)
											{
												_003C_003Eo__85._003C_003Ep__8 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target3 = _003C_003Eo__85._003C_003Ep__8.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__3 = _003C_003Eo__85._003C_003Ep__8;
											if (_003C_003Eo__85._003C_003Ep__7 == null)
											{
												_003C_003Eo__85._003C_003Ep__7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target3(_003C_003Ep__3, _003C_003Eo__85._003C_003Ep__7.Target(_003C_003Eo__85._003C_003Ep__7, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else if (control4[num3, j].Style.BackColor == Color.DarkGray)
										{
											if (_003C_003Eo__85._003C_003Ep__10 == null)
											{
												_003C_003Eo__85._003C_003Ep__10 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target4 = _003C_003Eo__85._003C_003Ep__10.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__4 = _003C_003Eo__85._003C_003Ep__10;
											if (_003C_003Eo__85._003C_003Ep__9 == null)
											{
												_003C_003Eo__85._003C_003Ep__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target4(_003C_003Ep__4, _003C_003Eo__85._003C_003Ep__9.Target(_003C_003Eo__85._003C_003Ep__9, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else if (control4[num3, j].Style.BackColor == Color.LightYellow)
										{
											if (_003C_003Eo__85._003C_003Ep__12 == null)
											{
												_003C_003Eo__85._003C_003Ep__12 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target5 = _003C_003Eo__85._003C_003Ep__12.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__5 = _003C_003Eo__85._003C_003Ep__12;
											if (_003C_003Eo__85._003C_003Ep__11 == null)
											{
												_003C_003Eo__85._003C_003Ep__11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target5(_003C_003Ep__5, _003C_003Eo__85._003C_003Ep__11.Target(_003C_003Eo__85._003C_003Ep__11, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else if (control4[num3, j].Style.BackColor == Color.LightCyan)
										{
											if (_003C_003Eo__85._003C_003Ep__14 == null)
											{
												_003C_003Eo__85._003C_003Ep__14 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target6 = _003C_003Eo__85._003C_003Ep__14.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__6 = _003C_003Eo__85._003C_003Ep__14;
											if (_003C_003Eo__85._003C_003Ep__13 == null)
											{
												_003C_003Eo__85._003C_003Ep__13 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target6(_003C_003Ep__6, _003C_003Eo__85._003C_003Ep__13.Target(_003C_003Eo__85._003C_003Ep__13, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else if (control4[num3, j].Style.BackColor == Color.LightPink)
										{
											if (_003C_003Eo__85._003C_003Ep__16 == null)
											{
												_003C_003Eo__85._003C_003Ep__16 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target7 = _003C_003Eo__85._003C_003Ep__16.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__7 = _003C_003Eo__85._003C_003Ep__16;
											if (_003C_003Eo__85._003C_003Ep__15 == null)
											{
												_003C_003Eo__85._003C_003Ep__15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target7(_003C_003Ep__7, _003C_003Eo__85._003C_003Ep__15.Target(_003C_003Eo__85._003C_003Ep__15, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else if (control4[num3, j].Style.BackColor == Color.LightGreen)
										{
											if (_003C_003Eo__85._003C_003Ep__18 == null)
											{
												_003C_003Eo__85._003C_003Ep__18 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target8 = _003C_003Eo__85._003C_003Ep__18.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__8 = _003C_003Eo__85._003C_003Ep__18;
											if (_003C_003Eo__85._003C_003Ep__17 == null)
											{
												_003C_003Eo__85._003C_003Ep__17 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target8(_003C_003Ep__8, _003C_003Eo__85._003C_003Ep__17.Target(_003C_003Eo__85._003C_003Ep__17, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(control4[k, j].Style.BackColor));
										}
										else
										{
											if (_003C_003Eo__85._003C_003Ep__20 == null)
											{
												_003C_003Eo__85._003C_003Ep__20 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target9 = _003C_003Eo__85._003C_003Ep__20.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__9 = _003C_003Eo__85._003C_003Ep__20;
											if (_003C_003Eo__85._003C_003Ep__19 == null)
											{
												_003C_003Eo__85._003C_003Ep__19 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											target9(_003C_003Ep__9, _003C_003Eo__85._003C_003Ep__19.Target(_003C_003Eo__85._003C_003Ep__19, worksheet.Cells[j + 2, num3 + 1]), ColorTranslator.ToOle(Color.Black));
										}
										num3++;
									}
								}
							}
							worksheet.Application.ActiveWindow.SplitRow = 1;
							worksheet.Application.ActiveWindow.FreezePanes = true;
							Range usedRange = worksheet.UsedRange;
							Borders borders = usedRange.Borders;
							borders.LineStyle = XlLineStyle.xlContinuous;
							borders.Weight = 2.0;
							usedRange.AutoFilter(1, Type.Missing, XlAutoFilterOperator.xlAnd, Type.Missing, true);
							worksheet.Columns.AutoFit();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
						control4.ClearSelection();
					}
				}
				if (_003C_003Eo__85._003C_003Ep__21 == null)
				{
					_003C_003Eo__85._003C_003Ep__21 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
				}
				Worksheet worksheet2 = _003C_003Eo__85._003C_003Ep__21.Target(_003C_003Eo__85._003C_003Ep__21, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
				worksheet2.Name = "Export Info";
				if (_003C_003Eo__85._003C_003Ep__22 == null)
				{
					_003C_003Eo__85._003C_003Ep__22 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
				}
				Worksheet worksheet3 = _003C_003Eo__85._003C_003Ep__22.Target(_003C_003Eo__85._003C_003Ep__22, workbook.Sheets["Export Info"]);
				worksheet3.Cells[1, 1] = "Revit Version";
				worksheet3.Cells[1, 2] = "Revit Version Number";
				worksheet3.Cells[1, 3] = "Revit Version Build";
				worksheet3.Cells[1, 4] = "Username";
				worksheet3.Cells[1, 5] = "Document Path";
				worksheet3.Cells[1, 6] = "Time";
				worksheet3.Cells[2, 1] = versionName;
				worksheet3.Cells[2, 2] = versionNumber;
				worksheet3.Cells[2, 3] = versionBuild;
				worksheet3.Cells[2, 4] = name;
				worksheet3.Cells[2, 5] = pathName;
				worksheet3.Cells[2, 6] = text;
				worksheet3.Cells[4, 1] = "Color Code";
				worksheet3.Cells[4, 2] = "Color Name";
				worksheet3.Cells[4, 3] = "Remark";
				worksheet3.Cells[5, 1] = "245,245,245";
				worksheet3.Cells[5, 2] = "White Smoke";
				worksheet3.Cells[5, 3] = "Data Read Only";
				worksheet3.Cells[6, 1] = "169,169,169";
				worksheet3.Cells[6, 2] = "Dark Gray";
				worksheet3.Cells[6, 3] = "Parameter Not Exist";
				worksheet3.Cells[7, 1] = "255,182,193";
				worksheet3.Cells[7, 2] = "Light Pink";
				worksheet3.Cells[7, 3] = "Parameter Store with Integer";
				worksheet3.Cells[8, 1] = "255,255,224";
				worksheet3.Cells[8, 2] = "Light Yellow";
				worksheet3.Cells[8, 3] = "Parameter Store with ElementId";
				worksheet3.Cells[9, 1] = "144,238,144";
				worksheet3.Cells[9, 2] = "Light Green";
				worksheet3.Cells[9, 3] = "Parameter Store with String";
				worksheet3.Cells[10, 1] = "224,255,255";
				worksheet3.Cells[10, 2] = "Light Cyan";
				worksheet3.Cells[10, 3] = "Parameter Store with Double";
				Range usedRange2 = worksheet3.UsedRange;
				((_Worksheet)worksheet3).get_Range((object)"A1", (object)"F1").Cells.Font.Bold = true;
				((_Worksheet)worksheet3).get_Range((object)"A4", (object)"C4").Cells.Font.Bold = true;
				((_Worksheet)worksheet3).get_Range((object)"A5", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.WhiteSmoke);
				((_Worksheet)worksheet3).get_Range((object)"A6", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.DarkGray);
				((_Worksheet)worksheet3).get_Range((object)"A7", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightPink);
				((_Worksheet)worksheet3).get_Range((object)"A8", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightYellow);
				((_Worksheet)worksheet3).get_Range((object)"A9", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
				((_Worksheet)worksheet3).get_Range((object)"A10", Type.Missing).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightCyan);
				Range range3 = ((_Worksheet)worksheet3).get_Range((object)"A5", (object)"A10");
				Borders borders2 = range3.Borders;
				borders2.LineStyle = XlLineStyle.xlContinuous;
				borders2.Weight = 2.0;
				worksheet3.Columns.AutoFit();
				worksheet3.Protect(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				int num4 = 2;
				int num5 = 1;
				if (_003C_003Eo__85._003C_003Ep__23 == null)
				{
					_003C_003Eo__85._003C_003Ep__23 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
				}
				Worksheet worksheet4 = _003C_003Eo__85._003C_003Ep__23.Target(_003C_003Eo__85._003C_003Ep__23, workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing));
				worksheet4.Name = "WorkSheet Index";
				if (_003C_003Eo__85._003C_003Ep__24 == null)
				{
					_003C_003Eo__85._003C_003Ep__24 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
				}
				Worksheet worksheet5 = _003C_003Eo__85._003C_003Ep__24.Target(_003C_003Eo__85._003C_003Ep__24, workbook.Sheets["WorkSheet Index"]);
				foreach (Control control5 in this.tabControl1.Controls)
				{
					TabPage tabPage2 = (TabPage)control5;
					foreach (DataGridView control6 in tabPage2.Controls)
					{
						string cell = "A" + num4.ToString();
						string cell2 = "B" + num4.ToString();
						string cell3 = "C" + num4.ToString();
						worksheet5.Cells[1, 1] = "Index";
						worksheet5.Cells[1, 2] = "Category";
						worksheet5.Cells[1, 3] = "Read/Skip";
						((_Worksheet)worksheet5).get_Range((object)"A1", (object)"C1").Cells.Interior.Color = ColorTranslator.ToOle(Color.WhiteSmoke);
						((_Worksheet)worksheet5).get_Range((object)"A2", (object)cell2).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
						((_Worksheet)worksheet5).get_Range((object)"C2", (object)cell3).Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
						((_Worksheet)worksheet5).get_Range((object)cell, Type.Missing).Value2 = num5.ToString();
						((_Worksheet)worksheet5).get_Range((object)"C2", (object)cell3).Value2 = "Read";
						worksheet5.Cells[num4, 2] = control6[2, 0].Value.ToString();
						worksheet5.Columns.AutoFit();
						((_Worksheet)worksheet5).get_Range((object)"C2", (object)cell3).Locked = false;
						num4++;
						num5++;
					}
				}
				Range usedRange3 = worksheet5.UsedRange;
				Borders borders3 = usedRange3.Borders;
				borders3.LineStyle = XlLineStyle.xlContinuous;
				borders3.Weight = 2.0;
				worksheet5.Protect(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.progressBar1.Visible = false;
				this.progressBar2.Visible = false;
				try
				{
					workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					workbook.Close(Type.Missing, Type.Missing, Type.Missing);
					Process.Start(fileName);
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message.ToString(), "Exception");
				}
				stopwatch.Stop();
			}
		}

		private void importExcelDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efa: Expected I4, but got Unknown
			//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe0: Expected O, but got Unknown
			//IL_1020: Unknown result type (might be due to invalid IL or missing references)
			//IL_1042: Unknown result type (might be due to invalid IL or missing references)
			//IL_1054: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1124: Unknown result type (might be due to invalid IL or missing references)
			//IL_124e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1253: Unknown result type (might be due to invalid IL or missing references)
			//IL_1256: Unknown result type (might be due to invalid IL or missing references)
			//IL_1257: Unknown result type (might be due to invalid IL or missing references)
			//IL_1259: Unknown result type (might be due to invalid IL or missing references)
			//IL_125e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1262: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_131d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1322: Unknown result type (might be due to invalid IL or missing references)
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_1328: Unknown result type (might be due to invalid IL or missing references)
			//IL_132d: Unknown result type (might be due to invalid IL or missing references)
			//IL_132f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1334: Unknown result type (might be due to invalid IL or missing references)
			//IL_1336: Unknown result type (might be due to invalid IL or missing references)
			//IL_1340: Unknown result type (might be due to invalid IL or missing references)
			//IL_134f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1356: Unknown result type (might be due to invalid IL or missing references)
			//IL_1407: Unknown result type (might be due to invalid IL or missing references)
			//IL_140c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1410: Unknown result type (might be due to invalid IL or missing references)
			//IL_1411: Unknown result type (might be due to invalid IL or missing references)
			//IL_1413: Unknown result type (might be due to invalid IL or missing references)
			//IL_1418: Unknown result type (might be due to invalid IL or missing references)
			//IL_141c: Unknown result type (might be due to invalid IL or missing references)
			//IL_147e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1483: Unknown result type (might be due to invalid IL or missing references)
			//IL_1489: Unknown result type (might be due to invalid IL or missing references)
			//IL_148b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1490: Unknown result type (might be due to invalid IL or missing references)
			//IL_14da: Unknown result type (might be due to invalid IL or missing references)
			//IL_14df: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_150c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1513: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
			UIApplication hGUiApp = this.HGUiApp;
			Document hGDoc = this.HGDoc;
			string versionName = hGUiApp.get_Application().get_VersionName();
			string versionNumber = hGUiApp.get_Application().get_VersionNumber();
			string pathName = hGDoc.get_PathName();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel WorkBook|*.xlsx";
			openFileDialog.Title = "Import Excel";
			openFileDialog.CheckPathExists = true;
			openFileDialog.ShowDialog();
			string fileName = openFileDialog.FileName;
			if (openFileDialog.FileName != "")
			{
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				application.Visible = false;
				Workbook workbook = application.Workbooks.Open(fileName, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
				Sheets worksheets = workbook.Worksheets;
				string index = "Export Info";
				try
				{
					if (_003C_003Eo__86._003C_003Ep__0 == null)
					{
						_003C_003Eo__86._003C_003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
					}
					Worksheet worksheet = _003C_003Eo__86._003C_003Ep__0.Target(_003C_003Eo__86._003C_003Ep__0, worksheets.get_Item((object)index));
					if (_003C_003Eo__86._003C_003Ep__9 == null)
					{
						_003C_003Eo__86._003C_003Ep__9 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = _003C_003Eo__86._003C_003Ep__9.Target;
					CallSite<Func<CallSite, object, bool>> _003C_003Ep__ = _003C_003Eo__86._003C_003Ep__9;
					if (_003C_003Eo__86._003C_003Ep__3 == null)
					{
						_003C_003Eo__86._003C_003Ep__3 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = _003C_003Eo__86._003C_003Ep__3.Target;
					CallSite<Func<CallSite, object, string, object>> _003C_003Ep__2 = _003C_003Eo__86._003C_003Ep__3;
					if (_003C_003Eo__86._003C_003Ep__2 == null)
					{
						_003C_003Eo__86._003C_003Ep__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target3 = _003C_003Eo__86._003C_003Ep__2.Target;
					CallSite<Func<CallSite, object, object>> _003C_003Ep__3 = _003C_003Eo__86._003C_003Ep__2;
					if (_003C_003Eo__86._003C_003Ep__1 == null)
					{
						_003C_003Eo__86._003C_003Ep__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Value2", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target2(_003C_003Ep__2, target3(_003C_003Ep__3, _003C_003Eo__86._003C_003Ep__1.Target(_003C_003Eo__86._003C_003Ep__1, worksheet.Cells[2, 1])), versionName);
					if (_003C_003Eo__86._003C_003Ep__8 == null)
					{
						_003C_003Eo__86._003C_003Ep__8 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg2;
					if (!_003C_003Eo__86._003C_003Ep__8.Target(_003C_003Eo__86._003C_003Ep__8, obj))
					{
						if (_003C_003Eo__86._003C_003Ep__7 == null)
						{
							_003C_003Eo__86._003C_003Ep__7 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target4 = _003C_003Eo__86._003C_003Ep__7.Target;
						CallSite<Func<CallSite, object, object, object>> _003C_003Ep__4 = _003C_003Eo__86._003C_003Ep__7;
						object arg = obj;
						if (_003C_003Eo__86._003C_003Ep__6 == null)
						{
							_003C_003Eo__86._003C_003Ep__6 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, object, string, object> target5 = _003C_003Eo__86._003C_003Ep__6.Target;
						CallSite<Func<CallSite, object, string, object>> _003C_003Ep__5 = _003C_003Eo__86._003C_003Ep__6;
						if (_003C_003Eo__86._003C_003Ep__5 == null)
						{
							_003C_003Eo__86._003C_003Ep__5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target6 = _003C_003Eo__86._003C_003Ep__5.Target;
						CallSite<Func<CallSite, object, object>> _003C_003Ep__6 = _003C_003Eo__86._003C_003Ep__5;
						if (_003C_003Eo__86._003C_003Ep__4 == null)
						{
							_003C_003Eo__86._003C_003Ep__4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Value2", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						arg2 = target4(_003C_003Ep__4, arg, target5(_003C_003Ep__5, target6(_003C_003Ep__6, _003C_003Eo__86._003C_003Ep__4.Target(_003C_003Eo__86._003C_003Ep__4, worksheet.Cells[2, 2])), versionNumber));
					}
					else
					{
						arg2 = obj;
					}
					if (target(_003C_003Ep__, arg2))
					{
						string index2 = "WorkSheet Index";
						if (_003C_003Eo__86._003C_003Ep__10 == null)
						{
							_003C_003Eo__86._003C_003Ep__10 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
						}
						Worksheet worksheet2 = _003C_003Eo__86._003C_003Ep__10.Target(_003C_003Eo__86._003C_003Ep__10, worksheets.get_Item((object)index2));
						Range usedRange = worksheet2.UsedRange;
						int num = 2;
						List<string> list = new List<string>();
						List<string> list2 = new List<string>();
						List<string> list3 = new List<string>();
						List<Element> list4 = new List<Element>();
						List<ElementId> list5 = new List<ElementId>();
						this.progressBar1.Visible = true;
						this.progressBar2.Visible = true;
						this.progressBar2.Maximum = usedRange.Rows.Count;
						for (num = 2; num <= usedRange.Rows.Count; num++)
						{
							this.progressBar2.Value = num;
							if (_003C_003Eo__86._003C_003Ep__14 == null)
							{
								_003C_003Eo__86._003C_003Ep__14 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target7 = _003C_003Eo__86._003C_003Ep__14.Target;
							CallSite<Func<CallSite, object, bool>> _003C_003Ep__7 = _003C_003Eo__86._003C_003Ep__14;
							if (_003C_003Eo__86._003C_003Ep__13 == null)
							{
								_003C_003Eo__86._003C_003Ep__13 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, string, object> target8 = _003C_003Eo__86._003C_003Ep__13.Target;
							CallSite<Func<CallSite, object, string, object>> _003C_003Ep__8 = _003C_003Eo__86._003C_003Ep__13;
							if (_003C_003Eo__86._003C_003Ep__12 == null)
							{
								_003C_003Eo__86._003C_003Ep__12 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target9 = _003C_003Eo__86._003C_003Ep__12.Target;
							CallSite<Func<CallSite, object, object>> _003C_003Ep__9 = _003C_003Eo__86._003C_003Ep__12;
							if (_003C_003Eo__86._003C_003Ep__11 == null)
							{
								_003C_003Eo__86._003C_003Ep__11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Value2", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (target7(_003C_003Ep__7, target8(_003C_003Ep__8, target9(_003C_003Ep__9, _003C_003Eo__86._003C_003Ep__11.Target(_003C_003Eo__86._003C_003Ep__11, worksheet2.Cells[num, 3])), "Read")))
							{
								int num2 = 1;
								int num3 = 0;
								int num4 = num - 1;
								if (_003C_003Eo__86._003C_003Ep__15 == null)
								{
									_003C_003Eo__86._003C_003Ep__15 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(HotGear_Parameter_Explorer)));
								}
								Worksheet worksheet3 = _003C_003Eo__86._003C_003Ep__15.Target(_003C_003Eo__86._003C_003Ep__15, worksheets.get_Item((object)num4.ToString()));
								Range usedRange2 = worksheet3.UsedRange;
								for (num3 = 2; num3 <= usedRange2.Rows.Count; num3++)
								{
									this.progressBar1.Maximum = usedRange2.Rows.Count;
									this.progressBar1.Value = num3;
									try
									{
										for (num2 = 3; num2 <= usedRange2.Columns.Count; num2++)
										{
											if (_003C_003Eo__86._003C_003Ep__24 == null)
											{
												_003C_003Eo__86._003C_003Ep__24 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											Func<CallSite, object, bool> target10 = _003C_003Eo__86._003C_003Ep__24.Target;
											CallSite<Func<CallSite, object, bool>> _003C_003Ep__10 = _003C_003Eo__86._003C_003Ep__24;
											if (_003C_003Eo__86._003C_003Ep__18 == null)
											{
												_003C_003Eo__86._003C_003Ep__18 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
												}));
											}
											Func<CallSite, object, int, object> target11 = _003C_003Eo__86._003C_003Ep__18.Target;
											CallSite<Func<CallSite, object, int, object>> _003C_003Ep__11 = _003C_003Eo__86._003C_003Ep__18;
											if (_003C_003Eo__86._003C_003Ep__17 == null)
											{
												_003C_003Eo__86._003C_003Ep__17 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											Func<CallSite, object, object> target12 = _003C_003Eo__86._003C_003Ep__17.Target;
											CallSite<Func<CallSite, object, object>> _003C_003Ep__12 = _003C_003Eo__86._003C_003Ep__17;
											if (_003C_003Eo__86._003C_003Ep__16 == null)
											{
												_003C_003Eo__86._003C_003Ep__16 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											obj = target11(_003C_003Ep__11, target12(_003C_003Ep__12, _003C_003Eo__86._003C_003Ep__16.Target(_003C_003Eo__86._003C_003Ep__16, worksheet3.Cells[num3, num2])), ColorTranslator.ToOle(Color.WhiteSmoke));
											if (_003C_003Eo__86._003C_003Ep__23 == null)
											{
												_003C_003Eo__86._003C_003Ep__23 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
												{
													CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
												}));
											}
											object arg4;
											if (!_003C_003Eo__86._003C_003Ep__23.Target(_003C_003Eo__86._003C_003Ep__23, obj))
											{
												if (_003C_003Eo__86._003C_003Ep__22 == null)
												{
													_003C_003Eo__86._003C_003Ep__22 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
													}));
												}
												Func<CallSite, object, object, object> target13 = _003C_003Eo__86._003C_003Ep__22.Target;
												CallSite<Func<CallSite, object, object, object>> _003C_003Ep__13 = _003C_003Eo__86._003C_003Ep__22;
												object arg3 = obj;
												if (_003C_003Eo__86._003C_003Ep__21 == null)
												{
													_003C_003Eo__86._003C_003Ep__21 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
													}));
												}
												Func<CallSite, object, int, object> target14 = _003C_003Eo__86._003C_003Ep__21.Target;
												CallSite<Func<CallSite, object, int, object>> _003C_003Ep__14 = _003C_003Eo__86._003C_003Ep__21;
												if (_003C_003Eo__86._003C_003Ep__20 == null)
												{
													_003C_003Eo__86._003C_003Ep__20 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Color", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
													}));
												}
												Func<CallSite, object, object> target15 = _003C_003Eo__86._003C_003Ep__20.Target;
												CallSite<Func<CallSite, object, object>> _003C_003Ep__15 = _003C_003Eo__86._003C_003Ep__20;
												if (_003C_003Eo__86._003C_003Ep__19 == null)
												{
													_003C_003Eo__86._003C_003Ep__19 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Interior", typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
													}));
												}
												arg4 = target13(_003C_003Ep__13, arg3, target14(_003C_003Ep__14, target15(_003C_003Ep__15, _003C_003Eo__86._003C_003Ep__19.Target(_003C_003Eo__86._003C_003Ep__19, worksheet3.Cells[num3, num2])), ColorTranslator.ToOle(Color.DarkGray)));
											}
											else
											{
												arg4 = obj;
											}
											if (target10(_003C_003Ep__10, arg4))
											{
												if (_003C_003Eo__86._003C_003Ep__26 == null)
												{
													_003C_003Eo__86._003C_003Ep__26 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HotGear_Parameter_Explorer)));
												}
												Func<CallSite, object, string> target16 = _003C_003Eo__86._003C_003Ep__26.Target;
												CallSite<Func<CallSite, object, string>> _003C_003Ep__16 = _003C_003Eo__86._003C_003Ep__26;
												if (_003C_003Eo__86._003C_003Ep__25 == null)
												{
													_003C_003Eo__86._003C_003Ep__25 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
													}));
												}
												string text = target16(_003C_003Ep__16, _003C_003Eo__86._003C_003Ep__25.Target(_003C_003Eo__86._003C_003Ep__25, (worksheet3.Cells[1, num2] as Range).Value2));
												if (_003C_003Eo__86._003C_003Ep__28 == null)
												{
													_003C_003Eo__86._003C_003Ep__28 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
													}));
												}
												Func<CallSite, object, bool> target17 = _003C_003Eo__86._003C_003Ep__28.Target;
												CallSite<Func<CallSite, object, bool>> _003C_003Ep__17 = _003C_003Eo__86._003C_003Ep__28;
												if (_003C_003Eo__86._003C_003Ep__27 == null)
												{
													_003C_003Eo__86._003C_003Ep__27 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
													{
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
														CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
													}));
												}
												if (!target17(_003C_003Ep__17, _003C_003Eo__86._003C_003Ep__27.Target(_003C_003Eo__86._003C_003Ep__27, (worksheet3.Cells[num3, 1] as Range).Text, string.Empty)))
												{
													if (_003C_003Eo__86._003C_003Ep__31 == null)
													{
														_003C_003Eo__86._003C_003Ep__31 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(HotGear_Parameter_Explorer)));
													}
													Func<CallSite, object, int> target18 = _003C_003Eo__86._003C_003Ep__31.Target;
													CallSite<Func<CallSite, object, int>> _003C_003Ep__18 = _003C_003Eo__86._003C_003Ep__31;
													if (_003C_003Eo__86._003C_003Ep__30 == null)
													{
														_003C_003Eo__86._003C_003Ep__30 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													Func<CallSite, Type, object, object> target19 = _003C_003Eo__86._003C_003Ep__30.Target;
													CallSite<Func<CallSite, Type, object, object>> _003C_003Ep__19 = _003C_003Eo__86._003C_003Ep__30;
													Type typeFromHandle = typeof(int);
													if (_003C_003Eo__86._003C_003Ep__29 == null)
													{
														_003C_003Eo__86._003C_003Ep__29 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
														{
															CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
														}));
													}
													int num5 = target18(_003C_003Ep__18, target19(_003C_003Ep__19, typeFromHandle, _003C_003Eo__86._003C_003Ep__29.Target(_003C_003Eo__86._003C_003Ep__29, (worksheet3.Cells[num3, 1] as Range).Value2)));
													ElementId val = new ElementId(num5);
													list5.Add(val);
													Element element = hGDoc.GetElement(val);
													Parameter val2 = element.LookupParameter(text);
													try
													{
														if (val2.get_Definition().get_Name() == text)
														{
															if (_003C_003Eo__86._003C_003Ep__33 == null)
															{
																_003C_003Eo__86._003C_003Ep__33 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[1]
																{
																	CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
																}));
															}
															Func<CallSite, object, bool> target20 = _003C_003Eo__86._003C_003Ep__33.Target;
															CallSite<Func<CallSite, object, bool>> _003C_003Ep__20 = _003C_003Eo__86._003C_003Ep__33;
															if (_003C_003Eo__86._003C_003Ep__32 == null)
															{
																_003C_003Eo__86._003C_003Ep__32 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HotGear_Parameter_Explorer), new CSharpArgumentInfo[2]
																{
																	CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
																	CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
																}));
															}
															if (target20(_003C_003Ep__20, _003C_003Eo__86._003C_003Ep__32.Target(_003C_003Eo__86._003C_003Ep__32, (worksheet3.Cells[num3, num2] as Range).Value2, null)))
															{
																string item = "";
																try
																{
																	if (!(val2.AsValueString() == string.Empty) && !(val2.AsValueString() == "") && val2.AsValueString() != null)
																	{
																		list.Add(text);
																		list2.Add(item);
																		list4.Add(element);
																	}
																}
																catch
																{
																	list3.Add(num5.ToString());
																}
															}
															else
															{
																Range range = worksheet3.Cells[num3, num2] as Range;
																if (_003C_003Eo__86._003C_003Ep__34 == null)
																{
																	_003C_003Eo__86._003C_003Ep__34 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HotGear_Parameter_Explorer)));
																}
																string text2 = _003C_003Eo__86._003C_003Ep__34.Target(_003C_003Eo__86._003C_003Ep__34, range.Text);
																string text3 = text2;
																try
																{
																	StorageType storageType = val2.get_StorageType();
																	switch ((int)storageType)
																	{
																	case 2:
																		try
																		{
																			if (!(text3 == val2.AsValueString().ToString()))
																			{
																				list.Add(text);
																				list2.Add(text3);
																				list4.Add(element);
																			}
																		}
																		catch
																		{
																			try
																			{
																				if (!(text3 == double.Parse(val2.AsValueString()).ToString()))
																				{
																					list.Add(text);
																					list2.Add(text3);
																					list4.Add(element);
																				}
																			}
																			catch
																			{
																			}
																		}
																		break;
																	case 4:
																		try
																		{
																			if (!(text3 == val2.AsValueString() + "[" + (object)val2.AsElementId() + "]"))
																			{
																				int.Parse(text3);
																				list.Add(text);
																				list2.Add(text3);
																				list4.Add(element);
																			}
																		}
																		catch
																		{
																		}
																		break;
																	case 1:
																		try
																		{
																			if (!(text3 == val2.AsValueString() + "[" + val2.AsInteger() + "]"))
																			{
																				int.Parse(text3);
																				list.Add(text);
																				list2.Add(text3);
																				list4.Add(element);
																			}
																		}
																		catch
																		{
																		}
																		break;
																	case 3:
																		if (!(text3 == val2.AsString()))
																		{
																			list.Add(text);
																			list2.Add(text3);
																			list4.Add(element);
																		}
																		break;
																	case 0:
																		if (!(text3 == val2.AsString()))
																		{
																			list.Add(text);
																			list2.Add(text3);
																			list4.Add(element);
																		}
																		break;
																	}
																}
																catch (Exception ex)
																{
																	MessageBox.Show(ex.StackTrace + "\n" + ex.Message);
																	list3.Add(num5.ToString());
																}
															}
														}
													}
													catch (NullReferenceException)
													{
													}
													continue;
												}
												break;
											}
										}
									}
									catch (Exception ex3)
									{
										MessageBox.Show(ex3.ToString());
									}
								}
							}
						}
						if (list3.Count != 0)
						{
							string str = string.Join(",", list3.Distinct().ToList().ToArray());
							MessageBox.Show("Missing ElementId : \n" + str);
						}
						List<Element> list6 = new List<Element>();
						foreach (ElementId item2 in list5)
						{
							Element element2 = hGDoc.GetElement(item2);
							list6.Add(element2);
						}
						if (GlobalVar.TypeORInstance == "Family Instance")
						{
							DataSet dataSet = new DataSet();
							DataSet dataSet2 = new DataSet();
							List<ElementId> list7 = new List<ElementId>();
							foreach (Element item3 in list6)
							{
								try
								{
									list7.Add(item3.get_Category().get_Id());
								}
								catch
								{
								}
							}
							List<ElementId> list8 = ((IEnumerable<ElementId>)list7).Distinct<ElementId>().ToList<ElementId>();
							foreach (ElementId item4 in list8)
							{
								FilteredElementCollector val3 = new FilteredElementCollector(hGDoc, (ICollection<ElementId>)list5).OfCategoryId(item4);
								IList<Element> eleList = val3.ToElements();
								DataTable table = Method.ElementParameter2Table(this.cmddata, eleList);
								DataTable table2 = Method.ParameterIsRead(this.cmddata, eleList, hGDoc);
								dataSet.Tables.Add(table);
								dataSet2.Tables.Add(table2);
							}
							GlobalVar.MyDataSet = dataSet;
							GlobalVar.Is_Read_Only = dataSet2;
							GlobalVar.CM_GetUpdata -= this.GetUpdate;
							this.tabControl1.Controls.Clear();
							this.treeView1.Nodes.Clear();
							this.Form_Load(sender, e);
						}
						else
						{
							ICollection<ElementId> collection = new List<ElementId>();
							List<Element> list9 = new List<Element>();
							foreach (ElementId item5 in list5)
							{
								try
								{
									Element element3 = hGDoc.GetElement(item5);
									list9.Add(element3);
								}
								catch
								{
								}
							}
							if (list9.Count > 0)
							{
								DataSet dataSet3 = new DataSet();
								DataSet dataSet4 = new DataSet();
								List<ElementId> list10 = new List<ElementId>();
								foreach (Element item6 in list9)
								{
									try
									{
										list10.Add(item6.get_Category().get_Id());
									}
									catch
									{
									}
								}
								List<ElementId> list11 = ((IEnumerable<ElementId>)list10).Distinct<ElementId>().ToList<ElementId>();
								foreach (ElementId item7 in list11)
								{
									FilteredElementCollector val4 = new FilteredElementCollector(hGDoc, (ICollection<ElementId>)list5).OfCategoryId(item7);
									IList<Element> eleList2 = val4.ToElements();
									DataTable table3 = Method.ElementParameter2Table(this.cmddata, eleList2);
									DataTable table4 = Method.ParameterIsRead(this.cmddata, eleList2, hGDoc);
									dataSet3.Tables.Add(table3);
									dataSet4.Tables.Add(table4);
								}
								GlobalVar.MyDataSet = dataSet3;
								GlobalVar.Is_Read_Only = dataSet4;
								GlobalVar.CM_GetUpdata -= this.GetUpdate;
								this.tabControl1.Controls.Clear();
								this.treeView1.Nodes.Clear();
								this.Form_Load(sender, e);
							}
						}
						GlobalVar.G_ParameterName = list;
						GlobalVar.G_ParameterValue = list2;
						GlobalVar.G_ElementList = list4;
						workbook.Close(Type.Missing, Type.Missing, Type.Missing);
						this.m_ExEvent.Raise();
					}
					else
					{
						MessageBox.Show("Notice", "Excel not match current revit");
					}
				}
				catch
				{
					MessageBox.Show("Please Note: Load the right Excel file without changing the name of Worksheet.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			this.progressBar1.Visible = false;
			this.progressBar2.Visible = false;
		}

		private void UpDateStatusStrip()
		{
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				double num = 0.0;
				int count = this.tabControl1.TabPages.Count;
				int count2 = this.tabControl2.TabPages.Count;
				int num2 = count + count2;
				this.toolStripStatusLabel3.Text = "Tab Pages : " + count + "/" + num2;
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					int num3 = control.RowCount;
					string str = num3.ToString();
					num3 = control.ColumnCount;
					string str2 = num3.ToString();
					this.toolStripStatusLabel2.Text = "Rows : " + str + " Columns : " + str2;
					num3 = control.SelectedCells.Count;
					string str3 = num3.ToString();
					int rowCount = control.RowCount;
					int columnCount = control.ColumnCount;
					int columnIndex = control.CurrentCell.ColumnIndex;
					num3 = rowCount * columnCount;
					string str4 = num3.ToString();
					this.toolStripStatusLabel1.Text = "Selected Cells : " + str3 + "/" + str4;
					this.toolStripStatusLabel4.Text = "Document : " + this.HGDoc.get_Title();
					try
					{
						for (int i = 0; i < control.Rows.Count; i++)
						{
							string text = control.Rows[i].Cells[columnIndex].Value.ToString();
							if (text == string.Empty)
							{
								num += 0.0;
							}
							else
							{
								double num4 = double.Parse(text, CultureInfo.InvariantCulture);
								num += num4;
							}
						}
						this.toolStripStatusLabel5.Text = "Column Sum : " + num.ToString();
					}
					catch
					{
						for (int j = 0; j < control.Rows.Count; j++)
						{
							string text2 = control.Rows[j].Cells[columnIndex].Value.ToString();
							if (text2 == string.Empty)
							{
								num += 0.0;
							}
							else
							{
								string s = text2.Remove(text2.Length - 2);
								string s2 = text2.Remove(text2.Length - 4);
								try
								{
									try
									{
										double num5 = double.Parse(s, CultureInfo.InvariantCulture);
										num += num5;
										this.toolStripStatusLabel5.Text = "Column Sum : " + num.ToString();
									}
									catch
									{
										double num6 = double.Parse(s2, CultureInfo.InvariantCulture);
										num += num6;
										this.toolStripStatusLabel5.Text = "Column Sum : " + num.ToString();
									}
								}
								catch
								{
									this.toolStripStatusLabel5.Text = "Column Sum : None";
								}
							}
						}
					}
				}
				foreach (DataGridView control2 in this.tabControl1.SelectedTab.Controls)
				{
					if (control2.GetCellCount(DataGridViewElementStates.Selected) > 1)
					{
						this.SelectOnRevit.BackColor = Color.LightSkyBlue;
					}
					else
					{
						this.SelectOnRevit.BackColor = Control.DefaultBackColor;
					}
					if (control2.SortOrder == SortOrder.None)
					{
						this.ColorSplat.Enabled = false;
						this.ColorSplat.BackColor = Control.DefaultBackColor;
					}
					else
					{
						this.ColorSplat.Enabled = true;
						this.ColorSplat.BackColor = Color.Yellow;
					}
					foreach (DataGridViewColumn column in control2.Columns)
					{
						if (column.HeaderText == "Mark")
						{
							this.Mark.Enabled = true;
							this.Mark.BackColor = Color.GreenYellow;
							if (control2.SortedColumn.Name == "Mark")
							{
								this.Mark.Enabled = false;
								this.Mark.BackColor = Control.DefaultBackColor;
							}
							break;
						}
						this.Mark.Enabled = false;
						this.Mark.BackColor = Control.DefaultBackColor;
					}
				}
			}
			catch
			{
			}
		}

		private void TabFilterByName(TabControl tabControl, List<string> CatName)
		{
			List<TabPage> list = tabControl.TabPages.Cast<TabPage>().ToList();
			foreach (TabPage item in list)
			{
				this.tabControl2.TabPages.Add(item);
				tabControl.TabPages.Remove(item);
			}
			foreach (string item2 in CatName)
			{
				foreach (TabPage tabPage3 in this.tabControl2.TabPages)
				{
					if (tabPage3.Text == item2)
					{
						tabControl.TabPages.Add(tabPage3);
					}
				}
			}
		}

		private void RowFilterByTreeNode(TabControl tabControl, List<string> CatName, List<string> ParamName, List<string> ParamValue)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = "";
			int num = 0;
			if (this.radioButton2.Checked)
			{
				value = "or";
				num = 2;
			}
			else if (!this.radioButton2.Checked)
			{
				value = "and";
				num = 3;
			}
			try
			{
				foreach (TabPage tabPage3 in tabControl.TabPages)
				{
					foreach (DataGridView control in tabPage3.Controls)
					{
						for (int i = 0; i < CatName.Count; i++)
						{
							stringBuilder.Append(string.Format("[{0}] = '{1}'", ParamName[i], ParamValue[i]));
							stringBuilder.Append(value);
							string rowFilter = stringBuilder.ToString().Remove(stringBuilder.Length - num);
							if (control.Name == CatName[i])
							{
								(control.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
							}
						}
					}
					stringBuilder.Clear();
				}
			}
			catch
			{
			}
		}

		private void ResetRowFilter(TabControl tabControl)
		{
			foreach (TabPage tabPage3 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage3.Controls)
				{
					(control.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
				}
			}
		}

		private static void TabSort(TabControl tabControl)
		{
			List<TabPage> list = tabControl.TabPages.Cast<TabPage>().ToList();
			list.Sort(new TabPageComparer());
			tabControl.TabPages.Clear();
			tabControl.TabPages.AddRange(list.ToArray());
		}

		private void ComboBoxData(TabControl tabControl)
		{
			IList<string> list = new List<string>();
			this.comboBox1.Items.Clear();
			List<TabPage> list2 = tabControl.TabPages.Cast<TabPage>().ToList();
			AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
			foreach (TabPage item in list2)
			{
				autoCompleteStringCollection.Add(item.Text);
				this.comboBox1.Items.Add(item.Text);
			}
			this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.comboBox1.AutoCompleteCustomSource = autoCompleteStringCollection;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = this.comboBox1.SelectedIndex;
			this.comboBox1.ResetText();
		}

		private void _CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			UIApplication hGUiApp = this.HGUiApp;
			Document hGDoc = this.HGDoc;
			UIDocument hGUiDoc = this.HGUiDoc;
			ICollection<ElementId> collection = new List<ElementId>();
			int rowIndex = e.RowIndex;
			int num = 0;
			if (GlobalVar.TypeORInstance == "Family Instance")
			{
				try
				{
					foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
					{
						num = int.Parse(control[0, rowIndex].Value.ToString());
					}
					ElementId val = new ElementId(num);
					Element element = hGDoc.GetElement(val);
					collection.Add(val);
					hGUiDoc.ShowElements(element);
					hGUiDoc.get_Selection().SetElementIds(collection);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					foreach (DataGridView control2 in this.tabControl1.SelectedTab.Controls)
					{
						num = int.Parse(control2[0, rowIndex].Value.ToString());
					}
					ElementId val2 = new ElementId(num);
					Element element2 = hGDoc.GetElement(val2);
					FilteredElementCollector val3 = new FilteredElementCollector(hGDoc).OfCategoryId(element2.get_Category().get_Id());
					IList<Element> list = val3.ToElements();
					List<Element> list2 = new List<Element>();
					foreach (Element item in list)
					{
						if (item.GetTypeId() == val2)
						{
							collection.Add(item.get_Id());
							list2.Add(item);
						}
					}
					hGUiDoc.ShowElements(collection);
					hGUiDoc.get_Selection().SetElementIds(collection);
				}
				catch
				{
					foreach (DataGridView control3 in this.tabControl1.SelectedTab.Controls)
					{
						num = int.Parse(control3[0, rowIndex].Value.ToString());
					}
					ElementId val4 = new ElementId(num);
					Element element3 = hGDoc.GetElement(val4);
					collection.Add(val4);
					hGUiDoc.get_Selection().SetElementIds(collection);
				}
			}
		}

		private void SelectOnRevit_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			Document hGDoc = this.HGDoc;
			UIDocument hGUiDoc = this.HGUiDoc;
			ICollection<ElementId> collection = new List<ElementId>();
			List<int> list = new List<int>();
			foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
			{
				if (control.GetCellCount(DataGridViewElementStates.Selected) > 0)
				{
					if (GlobalVar.TypeORInstance == "Family Instance")
					{
						try
						{
							for (int i = 0; i < control.GetCellCount(DataGridViewElementStates.Selected); i++)
							{
								list.Add(int.Parse(control[0, control.SelectedCells[i].RowIndex].Value.ToString()));
							}
							foreach (int item3 in list)
							{
								ElementId item = new ElementId(item3);
								collection.Add(item);
							}
							hGUiDoc.get_Selection().SetElementIds(collection);
							hGUiDoc.ShowElements(collection);
						}
						catch
						{
						}
					}
					else
					{
						try
						{
							for (int j = 0; j < control.GetCellCount(DataGridViewElementStates.Selected); j++)
							{
								list.Add(int.Parse(control[0, control.SelectedCells[j].RowIndex].Value.ToString()));
							}
							foreach (int item4 in list)
							{
								ElementId val = new ElementId(item4);
								Element element = hGDoc.GetElement(val);
								FilteredElementCollector val2 = new FilteredElementCollector(hGDoc).OfCategoryId(element.get_Category().get_Id());
								IList<Element> list2 = val2.ToElements();
								foreach (Element item5 in list2)
								{
									if (item5.GetTypeId() == val)
									{
										collection.Add(item5.get_Id());
									}
								}
							}
							hGUiDoc.ShowElements(collection);
							hGUiDoc.get_Selection().SetElementIds(collection);
						}
						catch
						{
							for (int k = 0; k < control.GetCellCount(DataGridViewElementStates.Selected); k++)
							{
								list.Add(int.Parse(control[0, control.SelectedCells[k].RowIndex].Value.ToString()));
							}
							foreach (int item6 in list)
							{
								ElementId item2 = new ElementId(item6);
								collection.Add(item2);
							}
							hGUiDoc.get_Selection().SetElementIds(collection);
						}
					}
				}
			}
		}

		private void AllSelectOnRevit_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			Document hGDoc = this.HGDoc;
			UIDocument hGUiDoc = this.HGUiDoc;
			ICollection<ElementId> collection = new List<ElementId>();
			List<int> list = new List<int>();
			foreach (TabPage tabPage3 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage3.Controls)
				{
					control.SelectAll();
					if (control.GetCellCount(DataGridViewElementStates.Selected) > 0)
					{
						if (GlobalVar.TypeORInstance == "Family Instance")
						{
							try
							{
								for (int i = 0; i < control.GetCellCount(DataGridViewElementStates.Selected); i++)
								{
									list.Add(int.Parse(control[0, control.SelectedCells[i].RowIndex].Value.ToString()));
								}
								foreach (int item2 in list)
								{
									ElementId item = new ElementId(item2);
									collection.Add(item);
								}
								hGUiDoc.get_Selection().SetElementIds(collection);
							}
							catch
							{
							}
						}
						else
						{
							try
							{
								for (int j = 0; j < control.GetCellCount(DataGridViewElementStates.Selected); j++)
								{
									list.Add(int.Parse(control[0, control.SelectedCells[j].RowIndex].Value.ToString()));
								}
								foreach (int item3 in list)
								{
									ElementId val = new ElementId(item3);
									Element element = hGDoc.GetElement(val);
									FilteredElementCollector val2 = new FilteredElementCollector(hGDoc).OfCategoryId(element.get_Category().get_Id());
									IList<Element> list2 = val2.ToElements();
									foreach (Element item4 in list2)
									{
										if (item4.GetTypeId() == val)
										{
											collection.Add(item4.get_Id());
										}
									}
								}
								hGUiDoc.get_Selection().SetElementIds(collection);
							}
							catch
							{
							}
						}
					}
				}
			}
		}

		private void ApplyFilter_Click(object sender, EventArgs e)
		{
			this.ResetRowFilter(this.tabControl1);
			List<string> list = new List<string>();
			foreach (TreeNode node in this.treeView1.Nodes)
			{
				foreach (TreeNode node2 in node.Nodes)
				{
					if (node2.Checked)
					{
						list.Add(node2.Text);
					}
				}
			}
			if (list.Count == 0)
			{
				MessageBox.Show("Please Select Filter.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.ResetFilter.Enabled = true;
				this.tabControl1.Visible = false;
				this.TabFilterByName(this.tabControl1, list);
				this.ComboBoxData(this.tabControl1);
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>();
				List<string> list4 = new List<string>();
				List<string> list5 = new List<string>();
				List<string> list6 = new List<string>();
				List<TabPage> list7 = this.tabControl1.TabPages.Cast<TabPage>().ToList();
				foreach (TreeNode node3 in this.treeView1.Nodes)
				{
					foreach (TreeNode node4 in node3.Nodes)
					{
						foreach (TreeNode node5 in node4.Nodes)
						{
							if (node5.Checked)
							{
								list3.Add(node5.Parent.Text);
								list5.Add(node5.Text);
							}
							foreach (TreeNode node6 in node5.Nodes)
							{
								if (node6.Checked)
								{
									list2.Add(node6.Parent.Parent.Text);
									list4.Add(node6.Parent.Text);
									list6.Add(node6.Text);
								}
							}
						}
						this.RowFilterByTreeNode(this.tabControl1, list2, list4, list6);
						if (list3.Count != 0 && list5.Count != 0)
						{
							foreach (TabPage tabPage3 in this.tabControl1.TabPages)
							{
								foreach (DataGridView control in tabPage3.Controls)
								{
									foreach (DataGridViewColumn column in control.Columns)
									{
										column.Visible = false;
									}
									control.Columns["ElementId"].Visible = true;
									control.Columns["Category"].Visible = true;
									control.Columns["ElementName"].Visible = true;
									for (int i = 0; i < list5.Count; i++)
									{
										if (control.Name == list3[i])
										{
											control.Columns[list5[i]].Visible = true;
										}
									}
								}
							}
						}
						list2.Clear();
						list4.Clear();
						list6.Clear();
					}
				}
				foreach (TabPage tabPage4 in this.tabControl1.TabPages)
				{
					foreach (DataGridView control2 in tabPage4.Controls)
					{
						if ((control2.DataSource as DataTable).DefaultView.RowFilter == string.Empty)
						{
							this.ResetFilter.BackColor = Control.DefaultBackColor;
						}
						else
						{
							this.ResetFilter.BackColor = Color.Red;
						}
					}
				}
				if (this.tabControl2.TabPages.Count > 0)
				{
					this.ResetFilter.BackColor = Color.Red;
				}
				else
				{
					this.ResetFilter.BackColor = Control.DefaultBackColor;
				}
				this.tabControl1.Visible = true;
				this.Accept_Change.BackColor = Control.DefaultBackColor;
				this.Reject_Change.BackColor = Control.DefaultBackColor;
				this.UpDateStatusStrip();
				this.CellFormatting();
			}
		}

		private void CheckChildren(TreeNode rootNode, bool isChecked)
		{
			foreach (TreeNode node in rootNode.Nodes)
			{
				this.CheckChildren(node, isChecked);
				node.Checked = isChecked;
			}
		}

		public void UncheckAllNodes(TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				node.Checked = false;
				this.CheckChildren(node, false);
			}
		}

		private void ResetFilter_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (TabPage tabPage3 in this.tabControl2.TabPages)
				{
					this.tabControl1.TabPages.Add(tabPage3);
				}
				HotGear_Parameter_Explorer.TabSort(this.tabControl1);
			}
			catch
			{
			}
			foreach (TabPage tabPage4 in this.tabControl1.TabPages)
			{
				foreach (DataGridView control in tabPage4.Controls)
				{
					if ((control.DataSource as DataTable).DefaultView.RowFilter == string.Empty)
					{
						this.ResetFilter.BackColor = Control.DefaultBackColor;
					}
					else
					{
						this.ResetFilter.BackColor = Color.Red;
					}
				}
			}
			if (this.tabControl2.TabPages.Count > 0)
			{
				this.ResetFilter.BackColor = Color.Red;
			}
			else
			{
				this.ResetFilter.BackColor = Control.DefaultBackColor;
			}
			this.GetUpdate();
			this.UncheckAllNodes(this.treeView1.Nodes);
			this.Accept_Change.BackColor = Control.DefaultBackColor;
			this.Reject_Change.BackColor = Control.DefaultBackColor;
			this.tabControl1.Visible = true;
			this.CellFormatting();
			this.UpDateStatusStrip();
		}

		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			this.SelectParents(e.Node, e.Node.Checked);
			this.CheckAllChildNodes(e.Node, e.Node.Checked);
			foreach (TreeNode node in this.treeView1.Nodes)
			{
				if (node.Checked)
				{
					this.ApplyFilter.BackColor = Color.LightGreen;
				}
				else
				{
					this.ApplyFilter.BackColor = Control.DefaultBackColor;
				}
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			foreach (TreeNode node in this.treeView1.Nodes)
			{
				foreach (TreeNode node2 in node.Nodes)
				{
					if (node2.IsSelected)
					{
						string text = node2.Text;
						foreach (TabPage tabPage3 in this.tabControl1.TabPages)
						{
							if (tabPage3.Text == text)
							{
								this.tabControl1.SelectedTab = tabPage3;
							}
						}
					}
				}
			}
		}

		private void SelectParents(TreeNode node, bool isChecked)
		{
			TreeNode parent = node.Parent;
			if (parent != null)
			{
				if (isChecked)
				{
					parent.Checked = true;
					this.SelectParents(parent, true);
				}
				else if (!parent.Nodes.Cast<TreeNode>().Any((TreeNode n) => n.Checked))
				{
					this.SelectParents(parent, false);
				}
			}
		}

		private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
		{
			if (!nodeChecked)
			{
				foreach (TreeNode node in treeNode.Nodes)
				{
					node.Checked = nodeChecked;
				}
			}
		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			this.groupBox1.Text = GlobalVar.TypeORInstance;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
			{
				int num = control.Columns.Count;
				foreach (DataGridViewColumn column in control.Columns)
				{
					if (column.HeaderText == "Mark")
					{
						for (int i = 0; i < control.RowCount; i++)
						{
							list.Add(control[0, i].Value.ToString());
						}
					}
					else
					{
						num--;
					}
				}
				if (num == 0)
				{
					MessageBox.Show(control.Name + " Don't Have Mark Parameter.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				foreach (DataGridViewColumn column2 in control.Columns)
				{
					if (column2.HeaderText == "Mark")
					{
						foreach (string item in list)
						{
							for (int j = 0; j < control.RowCount; j++)
							{
								if (control[0, j].Value.ToString() == item)
								{
									int index = column2.Index;
									control[index, j].Value = j + 1;
									control[index, j].Style.ForeColor = Color.Red;
								}
							}
						}
					}
				}
			}
		}

		private void ColorIsolate_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_0548: Unknown result type (might be due to invalid IL or missing references)
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_0555: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Unknown result type (might be due to invalid IL or missing references)
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_064e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_066d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0692: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06da: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0782: Unknown result type (might be due to invalid IL or missing references)
			//IL_078b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0827: Unknown result type (might be due to invalid IL or missing references)
			//IL_0832: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			UIApplication hGUiApp = this.HGUiApp;
			Document hGDoc = this.HGDoc;
			View activeView = hGDoc.get_ActiveView();
			OverrideGraphicSettings val = new OverrideGraphicSettings();
			val.SetSurfaceTransparency(GlobalVar.ColorSplatTransparency);
			val.SetHalftone(GlobalVar.HalfTone);
			FilteredElementCollector val2 = new FilteredElementCollector(hGDoc).WhereElementIsNotElementType();
			IList<Element> list = val2.ToElements();
			foreach (Element item5 in list)
			{
				activeView.SetElementOverrides(item5.get_Id(), val);
			}
			List<OverrideGraphicSettings> list2 = new List<OverrideGraphicSettings>();
			Application application = hGUiApp.get_ActiveUIDocument().get_Application().get_Application();
			List<byte> list3 = new List<byte>();
			List<byte> list4 = new List<byte>();
			List<byte> list5 = new List<byte>();
			List<string> list6 = new List<string>();
			List<Color> list7 = new List<Color>();
			list6.AddRange(GlobalVar.ColorHax.Hax);
			foreach (string item6 in list6)
			{
				Color item = ColorTranslator.FromHtml(item6);
				list7.Add(item);
				list3.Add(item.R);
				list4.Add(item.G);
				list5.Add(item.B);
			}
			List<string> list8 = new List<string>();
			List<string> list9 = new List<string>();
			List<ElementId> list10 = new List<ElementId>();
			int index;
			SortOrder sortOrder;
			if (GlobalVar.TypeORInstance == "Family Instance")
			{
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					try
					{
						index = control.SortedColumn.Index;
						List<string> list11 = list8;
						sortOrder = control.SortOrder;
						list11.Add(sortOrder.ToString());
						list8.Add(index.ToString());
						for (int i = 0; i < control.Rows.Count; i++)
						{
							try
							{
								string item2 = control[index, i].Value.ToString();
								list9.Add(item2);
								int num = int.Parse(control[0, i].Value.ToString());
								ElementId item3 = new ElementId(num);
								list10.Add(item3);
							}
							catch
							{
							}
						}
					}
					catch
					{
						MessageBox.Show("Please sort the parameter you want to color splat first");
						return;
					}
					List<string> list12 = list9.Distinct().ToList();
					int count = list12.Count;
					for (int j = 0; j < count; j++)
					{
						List<ElementId> list13 = new List<ElementId>();
						ElementClassFilter val3 = new ElementClassFilter(typeof(FillPatternElement));
						FilteredElementCollector val4 = new FilteredElementCollector(hGDoc).WherePasses(val3);
						IList<Element> list14 = val4.ToElements();
						foreach (Element item7 in list14)
						{
							if (item7.get_Name() == "Solid fill")
							{
								list13.Add(item7.get_Id());
							}
						}
						OverrideGraphicSettings val5 = new OverrideGraphicSettings();
						Color val6 = new Color(list3[j], list4[j], list5[j]);
						ElementId projectionFillPatternId = ((IEnumerable<ElementId>)list13).First<ElementId>();
						val5.SetProjectionFillColor(val6);
						val5.SetProjectionFillPatternId(projectionFillPatternId);
						val5.SetCutLineColor(val6);
						list2.Add(val5);
					}
					for (int k = 0; k < list9.Count; k++)
					{
						for (int l = 0; l < list12.Count; l++)
						{
							if (list9[k] == list12[l])
							{
								control[control.SortedColumn.Index, k].Style.BackColor = list7[l];
								activeView.SetElementOverrides(list10[k], list2[l]);
							}
						}
					}
				}
				GlobalVar.G_Ele_List = list10;
				GlobalVar.G_Color_Log = list8;
				if (GlobalVar.TempIsolate)
				{
					activeView.IsolateElementsTemporary((ICollection<ElementId>)list10);
				}
				this.m_ExEvent1.Raise();
			}
			else
			{
				List<int> list15 = new List<int>();
				list15.Add(0);
				foreach (DataGridView control2 in this.tabControl1.SelectedTab.Controls)
				{
					index = control2.SortedColumn.Index;
					List<string> list16 = list8;
					sortOrder = control2.SortOrder;
					list16.Add(sortOrder.ToString());
					list8.Add(index.ToString());
					for (int m = 0; m < control2.Rows.Count; m++)
					{
						string item4 = control2[index, m].Value.ToString();
						list9.Add(item4);
						int num2 = int.Parse(control2[0, m].Value.ToString());
						ElementId val7 = new ElementId(num2);
						Element element = hGDoc.GetElement(val7);
						FilteredElementCollector val8 = new FilteredElementCollector(hGDoc).OfCategoryId(element.get_Category().get_Id());
						IList<Element> list17 = val8.ToElements();
						foreach (Element item8 in list17)
						{
							if (item8.GetTypeId() == val7)
							{
								list10.Add(item8.get_Id());
							}
						}
						list15.Add(list10.Count);
					}
					List<string> list18 = list9.Distinct().ToList();
					int count2 = list18.Count;
					for (int n = 0; n < count2; n++)
					{
						List<ElementId> list19 = new List<ElementId>();
						FilteredElementCollector val9 = new FilteredElementCollector(hGDoc).OfClass(typeof(FillPatternElement));
						IList<Element> list20 = val9.ToElements();
						foreach (Element item9 in list20)
						{
							if (item9.get_Name() == "Solid fill")
							{
								list19.Add(item9.get_Id());
							}
						}
						OverrideGraphicSettings val10 = new OverrideGraphicSettings();
						Color val11 = new Color(list3[n], list4[n], list5[n]);
						ElementId projectionFillPatternId2 = ((IEnumerable<ElementId>)list19).First<ElementId>();
						val10.SetProjectionFillColor(val11);
						val10.SetProjectionFillPatternId(projectionFillPatternId2);
						val10.SetCutLineColor(val11);
						list2.Add(val10);
					}
					int num3 = 0;
					for (int num4 = 0; num4 < list9.Count; num4++)
					{
						for (int num5 = 0; num5 < list18.Count; num5++)
						{
							if (list9[num4] == list18[num5])
							{
								control2[control2.SortedColumn.Index, num4].Style.BackColor = list7[num5];
								int num6 = list15[num3];
								int num7 = list15[num3 + 1];
								for (int num8 = num6; num8 < num7; num8++)
								{
									activeView.SetElementOverrides(list10[num8], list2[num5]);
								}
								num3++;
							}
						}
					}
				}
				GlobalVar.G_Ele_List = list10;
				GlobalVar.G_Color_Log = list8;
				if (GlobalVar.TempIsolate)
				{
					activeView.IsolateElementsTemporary((ICollection<ElementId>)list10);
				}
				this.m_ExEvent1.Raise();
			}
		}

		private void colorSplatSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WF_ColorSplat wF_ColorSplat = new WF_ColorSplat();
			wF_ColorSplat.Show();
		}

		private void TabControl3_SelectedIndexChanged(object sender, EventArgs e)
		{
			string log = GlobalVar.Log;
			this.textBox2.Text = log;
		}

		private void resetElementColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			this.m_ExEvent3.Raise();
		}

		private void saveColorSplatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			string text = "";
			try
			{
				List<ElementId> g_Ele_List = GlobalVar.G_Ele_List;
				List<string> g_Color_Log = GlobalVar.G_Color_Log;
				try
				{
					text = text + g_Color_Log[0] + "," + g_Color_Log[1] + ",";
				}
				catch
				{
					text += "NoSortedColumn,NoSortedColumn,";
				}
				for (int i = 0; i < g_Ele_List.Count; i++)
				{
					text = ((i >= g_Ele_List.Count - 1) ? (text + (object)g_Ele_List[i]) : (text + (object)g_Ele_List[i] + ","));
				}
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Text File|*.txt";
				saveFileDialog.Title = "Save Color Log";
				saveFileDialog.CheckPathExists = true;
				saveFileDialog.ShowDialog();
				string fileName = saveFileDialog.FileName;
				File.WriteAllText(fileName, text);
			}
			catch
			{
				MessageBox.Show("Please Use Color Splat First.");
			}
		}

		private void loadColorSplatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_0548: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Unknown result type (might be due to invalid IL or missing references)
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_0626: Unknown result type (might be due to invalid IL or missing references)
			//IL_0629: Unknown result type (might be due to invalid IL or missing references)
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_0637: Unknown result type (might be due to invalid IL or missing references)
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			UIApplication hGUiApp = this.HGUiApp;
			Document document = hGUiApp.get_ActiveUIDocument().get_Document();
			View activeView = document.get_ActiveView();
			Document hGDoc = this.HGDoc;
			OverrideGraphicSettings val = new OverrideGraphicSettings();
			val.SetSurfaceTransparency(GlobalVar.ColorSplatTransparency);
			val.SetHalftone(GlobalVar.HalfTone);
			FilteredElementCollector val2 = new FilteredElementCollector(hGDoc).WhereElementIsNotElementType();
			IList<Element> list = val2.ToElements();
			foreach (Element item3 in list)
			{
				activeView.SetElementOverrides(item3.get_Id(), val);
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text File|*.txt";
			openFileDialog.Title = "Load Color Log";
			openFileDialog.CheckPathExists = true;
			openFileDialog.ShowDialog();
			string fileName = openFileDialog.FileName;
			List<ElementId> list2 = new List<ElementId>();
			List<string> list3 = new List<string>();
			list3.AddRange(GlobalVar.ColorHax.Hax);
			List<Color> list4 = new List<Color>();
			List<byte> list5 = new List<byte>();
			List<byte> list6 = new List<byte>();
			List<byte> list7 = new List<byte>();
			List<OverrideGraphicSettings> list8 = new List<OverrideGraphicSettings>();
			foreach (string item4 in list3)
			{
				Color item = ColorTranslator.FromHtml(item4);
				list4.Add(item);
				list5.Add(item.R);
				list6.Add(item.G);
				list7.Add(item.B);
			}
			List<ElementId> list9 = new List<ElementId>();
			FilteredElementCollector val3 = new FilteredElementCollector(hGDoc).OfClass(typeof(FillPatternElement));
			IList<Element> list10 = val3.ToElements();
			foreach (Element item5 in list10)
			{
				if (item5.get_Name() == "Solid fill")
				{
					list9.Add(item5.get_Id());
				}
			}
			List<int> list11 = new List<int>();
			List<ListSortDirection> list12 = new List<ListSortDirection>();
			try
			{
				using (StreamReader streamReader = File.OpenText(fileName))
				{
					string text = "";
					while ((text = streamReader.ReadLine()) != null)
					{
						string[] array = text.Split(',');
						for (int i = 0; i < array.Length; i++)
						{
							switch (i)
							{
							case 0:
								if (array[i] == "Ascending")
								{
									list12.Add(ListSortDirection.Ascending);
								}
								else if (array[i] == "Descending")
								{
									list12.Add(ListSortDirection.Descending);
								}
								break;
							case 1:
								try
								{
									list11.Add(int.Parse(array[i]));
								}
								catch
								{
								}
								break;
							default:
								try
								{
									int num = int.Parse(array[i]);
									ElementId item2 = new ElementId(num);
									list2.Add(item2);
									OverrideGraphicSettings val4 = new OverrideGraphicSettings();
									Color val5 = new Color(list5[i], list6[i], list7[i]);
									ElementId projectionFillPatternId = ((IEnumerable<ElementId>)list9).First<ElementId>();
									val4.SetProjectionFillColor(val5);
									val4.SetProjectionFillPatternId(projectionFillPatternId);
									val4.SetCutLineColor(val5);
									list8.Add(val4);
								}
								catch
								{
								}
								break;
							}
						}
						List<Element> list13 = new List<Element>();
						foreach (ElementId item6 in list2)
						{
							Element element = hGDoc.GetElement(item6);
							list13.Add(element);
						}
						if (GlobalVar.TypeORInstance == "Family Instance")
						{
							DataSet dataSet = new DataSet();
							DataSet dataSet2 = new DataSet();
							List<ElementId> list14 = new List<ElementId>();
							foreach (Element item7 in list13)
							{
								try
								{
									list14.Add(item7.get_Category().get_Id());
								}
								catch
								{
								}
							}
							List<ElementId> list15 = ((IEnumerable<ElementId>)list14).Distinct<ElementId>().ToList<ElementId>();
							foreach (ElementId item8 in list15)
							{
								FilteredElementCollector val6 = new FilteredElementCollector(hGDoc, (ICollection<ElementId>)list2).OfCategoryId(item8);
								IList<Element> eleList = val6.ToElements();
								DataTable table = Method.ElementParameter2Table(this.cmddata, eleList);
								DataTable table2 = Method.ParameterIsRead(this.cmddata, eleList, hGDoc);
								dataSet.Tables.Add(table);
								dataSet2.Tables.Add(table2);
							}
							GlobalVar.MyDataSet = dataSet;
							GlobalVar.Is_Read_Only = dataSet2;
							GlobalVar.CM_GetUpdata -= this.GetUpdate;
							this.tabControl1.Controls.Clear();
							this.treeView1.Nodes.Clear();
							this.Form_Load(sender, e);
						}
						else
						{
							ICollection<ElementId> collection = new List<ElementId>();
							List<Element> list16 = new List<Element>();
							foreach (ElementId item9 in list2)
							{
								try
								{
									Element element2 = hGDoc.GetElement(item9);
									ElementId typeId = element2.GetTypeId();
									Element element3 = hGDoc.GetElement(typeId);
									collection.Add(typeId);
									list16.Add(element3);
								}
								catch
								{
								}
							}
							if (list16.Count > 0)
							{
								DataSet dataSet3 = new DataSet();
								DataSet dataSet4 = new DataSet();
								List<ElementId> list17 = new List<ElementId>();
								foreach (Element item10 in list16)
								{
									try
									{
										list17.Add(item10.get_Category().get_Id());
									}
									catch
									{
									}
								}
								List<ElementId> list18 = ((IEnumerable<ElementId>)list17).Distinct<ElementId>().ToList<ElementId>();
								foreach (ElementId item11 in list18)
								{
									FilteredElementCollector val7 = new FilteredElementCollector(hGDoc, collection).OfCategoryId(item11);
									IList<Element> eleList2 = val7.ToElements();
									DataTable table3 = Method.ElementParameter2Table(this.cmddata, eleList2);
									DataTable table4 = Method.ParameterIsRead(this.cmddata, eleList2, hGDoc);
									dataSet3.Tables.Add(table3);
									dataSet4.Tables.Add(table4);
								}
								GlobalVar.MyDataSet = dataSet3;
								GlobalVar.Is_Read_Only = dataSet4;
								this.tabControl1.Controls.Clear();
								this.treeView1.Nodes.Clear();
								this.Form_Load(sender, e);
							}
						}
					}
				}
			}
			catch (ArgumentException)
			{
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
			}
			try
			{
				foreach (DataGridView control in this.tabControl1.SelectedTab.Controls)
				{
					try
					{
						control.Sort(control.Columns[list11[0]], list12[0]);
						this.ColorIsolate_Click(sender, e);
					}
					catch
					{
					}
				}
			}
			catch
			{
				MessageBox.Show("Please check you have to load the right txt file.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WF_About wF_About = new WF_About();
			wF_About.Show();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://hotgearproject.gitbooks.io/hotgear-project/content/");
		}

		private void toolStripStatusLabel5_Click(object sender, EventArgs e)
		{
		}
	}
}
