using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLista_Poniedzialek.Kontrolki;

namespace TodoLista_Poniedzialek
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //ekran logowania jako domyslny
            PokazLoginControl();
        }

        //metoda wyswietlajaca ekran logowania
        public void PokazLoginControl()
        {
            //czyscimy dotychcczasowe kontrolki
            Controls.Clear();

            //dodajemy do kontrolek konkretna kontrolke ekranu
            Controls.Add(new LoginControl(this));
        }

        //metoda wyswietlajaca ekran logowania
        public void PokazRegisterControl()
        {
            //czyscimy dotychcczasowe kontrolki
            Controls.Clear();

            //dodajemy do kontrolek konkretna kontrolke ekranu
            Controls.Add(new RegisterControl(this));
        }
        //metoda wyswietlajaca ekran logowania
        public void PokazTasksControl()
        {
            //czyscimy dotychcczasowe kontrolki
            Controls.Clear();

            //dodajemy do kontrolek konkretna kontrolke ekranu
            Controls.Add(new TasksControl(this));
        }
    }
}
