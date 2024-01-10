using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RocketGame.Model
{
    public class BaseGameObject
    {
        public Dictionary<string , BaseObject> ObjectsModel = new Dictionary<string, BaseObject> ();
        public BaseObject this[string propertyName]
        {
            get
            {
                return this.ObjectsModel[propertyName];
            }
            set
            {
                if (this.ObjectsModel.ContainsKey(propertyName))
                {
                    this.ObjectsModel[propertyName] = value;
                }
                else
                {
                    this.ObjectsModel.Add(propertyName , value);
                }
            }
        }

        public Timer timer;
        public BaseGameObject()
        {
            timer = new Timer { Interval = 10 };
            timer.Tick += (o,e)=> { Tick(); };
            timer.Start();

        }
        public virtual void AppendObjects( Form1 form1 )
        {
            foreach (var item in ObjectsModel)
            {
                form1.Add(item.Value);
            }
        }
        public virtual void Tick()
        {

        }
    }
}
