﻿using System;

// Использование локальных областей и локальных переменных.

namespace LocalVariables
{
    class Program
    {
        static void Main()
        {
            // ПРАВИЛО:
            // В коде можно создавать локальные области и в двух разных локальных областях хранить одноименные переменные.
                        
            // Локальная область 1
            {
                int a = 1;
                Console.WriteLine(a);
            }

            // Локальная область 2
            {
                int a = 2;
                Console.WriteLine(a);
            }

			
			// ПРАВИЛО:
			// Если в коде имеются локальные области, то запрещается хранить одноименные переменные за пределами локальных областей.

			//int a = 3; // ОШИБКА: Переменная с таким именем уже существует в локальной области.

			// Delay.
			Console.ReadKey();
        }
    }
}