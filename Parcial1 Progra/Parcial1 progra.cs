using System;

class CajeroAutomatico
{
    private double saldo;

    public CajeroAutomatico(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void VerificarSaldo()
    {
        Console.WriteLine($"Saldo disponible: ${saldo}");
    }

    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${saldo}");
        }
        else
        {
            Console.WriteLine("Error: El monto debe ser mayor que cero.");
        }
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${saldo}");
        }
        else if (cantidad > saldo)
        {
            Console.WriteLine("Error: Fondos insuficientes.");
        }
        else
        {
            Console.WriteLine("Error: El monto debe ser mayor que cero.");
        }
    }
}

class Program
{
    static void Main()
    {
        CajeroAutomatico cajero = new CajeroAutomatico(1000);

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n======= Cajero Automático =======");
            Console.WriteLine("1. Verificar Saldo");
            Console.WriteLine("2. Depositar Dinero");
            Console.WriteLine("3. Retirar Dinero");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione opción (1-4): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    cajero.VerificarSaldo();
                    break;
                case "2":
                    Console.Write("Ingrese el monto a depositar: $");
                    if (double.TryParse(Console.ReadLine(), out double cantidadDeposito))
                    {
                        cajero.Depositar(cantidadDeposito);
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese una cantidad válida.");
                    }
                    break;
                case "3":
                    Console.Write("Ingrese la cantidad a retirar: $");
                    if (double.TryParse(Console.ReadLine(), out double montoRetiro))
                    {
                        cajero.Retirar(montoRetiro);
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese una cantidad válida.");
                    }
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("Gracias por utilizar el cajero automático. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Error: Opción no válida. Por favor, seleccione una opción válida (1-4).");
                    break;
            }
        }
    }
}


