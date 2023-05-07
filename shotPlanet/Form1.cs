
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Resources;

namespace shotPlanet
{
    public partial class Form1 : Form
    {

        public delegate int getV();

        public int start=0;
        List<Point>  points = new List<Point>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        Graphics gp;
        Brush mypen;
        List<List<plane>> planes = new List<List<plane>>();
        List<plane> planeList = new List<plane>();
        Color mycolor;
        Random rand=new Random();
        int diem = 0;
        int moc = 5;
        int hp = 2;

        PictureBox pictureBox = new PictureBox();
        int _start = 0;

        UserControl1 u1 = new UserControl1();


        public Form1()
        {

            InitializeComponent();
            gp = panel1.CreateGraphics();
            mycolor = Color.White;
            mypen=new SolidBrush(mycolor);
            this.KeyPreview = true;
            pictureBox = planet;
            for(int i = 0; i < 5; i++)
            {
                List<plane> pl = new List<plane>();
                planes.Add(pl);
            }

            
            panel1.Controls.Add(u1);
           



          

        }

        

        private void Form1_Activated(object sender, EventArgs e)
        {

           
                
             

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point p = planet.Location;
            
            switch (e.KeyCode)
            {
                case Keys.Left:

                    planet.Left -= 30; break;
                   
                   

                case Keys.Right:
                    //   planet.Location = new Point(p.X + 30, p.Y);break; 
                    planet.Left += 30; break;
                case Keys.Up:
                    //timer1.Enabled = false;
                    Point c = new Point((p.X + planet.Width) - planet.Width / 2-10, p.Y-10);
                    points.Add(c);
                    PictureBox pic = new PictureBox();
                    pic.Width = 20;
                    pic.Height = 20;
                    pic.BackColor = Color.Transparent;
                    pic.Image = shotPlanet.Properties.Resources.dan;
                    pic.SizeMode=PictureBoxSizeMode.Zoom;
                    pic.Location = c;
                    pictureBoxes.Add(pic);
                    panel1.Controls.Add(pic);
                   // gp.FillEllipse(mypen, new Rectangle(c.X,c.Y, 10, 10));
                   // timer1.Enabled = true;
                   break;

            }
            if (planet.Location.X < 0) planet.Location=new Point(0,p.Y);
            else if(planet.Location.X > 430)  planet.Location=new Point(430,p.Y);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBoxes.Count != 0)
            {
                int count_ = points.Count;

               /* for (int i=0;i<count_;i++) 
                {
                    pictureBoxes[i].Top -= 10;
                    if (pictureBoxes[i].Top < 50)
                    {
                        try
                        {
                            panel1.Controls.Remove(pictureBoxes[i]);
                           // pictureBoxes.RemoveAt(i);
                            
                        }
                        catch { }   
                    }
                }*/
                foreach (PictureBox pictureBox in pictureBoxes.ToList())
                {
                    pictureBox.Top -= 10;
                    if (pictureBox.Top < 0)
                    {
                        panel1.Controls.Remove(pictureBox);
                        //pictureBox.Top = 50;
                        pictureBoxes.Remove(pictureBox);
                    }
                }
                
                foreach (var p in pictureBoxes.ToList())
                {

                    //-------------
                    if (p.Left > 10 && p.Left < 90)
                    {
                        if (planes[0].Count != 0)
                        {
                            if (p.Top < planes[0].First().Pic.Top)
                            {
                                planes[0].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[0].First().Hp == 0)
                                {
                                   
                                    panel1.Controls.Remove(planes[0].First().Pic);
                                    planes[0].Remove(planes[0].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();

                                }
                                
                            }
                        }

                        
                    }
                    //--------------

                    else if (p.Left > 110 && p.Left < 190)
                    {
                        if (planes[1].Count != 0)
                        {
                            if (p.Top < planes[1].First().Pic.Top)
                            {
                                planes[1].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[1].First().Hp == 0)
                                {

                                    panel1.Controls.Remove(planes[1].First().Pic);
                                    planes[1].Remove(planes[1].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();
                                }
                            }
                        }


                    }
                    //================
                    else if (p.Left > 210 && p.Left < 290)
                    {
                        if (planes[2].Count != 0)
                        {
                            if (p.Top < planes[2].First().Pic.Top)
                            {
                                planes[2].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[2].First().Hp == 0)
                                {

                                    panel1.Controls.Remove(planes[2].First().Pic);
                                    planes[2].Remove(planes[2].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();
                                }
                            }
                        }


                    }
                    //================
                    else if (p.Left > 310 && p.Left < 390)
                    {
                        if (planes[3].Count != 0)
                        {
                            if (p.Top < planes[3].First().Pic.Top)
                            {
                                planes[3].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[3].First().Hp == 0)
                                {

                                    panel1.Controls.Remove(planes[3].First().Pic);
                                    planes[3].Remove(planes[3].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();
                                }
                            }
                        }


                    }


                    //===========
                    else if (p.Left > 410 && p.Left < 490)
                    {
                        if (planes[4].Count != 0)
                        {
                            if (p.Top < planes[4].First().Pic.Top)
                            {
                                planes[4].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[4].First().Hp == 0)
                                {

                                    panel1.Controls.Remove(planes[4].First().Pic);
                                    planes[4].Remove(planes[4].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();

                                }
                            }
                        }


                    }
                    //====================
                    else if (p.Left > 510 && p.Left < 590)
                    {
                        if (planes[5].Count != 0)
                        {
                            if (p.Top < planes[5].First().Pic.Top)
                            {
                                planes[5].First().Hp -= 1;
                                panel1.Controls.Remove(p);
                                pictureBoxes.Remove(p);
                                if (planes[5].First().Hp == 0)
                                {

                                    panel1.Controls.Remove(planes[5].First().Pic);
                                    planes[5].Remove(planes[5].First());
                                    diem++;
                                    mark.Text = "Mark: " + diem.ToString();

                                }
                            }
                        }


                    }
                    //===============


                }



            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 80;
            pic.Height = 40;
            pic.Image = shotPlanet.Properties.Resources.dich;
           //pic.Image = Image.FromFile(@"\Resources\dich.png");
            /*Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("shotPlanet.Properties.Resources.maybay1");
            
            // Tạo một đối tượng Image từ stream
            Image image = Image.FromStream(stream);
            pic.Image = image;*/
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.Transparent;
            plane pl = new plane(pic, hp);

            int k = rand.Next(0, 5);
            
            switch (k)
            {
                case 0:
                    pic.Location = new Point(10, 0);
                    panel1.Controls.Add(pic);
                    planes[0].Add(pl);
                    

                    break;
                case 1:
                    pic.Location = new Point(110, 0);
                    panel1.Controls.Add(pic);
                    planes[1].Add(pl);
                    
                    break;
                case 2:
                    pic.Location = new Point(210, 0);
                    panel1.Controls.Add(pic);
                    planes[2].Add(pl);
                    break;
                case 3:
                    pic.Location = new Point(310, 0);
                    panel1.Controls.Add(pic);
                    planes[3].Add(pl);
                    break;
                case 4:
                    pic.Location = new Point(410, 0);
                    panel1.Controls.Add(pic);
                    planes[4].Add(pl);
                    break;
                case 5:
                    pic.Location = new Point(510, 0);
                    panel1.Controls.Add(pic);
                    planes[5].Add(pl);
                    break;
               

            }

            
            
        }

        private void dixuong_Tick(object sender, EventArgs e)
        {
            foreach (var p in planes)
            {
                foreach (var _p in p.ToList())
                {
                    _p.Pic.Top += 50;
                    if (_p.Pic.Top > 530)
                    {
                        panel1.Controls.Remove(_p.Pic);
                        
                       
                        timer_checker.Enabled = true;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        panel1.Controls.Clear();
                        foreach (var i in planes)
                        {
                            foreach (var j in i)
                            {
                                panel1.Controls.Remove(j.Pic);
                            }
                            i.Clear();
                        }

                        //panel1.Refresh();
                        panel1.Controls.Add(u1);
                       
                        
                        dixuong.Enabled = false;
                    }
                }
            }
        }

        private void level_Tick(object sender, EventArgs e)
        {
            if (diem >= moc * 2)
            {
                //dixuong.Enabled = false;
                hp += 2;
                moc = diem;

            }
        }

        private void timer_checker_Tick(object sender, EventArgs e)
        {
            if (u1.I == 1)
            {

                timer1.Enabled = true;
                timer2.Enabled = true;
                level.Enabled = true;
                dixuong.Enabled = true;

                panel1.Controls.Remove(u1);
                panel1.Focus();
                timer_checker.Enabled = false;
                u1.I = 0;
                panel1.Controls.Add(pictureBox);
                diem = 0;
                moc = 5;
                hp = 2;

            }
        }
    }
}
