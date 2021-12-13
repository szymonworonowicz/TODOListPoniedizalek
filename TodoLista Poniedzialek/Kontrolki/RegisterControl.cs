﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoLista_Poniedzialek.Kontrolki
{
    public partial class RegisterControl : UserControl
    {
        private MainForm mainForm;
        public RegisterControl(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            Dock = DockStyle.Fill;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            mainForm.PokazLoginControl();
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            mainForm.PokazRegisterControl();
        }
    }
}
