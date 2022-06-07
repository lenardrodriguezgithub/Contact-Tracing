using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public StreamWriter sw = new StreamWriter(Application.StartupPath + "\\POIs\\" + "TextFile.txt", append: true);
        public string FullName;
        public string Gender;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = FullName;
            textBox2.Text = Gender;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            FullName = txt_FirstName.Text + txt_Age.Text;
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            FullName = txt_FirstName.Text + txt_Age.Text;
        }


        private void lbl_Age_Click(object sender, EventArgs e)
        {

        }



        private void ChooseGender(object sender, EventArgs e)
        {
            if (rbttn_Male.Checked)
            {
                Gender = "Male";
            }
            else if (rbttn_Female.Checked)
            {
                Gender = "Female";
            }
            else if (rbttn_Others.Checked)
            {
                txt_Others.Enabled = true;
                Gender = txt_Others.Text;
            }
        }



        private void rbttn_Male_CheckedChanged(object sender, EventArgs e)
        {
            ChooseGender(sender, e);
        }

        private void rbttn_Female_CheckedChanged(object sender, EventArgs e)
        {
            ChooseGender(sender, e);
        }

        private void rbttn_Others_CheckedChanged(object sender, EventArgs e)
        {
            ChooseGender(sender, e);
        }

        private void txt_Others_TextChanged(object sender, EventArgs e)
        {
            Gender = txt_Others.Text;
        }
    }
}