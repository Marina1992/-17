using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание17
{/*  Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
  *  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
  *  Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типам. 
  *  Заполнить его поля и вывести информацию об экземпляре класса на печать. */
	class Program
	{
		static void Main(string[] args)
		{
			Bank<string> account1 = new Bank<string>(" сто три",1222.4,"Иванов Иван Иванович");
			
			account1.GiveInfo<string>();

			Bank<int> account2 = new Bank<int>(124, 3000, "Сергеев Сергей Сергеевич ");

			account2.GiveInfo<int>();


			Console.ReadKey();

		}
	}
	class Bank<T>
	{
		private T _number { get; set; }
		private double _balance { get; set; }

		private string _name { get; set; }

		public void GiveInfo<T>(  )
		{

			 Console.WriteLine($"Номер счета: {_number}\t  Баланс: {_balance } руб.\t Ф.И.О. владельца :{_name} ");
			
		}

		public Bank(T number, double balance, string name)
		{
			_number= number;
			_balance=balance;
			_name = name;
			
		}

		

		





		
	}
}
