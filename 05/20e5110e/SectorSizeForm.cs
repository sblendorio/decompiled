// Decompiled with JetBrains decompiler
// Type: AltairPeripheralEmulator.SectorSizeForm
// Assembly: AltairPeripheralEmulator, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 120C4B5F-FE40-457E-A7C0-4D6B2A9778DF
// Assembly location: C:\Users\Nino1\Downloads\AltairPeripheralEmulator.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AltairPeripheralEmulator
{
  [DesignerGenerated]
  public class SectorSizeForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("btn128")]
    private Button _btn128;
    [AccessedThroughProperty("btn512")]
    private Button _btn512;

    [DebuggerNonUserCode]
    public SectorSizeForm()
    {
      this.Shown += new EventHandler(this.SectorSizeForm_Shown);
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
      this.btn128 = new Button();
      this.btn512 = new Button();
      this.SuspendLayout();
      Button btn128_1 = this.btn128;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      btn128_1.Location = point2;
      this.btn128.Name = "btn128";
      Button btn128_2 = this.btn128;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      btn128_2.Size = size2;
      this.btn128.TabIndex = 0;
      this.btn128.Text = "&128 Byte";
      this.btn128.UseVisualStyleBackColor = true;
      Button btn512_1 = this.btn512;
      point1 = new Point(93, 12);
      Point point3 = point1;
      btn512_1.Location = point3;
      this.btn512.Name = "btn512";
      Button btn512_2 = this.btn512;
      size1 = new Size(75, 23);
      Size size3 = size1;
      btn512_2.Size = size3;
      this.btn512.TabIndex = 1;
      this.btn512.Text = "&512 byte";
      this.btn512.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(182, 46);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.btn512);
      this.Controls.Add((Control) this.btn128);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.MaximizeBox = false;
      size1 = new Size(190, 80);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      size1 = new Size(190, 80);
      this.MinimumSize = size1;
      this.Name = nameof (SectorSizeForm);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select Sector Size";
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    internal virtual Button btn128
    {
      [DebuggerNonUserCode] get => this._btn128;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btn128 != null)
          this._btn128.Click -= new EventHandler(this.btn128_Click);
        this._btn128 = value;
        if (this._btn128 == null)
          return;
        this._btn128.Click += new EventHandler(this.btn128_Click);
      }
    }

    internal virtual Button btn512
    {
      [DebuggerNonUserCode] get => this._btn512;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._btn512 != null)
          this._btn512.Click -= new EventHandler(this.btn512_Click);
        this._btn512 = value;
        if (this._btn512 == null)
          return;
        this._btn512.Click += new EventHandler(this.btn512_Click);
      }
    }

    private void btn128_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Yes;
      this.Close();
    }

    private void btn512_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Close();
    }

    private void SectorSizeForm_Shown(object sender, EventArgs e) => this.btn128.Focus();
  }
}
