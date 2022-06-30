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

        private void tester_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.GetName(txtfName.Text, txtlName.Text);
            contact.GetGender(this.cGender.GetItemText(this.cGender.SelectedItem));
        }
    }

    public class Contact
    {
        private string name = string.Empty;
        private string age = string.Empty;  
        private string birthday = string.Empty;
        private string gender = string.Empty;
        private string contact_no = string.Empty;
        private string email = string.Empty;
        private string address = string.Empty;
        
        public void GetName(string fName, string lName)
        {
            name = fName + " " + lName;
        }
        
        public void GetGender(string Gender)
        {
            gender = Gender;
        }
    }
}