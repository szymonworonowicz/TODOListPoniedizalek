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
    public partial class TasksControl : UserControl
    {
        private MainForm mainForm;
        public TasksControl(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            Dock = DockStyle.Fill;

        }
    }
}
