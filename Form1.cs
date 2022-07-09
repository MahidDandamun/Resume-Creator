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


namespace Resume_Creator
{
    public partial class FrmResumeCreator : Form
    {
        public FrmResumeCreator()
        {
            InitializeComponent();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cbxNavigateFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Selec File";
            open.InitialDirectory = @"E:\Downloads";
            open.Filter = "All files(*.*)|*.*|Text File (*.json)|*.json";
            open.FilterIndex = 1;
            open.ShowDialog();
            if (open.FileName!="")
            {
                cbxNavigateFiles.Text = open.FileName;
            }
            else
            {
                cbxNavigateFiles.Text = "";
            }
        }

        private void btnCreateResume_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your resume is now created");
            DialogResult dialogResult = MessageBox.Show("Do you want to create another one?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
