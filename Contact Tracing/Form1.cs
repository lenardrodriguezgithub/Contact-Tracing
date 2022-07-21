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

        public int? ID = 0;
        public string? Name;
        public string? Age;
        public string? Gender;
        public string? ContactNo;
        public string? Address;
        public string? Type;
        public string? Date;

        public void WriteToFile()
        {
            ID += ID;
            StreamWriter sw = new StreamWriter(Application.StartupPath +
                "\\Contact\\" + "ContactTracing.txt", append: true);
            sw.WriteLine(Name + "|" + Age + "|" + Gender + "|" +
                         ContactNo + "|" + Address + "|" + Type + "|" + Date);
            sw.Flush();
            sw.Close();
        }

        public void Confirm()
        {
            MessageBox.Show("Details saved.", "Message");
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (txtfName.Text == string.Empty || txtlName.Text == string.Empty ||
                txtAge.Text == string.Empty || txtContactNo.Text == string.Empty ||
                txtaNo.Text == string.Empty || txtaSt.Text == string.Empty ||
                txtaTown.Text == string.Empty || txtaMunicipal.Text == string.Empty)
            {
                MessageBox.Show("Please answer all the required fields.", "Message");
            }
            else
            {
                Name = txtfName.Text + " " + txtlName.Text;
                Age = txtAge.Text;
                Gender = cbGender.GetItemText(cbGender.SelectedItem);
                ContactNo = txtContactNo.Text;
                Address = txtaNo.Text + txtaSt.Text + ", " + 
                    txtaTown.Text + ", " + txtaMunicipal.Text;
                Type = cbType.GetItemText(cbType.SelectedItem);
                DateTime today = DateTime.Today;
                Date = today.ToString();
                WriteToFile();
            }       
        }
    }




}