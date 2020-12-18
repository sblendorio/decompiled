// Decompiled with JetBrains decompiler
// Type: AltairPeripheralEmulator.MainForm
// Assembly: AltairPeripheralEmulator, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 120C4B5F-FE40-457E-A7C0-4D6B2A9778DF
// Assembly location: C:\Users\Nino1\Downloads\AltairPeripheralEmulator.exe

using AltairPeripheralEmulator.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AltairPeripheralEmulator
{
  [DesignerGenerated]
  public class MainForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("cboDisk1")]
    private ComboBox _cboDisk1;
    [AccessedThroughProperty("cboDisk2")]
    private ComboBox _cboDisk2;
    [AccessedThroughProperty("cboDisk3")]
    private ComboBox _cboDisk3;
    [AccessedThroughProperty("lblFilename1")]
    private Label _lblFilename1;
    [AccessedThroughProperty("lblFilename2")]
    private Label _lblFilename2;
    [AccessedThroughProperty("lblFilename3")]
    private Label _lblFilename3;
    [AccessedThroughProperty("btnOpen0")]
    private Button _btnOpen0;
    [AccessedThroughProperty("btnOpen1")]
    private Button _btnOpen1;
    [AccessedThroughProperty("btnOpen2")]
    private Button _btnOpen2;
    [AccessedThroughProperty("btnOpen3")]
    private Button _btnOpen3;
    [AccessedThroughProperty("btnNew0")]
    private Button _btnNew0;
    [AccessedThroughProperty("btnNew1")]
    private Button _btnNew1;
    [AccessedThroughProperty("btnNew2")]
    private Button _btnNew2;
    [AccessedThroughProperty("btnNew3")]
    private Button _btnNew3;
    [AccessedThroughProperty("lblSize3")]
    private Label _lblSize3;
    [AccessedThroughProperty("lblSize2")]
    private Label _lblSize2;
    [AccessedThroughProperty("lblSize1")]
    private Label _lblSize1;
    [AccessedThroughProperty("NewFileDialog")]
    private OpenFileDialog _NewFileDialog;
    [AccessedThroughProperty("btnBoot0")]
    private Button _btnBoot0;
    [AccessedThroughProperty("btnBoot1")]
    private Button _btnBoot1;
    [AccessedThroughProperty("btnBoot2")]
    private Button _btnBoot2;
    [AccessedThroughProperty("btnBoot3")]
    private Button _btnBoot3;
    [AccessedThroughProperty("cboCOMPort")]
    private ComboBox _cboCOMPort;
    [AccessedThroughProperty("cboBaudRate")]
    private ComboBox _cboBaudRate;
    [AccessedThroughProperty("cboParity")]
    private ComboBox _cboParity;
    [AccessedThroughProperty("cboDataBits")]
    private ComboBox _cboDataBits;
    [AccessedThroughProperty("cboStopBits")]
    private ComboBox _cboStopBits;
    [AccessedThroughProperty("cboHandshaking")]
    private ComboBox _cboHandshaking;
    [AccessedThroughProperty("OpenFileDialog")]
    private OpenFileDialog _OpenFileDialog;
    [AccessedThroughProperty("SerialPort1")]
    private SerialPort _SerialPort1;
    [AccessedThroughProperty("lblSectorSize1")]
    private Label _lblSectorSize1;
    [AccessedThroughProperty("lblSectorSize2")]
    private Label _lblSectorSize2;
    [AccessedThroughProperty("lblSectorSize3")]
    private Label _lblSectorSize3;
    [AccessedThroughProperty("lblWriteData1")]
    private Label _lblWriteData1;
    [AccessedThroughProperty("lblWrite1")]
    private Label _lblWrite1;
    [AccessedThroughProperty("lblWriteData2")]
    private Label _lblWriteData2;
    [AccessedThroughProperty("lblWrite2")]
    private Label _lblWrite2;
    [AccessedThroughProperty("lblWriteData3")]
    private Label _lblWriteData3;
    [AccessedThroughProperty("lblWrite3")]
    private Label _lblWrite3;
    [AccessedThroughProperty("lblReadData1")]
    private Label _lblReadData1;
    [AccessedThroughProperty("lblRead1")]
    private Label _lblRead1;
    [AccessedThroughProperty("lblReadData2")]
    private Label _lblReadData2;
    [AccessedThroughProperty("lblRead2")]
    private Label _lblRead2;
    [AccessedThroughProperty("lblReadData3")]
    private Label _lblReadData3;
    [AccessedThroughProperty("lblRead3")]
    private Label _lblRead3;
    [AccessedThroughProperty("lblSectorData1")]
    private Label _lblSectorData1;
    [AccessedThroughProperty("lblSector1")]
    private Label _lblSector1;
    [AccessedThroughProperty("lblSectorData2")]
    private Label _lblSectorData2;
    [AccessedThroughProperty("lblSector2")]
    private Label _lblSector2;
    [AccessedThroughProperty("lblSectorData3")]
    private Label _lblSectorData3;
    [AccessedThroughProperty("lblSector3")]
    private Label _lblSector3;
    [AccessedThroughProperty("lblTrackData1")]
    private Label _lblTrackData1;
    [AccessedThroughProperty("lblTrack1")]
    private Label _lblTrack1;
    [AccessedThroughProperty("lblTrackData2")]
    private Label _lblTrackData2;
    [AccessedThroughProperty("lblTrack2")]
    private Label _lblTrack2;
    [AccessedThroughProperty("lblTrackData3")]
    private Label _lblTrackData3;
    [AccessedThroughProperty("lblTrack3")]
    private Label _lblTrack3;
    [AccessedThroughProperty("lblSectorSize0")]
    private Label _lblSectorSize0;
    [AccessedThroughProperty("lblSector0")]
    private Label _lblSector0;
    [AccessedThroughProperty("lblTrack0")]
    private Label _lblTrack0;
    [AccessedThroughProperty("cboDisk0")]
    private ComboBox _cboDisk0;
    [AccessedThroughProperty("lblFilename0")]
    private Label _lblFilename0;
    [AccessedThroughProperty("lblSize0")]
    private Label _lblSize0;
    [AccessedThroughProperty("lblTrackData0")]
    private Label _lblTrackData0;
    [AccessedThroughProperty("lblSectorData0")]
    private Label _lblSectorData0;
    [AccessedThroughProperty("lblRead0")]
    private Label _lblRead0;
    [AccessedThroughProperty("lblReadData0")]
    private Label _lblReadData0;
    [AccessedThroughProperty("lblWrite0")]
    private Label _lblWrite0;
    [AccessedThroughProperty("lblWriteData0")]
    private Label _lblWriteData0;
    [AccessedThroughProperty("lblAPE")]
    private Label _lblAPE;
    private APEFileClass Disk0;
    private APEFileClass Disk1;
    private APEFileClass Disk2;
    private APEFileClass Disk3;
    private APEFileClass SelectedDisk;
    private MainForm.RXStates RXState;
    private char RXCommand;
    private int RXData;
    private ushort RXChecksum;
    private byte[] RXWriteData;
    private int RXWriteCount;
    private int RXWriteIndex;

    public MainForm()
    {
      this.Load += new EventHandler(this.MainForm_Load);
      this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
      this.Disk0 = (APEFileClass) null;
      this.Disk1 = (APEFileClass) null;
      this.Disk2 = (APEFileClass) null;
      this.Disk3 = (APEFileClass) null;
      this.SelectedDisk = (APEFileClass) null;
      this.RXState = MainForm.RXStates.Command;
      this.RXChecksum = (ushort) 0;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.cboDisk1 = new ComboBox();
      this.cboDisk2 = new ComboBox();
      this.cboDisk3 = new ComboBox();
      this.lblFilename1 = new Label();
      this.lblFilename2 = new Label();
      this.lblFilename3 = new Label();
      this.btnOpen0 = new Button();
      this.btnOpen1 = new Button();
      this.btnOpen2 = new Button();
      this.btnOpen3 = new Button();
      this.btnNew0 = new Button();
      this.btnNew1 = new Button();
      this.btnNew2 = new Button();
      this.btnNew3 = new Button();
      this.lblSize3 = new Label();
      this.lblSize2 = new Label();
      this.lblSize1 = new Label();
      this.NewFileDialog = new OpenFileDialog();
      this.btnBoot0 = new Button();
      this.btnBoot1 = new Button();
      this.btnBoot2 = new Button();
      this.btnBoot3 = new Button();
      this.cboCOMPort = new ComboBox();
      this.cboBaudRate = new ComboBox();
      this.cboParity = new ComboBox();
      this.cboDataBits = new ComboBox();
      this.cboStopBits = new ComboBox();
      this.cboHandshaking = new ComboBox();
      this.OpenFileDialog = new OpenFileDialog();
      this.SerialPort1 = new SerialPort(this.components);
      this.lblSectorSize1 = new Label();
      this.lblSectorSize2 = new Label();
      this.lblSectorSize3 = new Label();
      this.lblWriteData1 = new Label();
      this.lblWrite1 = new Label();
      this.lblWriteData2 = new Label();
      this.lblWrite2 = new Label();
      this.lblWriteData3 = new Label();
      this.lblWrite3 = new Label();
      this.lblReadData1 = new Label();
      this.lblRead1 = new Label();
      this.lblReadData2 = new Label();
      this.lblRead2 = new Label();
      this.lblReadData3 = new Label();
      this.lblRead3 = new Label();
      this.lblSectorData1 = new Label();
      this.lblSector1 = new Label();
      this.lblSectorData2 = new Label();
      this.lblSector2 = new Label();
      this.lblSectorData3 = new Label();
      this.lblSector3 = new Label();
      this.lblTrackData1 = new Label();
      this.lblTrack1 = new Label();
      this.lblTrackData2 = new Label();
      this.lblTrack2 = new Label();
      this.lblTrackData3 = new Label();
      this.lblTrack3 = new Label();
      this.lblSectorSize0 = new Label();
      this.lblSector0 = new Label();
      this.lblTrack0 = new Label();
      this.cboDisk0 = new ComboBox();
      this.lblFilename0 = new Label();
      this.lblSize0 = new Label();
      this.lblTrackData0 = new Label();
      this.lblSectorData0 = new Label();
      this.lblRead0 = new Label();
      this.lblReadData0 = new Label();
      this.lblWrite0 = new Label();
      this.lblWriteData0 = new Label();
      this.lblAPE = new Label();
      this.SuspendLayout();
      this.cboDisk1.BackColor = Color.LightSteelBlue;
      this.cboDisk1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDisk1.FormattingEnabled = true;
      this.cboDisk1.Items.AddRange(new object[17]
      {
        (object) "",
        (object) "A",
        (object) "B",
        (object) "C",
        (object) "D",
        (object) "E",
        (object) "F",
        (object) "G",
        (object) "H",
        (object) "I",
        (object) "J",
        (object) "K",
        (object) "L",
        (object) "M",
        (object) "N",
        (object) "O",
        (object) "P"
      });
      ComboBox cboDisk1_1 = this.cboDisk1;
      Point point1 = new Point(11, 115);
      Point point2 = point1;
      cboDisk1_1.Location = point2;
      this.cboDisk1.Name = "cboDisk1";
      ComboBox cboDisk1_2 = this.cboDisk1;
      Size size1 = new Size(39, 21);
      Size size2 = size1;
      cboDisk1_2.Size = size2;
      this.cboDisk1.TabIndex = 6;
      this.cboDisk2.BackColor = Color.LightSteelBlue;
      this.cboDisk2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDisk2.FormattingEnabled = true;
      this.cboDisk2.Items.AddRange(new object[17]
      {
        (object) "",
        (object) "A",
        (object) "B",
        (object) "C",
        (object) "D",
        (object) "E",
        (object) "F",
        (object) "G",
        (object) "H",
        (object) "I",
        (object) "J",
        (object) "K",
        (object) "L",
        (object) "M",
        (object) "N",
        (object) "O",
        (object) "P"
      });
      ComboBox cboDisk2_1 = this.cboDisk2;
      point1 = new Point(11, 179);
      Point point3 = point1;
      cboDisk2_1.Location = point3;
      this.cboDisk2.Name = "cboDisk2";
      ComboBox cboDisk2_2 = this.cboDisk2;
      size1 = new Size(39, 21);
      Size size3 = size1;
      cboDisk2_2.Size = size3;
      this.cboDisk2.TabIndex = 12;
      this.cboDisk3.BackColor = Color.LightSteelBlue;
      this.cboDisk3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDisk3.FormattingEnabled = true;
      this.cboDisk3.Items.AddRange(new object[17]
      {
        (object) "",
        (object) "A",
        (object) "B",
        (object) "C",
        (object) "D",
        (object) "E",
        (object) "F",
        (object) "G",
        (object) "H",
        (object) "I",
        (object) "J",
        (object) "K",
        (object) "L",
        (object) "M",
        (object) "N",
        (object) "O",
        (object) "P"
      });
      ComboBox cboDisk3_1 = this.cboDisk3;
      point1 = new Point(11, 243);
      Point point4 = point1;
      cboDisk3_1.Location = point4;
      this.cboDisk3.Name = "cboDisk3";
      ComboBox cboDisk3_2 = this.cboDisk3;
      size1 = new Size(39, 21);
      Size size4 = size1;
      cboDisk3_2.Size = size4;
      this.cboDisk3.TabIndex = 18;
      this.lblFilename1.BackColor = Color.LightSteelBlue;
      this.lblFilename1.BorderStyle = BorderStyle.FixedSingle;
      this.lblFilename1.ForeColor = Color.Black;
      Label lblFilename1_1 = this.lblFilename1;
      point1 = new Point(56, 115);
      Point point5 = point1;
      lblFilename1_1.Location = point5;
      this.lblFilename1.Name = "lblFilename1";
      Label lblFilename1_2 = this.lblFilename1;
      size1 = new Size(515, 21);
      Size size5 = size1;
      lblFilename1_2.Size = size5;
      this.lblFilename1.TabIndex = 7;
      this.lblFilename1.Text = "lblFilename1";
      this.lblFilename1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblFilename2.BackColor = Color.LightSteelBlue;
      this.lblFilename2.BorderStyle = BorderStyle.FixedSingle;
      this.lblFilename2.ForeColor = Color.Black;
      Label lblFilename2_1 = this.lblFilename2;
      point1 = new Point(56, 179);
      Point point6 = point1;
      lblFilename2_1.Location = point6;
      this.lblFilename2.Name = "lblFilename2";
      Label lblFilename2_2 = this.lblFilename2;
      size1 = new Size(515, 21);
      Size size6 = size1;
      lblFilename2_2.Size = size6;
      this.lblFilename2.TabIndex = 13;
      this.lblFilename2.Text = "lblFilename2";
      this.lblFilename2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblFilename3.BackColor = Color.LightSteelBlue;
      this.lblFilename3.BorderStyle = BorderStyle.FixedSingle;
      this.lblFilename3.ForeColor = Color.Black;
      Label lblFilename3_1 = this.lblFilename3;
      point1 = new Point(56, 243);
      Point point7 = point1;
      lblFilename3_1.Location = point7;
      this.lblFilename3.Name = "lblFilename3";
      Label lblFilename3_2 = this.lblFilename3;
      size1 = new Size(516, 21);
      Size size7 = size1;
      lblFilename3_2.Size = size7;
      this.lblFilename3.TabIndex = 19;
      this.lblFilename3.Text = "lblFilename3";
      this.lblFilename3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnOpen0.Enabled = false;
      Button btnOpen0_1 = this.btnOpen0;
      point1 = new Point(394, 76);
      Point point8 = point1;
      btnOpen0_1.Location = point8;
      this.btnOpen0.Name = "btnOpen0";
      Button btnOpen0_2 = this.btnOpen0;
      size1 = new Size(55, 23);
      Size size8 = size1;
      btnOpen0_2.Size = size8;
      this.btnOpen0.TabIndex = 3;
      this.btnOpen0.Text = "&Open...";
      this.btnOpen0.UseVisualStyleBackColor = true;
      this.btnOpen1.Enabled = false;
      Button btnOpen1_1 = this.btnOpen1;
      point1 = new Point(394, 140);
      Point point9 = point1;
      btnOpen1_1.Location = point9;
      this.btnOpen1.Name = "btnOpen1";
      Button btnOpen1_2 = this.btnOpen1;
      size1 = new Size(55, 23);
      Size size9 = size1;
      btnOpen1_2.Size = size9;
      this.btnOpen1.TabIndex = 9;
      this.btnOpen1.Text = "&Open...";
      this.btnOpen1.UseVisualStyleBackColor = true;
      this.btnOpen2.Enabled = false;
      Button btnOpen2_1 = this.btnOpen2;
      point1 = new Point(394, 204);
      Point point10 = point1;
      btnOpen2_1.Location = point10;
      this.btnOpen2.Name = "btnOpen2";
      Button btnOpen2_2 = this.btnOpen2;
      size1 = new Size(55, 23);
      Size size10 = size1;
      btnOpen2_2.Size = size10;
      this.btnOpen2.TabIndex = 15;
      this.btnOpen2.Text = "&Open...";
      this.btnOpen2.UseVisualStyleBackColor = true;
      this.btnOpen3.Enabled = false;
      Button btnOpen3_1 = this.btnOpen3;
      point1 = new Point(394, 268);
      Point point11 = point1;
      btnOpen3_1.Location = point11;
      this.btnOpen3.Name = "btnOpen3";
      Button btnOpen3_2 = this.btnOpen3;
      size1 = new Size(55, 23);
      Size size11 = size1;
      btnOpen3_2.Size = size11;
      this.btnOpen3.TabIndex = 21;
      this.btnOpen3.Text = "&Open...";
      this.btnOpen3.UseVisualStyleBackColor = true;
      this.btnNew0.Enabled = false;
      Button btnNew0_1 = this.btnNew0;
      point1 = new Point(455, 76);
      Point point12 = point1;
      btnNew0_1.Location = point12;
      this.btnNew0.Name = "btnNew0";
      Button btnNew0_2 = this.btnNew0;
      size1 = new Size(55, 23);
      Size size12 = size1;
      btnNew0_2.Size = size12;
      this.btnNew0.TabIndex = 4;
      this.btnNew0.Text = "&New...";
      this.btnNew0.UseVisualStyleBackColor = true;
      this.btnNew1.Enabled = false;
      Button btnNew1_1 = this.btnNew1;
      point1 = new Point(455, 140);
      Point point13 = point1;
      btnNew1_1.Location = point13;
      this.btnNew1.Name = "btnNew1";
      Button btnNew1_2 = this.btnNew1;
      size1 = new Size(55, 23);
      Size size13 = size1;
      btnNew1_2.Size = size13;
      this.btnNew1.TabIndex = 10;
      this.btnNew1.Text = "&New...";
      this.btnNew1.UseVisualStyleBackColor = true;
      this.btnNew2.Enabled = false;
      Button btnNew2_1 = this.btnNew2;
      point1 = new Point(455, 204);
      Point point14 = point1;
      btnNew2_1.Location = point14;
      this.btnNew2.Name = "btnNew2";
      Button btnNew2_2 = this.btnNew2;
      size1 = new Size(55, 23);
      Size size14 = size1;
      btnNew2_2.Size = size14;
      this.btnNew2.TabIndex = 16;
      this.btnNew2.Text = "&New...";
      this.btnNew2.UseVisualStyleBackColor = true;
      this.btnNew3.Enabled = false;
      Button btnNew3_1 = this.btnNew3;
      point1 = new Point(455, 268);
      Point point15 = point1;
      btnNew3_1.Location = point15;
      this.btnNew3.Name = "btnNew3";
      Button btnNew3_2 = this.btnNew3;
      size1 = new Size(55, 23);
      Size size15 = size1;
      btnNew3_2.Size = size15;
      this.btnNew3.TabIndex = 22;
      this.btnNew3.Text = "&New...";
      this.btnNew3.UseVisualStyleBackColor = true;
      this.lblSize3.BackColor = Color.Black;
      this.lblSize3.BorderStyle = BorderStyle.FixedSingle;
      this.lblSize3.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSize3.ForeColor = Color.LimeGreen;
      Label lblSize3_1 = this.lblSize3;
      point1 = new Point(352, 270);
      Point point16 = point1;
      lblSize3_1.Location = point16;
      this.lblSize3.Name = "lblSize3";
      Label lblSize3_2 = this.lblSize3;
      size1 = new Size(27, 19);
      Size size16 = size1;
      lblSize3_2.Size = size16;
      this.lblSize3.TabIndex = 20;
      this.lblSize3.Text = "888";
      this.lblSize3.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSize2.BackColor = Color.Black;
      this.lblSize2.BorderStyle = BorderStyle.FixedSingle;
      this.lblSize2.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSize2.ForeColor = Color.LimeGreen;
      Label lblSize2_1 = this.lblSize2;
      point1 = new Point(352, 206);
      Point point17 = point1;
      lblSize2_1.Location = point17;
      this.lblSize2.Name = "lblSize2";
      Label lblSize2_2 = this.lblSize2;
      size1 = new Size(27, 19);
      Size size17 = size1;
      lblSize2_2.Size = size17;
      this.lblSize2.TabIndex = 14;
      this.lblSize2.Text = "888";
      this.lblSize2.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSize1.BackColor = Color.Black;
      this.lblSize1.BorderStyle = BorderStyle.FixedSingle;
      this.lblSize1.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSize1.ForeColor = Color.LimeGreen;
      Label lblSize1_1 = this.lblSize1;
      point1 = new Point(352, 142);
      Point point18 = point1;
      lblSize1_1.Location = point18;
      this.lblSize1.Name = "lblSize1";
      Label lblSize1_2 = this.lblSize1;
      size1 = new Size(27, 19);
      Size size18 = size1;
      lblSize1_2.Size = size18;
      this.lblSize1.TabIndex = 8;
      this.lblSize1.Text = "888";
      this.lblSize1.TextAlign = ContentAlignment.MiddleCenter;
      this.NewFileDialog.CheckFileExists = false;
      this.NewFileDialog.DefaultExt = "APE";
      this.NewFileDialog.FileName = "Untitled";
      this.NewFileDialog.Filter = "Altair files (*.ape)|*.ape|All files (*.*)|*.*";
      this.NewFileDialog.Title = "New Altair Disk File";
      this.btnBoot0.Enabled = false;
      Button btnBoot0_1 = this.btnBoot0;
      point1 = new Point(516, 76);
      Point point19 = point1;
      btnBoot0_1.Location = point19;
      this.btnBoot0.Name = "btnBoot0";
      Button btnBoot0_2 = this.btnBoot0;
      size1 = new Size(55, 23);
      Size size19 = size1;
      btnBoot0_2.Size = size19;
      this.btnBoot0.TabIndex = 5;
      this.btnBoot0.Text = "&Boot";
      this.btnBoot0.UseVisualStyleBackColor = true;
      this.btnBoot1.Enabled = false;
      Button btnBoot1_1 = this.btnBoot1;
      point1 = new Point(516, 140);
      Point point20 = point1;
      btnBoot1_1.Location = point20;
      this.btnBoot1.Name = "btnBoot1";
      Button btnBoot1_2 = this.btnBoot1;
      size1 = new Size(55, 23);
      Size size20 = size1;
      btnBoot1_2.Size = size20;
      this.btnBoot1.TabIndex = 11;
      this.btnBoot1.Text = "&Boot";
      this.btnBoot1.UseVisualStyleBackColor = true;
      this.btnBoot2.Enabled = false;
      Button btnBoot2_1 = this.btnBoot2;
      point1 = new Point(516, 204);
      Point point21 = point1;
      btnBoot2_1.Location = point21;
      this.btnBoot2.Name = "btnBoot2";
      Button btnBoot2_2 = this.btnBoot2;
      size1 = new Size(55, 23);
      Size size21 = size1;
      btnBoot2_2.Size = size21;
      this.btnBoot2.TabIndex = 17;
      this.btnBoot2.Text = "&Boot";
      this.btnBoot2.UseVisualStyleBackColor = true;
      this.btnBoot3.Enabled = false;
      Button btnBoot3_1 = this.btnBoot3;
      point1 = new Point(516, 268);
      Point point22 = point1;
      btnBoot3_1.Location = point22;
      this.btnBoot3.Name = "btnBoot3";
      Button btnBoot3_2 = this.btnBoot3;
      size1 = new Size(55, 23);
      Size size22 = size1;
      btnBoot3_2.Size = size22;
      this.btnBoot3.TabIndex = 23;
      this.btnBoot3.Text = "&Boot";
      this.btnBoot3.UseVisualStyleBackColor = true;
      this.cboCOMPort.BackColor = Color.LightSteelBlue;
      this.cboCOMPort.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboCOMPort.FormattingEnabled = true;
      ComboBox cboComPort1 = this.cboCOMPort;
      point1 = new Point(11, 12);
      Point point23 = point1;
      cboComPort1.Location = point23;
      this.cboCOMPort.Name = "cboCOMPort";
      ComboBox cboComPort2 = this.cboCOMPort;
      size1 = new Size(63, 21);
      Size size23 = size1;
      cboComPort2.Size = size23;
      this.cboCOMPort.Sorted = true;
      this.cboCOMPort.TabIndex = 24;
      this.cboBaudRate.BackColor = Color.LightSteelBlue;
      this.cboBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboBaudRate.FormattingEnabled = true;
      this.cboBaudRate.Items.AddRange(new object[7]
      {
        (object) "19200",
        (object) "9600",
        (object) "4800",
        (object) "2400",
        (object) "1200",
        (object) "300",
        (object) "110"
      });
      ComboBox cboBaudRate1 = this.cboBaudRate;
      point1 = new Point(80, 12);
      Point point24 = point1;
      cboBaudRate1.Location = point24;
      this.cboBaudRate.Name = "cboBaudRate";
      ComboBox cboBaudRate2 = this.cboBaudRate;
      size1 = new Size(63, 21);
      Size size24 = size1;
      cboBaudRate2.Size = size24;
      this.cboBaudRate.TabIndex = 25;
      this.cboParity.BackColor = Color.LightSteelBlue;
      this.cboParity.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboParity.FormattingEnabled = true;
      this.cboParity.Items.AddRange(new object[5]
      {
        (object) "None",
        (object) "Even",
        (object) "Odd",
        (object) "Mark",
        (object) "Space"
      });
      ComboBox cboParity1 = this.cboParity;
      point1 = new Point(149, 12);
      Point point25 = point1;
      cboParity1.Location = point25;
      this.cboParity.Name = "cboParity";
      ComboBox cboParity2 = this.cboParity;
      size1 = new Size(63, 21);
      Size size25 = size1;
      cboParity2.Size = size25;
      this.cboParity.TabIndex = 26;
      this.cboDataBits.BackColor = Color.LightSteelBlue;
      this.cboDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDataBits.FormattingEnabled = true;
      this.cboDataBits.Items.AddRange(new object[2]
      {
        (object) "8",
        (object) "7"
      });
      ComboBox cboDataBits1 = this.cboDataBits;
      point1 = new Point(218, 12);
      Point point26 = point1;
      cboDataBits1.Location = point26;
      this.cboDataBits.Name = "cboDataBits";
      ComboBox cboDataBits2 = this.cboDataBits;
      size1 = new Size(63, 21);
      Size size26 = size1;
      cboDataBits2.Size = size26;
      this.cboDataBits.TabIndex = 27;
      this.cboStopBits.BackColor = Color.LightSteelBlue;
      this.cboStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboStopBits.FormattingEnabled = true;
      this.cboStopBits.Items.AddRange(new object[3]
      {
        (object) "1",
        (object) "1.5",
        (object) "2"
      });
      ComboBox cboStopBits1 = this.cboStopBits;
      point1 = new Point(287, 12);
      Point point27 = point1;
      cboStopBits1.Location = point27;
      this.cboStopBits.Name = "cboStopBits";
      ComboBox cboStopBits2 = this.cboStopBits;
      size1 = new Size(63, 21);
      Size size27 = size1;
      cboStopBits2.Size = size27;
      this.cboStopBits.TabIndex = 28;
      this.cboHandshaking.BackColor = Color.LightSteelBlue;
      this.cboHandshaking.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboHandshaking.FormattingEnabled = true;
      this.cboHandshaking.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "RTS",
        (object) "XOn/XOff",
        (object) "RTS & XOn/XOff"
      });
      ComboBox cboHandshaking1 = this.cboHandshaking;
      point1 = new Point(356, 12);
      Point point28 = point1;
      cboHandshaking1.Location = point28;
      this.cboHandshaking.Name = "cboHandshaking";
      ComboBox cboHandshaking2 = this.cboHandshaking;
      size1 = new Size(107, 21);
      Size size28 = size1;
      cboHandshaking2.Size = size28;
      this.cboHandshaking.TabIndex = 29;
      this.OpenFileDialog.DefaultExt = "APE";
      this.OpenFileDialog.FileName = "Untitled";
      this.OpenFileDialog.Filter = "Altair files (*.ape)|*.ape|All files (*.*)|*.*";
      this.OpenFileDialog.Title = "Open Altair Disk File";
      this.lblSectorSize1.BackColor = Color.LightSteelBlue;
      this.lblSectorSize1.BorderStyle = BorderStyle.FixedSingle;
      this.lblSectorSize1.ForeColor = Color.Black;
      Label lblSectorSize1_1 = this.lblSectorSize1;
      point1 = new Point(309, 141);
      Point point29 = point1;
      lblSectorSize1_1.Location = point29;
      this.lblSectorSize1.Name = "lblSectorSize1";
      Label lblSectorSize1_2 = this.lblSectorSize1;
      size1 = new Size(70, 21);
      Size size29 = size1;
      lblSectorSize1_2.Size = size29;
      this.lblSectorSize1.TabIndex = 39;
      this.lblSectorSize1.Text = "Size";
      this.lblSectorSize1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorSize2.BackColor = Color.LightSteelBlue;
      this.lblSectorSize2.BorderStyle = BorderStyle.FixedSingle;
      this.lblSectorSize2.ForeColor = Color.Black;
      Label lblSectorSize2_1 = this.lblSectorSize2;
      point1 = new Point(309, 205);
      Point point30 = point1;
      lblSectorSize2_1.Location = point30;
      this.lblSectorSize2.Name = "lblSectorSize2";
      Label lblSectorSize2_2 = this.lblSectorSize2;
      size1 = new Size(70, 21);
      Size size30 = size1;
      lblSectorSize2_2.Size = size30;
      this.lblSectorSize2.TabIndex = 40;
      this.lblSectorSize2.Text = "Size";
      this.lblSectorSize2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorSize3.BackColor = Color.LightSteelBlue;
      this.lblSectorSize3.BorderStyle = BorderStyle.FixedSingle;
      this.lblSectorSize3.ForeColor = Color.Black;
      Label lblSectorSize3_1 = this.lblSectorSize3;
      point1 = new Point(309, 269);
      Point point31 = point1;
      lblSectorSize3_1.Location = point31;
      this.lblSectorSize3.Name = "lblSectorSize3";
      Label lblSectorSize3_2 = this.lblSectorSize3;
      size1 = new Size(70, 21);
      Size size31 = size1;
      lblSectorSize3_2.Size = size31;
      this.lblSectorSize3.TabIndex = 41;
      this.lblSectorSize3.Text = "Size";
      this.lblSectorSize3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblWriteData1.BackColor = Color.Black;
      this.lblWriteData1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblWriteData1.ForeColor = Color.OrangeRed;
      Label lblWriteData1_1 = this.lblWriteData1;
      point1 = new Point(291, 142);
      Point point32 = point1;
      lblWriteData1_1.Location = point32;
      this.lblWriteData1.Name = "lblWriteData1";
      Label lblWriteData1_2 = this.lblWriteData1;
      size1 = new Size(12, 19);
      Size size32 = size1;
      lblWriteData1_2.Size = size32;
      this.lblWriteData1.TabIndex = 43;
      this.lblWriteData1.TextAlign = ContentAlignment.MiddleCenter;
      this.lblWrite1.BackColor = Color.LightSteelBlue;
      this.lblWrite1.BorderStyle = BorderStyle.FixedSingle;
      this.lblWrite1.ForeColor = Color.Black;
      Label lblWrite1_1 = this.lblWrite1;
      point1 = new Point(258, 141);
      Point point33 = point1;
      lblWrite1_1.Location = point33;
      this.lblWrite1.Name = "lblWrite1";
      Label lblWrite1_2 = this.lblWrite1;
      size1 = new Size(45, 21);
      Size size33 = size1;
      lblWrite1_2.Size = size33;
      this.lblWrite1.TabIndex = 42;
      this.lblWrite1.Text = "Write";
      this.lblWrite1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblWriteData2.BackColor = Color.Black;
      this.lblWriteData2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblWriteData2.ForeColor = Color.OrangeRed;
      Label lblWriteData2_1 = this.lblWriteData2;
      point1 = new Point(291, 206);
      Point point34 = point1;
      lblWriteData2_1.Location = point34;
      this.lblWriteData2.Name = "lblWriteData2";
      Label lblWriteData2_2 = this.lblWriteData2;
      size1 = new Size(12, 19);
      Size size34 = size1;
      lblWriteData2_2.Size = size34;
      this.lblWriteData2.TabIndex = 45;
      this.lblWriteData2.TextAlign = ContentAlignment.MiddleCenter;
      this.lblWrite2.BackColor = Color.LightSteelBlue;
      this.lblWrite2.BorderStyle = BorderStyle.FixedSingle;
      this.lblWrite2.ForeColor = Color.Black;
      Label lblWrite2_1 = this.lblWrite2;
      point1 = new Point(258, 205);
      Point point35 = point1;
      lblWrite2_1.Location = point35;
      this.lblWrite2.Name = "lblWrite2";
      Label lblWrite2_2 = this.lblWrite2;
      size1 = new Size(45, 21);
      Size size35 = size1;
      lblWrite2_2.Size = size35;
      this.lblWrite2.TabIndex = 44;
      this.lblWrite2.Text = "Write";
      this.lblWrite2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblWriteData3.BackColor = Color.Black;
      this.lblWriteData3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblWriteData3.ForeColor = Color.OrangeRed;
      Label lblWriteData3_1 = this.lblWriteData3;
      point1 = new Point(291, 270);
      Point point36 = point1;
      lblWriteData3_1.Location = point36;
      this.lblWriteData3.Name = "lblWriteData3";
      Label lblWriteData3_2 = this.lblWriteData3;
      size1 = new Size(12, 19);
      Size size36 = size1;
      lblWriteData3_2.Size = size36;
      this.lblWriteData3.TabIndex = 47;
      this.lblWriteData3.TextAlign = ContentAlignment.MiddleCenter;
      this.lblWrite3.BackColor = Color.LightSteelBlue;
      this.lblWrite3.BorderStyle = BorderStyle.FixedSingle;
      this.lblWrite3.ForeColor = Color.Black;
      Label lblWrite3_1 = this.lblWrite3;
      point1 = new Point(258, 269);
      Point point37 = point1;
      lblWrite3_1.Location = point37;
      this.lblWrite3.Name = "lblWrite3";
      Label lblWrite3_2 = this.lblWrite3;
      size1 = new Size(45, 21);
      Size size37 = size1;
      lblWrite3_2.Size = size37;
      this.lblWrite3.TabIndex = 46;
      this.lblWrite3.Text = "Write";
      this.lblWrite3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblReadData1.BackColor = Color.Black;
      this.lblReadData1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblReadData1.ForeColor = Color.LimeGreen;
      Label lblReadData1_1 = this.lblReadData1;
      point1 = new Point(240, 142);
      Point point38 = point1;
      lblReadData1_1.Location = point38;
      this.lblReadData1.Name = "lblReadData1";
      Label lblReadData1_2 = this.lblReadData1;
      size1 = new Size(12, 19);
      Size size38 = size1;
      lblReadData1_2.Size = size38;
      this.lblReadData1.TabIndex = 49;
      this.lblReadData1.TextAlign = ContentAlignment.MiddleCenter;
      this.lblRead1.BackColor = Color.LightSteelBlue;
      this.lblRead1.BorderStyle = BorderStyle.FixedSingle;
      this.lblRead1.ForeColor = Color.Black;
      Label lblRead1_1 = this.lblRead1;
      point1 = new Point(207, 141);
      Point point39 = point1;
      lblRead1_1.Location = point39;
      this.lblRead1.Name = "lblRead1";
      Label lblRead1_2 = this.lblRead1;
      size1 = new Size(45, 21);
      Size size39 = size1;
      lblRead1_2.Size = size39;
      this.lblRead1.TabIndex = 48;
      this.lblRead1.Text = "Read";
      this.lblRead1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblReadData2.BackColor = Color.Black;
      this.lblReadData2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblReadData2.ForeColor = Color.LimeGreen;
      Label lblReadData2_1 = this.lblReadData2;
      point1 = new Point(240, 206);
      Point point40 = point1;
      lblReadData2_1.Location = point40;
      this.lblReadData2.Name = "lblReadData2";
      Label lblReadData2_2 = this.lblReadData2;
      size1 = new Size(12, 19);
      Size size40 = size1;
      lblReadData2_2.Size = size40;
      this.lblReadData2.TabIndex = 51;
      this.lblReadData2.TextAlign = ContentAlignment.MiddleCenter;
      this.lblRead2.BackColor = Color.LightSteelBlue;
      this.lblRead2.BorderStyle = BorderStyle.FixedSingle;
      this.lblRead2.ForeColor = Color.Black;
      Label lblRead2_1 = this.lblRead2;
      point1 = new Point(207, 205);
      Point point41 = point1;
      lblRead2_1.Location = point41;
      this.lblRead2.Name = "lblRead2";
      Label lblRead2_2 = this.lblRead2;
      size1 = new Size(45, 21);
      Size size41 = size1;
      lblRead2_2.Size = size41;
      this.lblRead2.TabIndex = 50;
      this.lblRead2.Text = "Read";
      this.lblRead2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblReadData3.BackColor = Color.Black;
      this.lblReadData3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblReadData3.ForeColor = Color.LimeGreen;
      Label lblReadData3_1 = this.lblReadData3;
      point1 = new Point(240, 270);
      Point point42 = point1;
      lblReadData3_1.Location = point42;
      this.lblReadData3.Name = "lblReadData3";
      Label lblReadData3_2 = this.lblReadData3;
      size1 = new Size(12, 19);
      Size size42 = size1;
      lblReadData3_2.Size = size42;
      this.lblReadData3.TabIndex = 53;
      this.lblReadData3.TextAlign = ContentAlignment.MiddleCenter;
      this.lblRead3.BackColor = Color.LightSteelBlue;
      this.lblRead3.BorderStyle = BorderStyle.FixedSingle;
      this.lblRead3.ForeColor = Color.Black;
      Label lblRead3_1 = this.lblRead3;
      point1 = new Point(207, 269);
      Point point43 = point1;
      lblRead3_1.Location = point43;
      this.lblRead3.Name = "lblRead3";
      Label lblRead3_2 = this.lblRead3;
      size1 = new Size(45, 21);
      Size size43 = size1;
      lblRead3_2.Size = size43;
      this.lblRead3.TabIndex = 52;
      this.lblRead3.Text = "Read";
      this.lblRead3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorData1.BackColor = Color.Black;
      this.lblSectorData1.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSectorData1.ForeColor = Color.LimeGreen;
      Label lblSectorData1_1 = this.lblSectorData1;
      point1 = new Point(174, 142);
      Point point44 = point1;
      lblSectorData1_1.Location = point44;
      this.lblSectorData1.Name = "lblSectorData1";
      Label lblSectorData1_2 = this.lblSectorData1;
      size1 = new Size(27, 19);
      Size size44 = size1;
      lblSectorData1_2.Size = size44;
      this.lblSectorData1.TabIndex = 55;
      this.lblSectorData1.Text = "888";
      this.lblSectorData1.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSector1.BackColor = Color.LightSteelBlue;
      this.lblSector1.BorderStyle = BorderStyle.FixedSingle;
      this.lblSector1.ForeColor = Color.Black;
      Label lblSector1_1 = this.lblSector1;
      point1 = new Point(132, 141);
      Point point45 = point1;
      lblSector1_1.Location = point45;
      this.lblSector1.Name = "lblSector1";
      Label lblSector1_2 = this.lblSector1;
      size1 = new Size(70, 21);
      Size size45 = size1;
      lblSector1_2.Size = size45;
      this.lblSector1.TabIndex = 54;
      this.lblSector1.Text = "Sector";
      this.lblSector1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorData2.BackColor = Color.Black;
      this.lblSectorData2.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSectorData2.ForeColor = Color.LimeGreen;
      Label lblSectorData2_1 = this.lblSectorData2;
      point1 = new Point(174, 206);
      Point point46 = point1;
      lblSectorData2_1.Location = point46;
      this.lblSectorData2.Name = "lblSectorData2";
      Label lblSectorData2_2 = this.lblSectorData2;
      size1 = new Size(27, 19);
      Size size46 = size1;
      lblSectorData2_2.Size = size46;
      this.lblSectorData2.TabIndex = 57;
      this.lblSectorData2.Text = "888";
      this.lblSectorData2.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSector2.BackColor = Color.LightSteelBlue;
      this.lblSector2.BorderStyle = BorderStyle.FixedSingle;
      this.lblSector2.ForeColor = Color.Black;
      Label lblSector2_1 = this.lblSector2;
      point1 = new Point(132, 205);
      Point point47 = point1;
      lblSector2_1.Location = point47;
      this.lblSector2.Name = "lblSector2";
      Label lblSector2_2 = this.lblSector2;
      size1 = new Size(70, 21);
      Size size47 = size1;
      lblSector2_2.Size = size47;
      this.lblSector2.TabIndex = 56;
      this.lblSector2.Text = "Sector";
      this.lblSector2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorData3.BackColor = Color.Black;
      this.lblSectorData3.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSectorData3.ForeColor = Color.LimeGreen;
      Label lblSectorData3_1 = this.lblSectorData3;
      point1 = new Point(174, 270);
      Point point48 = point1;
      lblSectorData3_1.Location = point48;
      this.lblSectorData3.Name = "lblSectorData3";
      Label lblSectorData3_2 = this.lblSectorData3;
      size1 = new Size(27, 19);
      Size size48 = size1;
      lblSectorData3_2.Size = size48;
      this.lblSectorData3.TabIndex = 59;
      this.lblSectorData3.Text = "888";
      this.lblSectorData3.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSector3.BackColor = Color.LightSteelBlue;
      this.lblSector3.BorderStyle = BorderStyle.FixedSingle;
      this.lblSector3.ForeColor = Color.Black;
      Label lblSector3_1 = this.lblSector3;
      point1 = new Point(131, 269);
      Point point49 = point1;
      lblSector3_1.Location = point49;
      this.lblSector3.Name = "lblSector3";
      Label lblSector3_2 = this.lblSector3;
      size1 = new Size(70, 21);
      Size size49 = size1;
      lblSector3_2.Size = size49;
      this.lblSector3.TabIndex = 58;
      this.lblSector3.Text = "Sector";
      this.lblSector3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrackData1.BackColor = Color.Black;
      this.lblTrackData1.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblTrackData1.ForeColor = Color.LimeGreen;
      Label lblTrackData1_1 = this.lblTrackData1;
      point1 = new Point(98, 142);
      Point point50 = point1;
      lblTrackData1_1.Location = point50;
      this.lblTrackData1.Name = "lblTrackData1";
      Label lblTrackData1_2 = this.lblTrackData1;
      size1 = new Size(27, 19);
      Size size50 = size1;
      lblTrackData1_2.Size = size50;
      this.lblTrackData1.TabIndex = 61;
      this.lblTrackData1.Text = "888";
      this.lblTrackData1.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTrack1.BackColor = Color.LightSteelBlue;
      this.lblTrack1.BorderStyle = BorderStyle.FixedSingle;
      this.lblTrack1.ForeColor = Color.Black;
      Label lblTrack1_1 = this.lblTrack1;
      point1 = new Point(56, 141);
      Point point51 = point1;
      lblTrack1_1.Location = point51;
      this.lblTrack1.Name = "lblTrack1";
      Label lblTrack1_2 = this.lblTrack1;
      size1 = new Size(70, 21);
      Size size51 = size1;
      lblTrack1_2.Size = size51;
      this.lblTrack1.TabIndex = 60;
      this.lblTrack1.Text = "Track";
      this.lblTrack1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrackData2.BackColor = Color.Black;
      this.lblTrackData2.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblTrackData2.ForeColor = Color.LimeGreen;
      Label lblTrackData2_1 = this.lblTrackData2;
      point1 = new Point(98, 206);
      Point point52 = point1;
      lblTrackData2_1.Location = point52;
      this.lblTrackData2.Name = "lblTrackData2";
      Label lblTrackData2_2 = this.lblTrackData2;
      size1 = new Size(27, 19);
      Size size52 = size1;
      lblTrackData2_2.Size = size52;
      this.lblTrackData2.TabIndex = 63;
      this.lblTrackData2.Text = "888";
      this.lblTrackData2.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTrack2.BackColor = Color.LightSteelBlue;
      this.lblTrack2.BorderStyle = BorderStyle.FixedSingle;
      this.lblTrack2.ForeColor = Color.Black;
      Label lblTrack2_1 = this.lblTrack2;
      point1 = new Point(56, 205);
      Point point53 = point1;
      lblTrack2_1.Location = point53;
      this.lblTrack2.Name = "lblTrack2";
      Label lblTrack2_2 = this.lblTrack2;
      size1 = new Size(70, 21);
      Size size53 = size1;
      lblTrack2_2.Size = size53;
      this.lblTrack2.TabIndex = 62;
      this.lblTrack2.Text = "Track";
      this.lblTrack2.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrackData3.BackColor = Color.Black;
      this.lblTrackData3.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblTrackData3.ForeColor = Color.LimeGreen;
      Label lblTrackData3_1 = this.lblTrackData3;
      point1 = new Point(98, 270);
      Point point54 = point1;
      lblTrackData3_1.Location = point54;
      this.lblTrackData3.Name = "lblTrackData3";
      Label lblTrackData3_2 = this.lblTrackData3;
      size1 = new Size(27, 19);
      Size size54 = size1;
      lblTrackData3_2.Size = size54;
      this.lblTrackData3.TabIndex = 65;
      this.lblTrackData3.Text = "888";
      this.lblTrackData3.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTrack3.BackColor = Color.LightSteelBlue;
      this.lblTrack3.BorderStyle = BorderStyle.FixedSingle;
      this.lblTrack3.ForeColor = Color.Black;
      Label lblTrack3_1 = this.lblTrack3;
      point1 = new Point(56, 269);
      Point point55 = point1;
      lblTrack3_1.Location = point55;
      this.lblTrack3.Name = "lblTrack3";
      Label lblTrack3_2 = this.lblTrack3;
      size1 = new Size(70, 21);
      Size size55 = size1;
      lblTrack3_2.Size = size55;
      this.lblTrack3.TabIndex = 64;
      this.lblTrack3.Text = "Track";
      this.lblTrack3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSectorSize0.BackColor = Color.LightSteelBlue;
      this.lblSectorSize0.BorderStyle = BorderStyle.FixedSingle;
      this.lblSectorSize0.ForeColor = Color.Black;
      Label lblSectorSize0_1 = this.lblSectorSize0;
      point1 = new Point(309, 77);
      Point point56 = point1;
      lblSectorSize0_1.Location = point56;
      this.lblSectorSize0.Name = "lblSectorSize0";
      Label lblSectorSize0_2 = this.lblSectorSize0;
      size1 = new Size(70, 21);
      Size size56 = size1;
      lblSectorSize0_2.Size = size56;
      this.lblSectorSize0.TabIndex = 38;
      this.lblSectorSize0.Text = "Size";
      this.lblSectorSize0.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSector0.BackColor = Color.LightSteelBlue;
      this.lblSector0.BorderStyle = BorderStyle.FixedSingle;
      this.lblSector0.ForeColor = Color.Black;
      Label lblSector0_1 = this.lblSector0;
      point1 = new Point(132, 77);
      Point point57 = point1;
      lblSector0_1.Location = point57;
      this.lblSector0.Name = "lblSector0";
      Label lblSector0_2 = this.lblSector0;
      size1 = new Size(70, 21);
      Size size57 = size1;
      lblSector0_2.Size = size57;
      this.lblSector0.TabIndex = 32;
      this.lblSector0.Text = "Sector";
      this.lblSector0.TextAlign = ContentAlignment.MiddleLeft;
      this.lblTrack0.BackColor = Color.LightSteelBlue;
      this.lblTrack0.BorderStyle = BorderStyle.FixedSingle;
      this.lblTrack0.ForeColor = Color.Black;
      Label lblTrack0_1 = this.lblTrack0;
      point1 = new Point(56, 77);
      Point point58 = point1;
      lblTrack0_1.Location = point58;
      this.lblTrack0.Name = "lblTrack0";
      Label lblTrack0_2 = this.lblTrack0;
      size1 = new Size(70, 21);
      Size size58 = size1;
      lblTrack0_2.Size = size58;
      this.lblTrack0.TabIndex = 30;
      this.lblTrack0.Text = "Track";
      this.lblTrack0.TextAlign = ContentAlignment.MiddleLeft;
      this.cboDisk0.BackColor = Color.LightSteelBlue;
      this.cboDisk0.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboDisk0.FormattingEnabled = true;
      this.cboDisk0.Items.AddRange(new object[17]
      {
        (object) "",
        (object) "A",
        (object) "B",
        (object) "C",
        (object) "D",
        (object) "E",
        (object) "F",
        (object) "G",
        (object) "H",
        (object) "I",
        (object) "J",
        (object) "K",
        (object) "L",
        (object) "M",
        (object) "N",
        (object) "O",
        (object) "P"
      });
      ComboBox cboDisk0_1 = this.cboDisk0;
      point1 = new Point(11, 51);
      Point point59 = point1;
      cboDisk0_1.Location = point59;
      this.cboDisk0.Name = "cboDisk0";
      ComboBox cboDisk0_2 = this.cboDisk0;
      size1 = new Size(39, 21);
      Size size59 = size1;
      cboDisk0_2.Size = size59;
      this.cboDisk0.TabIndex = 0;
      this.lblFilename0.BackColor = Color.LightSteelBlue;
      this.lblFilename0.BorderStyle = BorderStyle.FixedSingle;
      this.lblFilename0.ForeColor = Color.Black;
      Label lblFilename0_1 = this.lblFilename0;
      point1 = new Point(56, 51);
      Point point60 = point1;
      lblFilename0_1.Location = point60;
      this.lblFilename0.Name = "lblFilename0";
      Label lblFilename0_2 = this.lblFilename0;
      size1 = new Size(515, 21);
      Size size60 = size1;
      lblFilename0_2.Size = size60;
      this.lblFilename0.TabIndex = 1;
      this.lblFilename0.Text = "lblFilename0";
      this.lblFilename0.TextAlign = ContentAlignment.MiddleLeft;
      this.lblSize0.BackColor = Color.Black;
      this.lblSize0.BorderStyle = BorderStyle.FixedSingle;
      this.lblSize0.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSize0.ForeColor = Color.LimeGreen;
      Label lblSize0_1 = this.lblSize0;
      point1 = new Point(352, 78);
      Point point61 = point1;
      lblSize0_1.Location = point61;
      this.lblSize0.Name = "lblSize0";
      Label lblSize0_2 = this.lblSize0;
      size1 = new Size(27, 19);
      Size size61 = size1;
      lblSize0_2.Size = size61;
      this.lblSize0.TabIndex = 2;
      this.lblSize0.Text = "888";
      this.lblSize0.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTrackData0.BackColor = Color.Black;
      this.lblTrackData0.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblTrackData0.ForeColor = Color.LimeGreen;
      Label lblTrackData0_1 = this.lblTrackData0;
      point1 = new Point(98, 78);
      Point point62 = point1;
      lblTrackData0_1.Location = point62;
      this.lblTrackData0.Name = "lblTrackData0";
      Label lblTrackData0_2 = this.lblTrackData0;
      size1 = new Size(27, 19);
      Size size62 = size1;
      lblTrackData0_2.Size = size62;
      this.lblTrackData0.TabIndex = 31;
      this.lblTrackData0.Text = "888";
      this.lblTrackData0.TextAlign = ContentAlignment.MiddleCenter;
      this.lblSectorData0.BackColor = Color.Black;
      this.lblSectorData0.Font = new Font("Tahoma", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSectorData0.ForeColor = Color.LimeGreen;
      Label lblSectorData0_1 = this.lblSectorData0;
      point1 = new Point(174, 78);
      Point point63 = point1;
      lblSectorData0_1.Location = point63;
      this.lblSectorData0.Name = "lblSectorData0";
      Label lblSectorData0_2 = this.lblSectorData0;
      size1 = new Size(27, 19);
      Size size63 = size1;
      lblSectorData0_2.Size = size63;
      this.lblSectorData0.TabIndex = 33;
      this.lblSectorData0.Text = "888";
      this.lblSectorData0.TextAlign = ContentAlignment.MiddleCenter;
      this.lblRead0.BackColor = Color.LightSteelBlue;
      this.lblRead0.BorderStyle = BorderStyle.FixedSingle;
      this.lblRead0.ForeColor = Color.Black;
      Label lblRead0_1 = this.lblRead0;
      point1 = new Point(207, 77);
      Point point64 = point1;
      lblRead0_1.Location = point64;
      this.lblRead0.Name = "lblRead0";
      Label lblRead0_2 = this.lblRead0;
      size1 = new Size(45, 21);
      Size size64 = size1;
      lblRead0_2.Size = size64;
      this.lblRead0.TabIndex = 34;
      this.lblRead0.Text = "Read";
      this.lblRead0.TextAlign = ContentAlignment.MiddleLeft;
      this.lblReadData0.BackColor = Color.Black;
      this.lblReadData0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblReadData0.ForeColor = Color.LimeGreen;
      Label lblReadData0_1 = this.lblReadData0;
      point1 = new Point(240, 78);
      Point point65 = point1;
      lblReadData0_1.Location = point65;
      this.lblReadData0.Name = "lblReadData0";
      Label lblReadData0_2 = this.lblReadData0;
      size1 = new Size(12, 19);
      Size size65 = size1;
      lblReadData0_2.Size = size65;
      this.lblReadData0.TabIndex = 35;
      this.lblReadData0.TextAlign = ContentAlignment.MiddleCenter;
      this.lblWrite0.BackColor = Color.LightSteelBlue;
      this.lblWrite0.BorderStyle = BorderStyle.FixedSingle;
      this.lblWrite0.ForeColor = Color.Black;
      Label lblWrite0_1 = this.lblWrite0;
      point1 = new Point(258, 77);
      Point point66 = point1;
      lblWrite0_1.Location = point66;
      this.lblWrite0.Name = "lblWrite0";
      Label lblWrite0_2 = this.lblWrite0;
      size1 = new Size(45, 21);
      Size size66 = size1;
      lblWrite0_2.Size = size66;
      this.lblWrite0.TabIndex = 36;
      this.lblWrite0.Text = "Write";
      this.lblWrite0.TextAlign = ContentAlignment.MiddleLeft;
      this.lblWriteData0.BackColor = Color.Black;
      this.lblWriteData0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblWriteData0.ForeColor = Color.OrangeRed;
      Label lblWriteData0_1 = this.lblWriteData0;
      point1 = new Point(291, 78);
      Point point67 = point1;
      lblWriteData0_1.Location = point67;
      this.lblWriteData0.Name = "lblWriteData0";
      Label lblWriteData0_2 = this.lblWriteData0;
      size1 = new Size(12, 19);
      Size size67 = size1;
      lblWriteData0_2.Size = size67;
      this.lblWriteData0.TabIndex = 37;
      this.lblWriteData0.TextAlign = ContentAlignment.MiddleCenter;
      this.lblAPE.BackColor = Color.Black;
      this.lblAPE.Font = new Font("Trebuchet MS", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAPE.ForeColor = Color.White;
      this.lblAPE.ImageAlign = ContentAlignment.TopCenter;
      Label lblApe1 = this.lblAPE;
      point1 = new Point(503, 0);
      Point point68 = point1;
      lblApe1.Location = point68;
      this.lblAPE.Name = "lblAPE";
      Label lblApe2 = this.lblAPE;
      size1 = new Size(78, 42);
      Size size68 = size1;
      lblApe2.Size = size68;
      this.lblAPE.TabIndex = 66;
      this.lblAPE.Text = "ape";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(574, 301);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.lblAPE);
      this.Controls.Add((Control) this.lblTrackData3);
      this.Controls.Add((Control) this.lblTrack3);
      this.Controls.Add((Control) this.lblTrackData2);
      this.Controls.Add((Control) this.lblTrack2);
      this.Controls.Add((Control) this.lblTrackData1);
      this.Controls.Add((Control) this.lblTrack1);
      this.Controls.Add((Control) this.lblSectorData3);
      this.Controls.Add((Control) this.lblSector3);
      this.Controls.Add((Control) this.lblSectorData2);
      this.Controls.Add((Control) this.lblSector2);
      this.Controls.Add((Control) this.lblSectorData1);
      this.Controls.Add((Control) this.lblSector1);
      this.Controls.Add((Control) this.lblReadData3);
      this.Controls.Add((Control) this.lblRead3);
      this.Controls.Add((Control) this.lblReadData2);
      this.Controls.Add((Control) this.lblRead2);
      this.Controls.Add((Control) this.lblReadData1);
      this.Controls.Add((Control) this.lblRead1);
      this.Controls.Add((Control) this.lblWriteData3);
      this.Controls.Add((Control) this.lblWrite3);
      this.Controls.Add((Control) this.lblWriteData2);
      this.Controls.Add((Control) this.lblWrite2);
      this.Controls.Add((Control) this.lblWriteData1);
      this.Controls.Add((Control) this.lblWrite1);
      this.Controls.Add((Control) this.lblWriteData0);
      this.Controls.Add((Control) this.lblWrite0);
      this.Controls.Add((Control) this.lblReadData0);
      this.Controls.Add((Control) this.lblRead0);
      this.Controls.Add((Control) this.lblSectorData0);
      this.Controls.Add((Control) this.lblTrackData0);
      this.Controls.Add((Control) this.cboHandshaking);
      this.Controls.Add((Control) this.cboStopBits);
      this.Controls.Add((Control) this.cboDataBits);
      this.Controls.Add((Control) this.cboParity);
      this.Controls.Add((Control) this.cboBaudRate);
      this.Controls.Add((Control) this.cboCOMPort);
      this.Controls.Add((Control) this.btnBoot3);
      this.Controls.Add((Control) this.btnBoot2);
      this.Controls.Add((Control) this.btnBoot1);
      this.Controls.Add((Control) this.btnBoot0);
      this.Controls.Add((Control) this.lblSize3);
      this.Controls.Add((Control) this.lblSize2);
      this.Controls.Add((Control) this.lblSize1);
      this.Controls.Add((Control) this.lblSize0);
      this.Controls.Add((Control) this.btnNew3);
      this.Controls.Add((Control) this.btnNew2);
      this.Controls.Add((Control) this.btnNew1);
      this.Controls.Add((Control) this.btnNew0);
      this.Controls.Add((Control) this.btnOpen3);
      this.Controls.Add((Control) this.btnOpen2);
      this.Controls.Add((Control) this.btnOpen1);
      this.Controls.Add((Control) this.btnOpen0);
      this.Controls.Add((Control) this.lblFilename3);
      this.Controls.Add((Control) this.lblFilename2);
      this.Controls.Add((Control) this.lblFilename1);
      this.Controls.Add((Control) this.lblFilename0);
      this.Controls.Add((Control) this.cboDisk3);
      this.Controls.Add((Control) this.cboDisk2);
      this.Controls.Add((Control) this.cboDisk1);
      this.Controls.Add((Control) this.cboDisk0);
      this.Controls.Add((Control) this.lblTrack0);
      this.Controls.Add((Control) this.lblSector0);
      this.Controls.Add((Control) this.lblSectorSize0);
      this.Controls.Add((Control) this.lblSectorSize1);
      this.Controls.Add((Control) this.lblSectorSize2);
      this.Controls.Add((Control) this.lblSectorSize3);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      size1 = new Size(588, 335);
      this.MaximumSize = size1;
      size1 = new Size(588, 335);
      this.MinimumSize = size1;
      this.Name = nameof (MainForm);
      this.Text = "Altair Peripheral Emulator";
      this.ResumeLayout(false);
    }

    internal virtual ComboBox cboDisk1
    {
      [DebuggerNonUserCode] get => this._cboDisk1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboDisk1 != null)
        {
          this._cboDisk1.SelectedValueChanged -= new EventHandler(this.cboDisk1_SelectedValueChanged);
          this._cboDisk1.GotFocus -= new EventHandler(this.cboDisk1_GotFocus);
        }
        this._cboDisk1 = value;
        if (this._cboDisk1 == null)
          return;
        this._cboDisk1.SelectedValueChanged += new EventHandler(this.cboDisk1_SelectedValueChanged);
        this._cboDisk1.GotFocus += new EventHandler(this.cboDisk1_GotFocus);
      }
    }

    internal virtual ComboBox cboDisk2
    {
      [DebuggerNonUserCode] get => this._cboDisk2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboDisk2 != null)
        {
          this._cboDisk2.SelectedValueChanged -= new EventHandler(this.cboDisk2_SelectedValueChanged);
          this._cboDisk2.GotFocus -= new EventHandler(this.cboDisk2_GotFocus);
        }
        this._cboDisk2 = value;
        if (this._cboDisk2 == null)
          return;
        this._cboDisk2.SelectedValueChanged += new EventHandler(this.cboDisk2_SelectedValueChanged);
        this._cboDisk2.GotFocus += new EventHandler(this.cboDisk2_GotFocus);
      }
    }

    internal virtual ComboBox cboDisk3
    {
      [DebuggerNonUserCode] get => this._cboDisk3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboDisk3 != null)
        {
          this._cboDisk3.SelectedValueChanged -= new EventHandler(this.cboDisk3_SelectedValueChanged);
          this._cboDisk3.GotFocus -= new EventHandler(this.cboDisk3_GotFocus);
        }
        this._cboDisk3 = value;
        if (this._cboDisk3 == null)
          return;
        this._cboDisk3.SelectedValueChanged += new EventHandler(this.cboDisk3_SelectedValueChanged);
        this._cboDisk3.GotFocus += new EventHandler(this.cboDisk3_GotFocus);
      }
    }

    internal virtual Label lblFilename1
    {
      [DebuggerNonUserCode] get => this._lblFilename1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFilename1 = value;
    }

    internal virtual Label lblFilename2
    {
      [DebuggerNonUserCode] get => this._lblFilename2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFilename2 = value;
    }

    internal virtual Label lblFilename3
    {
      [DebuggerNonUserCode] get => this._lblFilename3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFilename3 = value;
    }

    internal virtual Button btnOpen0
    {
      [DebuggerNonUserCode] get => this._btnOpen0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnOpen0 != null)
          this._btnOpen0.Click -= new EventHandler(this.btnOpen_Click);
        this._btnOpen0 = value;
        if (this._btnOpen0 == null)
          return;
        this._btnOpen0.Click += new EventHandler(this.btnOpen_Click);
      }
    }

    internal virtual Button btnOpen1
    {
      [DebuggerNonUserCode] get => this._btnOpen1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnOpen1 != null)
          this._btnOpen1.Click -= new EventHandler(this.btnOpen_Click);
        this._btnOpen1 = value;
        if (this._btnOpen1 == null)
          return;
        this._btnOpen1.Click += new EventHandler(this.btnOpen_Click);
      }
    }

    internal virtual Button btnOpen2
    {
      [DebuggerNonUserCode] get => this._btnOpen2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnOpen2 != null)
          this._btnOpen2.Click -= new EventHandler(this.btnOpen_Click);
        this._btnOpen2 = value;
        if (this._btnOpen2 == null)
          return;
        this._btnOpen2.Click += new EventHandler(this.btnOpen_Click);
      }
    }

    internal virtual Button btnOpen3
    {
      [DebuggerNonUserCode] get => this._btnOpen3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnOpen3 != null)
          this._btnOpen3.Click -= new EventHandler(this.btnOpen_Click);
        this._btnOpen3 = value;
        if (this._btnOpen3 == null)
          return;
        this._btnOpen3.Click += new EventHandler(this.btnOpen_Click);
      }
    }

    internal virtual Button btnNew0
    {
      [DebuggerNonUserCode] get => this._btnNew0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnNew0 != null)
          this._btnNew0.Click -= new EventHandler(this.btnNew_Click);
        this._btnNew0 = value;
        if (this._btnNew0 == null)
          return;
        this._btnNew0.Click += new EventHandler(this.btnNew_Click);
      }
    }

    internal virtual Button btnNew1
    {
      [DebuggerNonUserCode] get => this._btnNew1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnNew1 != null)
          this._btnNew1.Click -= new EventHandler(this.btnNew_Click);
        this._btnNew1 = value;
        if (this._btnNew1 == null)
          return;
        this._btnNew1.Click += new EventHandler(this.btnNew_Click);
      }
    }

    internal virtual Button btnNew2
    {
      [DebuggerNonUserCode] get => this._btnNew2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnNew2 != null)
          this._btnNew2.Click -= new EventHandler(this.btnNew_Click);
        this._btnNew2 = value;
        if (this._btnNew2 == null)
          return;
        this._btnNew2.Click += new EventHandler(this.btnNew_Click);
      }
    }

    internal virtual Button btnNew3
    {
      [DebuggerNonUserCode] get => this._btnNew3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnNew3 != null)
          this._btnNew3.Click -= new EventHandler(this.btnNew_Click);
        this._btnNew3 = value;
        if (this._btnNew3 == null)
          return;
        this._btnNew3.Click += new EventHandler(this.btnNew_Click);
      }
    }

    internal virtual Label lblSize3
    {
      [DebuggerNonUserCode] get => this._lblSize3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSize3 = value;
    }

    internal virtual Label lblSize2
    {
      [DebuggerNonUserCode] get => this._lblSize2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSize2 = value;
    }

    internal virtual Label lblSize1
    {
      [DebuggerNonUserCode] get => this._lblSize1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSize1 = value;
    }

    internal virtual OpenFileDialog NewFileDialog
    {
      [DebuggerNonUserCode] get => this._NewFileDialog;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._NewFileDialog = value;
    }

    internal virtual Button btnBoot0
    {
      [DebuggerNonUserCode] get => this._btnBoot0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnBoot0 != null)
          this._btnBoot0.Click -= new EventHandler(this.btnBoot_Click);
        this._btnBoot0 = value;
        if (this._btnBoot0 == null)
          return;
        this._btnBoot0.Click += new EventHandler(this.btnBoot_Click);
      }
    }

    internal virtual Button btnBoot1
    {
      [DebuggerNonUserCode] get => this._btnBoot1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnBoot1 != null)
          this._btnBoot1.Click -= new EventHandler(this.btnBoot_Click);
        this._btnBoot1 = value;
        if (this._btnBoot1 == null)
          return;
        this._btnBoot1.Click += new EventHandler(this.btnBoot_Click);
      }
    }

    internal virtual Button btnBoot2
    {
      [DebuggerNonUserCode] get => this._btnBoot2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnBoot2 != null)
          this._btnBoot2.Click -= new EventHandler(this.btnBoot_Click);
        this._btnBoot2 = value;
        if (this._btnBoot2 == null)
          return;
        this._btnBoot2.Click += new EventHandler(this.btnBoot_Click);
      }
    }

    internal virtual Button btnBoot3
    {
      [DebuggerNonUserCode] get => this._btnBoot3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btnBoot3 != null)
          this._btnBoot3.Click -= new EventHandler(this.btnBoot_Click);
        this._btnBoot3 = value;
        if (this._btnBoot3 == null)
          return;
        this._btnBoot3.Click += new EventHandler(this.btnBoot_Click);
      }
    }

    internal virtual ComboBox cboCOMPort
    {
      [DebuggerNonUserCode] get => this._cboCOMPort;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboCOMPort != null)
          this._cboCOMPort.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboCOMPort = value;
        if (this._cboCOMPort == null)
          return;
        this._cboCOMPort.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual ComboBox cboBaudRate
    {
      [DebuggerNonUserCode] get => this._cboBaudRate;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboBaudRate != null)
          this._cboBaudRate.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboBaudRate = value;
        if (this._cboBaudRate == null)
          return;
        this._cboBaudRate.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual ComboBox cboParity
    {
      [DebuggerNonUserCode] get => this._cboParity;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboParity != null)
          this._cboParity.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboParity = value;
        if (this._cboParity == null)
          return;
        this._cboParity.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual ComboBox cboDataBits
    {
      [DebuggerNonUserCode] get => this._cboDataBits;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboDataBits != null)
          this._cboDataBits.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboDataBits = value;
        if (this._cboDataBits == null)
          return;
        this._cboDataBits.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual ComboBox cboStopBits
    {
      [DebuggerNonUserCode] get => this._cboStopBits;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboStopBits != null)
          this._cboStopBits.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboStopBits = value;
        if (this._cboStopBits == null)
          return;
        this._cboStopBits.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual ComboBox cboHandshaking
    {
      [DebuggerNonUserCode] get => this._cboHandshaking;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboHandshaking != null)
          this._cboHandshaking.SelectedValueChanged -= new EventHandler(this.SetupSerialPort);
        this._cboHandshaking = value;
        if (this._cboHandshaking == null)
          return;
        this._cboHandshaking.SelectedValueChanged += new EventHandler(this.SetupSerialPort);
      }
    }

    internal virtual OpenFileDialog OpenFileDialog
    {
      [DebuggerNonUserCode] get => this._OpenFileDialog;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OpenFileDialog = value;
    }

    internal virtual SerialPort SerialPort1
    {
      [DebuggerNonUserCode] get => this._SerialPort1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SerialPort1 != null)
        {
          this._SerialPort1.PinChanged -= new SerialPinChangedEventHandler(this.SerialPort1_PinChanged);
          this._SerialPort1.ErrorReceived -= new SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
          this._SerialPort1.DataReceived -= new SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
        }
        this._SerialPort1 = value;
        if (this._SerialPort1 == null)
          return;
        this._SerialPort1.PinChanged += new SerialPinChangedEventHandler(this.SerialPort1_PinChanged);
        this._SerialPort1.ErrorReceived += new SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
        this._SerialPort1.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
      }
    }

    internal virtual Label lblSectorSize1
    {
      [DebuggerNonUserCode] get => this._lblSectorSize1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorSize1 = value;
    }

    internal virtual Label lblSectorSize2
    {
      [DebuggerNonUserCode] get => this._lblSectorSize2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorSize2 = value;
    }

    internal virtual Label lblSectorSize3
    {
      [DebuggerNonUserCode] get => this._lblSectorSize3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorSize3 = value;
    }

    internal virtual Label lblWriteData1
    {
      [DebuggerNonUserCode] get => this._lblWriteData1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWriteData1 = value;
    }

    internal virtual Label lblWrite1
    {
      [DebuggerNonUserCode] get => this._lblWrite1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWrite1 = value;
    }

    internal virtual Label lblWriteData2
    {
      [DebuggerNonUserCode] get => this._lblWriteData2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWriteData2 = value;
    }

    internal virtual Label lblWrite2
    {
      [DebuggerNonUserCode] get => this._lblWrite2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWrite2 = value;
    }

    internal virtual Label lblWriteData3
    {
      [DebuggerNonUserCode] get => this._lblWriteData3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWriteData3 = value;
    }

    internal virtual Label lblWrite3
    {
      [DebuggerNonUserCode] get => this._lblWrite3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWrite3 = value;
    }

    internal virtual Label lblReadData1
    {
      [DebuggerNonUserCode] get => this._lblReadData1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblReadData1 = value;
    }

    internal virtual Label lblRead1
    {
      [DebuggerNonUserCode] get => this._lblRead1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblRead1 = value;
    }

    internal virtual Label lblReadData2
    {
      [DebuggerNonUserCode] get => this._lblReadData2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblReadData2 = value;
    }

    internal virtual Label lblRead2
    {
      [DebuggerNonUserCode] get => this._lblRead2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblRead2 = value;
    }

    internal virtual Label lblReadData3
    {
      [DebuggerNonUserCode] get => this._lblReadData3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblReadData3 = value;
    }

    internal virtual Label lblRead3
    {
      [DebuggerNonUserCode] get => this._lblRead3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblRead3 = value;
    }

    internal virtual Label lblSectorData1
    {
      [DebuggerNonUserCode] get => this._lblSectorData1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorData1 = value;
    }

    internal virtual Label lblSector1
    {
      [DebuggerNonUserCode] get => this._lblSector1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSector1 = value;
    }

    internal virtual Label lblSectorData2
    {
      [DebuggerNonUserCode] get => this._lblSectorData2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorData2 = value;
    }

    internal virtual Label lblSector2
    {
      [DebuggerNonUserCode] get => this._lblSector2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSector2 = value;
    }

    internal virtual Label lblSectorData3
    {
      [DebuggerNonUserCode] get => this._lblSectorData3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorData3 = value;
    }

    internal virtual Label lblSector3
    {
      [DebuggerNonUserCode] get => this._lblSector3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSector3 = value;
    }

    internal virtual Label lblTrackData1
    {
      [DebuggerNonUserCode] get => this._lblTrackData1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrackData1 = value;
    }

    internal virtual Label lblTrack1
    {
      [DebuggerNonUserCode] get => this._lblTrack1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrack1 = value;
    }

    internal virtual Label lblTrackData2
    {
      [DebuggerNonUserCode] get => this._lblTrackData2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrackData2 = value;
    }

    internal virtual Label lblTrack2
    {
      [DebuggerNonUserCode] get => this._lblTrack2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrack2 = value;
    }

    internal virtual Label lblTrackData3
    {
      [DebuggerNonUserCode] get => this._lblTrackData3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrackData3 = value;
    }

    internal virtual Label lblTrack3
    {
      [DebuggerNonUserCode] get => this._lblTrack3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrack3 = value;
    }

    internal virtual Label lblSectorSize0
    {
      [DebuggerNonUserCode] get => this._lblSectorSize0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorSize0 = value;
    }

    internal virtual Label lblSector0
    {
      [DebuggerNonUserCode] get => this._lblSector0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSector0 = value;
    }

    internal virtual Label lblTrack0
    {
      [DebuggerNonUserCode] get => this._lblTrack0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrack0 = value;
    }

    internal virtual ComboBox cboDisk0
    {
      [DebuggerNonUserCode] get => this._cboDisk0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._cboDisk0 != null)
        {
          this._cboDisk0.SelectedValueChanged -= new EventHandler(this.cboDisk0_SelectedValueChanged);
          this._cboDisk0.GotFocus -= new EventHandler(this.cboDisk0_GotFocus);
        }
        this._cboDisk0 = value;
        if (this._cboDisk0 == null)
          return;
        this._cboDisk0.SelectedValueChanged += new EventHandler(this.cboDisk0_SelectedValueChanged);
        this._cboDisk0.GotFocus += new EventHandler(this.cboDisk0_GotFocus);
      }
    }

    internal virtual Label lblFilename0
    {
      [DebuggerNonUserCode] get => this._lblFilename0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFilename0 = value;
    }

    internal virtual Label lblSize0
    {
      [DebuggerNonUserCode] get => this._lblSize0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSize0 = value;
    }

    internal virtual Label lblTrackData0
    {
      [DebuggerNonUserCode] get => this._lblTrackData0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTrackData0 = value;
    }

    internal virtual Label lblSectorData0
    {
      [DebuggerNonUserCode] get => this._lblSectorData0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSectorData0 = value;
    }

    internal virtual Label lblRead0
    {
      [DebuggerNonUserCode] get => this._lblRead0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblRead0 = value;
    }

    internal virtual Label lblReadData0
    {
      [DebuggerNonUserCode] get => this._lblReadData0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblReadData0 = value;
    }

    internal virtual Label lblWrite0
    {
      [DebuggerNonUserCode] get => this._lblWrite0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWrite0 = value;
    }

    internal virtual Label lblWriteData0
    {
      [DebuggerNonUserCode] get => this._lblWriteData0;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWriteData0 = value;
    }

    internal virtual Label lblAPE
    {
      [DebuggerNonUserCode] get => this._lblAPE;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._lblAPE != null)
          this._lblAPE.Click -= new EventHandler(this.Label1_Click);
        this._lblAPE = value;
        if (this._lblAPE == null)
          return;
        this._lblAPE.Click += new EventHandler(this.Label1_Click);
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.lblFilename0.Text = "";
      this.lblFilename1.Text = "";
      this.lblFilename2.Text = "";
      this.lblFilename3.Text = "";
      this.lblSize0.Text = "";
      this.lblSize1.Text = "";
      this.lblSize2.Text = "";
      this.lblSize3.Text = "";
      ComboBox cboComPort = this.cboCOMPort;
      string[] portNames = SerialPort.GetPortNames();
      int index = 0;
      while (index < portNames.Length)
      {
        string str = portNames[index];
        cboComPort.Items.Add((object) str);
        checked { ++index; }
      }
      this.cboBaudRate.Text = "19200";
      this.cboParity.Text = "None";
      this.cboDataBits.Text = "8";
      this.cboStopBits.Text = "1";
      this.cboHandshaking.Text = "RTS";
      this.lblTrackData0.Text = "";
      this.lblSectorData0.Text = "";
      this.lblReadData0.Text = "●";
      this.lblReadData0.ForeColor = Color.Black;
      this.lblWriteData0.Text = "●";
      this.lblWriteData0.ForeColor = Color.Black;
      this.lblTrackData1.Text = "";
      this.lblSectorData1.Text = "";
      this.lblReadData1.Text = "●";
      this.lblReadData1.ForeColor = Color.Black;
      this.lblWriteData1.Text = "●";
      this.lblWriteData1.ForeColor = Color.Black;
      this.lblTrackData2.Text = "";
      this.lblSectorData2.Text = "";
      this.lblReadData2.Text = "●";
      this.lblReadData2.ForeColor = Color.Black;
      this.lblWriteData2.Text = "●";
      this.lblWriteData2.ForeColor = Color.Black;
      this.lblTrackData3.Text = "";
      this.lblSectorData3.Text = "";
      this.lblReadData3.Text = "●";
      this.lblReadData3.ForeColor = Color.Black;
      this.lblWriteData3.Text = "●";
      this.lblWriteData3.ForeColor = Color.Black;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      switch (e.CloseReason)
      {
        case CloseReason.UserClosing:
          e.Cancel = Interaction.MsgBox((object) "Do you want to close?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, (object) this.Text) == MsgBoxResult.No;
          break;
      }
      if (e.Cancel)
        return;
      this.SelectedDisk = (APEFileClass) null;
      if (this.Disk0 != null)
        this.Disk0.Close();
      if (this.Disk1 != null)
        this.Disk1.Close();
      if (this.Disk2 != null)
        this.Disk2.Close();
      if (this.Disk3 != null)
        this.Disk3.Close();
      SerialPort serialPort1 = this.SerialPort1;
      if (serialPort1.IsOpen)
        serialPort1.Close();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      string name1 = button.Name;
      if (Operators.CompareString(name1, this.btnNew0.Name, false) == 0)
        this.NewFileDialog.FileName = "Untitled_0.ape";
      else if (Operators.CompareString(name1, this.btnNew1.Name, false) == 0)
        this.NewFileDialog.FileName = "Untitled_1.ape";
      else if (Operators.CompareString(name1, this.btnNew2.Name, false) == 0)
        this.NewFileDialog.FileName = "Untitled_2.ape";
      else if (Operators.CompareString(name1, this.btnNew3.Name, false) == 0)
        this.NewFileDialog.FileName = "Untitled_3.ape";
      switch (this.NewFileDialog.ShowDialog((IWin32Window) this))
      {
        case DialogResult.OK:
          bool flag = false;
          if (MyProject.Computer.FileSystem.FileExists(this.NewFileDialog.FileName))
          {
            switch (Interaction.MsgBox((object) (this.NewFileDialog.FileName + " already exists.\r\nDo you want to replace it?"), MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2, (object) this.Text))
            {
              case MsgBoxResult.Yes:
                flag = true;
                break;
            }
          }
          else
            flag = true;
          if (!flag)
            break;
          string name2 = button.Name;
          if (Operators.CompareString(name2, this.btnNew0.Name, false) == 0)
          {
            this.Disk0 = new APEFileClass(this.NewFileDialog.FileName, Conversions.ToUShort(Interaction.IIf(MyProject.Forms.SectorSizeForm.ShowDialog() == DialogResult.Yes, (object) 128, (object) 512)));
            this.lblTrackData0.Text = "";
            this.lblSectorData0.Text = "";
            this.lblReadData0.ForeColor = Color.Black;
            this.lblWriteData0.ForeColor = Color.Black;
            APEFileClass disk0 = this.Disk0;
            disk0.TrackLabel = this.lblTrackData0;
            disk0.SectorLabel = this.lblSectorData0;
            disk0.ReadLabel = this.lblReadData0;
            disk0.WriteLabel = this.lblWriteData0;
            if (this.Disk0.Format())
            {
              if (this.Disk0.Open())
              {
                this.lblFilename0.Text = this.Disk0.Filename;
                this.lblSize0.Text = this.Disk0.SectorSize.ToString();
              }
              else
              {
                int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
                this.cboDisk0.Text = " ";
              }
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to format.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk0.Text = " ";
            }
            this.btnOpen0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
            this.btnNew0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
            this.btnBoot0.Enabled = Operators.CompareString(this.cboDisk0.Text, "A", false) == 0 & Strings.Len(this.lblFilename0.Text) > 0;
            break;
          }
          if (Operators.CompareString(name2, this.btnNew1.Name, false) == 0)
          {
            this.Disk1 = new APEFileClass(this.NewFileDialog.FileName, Conversions.ToUShort(Interaction.IIf(MyProject.Forms.SectorSizeForm.ShowDialog() == DialogResult.Yes, (object) 128, (object) 512)));
            this.lblTrackData1.Text = "";
            this.lblSectorData1.Text = "";
            this.lblReadData1.ForeColor = Color.Black;
            this.lblWriteData1.ForeColor = Color.Black;
            APEFileClass disk1 = this.Disk1;
            disk1.TrackLabel = this.lblTrackData1;
            disk1.SectorLabel = this.lblSectorData1;
            disk1.ReadLabel = this.lblReadData1;
            disk1.WriteLabel = this.lblWriteData1;
            if (this.Disk1.Format())
            {
              if (this.Disk1.Open())
              {
                this.lblFilename1.Text = this.Disk1.Filename;
                this.lblSize1.Text = this.Disk1.SectorSize.ToString();
              }
              else
              {
                int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
                this.cboDisk1.Text = " ";
              }
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to format.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk1.Text = " ";
            }
            this.btnOpen1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
            this.btnNew1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
            this.btnBoot1.Enabled = Operators.CompareString(this.cboDisk1.Text, "A", false) == 0 & Strings.Len(this.lblFilename1.Text) > 0;
            break;
          }
          if (Operators.CompareString(name2, this.btnNew2.Name, false) == 0)
          {
            this.Disk2 = new APEFileClass(this.NewFileDialog.FileName, Conversions.ToUShort(Interaction.IIf(MyProject.Forms.SectorSizeForm.ShowDialog() == DialogResult.Yes, (object) 128, (object) 512)));
            this.lblTrackData2.Text = "";
            this.lblSectorData2.Text = "";
            this.lblReadData2.ForeColor = Color.Black;
            this.lblWriteData2.ForeColor = Color.Black;
            APEFileClass disk2 = this.Disk2;
            disk2.TrackLabel = this.lblTrackData2;
            disk2.SectorLabel = this.lblSectorData2;
            disk2.ReadLabel = this.lblReadData2;
            disk2.WriteLabel = this.lblWriteData2;
            if (this.Disk2.Format())
            {
              if (this.Disk2.Open())
              {
                this.lblFilename2.Text = this.Disk2.Filename;
                this.lblSize2.Text = this.Disk2.SectorSize.ToString();
              }
              else
              {
                int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
                this.cboDisk2.Text = " ";
              }
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to format.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk2.Text = " ";
            }
            this.btnOpen2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
            this.btnNew2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
            this.btnBoot2.Enabled = Operators.CompareString(this.cboDisk2.Text, "A", false) == 0 & Strings.Len(this.lblFilename2.Text) > 0;
            break;
          }
          if (Operators.CompareString(name2, this.btnNew3.Name, false) != 0)
            break;
          this.Disk3 = new APEFileClass(this.NewFileDialog.FileName, Conversions.ToUShort(Interaction.IIf(MyProject.Forms.SectorSizeForm.ShowDialog() == DialogResult.Yes, (object) 128, (object) 512)));
          this.lblTrackData3.Text = "";
          this.lblSectorData3.Text = "";
          this.lblReadData3.ForeColor = Color.Black;
          this.lblWriteData3.ForeColor = Color.Black;
          APEFileClass disk3 = this.Disk3;
          disk3.TrackLabel = this.lblTrackData3;
          disk3.SectorLabel = this.lblSectorData3;
          disk3.ReadLabel = this.lblReadData3;
          disk3.WriteLabel = this.lblWriteData3;
          if (this.Disk3.Format())
          {
            if (this.Disk3.Open())
            {
              this.lblFilename3.Text = this.Disk3.Filename;
              this.lblSize3.Text = this.Disk3.SectorSize.ToString();
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk3.Text = " ";
            }
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) "Disk failed to format.", MsgBoxStyle.Critical, (object) this.Text);
            this.cboDisk3.Text = " ";
          }
          this.btnOpen3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
          this.btnNew3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
          this.btnBoot3.Enabled = Operators.CompareString(this.cboDisk3.Text, "A", false) == 0 & Strings.Len(this.lblFilename3.Text) > 0;
          break;
      }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      switch (this.OpenFileDialog.ShowDialog((IWin32Window) this))
      {
        case DialogResult.OK:
          string name = button.Name;
          if (Operators.CompareString(name, this.btnOpen0.Name, false) == 0)
          {
            this.Disk0 = new APEFileClass(this.OpenFileDialog.FileName);
            this.lblTrackData0.Text = "";
            this.lblSectorData0.Text = "";
            this.lblReadData0.ForeColor = Color.Black;
            this.lblWriteData0.ForeColor = Color.Black;
            APEFileClass disk0 = this.Disk0;
            disk0.TrackLabel = this.lblTrackData0;
            disk0.SectorLabel = this.lblSectorData0;
            disk0.ReadLabel = this.lblReadData0;
            disk0.WriteLabel = this.lblWriteData0;
            if (this.Disk0.Open())
            {
              this.lblFilename0.Text = this.Disk0.Filename;
              this.lblSize0.Text = this.Disk0.SectorSize.ToString();
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk0.Text = " ";
            }
            this.btnOpen0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
            this.btnNew0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
            this.btnBoot0.Enabled = Operators.CompareString(this.cboDisk0.Text, "A", false) == 0 & Strings.Len(this.lblFilename0.Text) > 0;
            break;
          }
          if (Operators.CompareString(name, this.btnOpen1.Name, false) == 0)
          {
            this.Disk1 = new APEFileClass(this.OpenFileDialog.FileName);
            this.lblTrackData1.Text = "";
            this.lblSectorData1.Text = "";
            this.lblReadData1.ForeColor = Color.Black;
            this.lblWriteData1.ForeColor = Color.Black;
            APEFileClass disk1 = this.Disk1;
            disk1.TrackLabel = this.lblTrackData1;
            disk1.SectorLabel = this.lblSectorData1;
            disk1.ReadLabel = this.lblReadData1;
            disk1.WriteLabel = this.lblWriteData1;
            if (this.Disk1.Open())
            {
              this.lblFilename1.Text = this.Disk1.Filename;
              this.lblSize1.Text = this.Disk1.SectorSize.ToString();
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk1.Text = " ";
            }
            this.btnOpen1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
            this.btnNew1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
            this.btnBoot1.Enabled = Operators.CompareString(this.cboDisk1.Text, "A", false) == 0 & Strings.Len(this.lblFilename1.Text) > 0;
            break;
          }
          if (Operators.CompareString(name, this.btnOpen2.Name, false) == 0)
          {
            this.Disk2 = new APEFileClass(this.OpenFileDialog.FileName);
            this.lblTrackData2.Text = "";
            this.lblSectorData2.Text = "";
            this.lblReadData2.ForeColor = Color.Black;
            this.lblWriteData2.ForeColor = Color.Black;
            APEFileClass disk2 = this.Disk2;
            disk2.TrackLabel = this.lblTrackData2;
            disk2.SectorLabel = this.lblSectorData2;
            disk2.ReadLabel = this.lblReadData2;
            disk2.WriteLabel = this.lblWriteData2;
            if (this.Disk2.Open())
            {
              this.lblFilename2.Text = this.Disk2.Filename;
              this.lblSize2.Text = this.Disk2.SectorSize.ToString();
            }
            else
            {
              int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
              this.cboDisk2.Text = " ";
            }
            this.btnOpen2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
            this.btnNew2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
            this.btnBoot2.Enabled = Operators.CompareString(this.cboDisk2.Text, "A", false) == 0 & Strings.Len(this.lblFilename2.Text) > 0;
            break;
          }
          if (Operators.CompareString(name, this.btnOpen3.Name, false) != 0)
            break;
          this.Disk3 = new APEFileClass(this.OpenFileDialog.FileName);
          this.lblTrackData3.Text = "";
          this.lblSectorData3.Text = "";
          this.lblReadData3.ForeColor = Color.Black;
          this.lblWriteData3.ForeColor = Color.Black;
          APEFileClass disk3 = this.Disk3;
          disk3.TrackLabel = this.lblTrackData3;
          disk3.SectorLabel = this.lblSectorData3;
          disk3.ReadLabel = this.lblReadData3;
          disk3.WriteLabel = this.lblWriteData3;
          if (this.Disk3.Open())
          {
            this.lblFilename3.Text = this.Disk3.Filename;
            this.lblSize3.Text = this.Disk3.SectorSize.ToString();
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) "Disk failed to open.", MsgBoxStyle.Critical, (object) this.Text);
            this.cboDisk3.Text = " ";
          }
          this.btnOpen3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
          this.btnNew3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
          this.btnBoot3.Enabled = Operators.CompareString(this.cboDisk3.Text, "A", false) == 0 & Strings.Len(this.lblFilename3.Text) > 0;
          break;
      }
    }

    private void btnBoot_Click(object sender, EventArgs e)
    {
      switch (Interaction.MsgBox((object) "Send Boot Sector?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, (object) this.Text))
      {
        case MsgBoxResult.No:
          break;
        default:
          if (Operators.CompareString(this.cboDisk0.Text, "A", false) == 0)
          {
            if (this.Disk0 != null)
              this.SelectedDisk = this.Disk0;
          }
          else if (Operators.CompareString(this.cboDisk1.Text, "A", false) == 0)
          {
            if (this.Disk1 != null)
              this.SelectedDisk = this.Disk1;
          }
          else if (Operators.CompareString(this.cboDisk2.Text, "A", false) == 0)
          {
            if (this.Disk2 != null)
              this.SelectedDisk = this.Disk2;
          }
          else if (Operators.CompareString(this.cboDisk3.Text, "A", false) == 0 && this.Disk3 != null)
            this.SelectedDisk = this.Disk3;
          if (this.SelectedDisk == null)
            break;
          this.SelectedDisk.Track = 0;
          this.SelectedDisk.Sector = 1;
          byte[] SectorData = new byte[128];
          if (this.SelectedDisk.Read(ref SectorData))
          {
            int index = 0;
            do
            {
              this.SendCharacter((int) SectorData[index]);
              checked { ++index; }
            }
            while (index <= (int) sbyte.MaxValue);
          }
          this.RXState = MainForm.RXStates.Command;
          break;
      }
    }

    private void cboDisk0_GotFocus(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (Strings.Len(comboBox.Text) == 0 | Operators.CompareString(comboBox.Text, " ", false) == 0)
      {
        comboBox.Items.Clear();
        comboBox.Items.Add((object) " ");
        int num = 0;
        do
        {
          string Right = Conversions.ToString(Strings.Chr(checked (65 + num)));
          if (Operators.CompareString(this.cboDisk1.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk2.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk3.Text, Right, false) != 0)
            comboBox.Items.Add((object) Right);
          checked { ++num; }
        }
        while (num <= 15);
      }
    }

    private void cboDisk0_SelectedValueChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.cboDisk0.Text, " ", false) == 0)
      {
        if (this.Disk0 != null)
          this.Disk0.Close();
        this.Disk0 = (APEFileClass) null;
        this.lblTrackData0.Text = "";
        this.lblSectorData0.Text = "";
        this.lblReadData0.ForeColor = Color.Black;
        this.lblWriteData0.ForeColor = Color.Black;
        this.lblFilename0.Text = "";
        this.lblSize0.Text = "";
      }
      this.btnOpen0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
      this.btnNew0.Enabled = Operators.CompareString(this.cboDisk0.Text, " ", false) != 0 & Strings.Len(this.lblFilename0.Text) == 0;
      this.btnBoot0.Enabled = Operators.CompareString(this.cboDisk0.Text, "A", false) == 0 & Strings.Len(this.lblFilename0.Text) > 0;
    }

    private void cboDisk1_GotFocus(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (Strings.Len(comboBox.Text) == 0 | Operators.CompareString(comboBox.Text, " ", false) == 0)
      {
        comboBox.Items.Clear();
        comboBox.Items.Add((object) " ");
        int num = 0;
        do
        {
          string Right = Conversions.ToString(Strings.Chr(checked (65 + num)));
          if (Operators.CompareString(this.cboDisk0.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk2.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk3.Text, Right, false) != 0)
            comboBox.Items.Add((object) Right);
          checked { ++num; }
        }
        while (num <= 15);
      }
    }

    private void cboDisk1_SelectedValueChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.cboDisk1.Text, " ", false) == 0)
      {
        if (this.Disk1 != null)
          this.Disk1.Close();
        this.Disk1 = (APEFileClass) null;
        this.lblTrackData1.Text = "";
        this.lblSectorData1.Text = "";
        this.lblReadData1.ForeColor = Color.Black;
        this.lblWriteData1.ForeColor = Color.Black;
        this.lblFilename1.Text = "";
        this.lblSize1.Text = "";
      }
      this.btnOpen1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
      this.btnNew1.Enabled = Operators.CompareString(this.cboDisk1.Text, " ", false) != 0 & Strings.Len(this.lblFilename1.Text) == 0;
      this.btnBoot1.Enabled = Operators.CompareString(this.cboDisk1.Text, "A", false) == 0 & Strings.Len(this.lblFilename1.Text) > 0;
    }

    private void cboDisk2_GotFocus(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (Strings.Len(comboBox.Text) == 0 | Operators.CompareString(comboBox.Text, " ", false) == 0)
      {
        comboBox.Items.Clear();
        comboBox.Items.Add((object) " ");
        int num = 0;
        do
        {
          string Right = Conversions.ToString(Strings.Chr(checked (65 + num)));
          if (Operators.CompareString(this.cboDisk0.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk1.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk3.Text, Right, false) != 0)
            comboBox.Items.Add((object) Right);
          checked { ++num; }
        }
        while (num <= 15);
      }
    }

    private void cboDisk2_SelectedValueChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.cboDisk2.Text, " ", false) == 0)
      {
        if (this.Disk2 != null)
          this.Disk2.Close();
        this.Disk2 = (APEFileClass) null;
        this.lblTrackData2.Text = "";
        this.lblSectorData2.Text = "";
        this.lblReadData2.ForeColor = Color.Black;
        this.lblWriteData2.ForeColor = Color.Black;
        this.lblFilename2.Text = "";
        this.lblSize2.Text = "";
      }
      this.btnOpen2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
      this.btnNew2.Enabled = Operators.CompareString(this.cboDisk2.Text, " ", false) != 0 & Strings.Len(this.lblFilename2.Text) == 0;
      this.btnBoot2.Enabled = Operators.CompareString(this.cboDisk2.Text, "A", false) == 0 & Strings.Len(this.lblFilename2.Text) > 0;
    }

    private void cboDisk3_GotFocus(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (Strings.Len(comboBox.Text) == 0 | Operators.CompareString(comboBox.Text, " ", false) == 0)
      {
        comboBox.Items.Clear();
        comboBox.Items.Add((object) " ");
        int num = 0;
        do
        {
          string Right = Conversions.ToString(Strings.Chr(checked (65 + num)));
          if (Operators.CompareString(this.cboDisk0.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk1.Text, Right, false) != 0 & Operators.CompareString(this.cboDisk2.Text, Right, false) != 0)
            comboBox.Items.Add((object) Right);
          checked { ++num; }
        }
        while (num <= 15);
      }
    }

    private void cboDisk3_SelectedValueChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.cboDisk3.Text, " ", false) == 0)
      {
        if (this.Disk3 != null)
          this.Disk3.Close();
        this.Disk3 = (APEFileClass) null;
        this.lblTrackData3.Text = "";
        this.lblSectorData3.Text = "";
        this.lblReadData3.ForeColor = Color.Black;
        this.lblWriteData3.ForeColor = Color.Black;
        this.lblFilename3.Text = "";
        this.lblSize3.Text = "";
      }
      this.btnOpen3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
      this.btnNew3.Enabled = Operators.CompareString(this.cboDisk3.Text, " ", false) != 0 & Strings.Len(this.lblFilename3.Text) == 0;
      this.btnBoot3.Enabled = Operators.CompareString(this.cboDisk3.Text, "A", false) == 0 & Strings.Len(this.lblFilename3.Text) > 0;
    }

    private void RXCharacter(int ASCIICode)
    {
      switch (this.RXState)
      {
        case MainForm.RXStates.Command:
          this.RXCommand = Strings.Chr(ASCIICode);
          this.RXChecksum = checked ((ushort) ASCIICode);
          this.RXState = MainForm.RXStates.Data;
          break;
        case MainForm.RXStates.Data:
          this.RXData = ASCIICode;
          this.RXChecksum = checked ((ushort) ((int) (ushort) unchecked ((int) this.RXChecksum + (int) checked ((ushort) ASCIICode)) & (int) byte.MaxValue));
          this.RXState = MainForm.RXStates.Checksum;
          break;
        case MainForm.RXStates.Checksum:
          this.RXChecksum = checked ((ushort) ((int) (ushort) unchecked ((int) this.RXChecksum + (int) checked ((ushort) ASCIICode)) & (int) byte.MaxValue));
          if (this.RXChecksum != (ushort) 0)
          {
            this.SendCharacter(78);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.ProcessRXCommand();
          break;
        case MainForm.RXStates.WriteData:
          if (this.SelectedDisk == null)
            break;
          this.RXWriteData[this.RXWriteIndex] = checked ((byte) ASCIICode);
          this.RXChecksum = checked ((ushort) ((int) (ushort) unchecked ((int) this.RXChecksum + (int) checked ((ushort) ASCIICode)) & (int) byte.MaxValue));
          checked { ++this.RXWriteIndex; }
          checked { --this.RXWriteCount; }
          if (this.RXWriteCount > 0)
          {
            this.RXState = MainForm.RXStates.WriteData;
            break;
          }
          if (this.RXChecksum != (ushort) 0)
          {
            this.SendCharacter(78);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.RXWriteData = (byte[]) Utils.CopyArray((Array) this.RXWriteData, (Array) new byte[checked ((int) this.SelectedDisk.SectorSize - 1 + 1)]);
          if (this.SelectedDisk.Write(ref this.RXWriteData))
          {
            this.SendCharacter(65);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
      }
    }

    private void ProcessRXCommand()
    {
      switch (this.RXCommand)
      {
        case 'B':
          if (Operators.CompareString(this.cboDisk0.Text, "A", false) == 0)
          {
            if (this.Disk0 != null)
              this.SelectedDisk = this.Disk0;
          }
          else if (Operators.CompareString(this.cboDisk1.Text, "A", false) == 0)
          {
            if (this.Disk1 != null)
              this.SelectedDisk = this.Disk1;
          }
          else if (Operators.CompareString(this.cboDisk2.Text, "A", false) == 0)
          {
            if (this.Disk2 != null)
              this.SelectedDisk = this.Disk2;
          }
          else if (Operators.CompareString(this.cboDisk3.Text, "A", false) == 0 && this.Disk3 != null)
            this.SelectedDisk = this.Disk3;
          if (this.SelectedDisk != null)
          {
            int num1;
            switch (this.SelectedDisk.SectorSize)
            {
              case 128:
                num1 = checked (this.SelectedDisk.SectorsPerTrack - 1 + this.SelectedDisk.SectorsPerTrack);
                break;
              case 512:
                num1 = checked (4 * this.SelectedDisk.SectorsPerTrack - 1 + this.SelectedDisk.SectorsPerTrack);
                break;
            }
            int ASCIICode = checked (this.RXData + 1);
            if (ASCIICode >= num1)
              ASCIICode = 0;
            switch (this.SelectedDisk.SectorSize)
            {
              case 128:
                if (this.RXData < checked (this.SelectedDisk.SectorsPerTrack - 1))
                {
                  this.SelectedDisk.Track = 0;
                  this.SelectedDisk.Sector = checked (this.RXData + 1 + 1);
                }
                else
                {
                  this.SelectedDisk.Track = 1;
                  this.SelectedDisk.Sector = checked (this.RXData - (this.SelectedDisk.SectorsPerTrack - 1) + 1);
                }
                byte[] SectorData1 = new byte[checked ((int) this.SelectedDisk.SectorSize - 1 + 1)];
                if (this.SelectedDisk.Read(ref SectorData1))
                {
                  this.SendCharacter(65);
                  ushort num2 = 0;
                  this.SendCharacter(ASCIICode);
                  ushort num3 = checked ((ushort) ((int) (ushort) unchecked ((int) num2 + (int) checked ((ushort) ASCIICode)) & (int) byte.MaxValue));
                  int num4 = checked ((int) this.SelectedDisk.SectorSize - 1);
                  int index = 0;
                  while (index <= num4)
                  {
                    this.SendCharacter((int) SectorData1[index]);
                    num3 = checked ((ushort) ((int) (ushort) unchecked ((int) num3 + (int) SectorData1[index]) & (int) byte.MaxValue));
                    checked { ++index; }
                  }
                  this.SendCharacter(checked (256 - (int) num3) & (int) byte.MaxValue);
                  this.RXState = MainForm.RXStates.Command;
                  return;
                }
                this.SendCharacter(78);
                this.RXState = MainForm.RXStates.Command;
                return;
              case 512:
                if (this.RXData < checked (4 * this.SelectedDisk.SectorsPerTrack - 1))
                {
                  this.SelectedDisk.Track = 0;
                  this.SelectedDisk.Sector = checked (unchecked (this.RXData / 4) + 1 + 1);
                }
                else
                {
                  this.SelectedDisk.Track = 1;
                  this.SelectedDisk.Sector = checked (unchecked (checked (this.RXData - 4 * (this.SelectedDisk.SectorsPerTrack - 1)) / 4) + 1);
                }
                int num5 = checked (unchecked (this.RXData % 4) * 128);
                byte[] SectorData2 = new byte[checked ((int) this.SelectedDisk.SectorSize - 1 + 1)];
                if (this.SelectedDisk.Read(ref SectorData2))
                {
                  this.SendCharacter(65);
                  ushort num2 = 0;
                  this.SendCharacter(ASCIICode);
                  ushort num3 = checked ((ushort) ((int) (ushort) unchecked ((int) num2 + (int) checked ((ushort) ASCIICode)) & (int) byte.MaxValue));
                  int num4 = checked (0 + num5);
                  int num6 = checked ((int) sbyte.MaxValue + num5);
                  int index = num4;
                  while (index <= num6)
                  {
                    this.SendCharacter((int) SectorData2[index]);
                    num3 = checked ((ushort) ((int) (ushort) unchecked ((int) num3 + (int) SectorData2[index]) & (int) byte.MaxValue));
                    checked { ++index; }
                  }
                  this.SendCharacter(checked (256 - (int) num3) & (int) byte.MaxValue);
                  this.RXState = MainForm.RXStates.Command;
                  return;
                }
                this.SendCharacter(78);
                this.RXState = MainForm.RXStates.Command;
                return;
              default:
                return;
            }
          }
          else
          {
            this.SendCharacter(78);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
        case 'D':
          this.SelectedDisk = (APEFileClass) null;
          if (Operators.CompareString(this.cboDisk0.Text, Conversions.ToString(Strings.Chr(this.RXData)), false) == 0)
          {
            if (this.Disk0 != null)
              this.SelectedDisk = this.Disk0;
          }
          else if (Operators.CompareString(this.cboDisk1.Text, Conversions.ToString(Strings.Chr(this.RXData)), false) == 0)
          {
            if (this.Disk1 != null)
              this.SelectedDisk = this.Disk1;
          }
          else if (Operators.CompareString(this.cboDisk2.Text, Conversions.ToString(Strings.Chr(this.RXData)), false) == 0)
          {
            if (this.Disk2 != null)
              this.SelectedDisk = this.Disk2;
          }
          else if (Operators.CompareString(this.cboDisk3.Text, Conversions.ToString(Strings.Chr(this.RXData)), false) == 0 && this.Disk3 != null)
            this.SelectedDisk = this.Disk3;
          if (this.SelectedDisk != null)
          {
            this.SendCharacter(65);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
        case 'G':
          if (this.SelectedDisk != null)
          {
            switch (this.SelectedDisk.SectorSize)
            {
              case 128:
                this.SendCharacter(65);
                this.SendCharacter(0);
                this.SendCharacter(0);
                this.RXState = MainForm.RXStates.Command;
                return;
              case 512:
                this.SendCharacter(65);
                this.SendCharacter(1);
                this.SendCharacter((int) byte.MaxValue);
                this.RXState = MainForm.RXStates.Command;
                return;
              default:
                return;
            }
          }
          else
          {
            this.SendCharacter(78);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
        case 'R':
          if (this.SelectedDisk != null)
          {
            byte[] SectorData = new byte[checked ((int) this.SelectedDisk.SectorSize - 1 + 1)];
            if (this.SelectedDisk.Read(ref SectorData))
            {
              this.SendCharacter(65);
              ushort num1 = 0;
              int num2 = checked ((int) this.SelectedDisk.SectorSize - 1);
              int index = 0;
              while (index <= num2)
              {
                this.SendCharacter((int) SectorData[index]);
                num1 = checked ((ushort) ((int) (ushort) unchecked ((int) num1 + (int) SectorData[index]) & (int) byte.MaxValue));
                checked { ++index; }
              }
              this.SendCharacter(checked (256 - (int) num1) & (int) byte.MaxValue);
              this.RXState = MainForm.RXStates.Command;
              break;
            }
            this.SendCharacter(78);
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
        case 'S':
          if (this.SelectedDisk != null)
          {
            this.SendCharacter(65);
            this.SelectedDisk.Sector = this.RXData;
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
        case 'T':
          if (this.SelectedDisk != null)
          {
            this.SendCharacter(65);
            this.SelectedDisk.Track = this.RXData;
            this.RXState = MainForm.RXStates.Command;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
        case 'W':
          if (this.SelectedDisk != null)
          {
            this.SendCharacter(65);
            this.RXWriteData = new byte[checked ((int) this.SelectedDisk.SectorSize + 1)];
            this.RXWriteCount = checked ((int) this.SelectedDisk.SectorSize + 1);
            this.RXWriteIndex = 0;
            this.RXChecksum = (ushort) 0;
            this.RXState = MainForm.RXStates.WriteData;
            break;
          }
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
        default:
          this.SendCharacter(78);
          this.RXState = MainForm.RXStates.Command;
          break;
      }
    }

    private void SetupSerialPort(object sender, EventArgs e)
    {
      if (Strings.Len(this.cboCOMPort.Text) <= 0 || Strings.Len(this.cboBaudRate.Text) <= 0 || (Strings.Len(this.cboParity.Text) <= 0 || Strings.Len(this.cboDataBits.Text) <= 0) || Strings.Len(this.cboStopBits.Text) <= 0)
        return;
      if (Strings.Len(this.cboHandshaking.Text) <= 0)
        return;
      try
      {
        SerialPort serialPort1 = this.SerialPort1;
        if (serialPort1.IsOpen)
          serialPort1.Close();
        serialPort1.BaudRate = Conversions.ToInteger(this.cboBaudRate.Text);
        serialPort1.DataBits = Conversions.ToInteger(this.cboDataBits.Text);
        string text1 = this.cboStopBits.Text;
        if (Operators.CompareString(text1, "1", false) == 0)
          serialPort1.StopBits = StopBits.One;
        else if (Operators.CompareString(text1, "1.5", false) == 0)
          serialPort1.StopBits = StopBits.OnePointFive;
        else if (Operators.CompareString(text1, "2", false) == 0)
          serialPort1.StopBits = StopBits.Two;
        serialPort1.ParityReplace = (byte) 63;
        string text2 = this.cboParity.Text;
        if (Operators.CompareString(text2, "None", false) == 0)
          serialPort1.Parity = Parity.None;
        else if (Operators.CompareString(text2, "Even", false) == 0)
          serialPort1.Parity = Parity.Even;
        else if (Operators.CompareString(text2, "Odd", false) == 0)
          serialPort1.Parity = Parity.Odd;
        else if (Operators.CompareString(text2, "Mark", false) == 0)
          serialPort1.Parity = Parity.Mark;
        else if (Operators.CompareString(text2, "Space", false) == 0)
          serialPort1.Parity = Parity.Space;
        serialPort1.RtsEnable = true;
        serialPort1.DtrEnable = true;
        string text3 = this.cboHandshaking.Text;
        if (Operators.CompareString(text3, "None", false) == 0)
          serialPort1.Handshake = Handshake.None;
        else if (Operators.CompareString(text3, "RTS", false) == 0)
          serialPort1.Handshake = Handshake.RequestToSend;
        else if (Operators.CompareString(text3, "XOn/XOff", false) == 0)
          serialPort1.Handshake = Handshake.XOnXOff;
        else if (Operators.CompareString(text3, "RTS & XOn/XOff", false) == 0)
          serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
        serialPort1.DiscardNull = false;
        serialPort1.Encoding = Encoding.UTF8;
        serialPort1.PortName = this.cboCOMPort.Text;
        serialPort1.Open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Serial Port failed to open.  It may be in use by another program.", MsgBoxStyle.Critical, (object) this.Text);
        ProjectData.ClearProjectError();
      }
    }

    private void SendCharacter(int ASCIICode)
    {
      SerialPort serialPort1 = this.SerialPort1;
      if (serialPort1.IsOpen)
      {
        byte[] buffer = new byte[2]
        {
          checked ((byte) ASCIICode),
          (byte) 0
        };
        serialPort1.Write(buffer, 0, 1);
      }
    }

    private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      switch (e.EventType)
      {
        case SerialData.Chars:
          while (this.SerialPort1.BytesToRead > 0)
          {
            try
            {
              this.Invoke((Delegate) new MainForm.ReceiveCharacter(this.RXCharacter), (object) this.SerialPort1.ReadByte());
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          break;
      }
    }

    private void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
    {
      switch (e.EventType)
      {
      }
    }

    private void SerialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
    {
      switch (e.EventType)
      {
      }
    }

    private void tmrRead0_Tick(object sender, EventArgs e)
    {
    }

    private void Label1_Click(object sender, EventArgs e)
    {
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(false);
      int index = 0;
      while (index < customAttributes.Length)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(customAttributes[index]);
        string name = objectValue.GetType().Name;
        if (Operators.CompareString(name, "AssemblyCompanyAttribute", false) == 0)
          str1 = ((AssemblyCompanyAttribute) objectValue).Company;
        else if (Operators.CompareString(name, "AssemblyCopyrightAttribute", false) == 0)
          str2 = ((AssemblyCopyrightAttribute) objectValue).Copyright;
        else if (Operators.CompareString(name, "AssemblyDescriptionAttribute", false) == 0)
          str3 = ((AssemblyDescriptionAttribute) objectValue).Description;
        else if (Operators.CompareString(name, "AssemblyProductAttribute", false) == 0)
          str4 = ((AssemblyProductAttribute) objectValue).Product;
        else if (Operators.CompareString(name, "AssemblyTitleAttribute", false) == 0)
          str5 = ((AssemblyTitleAttribute) objectValue).Title;
        else if (Operators.CompareString(name, "AssemblyTrademarkAttribute", false) == 0)
          str6 = ((AssemblyTrademarkAttribute) objectValue).Trademark;
        checked { ++index; }
      }
      int num = (int) Interaction.MsgBox((object) (string.Format("About {0}", (object) str5) + "\r\n\r\n" + string.Format("Version {0}", (object) str7) + "\r\n" + str4 + "\r\n" + str2 + "\r\n" + str1 + "\r\n" + str6 + "\r\n" + str3), MsgBoxStyle.Information, (object) this.Text);
    }

    private enum RXStates
    {
      Command,
      Data,
      Checksum,
      WriteData,
    }

    public delegate void ReceiveCharacter(int ASCIICode);
  }
}
