﻿using GSharp.Base.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSharp.Graphic.Blocks
{
    public abstract class ObjectBlock : BaseBlock
    {
        public abstract GObject GObject { get; }

        public ObjectBlock()
        {
        }
    }
}
