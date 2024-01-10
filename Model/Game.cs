using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketGame.Model
{
    internal class Game : BaseGameObject
    {
        
        public Game(Form1 form)
        {
            this["payer"] = new Player(){ ModelPosition = new Vector2D(100, 100)};
            this["BaseObject"] = new BaseObject() { ModelPosition = new Vector2D(100, 100) };



            this.AppendObjects(form);
            form.KeyboardDown += KeyDown;
        }
        public void KeyDown(Keys keys ,string keylow)
        {
            switch (keys)
            {
                case Keys.D:

                    this["payer"].ModelVelocity += new Vector2D(4, 0);

                    Debug.WriteLine(this["payer"].ModelPosition);

                    break;
                case Keys.A:

                    this["payer"].ModelVelocity -= new Vector2D(4, 0);

                   
                    break;
                default:
                    break;
            }
            
           
        }
        public override void Tick()
        {

          
            this["payer"].MoveUpdate();
            

            base.Tick();
        }
    }
}
