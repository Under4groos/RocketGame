using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketGame.Model
{
    public class BaseObject : Panel
    {
        public Vector2D ModelPosition
        {
            get
            {
                return new Vector2D(this.Left, this.Top);
            }

            set
            {
                this.Left = value.X;
                this.Top = value.Y;
            }
        }
        public Size ModelSize
        {
            get
            {
                return new Size(this.Width, this.Height);
            }

            set
            {
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }

        public Vector2D ModelVelocity
        {
            get;set;
        }
        public int VelocitySub
        {
            get; set;
        } = 1;
        public BaseObject( bool debug = true) 
        {
            if (debug)
            {
                this.BackColor = Color.Red;
            }
            this.ModelPosition = new Vector2D(0, 0);
            this.ModelSize = new Size(50, 50);
        }

        public virtual void MoveUpdate()
        {
            
            if (ModelVelocity.X > 0)
                ModelVelocity -= new Vector2D(VelocitySub, 0);
            if (ModelVelocity.Y > 0)
                ModelVelocity -= new Vector2D(0, VelocitySub);

            if (ModelVelocity.X < 0)
                ModelVelocity += new Vector2D(VelocitySub, 0);
            if (ModelVelocity.Y < 0)
                ModelVelocity += new Vector2D(0, VelocitySub);


            this.Move(ModelVelocity.X, ModelVelocity.Y);
        }

        public virtual void Move(int x , int y)
        {
            ModelPosition += new Vector2D(x, y);
        }
    }
}
