using System;
using System.Runtime.CompilerServices;

namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[9];

            string name, email;
            int room, qt;

            Console.Write("QUANTIDADE DE ESTUDANTES: ");
            qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++)
            {
                Console.Write("NOME: ");
                name = Console.ReadLine();

                Console.Write("EMAIL: ");
                email = Console.ReadLine();

                Console.Write("QUARTO: ");
                room = int.Parse(Console.ReadLine());

                students[room] = new Student { Room = room, Email = email, Name = name };

            }

            for (int j = 0; j <= 8; j++)
            {
                if (students[j] != null)
                {
                    Console.WriteLine($"Quarto: {students[j].Room}");
                    Console.WriteLine($"Nome: {students[j].Name}");
                    Console.WriteLine($"Email: {students[j].Email}");
                    Console.WriteLine();
                }
            }
        }
    }
}