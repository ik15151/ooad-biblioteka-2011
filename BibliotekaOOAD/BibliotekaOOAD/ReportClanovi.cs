﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReportClanovi : Form
    {
        public ReportClanovi()
        {
            InitializeComponent();
        }

        private void Članovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ooadtim6DataSet.clanovi_biblioteke' table. You can move, or remove it, as needed.
            this.clanovi_bibliotekeTableAdapter.Fill(this.ooadtim6DataSet.clanovi_biblioteke);

            this.reportViewer1.RefreshReport();
        }
    }
}
