using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mthods;
using Constants;

namespace V2ray_Account_maker
{
    public partial class Form1 : Form
    {
        int time = 0;
        public Form1()
        {
            Qrcode.setLice();
            InitializeComponent();
            txtName.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Requests.isServer(Information.IP[0]))
            {
                MessageBox.Show("Network or server Error check network if problem not solved contact your support", "Error");
                Environment.Exit(0);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtName.Text))
            {
                string account = Requests.createAccount(txtName.Text);
                if(!string.IsNullOrEmpty(account))
                {
                    string base64 = Qrcode.convertTobase64(account);
                    Bitmap qr = Qrcode.createQrCode("vmess://"+base64);
                    if(qr != null)
                    {
                        pbQrCode.Image = qr;
                        timerPicture.Enabled = true;
                        timerPicture.Start();
                    }
                    else
                    {
                        MessageBox.Show("Error while creating qrCode", "Erro");
                    }
                }
            }
        }

        private void timerPicture_Tick(object sender, EventArgs e)
        {
            time++;
            lblCounter.Text = $"{20 - time} secs remaining";
            if(time == 20)
            {
                txtName.Text = string.Empty;
                pbQrCode.Image = null;
                lblCounter.Text = "0 secs remaining";
                timerPicture.Enabled = false;
                timerPicture.Stop();
                time = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
