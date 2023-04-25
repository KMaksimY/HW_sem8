using System;

class Program {
    static void Main(string[] args) {
        // задаем двумерный массив
        int[,] arr = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        // проходим по каждой строке массива
        for (int i = 0; i < arr.GetLength(0); i++) {
            // создаем временный одномерный массив для сортировки
            int[] tempArr = new int[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++) {
                tempArr[j] = arr[i, j];
            }

            // сортируем элементы строки в порядке убывания
            Array.Sort(tempArr, new Comparer());

            // копируем отсортированные элементы обратно в исходный массив
            for (int j = 0; j < arr.GetLength(1); j++) {
                arr[i, j] = tempArr[j];
            }

            // выводим элементы строки
            for (int j = 0; j < arr.GetLength(1); j++) {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // класс для сравнения элементов в порядке убывания
    class Comparer : System.Collections.IComparer {
        public int Compare(object x, object y) {
            int a = (int)x;
            int b = (int)y;
            if (a > b) {
                return -1;
            } else if (a < b) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}
