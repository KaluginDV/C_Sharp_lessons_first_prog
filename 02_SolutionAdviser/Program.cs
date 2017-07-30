using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа поможет найти фильм, который будет вам по душе.");
			Console.WriteLine("Как вас зовут?");
			String name = Console.ReadLine();

			Console.WriteLine("Здравствуте, " + name);

			Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, эротика, триллер, боевик?");
			String genre = Console.ReadLine();


			if (genre == "комедия")
			{
				Console.WriteLine("Какой фильм вам бы сейчас больше хотелось посмотреть: отечественный или зарубежный?");
				String country = Console.ReadLine();
				if (country == "отечественный")
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Иван Васильевич меняет профессию");
					Console.WriteLine("* Операция «Ы» и другие приключения Шурика");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Назад в будущее");
					Console.WriteLine("* В джазе только девушки");
				}
			}
			else if (genre == "фантастика")
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Люди икс");
				Console.WriteLine("* Черепашки ниндзя");
			}
			else if (genre == "триллер")
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Начало");
				Console.WriteLine("* Бойцовский клуб");
			}
			else if (genre == "боевик")
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
				Console.WriteLine("* Темный рыцарь");
				Console.WriteLine("* Матрица");
			}
			else if (genre == "эротика")
			{
				Console.WriteLine("Сколько вам лет?");
				String yearString = Console.ReadLine();
				int years = Int32.Parse(yearString);
				if (years < 18)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("К сожалению, этот жанр доступен только для пользователей 18+");
					Console.WriteLine("Приходите через " + (18 - years) + " лет");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("В таком случае, рекомендую посмотреть вам следуюдие фильмы:");
					Console.WriteLine("* Эммануэль");
					Console.WriteLine("* Нимфоманка");
				}
			}
			else
			{
				Console.WriteLine("* Зеленая миля");
				Console.WriteLine("* Побег из Шоушенка");
			}

			Console.ReadLine();
		}
	}
}
