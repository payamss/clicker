using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            if (btnStart.Text == "Start")
            {

                timer2.Tick += (o, args) =>
                {

                    string SetDate = txtHour.Text + ":" + txtMin.Text + ":" + txtSec.Text + " " + ddList.SelectedItem.ToString();
                    try
                    {
                        DateTime datetime = DateTime.ParseExact(SetDate, "HH:mm:ss tt", null);
                        if ((datetime - DateTime.Now).TotalMilliseconds < 0)
                        {
                            timer2.Stop();
                            btnStart.Text = "Start";
                            SetCursorPos(Convert.ToInt16(txtMouseX.Text), Convert.ToInt16(txtMouseY.Text));
                            DoMouseClick();
                            System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));
                            if (cb1.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(txtMouseX2.Text), Convert.ToInt16(txtMouseY2.Text));
                                DoMouseClick();
                            }

                            //MessageBox.Show("DONE");
                        }
                        else
                        {
                            lblRemaining.Text = (datetime - DateTime.Now).TotalMilliseconds.ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        timer2.Stop();

                        MessageBox.Show("Enter date Correctly in two digit form" + ex.Message);

                    }
                    Console.WriteLine();

                };
                timer2.Start();
                btnStart.Text = "Stop";
                btnStart.BackColor = Color.Crimson;


            }
            else
            {
                timer2.Stop();
                btnStart.Text = "Start";
                btnStart.BackColor = Color.SteelBlue;

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
                    btnGrab.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        btnGrab.Enabled = true;
                        btnGrab.Text = "Grab";
                        btnGrab.BackColor = Color.SteelBlue;

                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());


            };
            timer3.Start();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void DoMouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public static void MoveCursorToPoint(int x, int y)
        {
            SetCursorPos(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SetCursorPos(Convert.ToInt16(txtMouseX.Text), Convert.ToInt16(txtMouseY.Text));
            DoMouseClick();
        }

        private void btnGrab2_Click(object sender, EventArgs e)
        {
            btnGrab2.Text = "Go to Location";

            int dt = 0;

            txtMouseX2.Text = Cursor.Position.X.ToString();
            txtMouseY2.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((txtMouseX2.Text != Cursor.Position.X.ToString()) || (txtMouseY2.Text != Cursor.Position.Y.ToString()))
                {
                    txtMouseX2.Text = Cursor.Position.X.ToString();
                    txtMouseY2.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    btnGrab2.Enabled = false;
                    btnGrab2.Text = "Grabbing ...";
                    btnGrab2.BackColor = Color.Crimson;

                    if (dt > 3)
                    {
                        btnGrab2.Enabled = true;
                        btnGrab2.Text = "Grab";
                        btnGrab2.BackColor = Color.SteelBlue;

                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());

                 
            };
            timer3.Start();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                Form1.ActiveForm.Opacity = Convert.ToDouble(textBox1.Text)/100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
