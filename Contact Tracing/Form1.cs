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
        // creates streamwriter and declares variables
        public StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contact\\" + "ContactTracing.txt", append: true);
        public string? FullName, Gender, Age, Email, Contact, Address;
        public string? CContact1, CContact2, CContact3, CContact4, CContact5;

        private void bttn_Answer_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
        }

        private void bttn_Previous1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void bttn_Next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_Age.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Contact.Text) ||
                string.IsNullOrWhiteSpace(txt_HouseNumber.Text) ||
                string.IsNullOrWhiteSpace(txt_Street.Text) ||
                string.IsNullOrWhiteSpace(txt_Barangay.Text) ||
                string.IsNullOrWhiteSpace(txt_Municipality.Text) ||
                string.IsNullOrWhiteSpace(Gender))
            {
                MessageBox.Show("Please complete all required fields.", "Message");
            }
            else
            {
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
            }
        }

        private void bttn_Previous2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
        }

        private void bttn_Submit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Form was submitted.", "Message");
            }
            // writes to text file
            sw.WriteLine(FullName);
            sw.WriteLine(Gender);
            sw.WriteLine(Age);
            sw.WriteLine(Email);
            sw.WriteLine(Contact);
            sw.WriteLine(Address);
            sw.WriteLine(CContact1);
            sw.WriteLine(CContact2);
            sw.WriteLine(CContact3);
            sw.WriteLine(CContact4);
            sw.WriteLine(CContact5);
            sw.WriteLine("");
            sw.Flush();

            // resets variables and controls
            FullName = null;
            Gender = null;
            Age = null;
            Email = null;
            Contact = null;
            Address = null;
            CContact1 = null;
            CContact2 = null;
            CContact3 = null;
            CContact4 = null;
            CContact5 = null;
            this.Controls.Clear();
            this.InitializeComponent();

            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            FullName = txt_FirstName.Text + " " + txt_LastName.Text;
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            FullName = txt_FirstName.Text + " " + txt_LastName.Text;
        }

        private void lbl_Age_Click(object sender, EventArgs e)
        {

        }

        private void txt_Age_TextChanged(object sender, EventArgs e)
        {
            Age = txt_Age.Text;
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            Email = txt_Email.Text;
        }

        private void txt_Contact_TextChanged(object sender, EventArgs e)
        {
            Contact =txt_Contact.Text;
        }

        private void ConcatAddress(object sender, EventArgs e)
        {
            Address = txt_HouseNumber.Text + " " + txt_Street.Text  + " " + txt_Barangay.Text + ", " + txt_Municipality.Text;
        }

        private void txt_CTName1_TextChanged(object sender, EventArgs e)
        {
            CContact1 = txt_CTName1.Text + ", " + date_CTTime1.Value + ", " + txt_CTLocation1.Text; ;
        }

        private void date_CTTime1_ValueChanged(object sender, EventArgs e)
        {
            CContact1 = txt_CTName1.Text + ", " + date_CTTime1.Value + ", " + txt_CTLocation1.Text;
        }

        private void txt_CTLocation1_TextChanged(object sender, EventArgs e)
        {
            CContact1 = txt_CTName1.Text + ", " + date_CTTime1.Value + ", " + txt_CTLocation1.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_CTName2_TextChanged(object sender, EventArgs e)
        {
            CContact2 = txt_CTName2.Text + ", " + date_CTTime2.Value + ", " + txt_CTLocation2.Text;
        }

        private void date_CTTime2_ValueChanged(object sender, EventArgs e)
        {
            CContact2 = txt_CTName2.Text + ", " + date_CTTime2.Value + ", " + txt_CTLocation2.Text;
        }

        private void txt_CTLocation2_TextChanged(object sender, EventArgs e)
        {
            CContact2 = txt_CTName2.Text + ", " + date_CTTime2.Value + ", " + txt_CTLocation2.Text;
        }

        private void txt_CTName3_TextChanged(object sender, EventArgs e)
        {
            CContact3 = txt_CTName3.Text + ", " + date_CTTime3.Value + ", " + txt_CTLocation3.Text;
        }

        private void date_CTTime3_ValueChanged(object sender, EventArgs e)
        {
            CContact3 = txt_CTName3.Text + ", " + date_CTTime3.Value + ", " + txt_CTLocation3.Text;
        }

        private void txt_CTLocation3_TextChanged(object sender, EventArgs e)
        {
            CContact3 = txt_CTName3.Text + ", " + date_CTTime3.Value + ", " + txt_CTLocation3.Text;
        }

        private void txt_CTName4_TextChanged(object sender, EventArgs e)
        {
            CContact4 = txt_CTName4.Text + ", " + date_CTTime4.Value + ", " + txt_CTLocation4.Text;
        }

        private void date_CTTime4_ValueChanged(object sender, EventArgs e)
        {
            CContact4 = txt_CTName4.Text + ", " + date_CTTime4.Value + ", " + txt_CTLocation4.Text;
        }

        private void txt_CTLocation4_TextChanged(object sender, EventArgs e)
        {
            CContact4 = txt_CTName4.Text + ", " + date_CTTime4.Value + ", " + txt_CTLocation4.Text;
        }

        private void txt_CTName5_TextChanged(object sender, EventArgs e)
        {
            CContact5 = txt_CTName5.Text + ", " + date_CTTime5.Value + ", " + txt_CTLocation5.Text;
        }

        private void date_CTTime5_ValueChanged(object sender, EventArgs e)
        {
            CContact5 = txt_CTName5.Text + ", " + date_CTTime5.Value + ", " + txt_CTLocation5.Text;
        }

        private void txt_CTLocation5_TextChanged(object sender, EventArgs e)
        {
            CContact5 = txt_CTName5.Text + ", " + date_CTTime5.Value + ", " + txt_CTLocation5.Text;
        }

        private void txt_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_HouseNumber_TextChanged(object sender, EventArgs e)
        {
            Address = txt_HouseNumber.Text + " " + txt_Street.Text + " " + txt_Barangay.Text + ", " + txt_Municipality.Text;
        }

        private void txt_Street_TextChanged(object sender, EventArgs e)
        {
            Address = txt_HouseNumber.Text + " " + txt_Street.Text + " " + txt_Barangay.Text + ", " + txt_Municipality.Text;
        }

        private void txt_Barangay_TextChanged(object sender, EventArgs e)
        {
            Address = txt_HouseNumber.Text + " " + txt_Street.Text + " " + txt_Barangay.Text + ", " + txt_Municipality.Text;
        }

        private void txt_Municipality_TextChanged(object sender, EventArgs e)
        {
            Address = txt_HouseNumber.Text + " " + txt_Street.Text + " " + txt_Barangay.Text + ", " + txt_Municipality.Text;
        }

        private void ChooseGender(object sender, EventArgs e)
        {
            if (rbttn_Male.Checked)
            {
                Gender = "Male";
                txt_Others.Text = null;
                txt_Others.Enabled = false;
            }
            else if (rbttn_Female.Checked)
            {
                Gender = "Female";
                txt_Others.Text = null;
                txt_Others.Enabled = false;
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