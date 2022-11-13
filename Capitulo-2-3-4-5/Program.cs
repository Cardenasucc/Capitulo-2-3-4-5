//capitulo 2
namespace ejercicio2_3
{
    public class Progam
    {
        public static void Main()
        {
            double resultado1;
            double resultado2;
            int num;
            num = 2;
            resultado1 = Math.Pow(num, 0);
            resultado2 = Math.Pow(num, 10);
            Console.WriteLine($"El resultado de las potencias de 2 entre 0 es: {resultado1}");
            Console.WriteLine("");
            Console.WriteLine($"El resultado de las potencia de 2 entre 10 es: {resultado2}");
        }
    }
}
