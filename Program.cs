double valorInicial = 0;
string menu;
calculadora calc = new calculadora(valorInicial);

do
{
    Console.WriteLine("¿Que operacion desea realizar?");
    Console.WriteLine("\n1.Suma\n2.Resta\n3.Multiplicar\n4.Dividir\n5.Limpiar");
    int flag = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero:");
    string numero = Console.ReadLine();
    double N = Convert.ToDouble(numero);
    
    switch (flag)
    {
        case 1:
            calc.Suma(N);
        break;

        case 2:
            calc.Resta(N);
        break;

        case 3:
            calc.Multiplicacion(N);
        break;

        case 4:
            calc.Division(N);
        break;

        case 5:
            calc.Limpiar();
        break;

        default:
            Console.WriteLine("Error");
        break;
    }
    Console.WriteLine("El resultado es: " + calc.resultado);
    Console.WriteLine("¿Desea realizar otra opreacion? 1.Si 2.No");
    menu = Console.ReadLine();
} while (menu=="1");