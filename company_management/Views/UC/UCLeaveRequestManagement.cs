﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_management.Views
{
    public partial class UCLeaveRequestManagement : UserControl
    {
        public UCLeaveRequestManagement()
        {
            InitializeComponent();
        }

        private void btnLR_Click(object sender, EventArgs e)
        {
            FormLeaveQuest formLR = new FormLeaveQuest();
            formLR.ShowDialog();
        }
    }
}
