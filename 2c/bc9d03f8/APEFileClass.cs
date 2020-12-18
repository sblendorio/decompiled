// Decompiled with JetBrains decompiler
// Type: AltairPeripheralEmulator.APEFileClass
// Assembly: AltairPeripheralEmulator, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: 120C4B5F-FE40-457E-A7C0-4D6B2A9778DF
// Assembly location: C:\Users\Nino1\Downloads\AltairPeripheralEmulator.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AltairPeripheralEmulator
{
  public class APEFileClass
  {
    private string mFilename;
    private ushort mSectorSize;
    private int mTracks;
    private int mSectorsPerTrack;
    private int mTrack;
    private int mSector;
    private FileStream fs;
    private BinaryWriter bw;
    private BinaryReader br;
    private Label mTrackLabel;
    private Label mSectorLabel;
    private Label mReadLabel;
    private Color mReadOnColor;
    private Color mReadOffColor;
    private Label mWriteLabel;
    private Color mWriteOnColor;
    private Color mWriteOffColor;

    public APEFileClass()
    {
      this.fs = (FileStream) null;
      this.bw = (BinaryWriter) null;
      this.br = (BinaryReader) null;
      this.mFilename = "";
      this.mSectorSize = (ushort) 128;
      this.mTracks = 77;
      switch (this.mSectorSize)
      {
        case 128:
          this.mSectorsPerTrack = 26;
          break;
        case 512:
          this.mSectorsPerTrack = 8;
          break;
      }
      this.mTrack = 0;
      this.mSector = 1;
      this.mTrackLabel = (Label) null;
      this.mSectorLabel = (Label) null;
      this.mReadLabel = (Label) null;
      this.mReadOnColor = Color.LimeGreen;
      this.mReadOffColor = Color.Black;
      this.mWriteLabel = (Label) null;
      this.mWriteOnColor = Color.OrangeRed;
      this.mWriteOffColor = Color.Black;
    }

    public APEFileClass(string Filename)
    {
      this.fs = (FileStream) null;
      this.bw = (BinaryWriter) null;
      this.br = (BinaryReader) null;
      this.mFilename = Filename;
      this.mSectorSize = (ushort) 128;
      this.mTracks = 77;
      switch (this.mSectorSize)
      {
        case 128:
          this.mSectorsPerTrack = 26;
          break;
        case 512:
          this.mSectorsPerTrack = 8;
          break;
      }
      this.mTrack = 0;
      this.mSector = 1;
      this.mTrackLabel = (Label) null;
      this.mSectorLabel = (Label) null;
      this.mReadLabel = (Label) null;
      this.mReadOnColor = Color.LimeGreen;
      this.mReadOffColor = Color.Black;
      this.mWriteLabel = (Label) null;
      this.mWriteOnColor = Color.OrangeRed;
      this.mWriteOffColor = Color.Black;
    }

    public APEFileClass(string Filename, ushort SectorSize)
    {
      this.fs = (FileStream) null;
      this.bw = (BinaryWriter) null;
      this.br = (BinaryReader) null;
      this.mFilename = Filename;
      this.mSectorSize = SectorSize;
      this.mTracks = 77;
      switch (this.mSectorSize)
      {
        case 128:
          this.mSectorsPerTrack = 26;
          break;
        case 512:
          this.mSectorsPerTrack = 8;
          break;
      }
      this.mTrack = 0;
      this.mSector = 1;
      this.mTrackLabel = (Label) null;
      this.mSectorLabel = (Label) null;
      this.mReadLabel = (Label) null;
      this.mReadOnColor = Color.LimeGreen;
      this.mReadOffColor = Color.Black;
      this.mWriteLabel = (Label) null;
      this.mWriteOnColor = Color.OrangeRed;
      this.mWriteOffColor = Color.Black;
    }

    public string Filename
    {
      get => this.mFilename;
      set => this.mFilename = value;
    }

    public ushort SectorSize
    {
      get => this.mSectorSize;
      set
      {
        this.mSectorSize = value;
        switch (this.mSectorSize)
        {
          case 128:
            this.mSectorsPerTrack = 26;
            break;
          case 512:
            this.mSectorsPerTrack = 8;
            break;
        }
        this.mTrack = 0;
        this.mSector = 1;
      }
    }

    public int Tracks => this.mTracks;

    public int SectorsPerTrack => this.mSectorsPerTrack;

    public int Track
    {
      get => this.mTrack;
      set
      {
        this.mTrack = value;
        if (this.mTrackLabel == null)
          return;
        this.mTrackLabel.Text = this.mTrack.ToString();
      }
    }

    public int Sector
    {
      get => this.mSector;
      set
      {
        this.mSector = value;
        if (this.mSectorLabel == null)
          return;
        this.mSectorLabel.Text = this.mSector.ToString();
      }
    }

    public bool Format()
    {
      byte[] buffer = new byte[checked ((int) this.SectorSize - 1 + 1)];
      int num1 = checked ((int) this.SectorSize - 1);
      int index = 0;
      while (index <= num1)
      {
        buffer[index] = (byte) 0;
        checked { ++index; }
      }
      bool flag;
      if (Strings.Len(this.Filename) > 0)
      {
        try
        {
          FileStream fileStream = new FileStream(this.Filename, FileMode.Create, FileAccess.Write);
          BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream);
          try
          {
            binaryWriter.Write(this.SectorSize);
            int num2 = checked (this.Tracks - 1);
            int num3 = 0;
            while (num3 <= num2)
            {
              int sectorsPerTrack = this.SectorsPerTrack;
              int num4 = 1;
              while (num4 <= sectorsPerTrack)
              {
                binaryWriter.Write(buffer);
                checked { ++num4; }
              }
              checked { ++num3; }
            }
            switch (this.SectorSize)
            {
              case 128:
                long offset1 = 6659;
                do
                {
                  fileStream.Seek(offset1, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset1 += 32L; }
                }
                while (offset1 <= 7011L);
                long offset2 = 7171;
                do
                {
                  fileStream.Seek(offset2, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset2 += 32L; }
                }
                while (offset2 <= 7267L);
                long offset3 = 7427;
                do
                {
                  fileStream.Seek(offset3, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset3 += 32L; }
                }
                while (offset3 <= 7779L);
                long offset4 = 7939;
                do
                {
                  fileStream.Seek(offset4, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset4 += 32L; }
                }
                while (offset4 <= 8035L);
                long offset5 = 8195;
                do
                {
                  fileStream.Seek(offset5, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset5 += 32L; }
                }
                while (offset5 <= 8547L);
                long offset6 = 8707;
                do
                {
                  fileStream.Seek(offset6, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset6 += 32L; }
                }
                while (offset6 <= 8803L);
                long offset7 = 8963;
                do
                {
                  fileStream.Seek(offset7, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset7 += 32L; }
                }
                while (offset7 <= 9059L);
                long offset8 = 9219;
                do
                {
                  fileStream.Seek(offset8, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset8 += 32L; }
                }
                while (offset8 <= 9315L);
                long offset9 = 9475;
                do
                {
                  fileStream.Seek(offset9, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset9 += 32L; }
                }
                while (offset9 <= 9571L);
                long offset10 = 9731;
                do
                {
                  fileStream.Seek(offset10, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset10 += 32L; }
                }
                while (offset10 <= 9827L);
                break;
              case 512:
                long offset11 = 8195;
                do
                {
                  fileStream.Seek(offset11, SeekOrigin.Begin);
                  binaryWriter.Write((byte) 229);
                  checked { offset11 += 32L; }
                }
                while (offset11 <= 10211L);
                break;
            }
            flag = true;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flag = false;
            ProjectData.ClearProjectError();
          }
          binaryWriter.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = false;
          ProjectData.ClearProjectError();
        }
      }
      else
        flag = false;
      return flag;
    }

    public bool Open()
    {
      bool flag;
      if (Strings.Len(this.Filename) > 0)
      {
        try
        {
          this.fs = new FileStream(this.Filename, FileMode.Open, FileAccess.ReadWrite);
          this.br = new BinaryReader((Stream) this.fs);
          this.bw = new BinaryWriter((Stream) this.fs);
          try
          {
            this.SectorSize = this.br.ReadUInt16();
            flag = true;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flag = false;
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = false;
          ProjectData.ClearProjectError();
        }
      }
      else
        flag = false;
      return flag;
    }

    public void Close()
    {
      try
      {
        this.bw.Close();
        this.br.Close();
        this.fs.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public bool Write(ref byte[] SectorData)
    {
      if (this.mWriteLabel != null)
        this.mWriteLabel.ForeColor = this.mWriteOnColor;
      if (this.mReadLabel != null)
        this.mReadLabel.ForeColor = this.mReadOffColor;
      bool flag;
      try
      {
        this.fs.Seek((long) checked (3 + this.Track * this.SectorsPerTrack * (int) this.SectorSize + (this.Sector - 1) * (int) this.SectorSize), SeekOrigin.Begin);
        this.bw.Write(SectorData);
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool Read(ref byte[] SectorData)
    {
      if (this.mReadLabel != null)
        this.mReadLabel.ForeColor = this.mReadOnColor;
      if (this.mWriteLabel != null)
        this.mWriteLabel.ForeColor = this.mWriteOffColor;
      bool flag;
      try
      {
        this.fs.Seek((long) checked (3 + this.Track * this.SectorsPerTrack * (int) this.SectorSize + (this.Sector - 1) * (int) this.SectorSize), SeekOrigin.Begin);
        SectorData = this.br.ReadBytes((int) this.SectorSize);
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public Label TrackLabel
    {
      get => this.mTrackLabel;
      set => this.mTrackLabel = value;
    }

    public Label SectorLabel
    {
      get => this.mSectorLabel;
      set => this.mSectorLabel = value;
    }

    public Label ReadLabel
    {
      get => this.mReadLabel;
      set => this.mReadLabel = value;
    }

    public Label WriteLabel
    {
      get => this.mWriteLabel;
      set => this.mWriteLabel = value;
    }
  }
}
