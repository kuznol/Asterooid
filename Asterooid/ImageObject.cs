﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterooid
{
     class ImageObject : VisualObject
    {
        private Image _Image;
        public ImageObject(Point Position, Point Direction, Size Size, Image Image)
            : base(Position, Direction, Size)
        {
            _Image = Image;
        }
    }
}
