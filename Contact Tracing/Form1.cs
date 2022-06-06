using System;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\POIs\\" + txt_FirstName.Text + " " + txt_LastName.Text + ".txt");
            string FullName = txt_FirstName.Text + " " + txt_LastName.Text;
            sw.WriteLine(FullName);
            sw.Close();
        }
    }
}