﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Shape
{
    double Width { get; set; }
    double Height { get; set; }

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculateSurface()
    {
        return this.Height * this.Width;
    }
}

