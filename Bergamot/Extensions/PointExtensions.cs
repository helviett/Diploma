﻿using System;
using System.Drawing;

namespace Bergamot.Extensions
{
    public static class PointExtensions
    {
        public static Point Add(this Point self, Point other)
        {
            return new Point(self.X + other.X, self.Y + other.Y);
        }

        public static Point Sub(this Point self, Point other)
        {
            return new Point(self.X - other.X, self.Y - other.Y);
        }

        public static Point Clamp(this Point self, int x1, int x2, int y1, int y2)
        {
            return new Point(self.X.Clamp(x1, x2), self.Y.Clamp(y1, y2));
        }

        public static Point Swap(this Point self)
        {
            return new Point(self.Y, self.X);
        }

        public static Point Abs(this Point self)
        {
            return new Point(Math.Abs(self.X), Math.Abs(self.Y));
        }
    }
}
