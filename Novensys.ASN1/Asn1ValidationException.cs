﻿// Decompiled with JetBrains decompiler
// Type: Novensys.ASN1.Asn1ValidationException
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

namespace Novensys.ASN1
{
  public class Asn1ValidationException : Asn1Exception
  {
    public Asn1ValidationException(Asn1Exception ex)
      : base(ex)
    {
    }

    public Asn1ValidationException(int code, string info)
      : base(code, info)
    {
    }
  }
}
