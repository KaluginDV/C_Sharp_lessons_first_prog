using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Подключаем библиотеку SmallBasic
using Microsoft.SmallBasic.Library;

namespace _03_TurtleTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			//Инициализация основных переменных
			int i = 0;
			int turteStep = 40;
			int turtleAngle = -90;
			//Нужно запомнить изначальные координаты (не факт, что они (0,0))
			int turtlePosX = Turtle.X;
			int turtlePosY = Turtle.Y;

			//Скорость черепашки
			Turtle.Speed = 9;

			while (i < 16)
			{
				//Поворачиваем черепашку каждые два шага в противоположную сторону
				if (i % 2 == 0)
				{
					turtleAngle = turtleAngle * (-1);
				}
				//Черепашка рисует змейку
				Turtle.Move(turteStep);
				Turtle.Turn(turtleAngle);
				i++;
			}

			//Устанавливаем черепашку на новое место
			Turtle.X = turtlePosX - 15;
			Turtle.Y = turtlePosY + 80;

			//Обнуляем счетчик
			i = 0;

			//Новые значения переменных для прорисовки шестиугольника
			turtleAngle = 60;
			turteStep = 200;

			//Черепашка рисует шестиугольник
			while (i < 6)
			{
				Turtle.Move(turteStep);
				Turtle.Turn(turtleAngle);
				i++;
			}
		}
	}
}
