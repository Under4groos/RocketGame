using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketGame.Model
{
    public class Player : BaseObject
    {
        public Image Image { get; set; }
        public Player() 
        {
            Image = Image.FromFile("Resource/rocket.png");

            this.ResiseOnImage();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(Image , new PointF());
        }




        public void ResiseOnImage()
        {
            if(Image == null)
                return;

            ModelSize = Image.Size;
        }
    }
}
