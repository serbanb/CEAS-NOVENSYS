﻿// Decompiled with JetBrains decompiler
// Type: Novensys.ASN1.Type.Asn1VisibleStringType
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using System;
using System.ComponentModel;

namespace Novensys.ASN1.Type
{
  [Serializable]
  public class Asn1VisibleStringType : Asn1KnownMultiplierStringType
  {
    public override string TypeName
    {
      get
      {
        return "VisibleString";
      }
    }

    public Asn1VisibleStringType()
    {
    }

    public Asn1VisibleStringType(string str)
      : base(str)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getBaseAlphabetAlignedNbBitPerChar()
    {
      return 8;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override long __getBaseAlphabetLowerBound()
    {
      return 32L;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getBaseAlphabetUnalignedNbBitPerChar()
    {
      return 7;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override long __getBaseAlphabetUpperBound()
    {
      return 126L;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getUniversalTagNumber()
    {
      return 26;
    }

    protected internal override void __setTypeValue(Asn1Type typeInstance)
    {
      if (typeInstance == null)
      {
        this.ResetType();
      }
      else
      {
        if (!(typeInstance is Asn1VisibleStringType))
          return;
        this.SetValue(((Asn1StringType) typeInstance).GetStringValue());
      }
    }

    public override bool Equals(object anObject)
    {
      return this == anObject || (anObject is Asn1VisibleStringType || anObject is Asn1ISO646StringType) && this.HasEqualValue((Asn1StringType) anObject);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
