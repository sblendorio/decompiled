// Decompiled with JetBrains decompiler
// Type: AltairPeripheralEmulator.My.Resources.Resources
// Assembly: AltairPeripheralEmulator, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 120C4B5F-FE40-457E-A7C0-4D6B2A9778DF
// Assembly location: C:\Users\Nino1\Downloads\AltairPeripheralEmulator.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AltairPeripheralEmulator.My.Resources
{
  [HideModuleName]
  [StandardModule]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) AltairPeripheralEmulator.My.Resources.Resources.resourceMan, (object) null))
          AltairPeripheralEmulator.My.Resources.Resources.resourceMan = new ResourceManager("AltairPeripheralEmulator.Resources", typeof (AltairPeripheralEmulator.My.Resources.Resources).Assembly);
        return AltairPeripheralEmulator.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => AltairPeripheralEmulator.My.Resources.Resources.resourceCulture;
      set => AltairPeripheralEmulator.My.Resources.Resources.resourceCulture = value;
    }
  }
}
