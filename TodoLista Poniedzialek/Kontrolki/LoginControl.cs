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
    public partial class LoginControl : UserControl
    {
        private MainForm mainForm;
        public LoginControl(MainForm form)
        {
            InitializeComponent();

            //przekazanie referencji na glowny formularz
            mainForm = form;
            //konttolka zajmuje cal apowierzchnie okna
            Dock = DockStyle.Fill;
        }


        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            //sprawdzamy czy textboxy nie sa puste
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(lblHaslo.Text))
            {
                lblWalidacjaLogowania.Visible = true;
                lblWalidacjaLogowania.Text = "Login lub hasło nie może być puste";
            }
            else
            {
                // jeżeli login i hasło podane to sprawdzamy czy taki użytkownik
                // istnieje za pomoca metody do wyszukiwania użytkowników
                // wiemy, że jak zwróci null to nie ma takiego użytkownika
                User user = mainForm.userManager.WyszukajUzytkownika(tbLogin.Text, tbHaslo.Text);
                if (user == null)
                {
                    lblWalidacjaLogowania.Visible = true;
                    lblWalidacjaLogowania.Text = "Podany uzytkownik nie istnieje";

                }
                else
                {
                    mainForm.PokazTasksControl(user);

                }
            }
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            mainForm.PokazRegisterControl();
        }
    }
}
