using RocketGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketGame
{
    public partial class Form1 : Form
    {
        public DelOnKeyDown KeyboardDown;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Game(this);
        }
        public void Add( Control control )
        {
            this.Controls.Add(control);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(KeyboardDown != null)
                KeyboardDown(e.KeyCode , e.KeyCode.ToString().ToLower());
        }
    }
}
