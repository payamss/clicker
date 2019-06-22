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
                            for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                            {
                                DoMouseClick(); 
                                lblNumber.Text = (1+i).ToString();
                                System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                            }
                            System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            if (cb1.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(txtMouseX2.Text), Convert.ToInt16(txtMouseY2.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox1.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox2.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox3.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox6.Text), Convert.ToInt16(textBox7.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox4.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox5.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox10.Text), Convert.ToInt16(textBox11.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox6.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox12.Text), Convert.ToInt16(textBox13.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox7.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox14.Text), Convert.ToInt16(textBox15.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

                            }

                            if (checkBox8.Checked)
                            {
                                SetCursorPos(Convert.ToInt16(textBox16.Text), Convert.ToInt16(textBox17.Text));
                                for (int i = 0; i < Convert.ToInt16(textBox18.Text); i++)
                                {
                                    DoMouseClick();
                                    lblNumber.Text = (1 + i).ToString();
                                    System.Threading.Thread.Sleep(Convert.ToInt16(clickDelay.Text));
                                }
                                System.Threading.Thread.Sleep(Convert.ToInt16(delay.Text));

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
                btnStart.BackColor = Color.SteelBlue;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "Go to Location";

            int dt = 0;

            textBox2.Text = Cursor.Position.X.ToString();
            textBox3.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox2.Text != Cursor.Position.X.ToString()) || (textBox3.Text != Cursor.Position.Y.ToString()))
                {
                    textBox2.Text = Cursor.Position.X.ToString();
                    textBox3.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button1.Enabled = false;
                    button1.Text = "Grabbing ...";
                    button1.BackColor = Color.Crimson;

                    if (dt > 3)
                    {
                        button1.Enabled = true;
                        button1.Text = "Grab";
                        button1.BackColor = Color.SteelBlue;

                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());


            };
            timer3.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = "Go to Location";

            int dt = 0;

            textBox4.Text = Cursor.Position.X.ToString();
            textBox5.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox4.Text != Cursor.Position.X.ToString()) || (textBox5.Text != Cursor.Position.Y.ToString()))
                {
                    textBox4.Text = Cursor.Position.X.ToString();
                    textBox5.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button2.Enabled = false;
                    button2.Text = "Grabbing ...";
                    button2.BackColor = Color.Crimson;

                    if (dt > 3)
                    {
                        button2.Enabled = true;
                        button2.Text = "Grab";
                        button2.BackColor = Color.SteelBlue;

                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());


            };
            timer3.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Go to Location";
            int dt = 0;
            textBox6.Text = Cursor.Position.X.ToString();
            textBox7.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox6.Text != Cursor.Position.X.ToString()) || (textBox7.Text != Cursor.Position.Y.ToString()))
                {
                    textBox6.Text = Cursor.Position.X.ToString();
                    textBox7.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button3.Enabled = false;
                    button3.Text = "Grabbing ...";
                    button3.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button3.Enabled = true;
                        button3.Text = "Grab";
                        button3.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Go to Location";
            int dt = 0;
            textBox8.Text = Cursor.Position.X.ToString();
            textBox9.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox8.Text != Cursor.Position.X.ToString()) || (textBox9.Text != Cursor.Position.Y.ToString()))
                {
                    textBox8.Text = Cursor.Position.X.ToString();
                    textBox9.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button4.Enabled = false;
                    button4.Text = "Grabbing ...";
                    button4.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button4.Enabled = true;
                        button4.Text = "Grab";
                        button4.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Go to Location";
            int dt = 0;
            textBox10.Text = Cursor.Position.X.ToString();
            textBox11.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox10.Text != Cursor.Position.X.ToString()) || (textBox11.Text != Cursor.Position.Y.ToString()))
                {
                    textBox10.Text = Cursor.Position.X.ToString();
                    textBox11.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button5.Enabled = false;
                    button5.Text = "Grabbing ...";
                    button5.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button5.Enabled = true;
                        button5.Text = "Grab";
                        button5.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Go to Location";
            int dt = 0;
            textBox12.Text = Cursor.Position.X.ToString();
            textBox13.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox12.Text != Cursor.Position.X.ToString()) || (textBox13.Text != Cursor.Position.Y.ToString()))
                {
                    textBox12.Text = Cursor.Position.X.ToString();
                    textBox13.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button6.Enabled = false;
                    button6.Text = "Grabbing ...";
                    button6.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button6.Enabled = true;
                        button6.Text = "Grab";
                        button6.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "Go to Location";
            int dt = 0;
            textBox14.Text = Cursor.Position.X.ToString();
            textBox15.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox14.Text != Cursor.Position.X.ToString()) || (textBox15.Text != Cursor.Position.Y.ToString()))
                {
                    textBox14.Text = Cursor.Position.X.ToString();
                    textBox15.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button7.Enabled = false;
                    button7.Text = "Grabbing ...";
                    button7.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button7.Enabled = true;
                        button7.Text = "Grab";
                        button7.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "Go to Location";
            int dt = 0;
            textBox16.Text = Cursor.Position.X.ToString();
            textBox17.Text = Cursor.Position.Y.ToString();
            var timer3 = new Timer { Interval = 1000 };
            timer3.Tick += (o, args) =>
            {
                if ((textBox16.Text != Cursor.Position.X.ToString()) || (textBox17.Text != Cursor.Position.Y.ToString()))
                {
                    textBox16.Text = Cursor.Position.X.ToString();
                    textBox17.Text = Cursor.Position.Y.ToString();
                }
                else
                {
                    dt++;
                    button8.Enabled = false;
                    button8.Text = "Grabbing ...";
                    button8.BackColor = Color.Crimson;
                    if (dt > 3)
                    {
                        button8.Enabled = true;
                        button8.Text = "Grab";
                        button8.BackColor = Color.SteelBlue;
                        timer3.Stop();
                    }
                }
                Console.WriteLine(timer3.ToString());
            };
            timer3.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
