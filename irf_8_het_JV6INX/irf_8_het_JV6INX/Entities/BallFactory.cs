﻿using irf_8_het_JV6INX.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irf_8_het_JV6INX.Entities
{
    public class BallFactory : Abstractions.IToyFactory
    {
        public Color BallColor { get; set; }
        public Abstractions.Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
