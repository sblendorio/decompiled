// Decompiled with JetBrains decompiler
// Type: AltairPeripheralEmulator.My.MyApplication
// Assembly: AltairPeripheralEmulator, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 120C4B5F-FE40-457E-A7C0-4D6B2A9778DF
// Assembly location: C:\Users\Nino1\Downloads\AltairPeripheralEmulator.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace AltairPeripheralEmulator.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [STAThread]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = false;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.MainForm;
  }
}
