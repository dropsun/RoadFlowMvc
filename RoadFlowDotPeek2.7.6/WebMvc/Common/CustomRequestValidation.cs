﻿// Decompiled with JetBrains decompiler
// Type: WebMvc.Common.CustomRequestValidation
// Assembly: WebMvc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43FD7615-6DC3-49FB-B263-7F7CC91AFA77
// Assembly location: C:\inetpub\wwwroot\RoadFlowMvc\bin\WebMvc.dll

using System.Web;
using System.Web.Util;

namespace WebMvc.Common
{
  public class CustomRequestValidation : RequestValidator
  {
    protected override bool IsValidRequestString(HttpContext context, string value, RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex)
    {
      validationFailureIndex = 0;
      return true;
    }
  }
}
