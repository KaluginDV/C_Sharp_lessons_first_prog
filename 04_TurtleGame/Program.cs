using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Подключаем библиотеку SmallBasic
using Microsoft.SmallBasic.Library;

namespace _04_TurtleGame
{
	class Program
	{
		static void Main(string[] args)
		{
			GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;

			Turtle.PenUp();

			GraphicsWindow.BrushColor = "Red";

			var eat = Shapes.AddRectangle(10,10);
			var eatPosX = 200;
			var eatPosY = 200;
			Random rand = new Random();

			Shapes.Move(eat, eatPosX, eatPosY);

			while (true)
			{
				Turtle.Move(10);
				if (Turtle.X >= eatPosX 
					&& Turtle.X <= eatPosX + 10  
					&& Turtle.Y >= eatPosY 
					&& Turtle.Y <= eatPosY + 10)
				{
					eatPosX = rand.Next(0,GraphicsWindow.Width);
					eatPosY = rand.Next(0,GraphicsWindow.Height);
					Shapes.Move(eat, eatPosX, eatPosY);
					Turtle.Speed += 1; 
				}
			}
		}

		private static void GraphicsWindow_KeyDown()
		{
			if (GraphicsWindow.LastKey == "Up")
			{
				Turtle.Angle = 0;
			}
			else if (GraphicsWindow.LastKey == "Right")
			{
				Turtle.Angle = 90;
			}
			else if (GraphicsWindow.LastKey == "Down")
			{
				Turtle.Angle = 180;
			}
			else if (GraphicsWindow.LastKey == "Left")
			{
				Turtle.Angle = 270;
			}
		}
	}
}
