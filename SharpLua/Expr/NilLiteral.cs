﻿using System;
using System.Collections.Generic;
using System.Text;

using SharpLua.LuaTypes;

namespace SharpLua.AST
{
    public partial class NilLiteral : Term
    {
        public override LuaValue Evaluate(LuaTable enviroment)
        {
            return LuaNil.Nil;
        }
    }
}
