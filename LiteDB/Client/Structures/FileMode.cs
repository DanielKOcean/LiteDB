﻿using LiteDB.Engine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LiteDB
{
    public enum FileMode
    {
        Shared,
        Exclusive,
        ReadOnly
    }
}