using System;
using System.Threading;
using System.Windows.Forms;

namespace lotto_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string makeNum()
        {
            Random rand = new Random();
            string lottoNum = null;
            int a = 0;
            int[] arr=new int[6];
            for(int i=0;i<6;i++)
            {
                a = rand.Next(1, 45);
                arr[i] = a;
            }
            Array.Sort(arr);
            for(int i=0;i<6;i++)
            {
                if (i == 0)
                    lottoNum += "     " + arr[i];
                else if (i == 5)
                    lottoNum += ", " + arr[i].ToString();
                else
                    lottoNum += ", " + arr[i];
            }
            return lottoNum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string lnum = makeNum();
            label1.Text = lnum;
            listBox1.Items.Add( lnum.Trim() );
            pictureBox2.Visible= true;
            button1.Enabled = false;
            label2.Visible = true;

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (pictureBox2.Visible == true && count >= 4) 
            {
                pictureBox2.Visible= false;
                label2.Visible = false;
                button1.Enabled = true;
                count = 0;
            }
        }
    }
}
