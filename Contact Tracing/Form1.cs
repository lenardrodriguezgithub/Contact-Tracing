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

        StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contact\\" + "ContactTracing.txt", append: true);


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
                Contact mycontact = new();
                mycontact.Name = txtfName.Text + " " + txtlName.Text;
                mycontact.Age = txtAge.Text;
                mycontact.Birth = dtpBirth.Text;
                mycontact.Gender = lbGender.Text;
                mycontact.ContactNo = txtContactNo.Text;
                mycontact.Email = txtEmail.Text;
                mycontact.Address = txtaNo.Text + ", " + txtaSt.Text + ", " + txtaTown.Text + ", " + txtaMunicipal.Text;
                mycontact.Type = lbType.Text;
                mycontact.WriteToFile();
                mycontact.ShowDetails();
            }       
        }
    }

    public class Contact
    {
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Birth { get; set; }
        public string? Gender { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Type { get; set; }

        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contact\\" + "ContactTracingV2.txt", append: true);
            sw.WriteLine(Name, Age, Birth, Gender, ContactNo, Email, Address, Type);
            sw.Flush();
            MessageBox.Show(Application.StartupPath);
        }

        public void ShowDetails()
        {
            MessageBox.Show(Name + Environment.NewLine +
                            Age + Environment.NewLine +
                            Birth + Environment.NewLine +
                            Gender + Environment.NewLine +
                            ContactNo + Environment.NewLine +
                            Email + Environment.NewLine +
                            Address + Environment.NewLine +
                            Type + Environment.NewLine);
        }

        
    }
}