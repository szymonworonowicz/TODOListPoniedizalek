using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoLista_Poniedzialek.Klasy
{
	public class TodoTask
	{
		public int Id;
		public Guid UserId;
		public string Tytul;
		public string Opis;
		public bool Zrobione;

		public TodoTask(int id, Guid userId, string tytul, string opis, bool zrobione)
		{
			Id = id;
			UserId = userId;
			Tytul = tytul;
			Opis = opis;
			Zrobione = zrobione;
		}
	}
}
