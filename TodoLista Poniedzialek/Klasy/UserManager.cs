using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_Poniedzialek.Klasy
{
    public  class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            //stworzenie listy
            users = new List<User>();
            //dodanie testowego uzytkownika
            users.Add(new User(Guid.NewGuid(), "test", "test", "text"));
        }

        //wyszukiwanie uzytkownika po hasle i loginie 
        public User WyszukajUzytkownika(string login, string haslo)
        {
            foreach (User user in users)
            {
                if (user.Login == login && user.Haslo == haslo)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
