using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_Poniedzialek.Klasy
{
    //klasa do zarzadzania zadaniami
    public class TodoTaskManager
    {
        //lista zadan
        private List<TodoTask> zadania;

        public TodoTaskManager()
        {
            zadania = new List<TodoTask>();
        }

        // metoda zwracająca zadanie znalezione po Id
        public TodoTask ZnajdzZadanie(int id)
        {
            //iterujemy po wszystkich zadaniach
            foreach (TodoTask task in zadania)
            {
                // jak znalezione zadanie ma id takie jak przekazane
                // to je zwracamy
                if (task.Id == id)
                {
                    return task;
                }
            }
            // jeżeli nie ma zadania o podanym id to zwraqcamy nulla
            return null;
        }

        //dodawanie zadania na liste
        public void DodajZadanie(TodoTask zadanie)
        {
            zadania.Add(zadanie);
        }
        //usuniecie zadania z listy
        public void UsunZadanie(int id)
        {
            TodoTask zadanie = ZnajdzZadanie(id);
            zadania.Remove(zadanie);
        }
    }
}
