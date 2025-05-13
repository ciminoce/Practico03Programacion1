namespace Ejercicio01B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero cualquiera:");

            if (int.TryParse(Console.ReadLine(), out int nro))
            {
                Console.WriteLine(TipoNumero(nro));
                Console.WriteLine(InformarCondicionNumero(nro));
            }
            else
            {
                Console.WriteLine("Nro mal ingresado");
            }
            Console.ReadKey();
        }
        static string InformarCondicionNumero(int numero)
        {
            if(numero==0){ return $"{numero} es neutro";}
            if (numero % 2 == 0)//PSeint numero MOD 2=0
            {
                return $"{numero} es par";
            }
            else
            {
                return $"{numero} es impar";
            }

        }
        static string TipoNumero(int numero)
        {
            if (numero > 0)
            {
                return $"{numero} es positivo";
            }
            else if (numero < 0)
            {
                return $"{numero} es negativo";
            }
            else
            {
                return $"{numero} es cero";
            }
        }

    }
}
