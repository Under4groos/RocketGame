using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketGame.Model
{
    public struct Vector2D
    {

        
        public static readonly Vector2D Empty;
        private int x;

        private int y;
        [Browsable(false)]
        public bool IsEmpty
        {
            get
            {
                if (x == 0)
                {
                    return y == 0;
                }

                return false;
            }
        }

    
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

     
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

    
        public Vector2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        
        public Vector2D(Size sz)
        {
            x = sz.Width;
            y = sz.Height;
        }

        

      
        public static explicit operator Size(Vector2D p)
        {
            return new Size(p.X, p.Y);
        }

       
        public static Vector2D operator +(Vector2D pt, Size sz)
        {
            return Add(pt, sz);
        }
        public static Vector2D operator +(Vector2D pt, Vector2D sz)
        {
            return Add(pt, sz);
        }

        public static Vector2D operator -(Vector2D pt, Size sz)
        {
            return Subtract(pt, sz);
        }
        public static Vector2D operator -(Vector2D pt, Vector2D sz)
        {
            return Subtract(pt, sz);
        }

        public static bool operator ==(Vector2D left, Vector2D right)
        {
            if (left.X == right.X)
            {
                return left.Y == right.Y;
            }

            return false;
        }

        
        public static bool operator !=(Vector2D left, Vector2D right)
        {
            return !(left == right);
        }

       
        public static Vector2D Add(Vector2D pt, Size sz)
        {
            return new Vector2D(pt.X + sz.Width, pt.Y + sz.Height);
        }
        public static Vector2D Add(Vector2D pt, Vector2D sz)
        {
            return new Vector2D(pt.X + sz.X, pt.Y + sz.Y);
        }


        public static Vector2D Subtract(Vector2D pt, Size sz)
        {
            return new Vector2D(pt.X - sz.Width, pt.Y - sz.Height);
        }
        public static Vector2D Subtract(Vector2D pt, Vector2D sz)
        {
            return new Vector2D(pt.X - sz.X, pt.Y - sz.Y);
        }



        public static Vector2D Round(PointF value)
        {
            return new Vector2D((int)Math.Round(value.X), (int)Math.Round(value.Y));
        }

    
        public override bool Equals(object obj)
        {
            if (!(obj is Point point))
            {
                return false;
            }

            if (point.X == X)
            {
                return point.Y == Y;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return x ^ y;
        }

        public void Offset(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public void Offset(Point p)
        {
            Offset(p.X, p.Y);
        }

      
        public override string ToString()
        {
            return "{X=" + X.ToString(CultureInfo.CurrentCulture) + ",Y=" + Y.ToString(CultureInfo.CurrentCulture) + "}";
        }

      
    }
}
