using System;
using System.Collections.Generic;


namespace shirina_2
{
    class Program
    {
        

        static void BFS(int v, int[,] matrix, bool[] visited,int size) {

            Queue<int> queue = new Queue<int>(); //Создаем новую очередь
            queue.Enqueue(v); //Помещаем v в очередь
            visited[v] = true;
            Console.WriteLine();
            Console.Write("Результат обхода:  ");
            while (queue.Count != 0)
            {
                int dv = queue.Dequeue();//Удаляем первый элемент из очереди
                
                Console.Write($"{dv}");
                
                for (int i = 0; i < size; i++)
                {
                    if (matrix[dv,i] == 1 && !visited[i])
                    {
                        queue.Enqueue(i); //Помещаем i в очередь
                    }
                }
                visited[dv] = true;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите вершину для начала обхода:");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность матрицы:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] M = new int[size,size];
            bool[] NUM = new bool[size];
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("Сгененрированная матрица:\t");
            

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    M[i, j] = random.Next(2);
                    M[j, i] = M[i, j];
                }
            }

                    for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                    Console.Write($"{M[i,j]}, \t");

                }
                Console.WriteLine();
            }

            while (NUM[v] != true)
            {
                BFS(v, M, NUM, size);
            }
        }
    }
}
