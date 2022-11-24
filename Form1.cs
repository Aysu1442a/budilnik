using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int saat, deq , san;
        string zenglisaat, zenglideqiqe;

        private void button1_Click(object sender, EventArgs e)
        {
            zenglisaat = comboBox1.Text;
            zenglideqiqe = comboBox2.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            san = DateTime.Now.Second;
            deq=DateTime.Now.Minute;
            saat=DateTime.Now.Hour;
            label2.Text=saat.ToString();
            label3.Text=deq.ToString();
            label4.Text=san.ToString();
            Ring_Alarm();

        }
        void Ring_Alarm()
        {
            if (zenglisaat == saat.ToString() && zenglideqiqe == deq.ToString() &&
                san.ToString () == "0")
            {

                axWindowsMediaPlayer1.URL = "C:\\Users\\user\\Desktop\\alarm_sound.mp3";
            }
}
       
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

          for(int i = 0; i < 24; i++) 
            {
                comboBox1.Items.Add(i);
            }

          for(int j=0; j < 60; j++)
            {
                comboBox2.Items.Add(j);

            }


        }
    }
}
