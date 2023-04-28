using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shotPlanet
{
    public class plane
    {
        PictureBox pic;
        int hp;
        public plane(PictureBox pic, int hp)
        {
            Pic = pic;
            Hp = hp;
           
        }
        public plane() { }

        public int Hp { get => hp; set => hp = value; }
        public PictureBox Pic { get => pic; set => pic = value; }
    }
}
