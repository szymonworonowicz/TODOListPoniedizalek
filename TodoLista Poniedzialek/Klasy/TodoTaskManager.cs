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

        // metoda zwracająca wszystkie zadania zalogowanego użytkownika z listy
        public List<TodoTask> PobierzZadania(Guid userId)
        {
            // szukamy wszystkich zadań, których userId
            // jest takie jak zalogowanego użytkownika
            List<TodoTask> zadaniaZalogowanego = new List<TodoTask>();

            foreach (TodoTask zadanie in zadania)
            {
                if (zadanie.UserId == userId)
                {
                    zadaniaZalogowanego.Add(zadanie);
                } 
            }

            return zadaniaZalogowanego;
        }

        public int ObliczNastepneId()
        {
            //zmienna na maksymalne id
            int max = 0;
            // iterujemy po wszystkich zadaniach
            foreach (TodoTask zadanie in zadania)
            {
                // jeżeli id kolejnego zadania większe
                if (zadanie.Id > max)
                {
                    max = zadanie.Id;
                } 
            }
            // numer następnego zadania będzie o jeden większy
            // od maksymalnego numeru zadań, które są na liście
            return max + 1;
        }
    }
}
