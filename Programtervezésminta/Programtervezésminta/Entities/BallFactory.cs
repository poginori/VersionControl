﻿using Programtervezésminta.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programtervezésminta.Entities
{
    public class BallFactory: IToyFactory

    {
        public Color BallColor { get; set; }

        public Toy Createnew()
        {
            return new Ball(BallColor);
        }
    }
}
