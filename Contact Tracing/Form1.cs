using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string? Name;
        public string? Age;
        public string? Gender;
        public string? ContactNo;
        public string? Address;
        public string? Type;
        public string? Date;
       
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Contact No.", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Date", typeof(string));
        }

        public void ImportFromTextFile()
        {
            string[] lines = File.ReadAllLines(Application.StartupPath + "\\Contact\\" + "ContactTracing.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
            MessageBox.Show(lines.Length.ToString());
            dgvContactList.Update();
            dgvContactList.Refresh();
        }

        public void WriteToTextFile()
        {
            Name = txtfName.Text + " " + txtlName.Text;
            Age = txtAge.Text;
            Gender = cbGender.GetItemText(cbGender.SelectedItem);
            ContactNo = txtContactNo.Text;
            Address = txtaNo.Text + " " + txtaSt.Text + ", " +
                txtaTown.Text + ", " + txtaMunicipal.Text;
            Type = cbType.GetItemText(cbType.SelectedItem);
            Date = DateTime.UtcNow.ToShortDateString();
            StreamWriter sw = new StreamWriter(Application.StartupPath +
                "\\Contact\\" + "ContactTracing.txt", append: true);
            sw.WriteLine(Name + "|" + Age + "|" + Gender + "|" +
                         ContactNo + "|" + Address + "|" + Type + "|" + Date);
            sw.Flush();
            sw.Close();
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
                WriteToTextFile();
                MessageBox.Show("Details saved.", "Message");
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportFromTextFile();
        }
    }




}