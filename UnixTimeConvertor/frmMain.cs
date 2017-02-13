using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnixTimeConvertor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbnow.Text = "";
            lbresult.Text = "";
            updateNowTime();
            this.ActiveControl = txtinput;
        }

        private string epoch2string(int epoch)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToLocalTime()).ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtinput.Text.Length > 0)
            {
                try
                {
                    string convert_result = "";
                    //if (rbunix.Checked)
                    if(txtinput.Text.Contains("/"))
                    {
                        string given_date = txtinput.Text;
                        DateTime dt = Convert.ToDateTime(given_date);
                        long epoch = (dt.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
                        convert_result = epoch.ToString();
                    }
                    else
                    {
                        convert_result = epoch2string(Convert.ToInt32(txtinput.Text));
                    }
                    lbresult.Text = convert_result;
                    copyToClipboard(convert_result);
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error Occured : " + ee.ToString());
                    changeInputText("");
                }
                
            }
        }

        private void copyToClipboard(String str)
        {
            lbstatus.Visible = true;
            System.Windows.Forms.Clipboard.SetText(str);
            var t = new Timer();
            t.Interval = 1500; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                lbstatus.Visible = false;
                t.Stop();
            };
            t.Start();
            focusOnInput();
        }

        private void lbresult_Click(object sender, EventArgs e)
        {
            copyToClipboard(lbresult.Text);
        }

        private void updateNowTime()
        {
            lbnow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            var epoch_double = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            CultureInfo info = CultureInfo.GetCultureInfo("en-US");
            string epoch = (10000 * epoch_double).ToString("00000000000000", info);
            lbNowEpoch.Text = "(" + epoch.Substring(0,10) + ")";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateNowTime();
        }

        private void changeInputText(String str)
        {
            txtinput.Text = str;
            focusOnInput();
        }

        private void lbNowEpoch_Click(object sender, EventArgs e)
        {
            string s = lbNowEpoch.Text.Replace("(",String.Empty);
            string s1 = s.Replace(")", String.Empty);
            
            copyToClipboard(s1);
        }

        private void focusOnInput()
        {
            this.ActiveControl = txtinput;
        }

        private void lbnow_Click(object sender, EventArgs e)
        {
            copyToClipboard(lbnow.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInputText("");
        }

        private void btnPasteInput_Click(object sender, EventArgs e)
        {
            txtinput.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void btnCopyInput_Click(object sender, EventArgs e)
        {
            if (txtinput.Text.Length > 0)
            {
                copyToClipboard(txtinput.Text);
            }
            
        }

        private void txtinput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }
        }
    }
}
