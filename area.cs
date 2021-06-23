 static void Main(string[] args)
        {

            const double pi=3.14159265358979323846264338327950;

            double raio= 10;
            double area ;

            Console.WriteLine("Calculo da área de um circulo\n");
            Console.WriteLine("Formula: area= pi*raio^2\n");

            area=pi * Math.Pow(raio,2);

             Console.WriteLine("Area={0}",area);
            Console.WriteLine("Area={0:N}",area);
            Console.WriteLine("Area={0:N5}",area);

            Console.ReadKey();

        }
    }
}
