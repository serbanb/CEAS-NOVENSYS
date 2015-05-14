﻿// Decompiled with JetBrains decompiler
// Type: Novensys.eCard.SDK.ISO8583.Exceptions.UnknownFieldException
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using System;

namespace Novensys.eCard.SDK.ISO8583.Exceptions
{
  public class UnknownFieldException : ApplicationException
  {
    public string FieldNumber { get; set; }

    public UnknownFieldException(string fieldNumber)
      : base("Field " + fieldNumber + " is unknown")
    {
      this.FieldNumber = fieldNumber;
    }
  }
}