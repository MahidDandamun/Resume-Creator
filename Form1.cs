using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
