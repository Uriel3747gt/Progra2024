using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial2Programacion;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        using System;
        using System.Collections.Generic;

// Clase base Calculadora
public class Calculadora
    {
        // Funcion para sumar
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Funcion para restar 
        public double Restar(double a, double b)
        {
            return a - b;
        }

        // Funcion para multiplicar 
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Funcion para dividir 
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }

    // Clase Calculadora_Cientifica
    public class CalculadoraCientifica : Calculadora
    {
        // Funcion para calcular la raíz cuadrada
        public double RaizCuadrada(double a)
        {
            return Math.Sqrt(a);
        }

        // Funcion para calcular una potencia
        public double Potencia(double a, double exponente)
        {
            return Math.Pow(a, exponente);
        }

        // Funcion para funciones trigonométricas
        public double Seno(double a)
        {
            return Math.Sin(a);
        }

        public double Coseno(double a)
        {
            return Math.Cos(a);
        }

        public double Tangente(double a)
        {
            return Math.Tan(a);
        }
    }

    // Clase para la funcion de memoria
    public class Memoria
    {
        private List<string> operaciones;

        public Memoria()
        {
            operaciones = new List<string>();
        }

        // Funcion para agregar una operación a la memoria
        public void AgregarOperacion(string operacion)
        {
            operaciones.Add(operacion);
        }

        // Funcion para consultar las operaciones almacenadas en la memoria
        public List<string> ConsultarOperaciones()
        {
            return operaciones;
        }
    }

    

}
}