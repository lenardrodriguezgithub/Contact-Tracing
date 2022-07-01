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
                string Name = txtfName.Text + " " + txtlName.Text;
                string Age = txtAge.Text;
                string Birth = dtpBirth.Text;
                string Gender = lbGender.Text;
                string ContactNo = txtContactNo.Text;
                string Email = txtEmail.Text;
                string Address = txtaNo.Text + ", " + txtaSt.Text + ", " + txtaTown.Text + ", " + txtaMunicipal.Text;
                string Type = lbType.Text;

                Contact mycontact = new(Name, Age, Birth, Gender, ContactNo, Email, Address, Type);
                mycontact.ShowDetails();

                StreamWriter sw = new StreamWriter();

            }       
        }
    }

    public class Contact
    {
        private string name = string.Empty;
        private string age = string.Empty;  
        private string birth = string.Empty;
        private string gender = string.Empty;
        private string contactno = string.Empty;
        private string email = string.Empty;
        private string address = string.Empty;
        private string type = string.Empty;

        public Contact(string name, string age, string birth, string gender, string contact_no, string email, string address, string type)
        {
            this.name = name;
            this.age = age;
            this.birth = birth;
            this.gender = gender;
            this.contactno = contact_no;
            this.email = email;
            this.address = address;
            this.type = type;
        }

        public void ShowDetails()
        {
            MessageBox.Show(name + Environment.NewLine +
                            age + Environment.NewLine +
                            birth + Environment.NewLine +
                            gender + Environment.NewLine +
                            contactno + Environment.NewLine +
                            email + Environment.NewLine +
                            address + Environment.NewLine +
                            type + Environment.NewLine);
        }

        
    }
}