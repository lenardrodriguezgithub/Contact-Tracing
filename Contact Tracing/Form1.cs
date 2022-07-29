using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using IronBarCode;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            dgvContactList.DataSource = table;
        }

        public string? Name;
        public string? Age;
        public string? Gender;
        public string? ContactNo;
        public string? Address;
        public string? Type;
        public string? Date;
       
        public void ImportFromTextFile()
        {
            table.Clear();
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

        public void ClearAllFields()
        {
            txtfName.Clear();
            txtlName.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            txtaNo.Clear();
            txtaSt.Clear();
            txtaTown.Clear();
            txtaMunicipal.Clear();
            cbGender.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "Name LIKE '" + txtSearch.Text + "%'";
            dgvContactList.DataSource = dv;
        }

        private void bttnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open an Image File";
            ofd.Filter = "All Files (*.*) | *.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    txtFile.Text = ofd.SafeFileName;
                    BarcodeResult Result = BarcodeReader.
                        QuicklyReadOneBarcode(ofd.FileName,
                        BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);
                    txtResult.Text = Result.ToString();
                }
                catch
                {
                    MessageBox.Show("There was an error!", "Error Message");
                }

            }
        }

        private void bttnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtResult.Text != null)
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath +
                    "\\Contact\\" + "ContactTracing.txt", append: true);
                    sw.WriteLine(txtResult.Text);
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Details saved.", "Message");
                    pnlSurvey.Visible = false;
                    pnlMenu.Visible = true;
                    pnlList.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("There was an erorr.", "Error Message");
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfName.Text == string.Empty || txtlName.Text == string.Empty ||
                cbGender.SelectedItem == null || cbType.SelectedItem == null ||
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
                    pnlSurvey.Visible = false;
                    pnlMenu.Visible = true;
                    pnlList.Visible = false; 
                    ClearAllFields();
                }
            }
            catch
            {
                MessageBox.Show("There was an error!", "Error Message");
                ClearAllFields();
            }
     
        }

        private void bttnToSurvey_Click(object sender, EventArgs e)
        {
            pnlSurvey.Visible = true;
            pnlMenu.Visible = false;
            pnlList.Visible = false;
        }

        private void bttnToList_Click(object sender, EventArgs e)
        {
            ImportFromTextFile();
            pnlSurvey.Visible = false;
            pnlMenu.Visible = false;
            pnlList.Visible = true;
        }

        private void bttnBackSurvey_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            pnlSurvey.Visible = false;
            pnlMenu.Visible = true;
            pnlList.Visible = false;
        }

        private void bttnBackList_Click(object sender, EventArgs e)
        {
            pnlSurvey.Visible = false;
            pnlMenu.Visible = true;
            pnlList.Visible = false;
            pnlQR.Visible = false;
        }

        private void bttnQR_Click(object sender, EventArgs e)
        {
            pnlSurvey.Visible = false;
            pnlMenu.Visible = false;
            pnlList.Visible = false;
            pnlQR.Visible = true;
        }

        private void bttnBackQR_Click(object sender, EventArgs e)
        {
            pnlSurvey.Visible = false;
            pnlMenu.Visible = true;
            pnlList.Visible = false;
            pnlQR.Visible = false;
        }

    }




}