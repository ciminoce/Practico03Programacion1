namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero cualquiera:");
            //bool esValido = int.TryParse(Console.ReadLine(), out int nro);
            //if (esValido)
            //{
            //    Console.WriteLine(nro);
            //}
            //else
            //{
            //    Console.WriteLine("Nro no válido");
            //}
            if(int.TryParse(Console.ReadLine(),out int nro))
            {
                if (nro > 0)
                {
                    Console.WriteLine($"{nro} es positivo");
                }
                else if (nro < 0)
                {
                    Console.WriteLine($"{nro} es negativo");
                }
                else
                {
                    Console.WriteLine($"{nro} es cero");
                }

                if (nro % 2 == 0)//PSeint nro MOD 2=0
                {
                    Console.WriteLine($"{nro} es par");
                }
                else
                {
                    Console.WriteLine($"{nro} es impar");
                }
            }
            else
            {
                Console.WriteLine("Nro mal ingresado");
            }
        }
    }
}
