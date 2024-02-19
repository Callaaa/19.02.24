using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podgotvitelna_zadacha
{
    public partial class Form1 : Form
    {
        string job;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lName = txtLname.Text;
            string age = txtAge.Text;
            string position = cmb.Text;
            //string job;
            bool isAllChecked = true;

            bool isJobChecked = false;
            if (rdChistach.Checked) 
            {
                job = rdChistach.Text;
                isJobChecked = true;
            }
            else
            if (rdProdavach.Checked) 
            {
                job = rdChistach.Text;

                isJobChecked = true;

            }
            else
            if (rdServivitor.Checked) 
            {
                job = rdChistach.Text;
                isJobChecked = true;

            }
            else
            if (rdShofyor.Checked) 
            {
                job = rdChistach.Text;
                isJobChecked = true;

            }

            if (isJobChecked==false)
            {
                MessageBox.Show("Job not checked","Vnimanie",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name not checked", "Vnimanie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isAllChecked= false;
            }
            if (string.IsNullOrEmpty(lName))
            {
                MessageBox.Show("Last Name not checked", "Vnimanie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isAllChecked = false;

            }
            if (string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Age not checked", "Vnimanie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isAllChecked = false;

            }
            if (cmb.SelectedItem == null)
            {
                MessageBox.Show("Age not checked", "Vnimanie",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isAllChecked = false;

            }
            if (isAllChecked==true)
            {
                DialogResult result= MessageBox.Show("Gonna continue?", "Vnimanie",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Produljavane", "Vnimanie",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"{name} {lName} {age}" +
                        $"\n{position} {job}", "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"zaguba na info", "warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAge.Clear();
                    txtLname.Clear();
                    txtName.Clear();
                    cmb.SelectedItem = null;
                    rdChistach.Checked = false;
                    rdProdavach.Checked = false;
                    rdServivitor.Checked = false;
                    rdShofyor.Checked = false;
                    checkBox1.Checked = false;

                }
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
