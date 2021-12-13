using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLista_Poniedzialek.Klasy;

namespace TodoLista_Poniedzialek.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        private MainForm mainForm;
        private User currentUser;
        public TasksControl(MainForm form, User user)
        {
            InitializeComponent();
            mainForm = form;
            Dock = DockStyle.Fill;

            currentUser = user;

            lblZalogowanyWartosc.Text = user.Imie;
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            mainForm.PokazLoginControl();
        }
    }
}
