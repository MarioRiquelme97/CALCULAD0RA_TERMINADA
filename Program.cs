





double num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
string operacion;
double resultado;
string reinicio = "SI";
string SALIR = "NO";


while (reinicio == "SI")
{
    Console.WriteLine("Digite operacion");
    Console.WriteLine("SUMA");
    Console.WriteLine("RESTA");
    Console.WriteLine("MULTI");
    Console.WriteLine("DIVI");
    operacion = Console.ReadLine();


    Console.WriteLine("Digite Numero");
    string entrada1 = Console.ReadLine();
    num1 = Convert.ToDouble(!string.IsNullOrEmpty(entrada1) ? entrada1 : 0);

    Console.WriteLine("Digite Numero");
    string entrada2 = Console.ReadLine();
    num2 = Convert.ToDouble(!string.IsNullOrEmpty(entrada2) ? entrada2 : 0);

    Console.WriteLine("Digite Numero");
    string entrada3 = Console.ReadLine();
    num3 = Convert.ToDouble(!string.IsNullOrEmpty(entrada3) ? entrada3 : 0);

    Console.WriteLine("Digite Numero");
    string entrada4 = Console.ReadLine();
    num4 = Convert.ToDouble(!string.IsNullOrEmpty(entrada4) ? entrada4 : 0);

    Console.WriteLine("Digite Numero");
    string entrada5 = Console.ReadLine();
    num5 = Convert.ToDouble(!string.IsNullOrEmpty(entrada5) ? entrada5 : 0);

    Console.Clear();


    if (operacion == "SUMA")
    {
        resultado = num1 + num2 + num3 + num4 + num5;
        Console.WriteLine(resultado);
    }

    if (operacion == "RESTA")
    {
        resultado = num1 - num2 - num3 - num4 - num5;
        Console.WriteLine(resultado);
    }
    if (operacion == "MULTI")
    {
        resultado = num1 * num2 * num3 * num4 * num5;
        Console.WriteLine(resultado);
    }
    if (operacion == "DIVI")
    {
        resultado = num1 / num2 / num3 / num4 / num5;
        Console.WriteLine(resultado);

    }


    Console.WriteLine("OTRA OPERACION?");
    reinicio = Console.ReadLine();

}
Console.Clear();
Environment.Exit(0);