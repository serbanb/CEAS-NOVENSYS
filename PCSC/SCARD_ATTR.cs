﻿// Decompiled with JetBrains decompiler
// Type: Novensys.eCard.SDK.PCSC.SCARD_ATTR
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

namespace Novensys.eCard.SDK.PCSC
{
  public enum SCARD_ATTR : uint
  {
    VENDOR_NAME = 65792U,
    VENDOR_IFD_TYPE = 65793U,
    VENDOR_IFD_VERSION = 65794U,
    VENDOR_IFD_SERIAL_NO = 65795U,
    CHANNEL_ID = 131344U,
    PROTOCOL_TYPES = 196896U,
    DEFAULT_CLK = 196897U,
    MAX_CLK = 196898U,
    DEFAULT_DATA_RATE = 196899U,
    MAX_DATA_RATE = 196900U,
    MAX_IFSD = 196901U,
    POWER_MGMT_SUPPORT = 262449U,
    USER_TO_CARD_AUTH_DEVICE = 328000U,
    USER_AUTH_INPUT_DEVICE = 328002U,
    CHARACTERISTICS = 393552U,
    ESC_RESET = 499712U,
    ESC_CANCEL = 499715U,
    ESC_AUTHREQUEST = 499717U,
    MAXINPUT = 499719U,
    CURRENT_PROTOCOL_TYPE = 524801U,
    CURRENT_CLK = 524802U,
    CURRENT_F = 524803U,
    CURRENT_D = 524804U,
    CURRENT_N = 524805U,
    CURRENT_W = 524806U,
    CURRENT_IFSC = 524807U,
    CURRENT_IFSD = 524808U,
    CURRENT_BWT = 524809U,
    CURRENT_CWT = 524810U,
    CURRENT_EBC_ENCODING = 524811U,
    EXTENDED_BWT = 524812U,
    ICC_PRESENCE = 590592U,
    ICC_INTERFACE_STATUS = 590593U,
    CURRENT_IO_STATE = 590594U,
    ATR_STRING = 590595U,
    ICC_TYPE_PER_ATR = 590596U,
    PERF_NUM_TRANSMISSIONS = 2147352577U,
    PERF_BYTES_TRANSMITTED = 2147352578U,
    PERF_TRANSMISSION_TIME = 2147352579U,
    DEVICE_UNIT = 2147418113U,
    DEVICE_IN_USE = 2147418114U,
    DEVICE_FRIENDLY_NAME_A = 2147418115U,
    DEVICE_SYSTEM_NAME_A = 2147418116U,
    DEVICE_FRIENDLY_NAME_W = 2147418117U,
    DEVICE_SYSTEM_NAME_W = 2147418118U,
    SUPRESS_T1_IFS_REQUEST = 2147418119U,
  }
}