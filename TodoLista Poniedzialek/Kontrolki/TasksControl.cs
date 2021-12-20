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

			foreach (TodoTask zadanie in taskManager.PobierzZadania(currentUser.Id))
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
			// kolejne dodajemy jako dodatkowe elementy 
			item.SubItems.Add(zadanie.Tytul);
			// wyznaczamy znak do wyświetlenia
			// jeżeli zadanie skończone to pokazujemy ticzek,
			// jak nie to krzyżyk
			string skonczone = zadanie.Zrobione ? "✓" : "X";

			item.SubItems.Add(skonczone);
			// dodajemy element do listy zadań

			lvZadania.Items.Add(item);
		}

		private void btnWyloguj_Click(object sender, EventArgs e)
		{
			mainForm.PokazLoginControl();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// sprawdzamy czy jest zaznaczone jakieś zadanie na liście
			if (lvZadania.SelectedItems.Count == 0)
			{
				// jeżeli nie to wyświetlamy messagebox z komunikatem
				MessageBox.Show("Nie wybrano zadnego zadania do usuniecia", "Błąd",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// pobieramy z pierwszego zaznaczonego zadania
				// (można zaznaczyć tylko jedno bo tak skonfigurowaliśmy listę)
				// pierwszą kolumnę (czyli Id)
				string zaznaczoneZadanieId = lvZadania.SelectedItems[0].SubItems[0].Text;
				// przekazujemy menadzerowi zadanie do usunięcia
				taskManager.UsunZadanie(int.Parse(zaznaczoneZadanieId));
				lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
			}
		}
	}
}
