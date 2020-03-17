using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tron.Engine.Common
{
    public class Change
    {
        public Color PlayerId { get; set; }

        public Direction? Direction { get; set; }

        public bool IsDead { get; set; }
    }
}
