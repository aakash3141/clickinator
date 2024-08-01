using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Autoclicker
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern uint SendInput(uint cInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            internal int type;
            internal MOUSEINPUT mi;
        }

        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_VIRTUALDESK = 0x4000;
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        public Form1()
        {
            InitializeComponent();
        }

        INPUT[] mousedown = new INPUT[1];
        INPUT[] mouseup = new INPUT[1];

        private void initializeclick()
        {
            mousedown[0].mi.dx = 0;
            mousedown[0].mi.dy = 0;
            mousedown[0].mi.mouseData = 0;
            mousedown[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF_ABSOLUTE;
            mousedown[0].mi.time = 0;
            mousedown[0].mi.dwExtraInfo = UIntPtr.Zero;

            mouseup[0].type = 0;
            mouseup[0].mi.dx = 0;
            mouseup[0].mi.dy = 0;
            mouseup[0].mi.mouseData = 0;
            mouseup[0].mi.dwFlags = MOUSEEVENTF_LEFTUP | MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF_ABSOLUTE;
            mouseup[0].mi.time = 0;
            mouseup[0].mi.dwExtraInfo = UIntPtr.Zero;
        }

        private void click(int amt)
        {
            for (int i = 0; i < amt; i++)
            {
                SendInput(1, mousedown, Marshal.SizeOf(typeof(INPUT)));
                SendInput(1, mouseup, Marshal.SizeOf(typeof(INPUT)));
            }
        }

        private void enablecontrols(bool status)
        {
            customcoords.Enabled = trackptr.Enabled = clicknumber.Enabled = clickfreq.Enabled = clickforever.Enabled = sendclicks.Enabled = status;
            if (status == false)
            {
                clickduration.Enabled = false;
                cursorX.Enabled = cursorY.Enabled = false;
            }

            if (status == true && clickforever.Checked == true)
            {
                clickduration.Enabled = false;
            }
            else if (status == true && clickforever.Checked == false)
            {
                clickduration.Enabled = true;
            }

            if (status == true && trackptr.Checked == true)
            {
                cursorX.Enabled = cursorY.Enabled = false;
            }
            else if (status == true && trackptr.Checked == false)
            {
                cursorX.Enabled = cursorY.Enabled = true;
            }
        }

        DateTime clicktime;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (customcoords.Checked == true)
            {
                cursorX.Enabled = cursorY.Enabled = true;
                tracktimer.Stop();
                label1.Text = "Enter desired coordinates";
                this.KeyPreview = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (trackptr.Checked == true)
            {
                cursorX.Enabled = cursorY.Enabled = false;
                tracktimer.Start();
                label1.Text = "[Space] to lock coordinates";
                this.KeyPreview = true;
                this.ActiveControl = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cursorX.Text = Cursor.Position.X.ToString();
            cursorY.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            customcoords.Checked = true;
            cursorX.Maximum = Screen.PrimaryScreen.Bounds.Width;
            cursorY.Maximum = Screen.PrimaryScreen.Bounds.Height;
            clickfreq.Maximum = clickduration.Maximum = decimal.MaxValue;
            initializeclick();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.ActiveControl = null;
                if (tracktimer.Enabled == true && trackptr.Checked == true)
                {
                    tracktimer.Stop();
                    label1.Text = "[Space] to unlock coordinates";
                }
                else if (tracktimer.Enabled == false && trackptr.Checked == true)
                {
                    tracktimer.Start();
                    label1.Text = "[Space] to lock coordinates";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tracktimer.Enabled == true) //check if tracking is on
            {
                MessageBox.Show("Clicks cannot be sent when coordinates are not locked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = null;
            }
            else
            {
                Point point = new Point();

                point.X = (int)cursorX.Value;
                point.Y = (int)cursorY.Value; //set up cursor position

                DialogResult result = MessageBox.Show("Caution: You are about to automate (potentially many) clicks. Make sure the window you want to send clicks to is DIRECTLY underneath the app window.\n\nYou may hover your mouse anywhere over the app window at any time to stop clicking.\n\nDo you wish to continue?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    if (clickforever.Checked == true)
                    {
                        keepclicking.Interval = (int)clickfreq.Value;
                        Cursor.Position = point;
                        keepclicking.Start();
                        click((int)clicknumber.Value);
                        enablecontrols(false);
                    }
                    else
                    {
                        clicktimer.Interval = (int)clickfreq.Value;
                        Cursor.Position = point;
                        clicktime = DateTime.Now;
                        clicktimer.Start();
                        click((int)clicknumber.Value);
                        enablecontrols(false);
                    }
                }
            }

            this.ActiveControl = null;
        }
        
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Clickinator v1 (Build 2024.07)\n\nCheck out the project on GitHub!", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (clickforever.Checked == true)
            {
                clickduration.Enabled = false;
            }
            else
            {
                clickduration.Enabled = true;
            }

            this.ActiveControl = null;
        }

        private void keepclicking_Tick(object sender, EventArgs e)
        {
            click((int)clicknumber.Value);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicktimer.Enabled == true)
            {
                clicktimer.Stop();
            }
            else if (keepclicking.Enabled == true)
            {
                keepclicking.Stop();
            }

            enablecontrols(true);
        }

        private void clicktimer_Tick(object sender, EventArgs e)
        {
            if ((int)Math.Floor((DateTime.Now - clicktime).TotalSeconds) < clickduration.Value)
            {
                click((int)clicknumber.Value);
            }
            else
            {
                clicktimer.Stop();
                enablecontrols(true);
            }
        }

        private void sendclicks_EnabledChanged(object sender, EventArgs e)
        {
            if (sendclicks.Enabled == true)
            {
                label9.Visible = false;
            }
            else if (sendclicks.Enabled == false)
            {
                label9.Visible = true;
            }
        }
    }
}
