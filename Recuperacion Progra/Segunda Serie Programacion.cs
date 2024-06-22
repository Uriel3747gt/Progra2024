using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double suma = Sumar(numero1, numero2);
        double resta = Restar(numero1, numero2);
        double multiplicacion = Multiplicar(numero1,numero2);
        double division = Dividir(numero1, numero2);

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }

    static double Sumar(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Restar(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return 0;
        }
        return num1 / num2;
    }
}
