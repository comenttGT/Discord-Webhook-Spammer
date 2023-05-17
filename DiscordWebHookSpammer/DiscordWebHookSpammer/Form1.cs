using System;
using System.Diagnostics;
using System.Windows.Forms;
using DiscordWebHookSpammer.res;

namespace DiscordWebHookSpammer
{
    public partial class Form1 : Form
    {
        private int spamornot;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendmsg(webhook.Text, customMessage.Text, customBotName.Text);
        }

        private static void sendmsg(string webhook, string message, string botname)
        {
            connection.post(webhook, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });

        }

        

        

        private void veryfastspam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Start();
        }

        private void webhook_TextChanged(object sender, EventArgs e)
        {
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (veryfastspam.Checked)
            {
                sendmsg(webhook.Text, customMessage.Text, customBotName.Text);
            }
            else
            {

            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@comenttGT");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sUg38TnqQn");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
