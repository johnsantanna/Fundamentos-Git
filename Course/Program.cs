using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluguel[] a = new Aluguel[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Rent #"+(i+1));
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                a[i] = new Aluguel(nome, email, quarto);
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < n; i++) {
                if (a[i] != null)
                    Console.WriteLine(a[i]);
            }

        }
    }
}
