﻿// Decompiled with JetBrains decompiler
// Type: RoadFlow.Data.Interface.IWorkTime
// Assembly: RoadFlow.Data.Interface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2109DD37-8E2D-4F7C-8293-6084646C162F
// Assembly location: C:\inetpub\wwwroot\RoadFlowMvc\bin\RoadFlow.Data.Interface.dll

using RoadFlow.Data.Model;
using System;
using System.Collections.Generic;

namespace RoadFlow.Data.Interface
{
  public interface IWorkTime
  {
    int Add(WorkTime model);

    int Update(WorkTime model);

    List<WorkTime> GetAll();

    WorkTime Get(Guid id);

    int Delete(Guid id);

    long GetCount();

    List<int> GetAllYear();

    List<WorkTime> GetAll(int year);
  }
}
