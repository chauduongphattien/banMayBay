using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shotPlanet
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private int i;

        public int I { get => i; set => i = value; }

        public UserControl1(int i)
        {
            I= i;
        }
        

      
       

        private void startbtn_Click(object sender, EventArgs e)
        {
           this.I = 1;
        }
    }
}
