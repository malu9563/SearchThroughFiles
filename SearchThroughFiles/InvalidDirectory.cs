﻿using System;
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
    public partial class InvalidDirectory : Form
    {
        public InvalidDirectory()
        {
            InitializeComponent();
            this.Text = "Invalid Directory";
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
