using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {

        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                // To update the first time.
                label1.Text = (DateTime.Now).ToString(@"HH\:mm\:ss");
                var timer = new Timer { Interval = 1000 };
                timer.Tick += (o, args) =>
                {
                    label1.Text = (DateTime.Now).ToString(@"HH\:mm\:ss");
                };
                timer.Start();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            var timer2 = new Timer { Interval = Convert.ToInt32(txtInterval.Text) };

            if (btnStart.Text=="Start")
            {
                timer2.Tick += (o, args) =>
                { 
                    
                    string SetDate=  txtHour.Text+":" + txtMin.Text+":" + txtSec.Text+" "+ ddList.SelectedItem.ToString();
                    DateTime datetime = DateTime.ParseExact(SetDate, "HH:mm:ss tt", null);
                    Console.WriteLine();
                    if ((datetime - DateTime.Now).TotalMilliseconds<0)
                    {
                        timer2.Stop();
                        btnStart.Text = "Start";
                        MessageBox.Show("DONE");
                    }
                    else
                    {
                        lblRemaining.Text = (datetime - DateTime.Now).TotalMilliseconds.ToString();
                        }
                };
                timer2.Start();
                btnStart.Text = "Stop";
                
            }
            else
            {
                timer2.Stop();
                btnStart.Text = "Start";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Win32.POINT p = new Win32.POINT();
            p.x = Convert.ToInt16(txtMouseX.Text);
            p.y = Convert.ToInt16(txtMouseY.Text);

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
            
        }


        private void btnGrab_Click(object sender, EventArgs e)
        {
            btnGrab.Text = "Go to Location";

            int dt = 0;
            
            txtMouseX.Text = Cursor.Position.X.ToString();
            txtMouseY.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((txtMouseX.Text != Cursor.Position.X.ToString()) || (txtMouseY.Text != Cursor.Position.Y.ToString()))
                {
                    txtMouseX.Text = Cursor.Position.X.ToString();
                    txtMouseY.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    btnGrab.Enabled = false;
                    btnGrab.Text = "Grabbing ...";
                    if (dt > 3)
                    {
                        btnGrab.Enabled = true;
                        btnGrab.Text = "Grab";
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());


            };
            timer3.Start();
        }
    }
}
