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
        private TodoTaskManager taskManager;

        public TasksControl(MainForm form, User user)
        {
            InitializeComponent();
            mainForm = form;
            Dock = DockStyle.Fill;

            currentUser = user;

            lblZalogowanyWartosc.Text = user.Imie;

            taskManager = new TodoTaskManager();

            foreach(TodoTask zadanie in taskManager.PobierzZadania(currentUser.Id))
            {
                DodajZadanieDoListy(zadanie);
            }
        }

        // metoda wyświetlająca zadanie w kontrolce ListView
        private void DodajZadanieDoListy(TodoTask zadanie)
        {
            // kontrolka ListView wyświetla elementy typu ListViewItem
            // pierwsząkolumne podajemy tworząc obiekt
            ListViewItem item = new ListViewItem(zadanie.Id.ToString());
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            mainForm.PokazLoginControl();
        }
    }
}
