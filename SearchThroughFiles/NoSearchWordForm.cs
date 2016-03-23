using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchThroughFiles
{
    public partial class NoSearchWordForm : Form
    {
        public NoSearchWordForm()
        {
            InitializeComponent();
            this.Text = "No Search Word";
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
