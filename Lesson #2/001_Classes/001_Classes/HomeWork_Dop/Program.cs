using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.  
//Создать экземпляр класса Address.  
//В поля экземпляра записать информацию о почтовом адресе.  
//Выведите на экран значения полей, описывающих адрес.


namespace HomeWork_Dop
{
	class Address
	{
		public int index;
		public string country;
		public string city;
		public string street;
		public int house;
		public int apartament;

		
		////////////////////////////////////////////////  Страна
		public void SetCountry(string Country)
		{
			country = Country;
		}

		public string GetCountry()
		{
			return country;
		}
		////////////////////////////////////////////////  Город
		public void SetCity(string City)
		{
			city = City;
		}

		public string GetCity()
		{
			return city;
		}
		////////////////////////////////////////////////  Улица
		public void SetStreet(string Street)
		{
			street = Street;
		}

		public string GetStreet()
		{
			return street;
		}
		////////////////////////////////////////////////  Дом
		public void SetHouse(int House)
		{
			house = House;
		}

		public int GetHouse()
		{
			return house;
		}
		////////////////////////////////////////////////  Квартира
		public void SetApartament(int Apartament)
		{
			apartament = Apartament;
		}

		public int GetApartament()
		{
			return apartament;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{

			Address adress = new Address();// экземпляр класса Address

			adress.index = 220007;
			adress.country = "GB";
			adress.city = "London";
			adress.street = "Watson";
			adress.house = 13;
			adress.apartament = 227;

			Console.WriteLine(adress.index);
			Console.WriteLine(adress.country);
			Console.WriteLine(adress.city);
			Console.WriteLine(adress.street);
			Console.WriteLine(adress.house);
			Console.WriteLine(adress.apartament);

			//задержка
			Console.ReadKey();
		}
	}
}
