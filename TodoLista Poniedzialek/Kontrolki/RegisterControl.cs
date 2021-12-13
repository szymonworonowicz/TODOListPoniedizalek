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
            if(mainForm.userManager.CzyLoginWolny(tbLogin.Text))
            {
                User newUser = new User(Guid.NewGuid(), tbImie.Text, tbLogin.Text, tbHaslo.Text);

                mainForm.userManager.DodajUzytkownika(newUser);

                mainForm.PokazTasksControl(newUser);
            }
        }
    }
}
