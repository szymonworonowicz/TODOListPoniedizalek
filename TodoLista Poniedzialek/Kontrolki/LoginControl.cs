using System;
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
            mainForm.PokazTasksControl();
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            mainForm.PokazRegisterControl();
        }
    }
}
