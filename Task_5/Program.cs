// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program {
    static void Main(string[] args) {
        int[,] arr = new int[4, 4];
        int num = 1, x = 0, y = 0;

        for (int i = 0; i < 2; i++) {
            // заполнение верхней горизонтальной линии слева направо
            for (int j = 0; j < 4 - i * 2; j++) {
                arr[x, y++] = num++;
            }
            y--;
            x++;

            // заполнение правой вертикальной линии сверху вниз
            for (int j = 0; j < 2 - i; j++) {
                arr[x++, y] = num++;
            }
            x--;
            y--;

            // заполнение нижней горизонтальной линии справа налево
            for (int j = 0; j < 4 - i * 2 - 1; j++) {
                arr[x, y--] = num++;
            }
            y++;
            x--;

            // заполнение левой вертикальной линии снизу вверх
            for (int j = 0; j < 2 - i - 1; j++) {
                arr[x--, y] = num++;
            }
            x++;
            y++;
        }

        // вывод массива на экран
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

