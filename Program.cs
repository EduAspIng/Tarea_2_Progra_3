using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Eduardo_Espinoza
{
    internal class Programa_Tarea_2
    {
        static void Main(string[] args)
        {//Menu de opciones
            int opcion = 0;
            do
            {//opciones
                Console.Clear();
                Console.WriteLine("Seleccione una opcion por favor");
                Console.WriteLine("(1) Ejercicio #1");
                Console.WriteLine("(2) Ejercicio #2");
                Console.WriteLine("(3) Ejercicio #3");
                Console.WriteLine("(4) Salir");
                opcion =int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {           //Llamando los metodos con el switch
                    case 1: Ejercicio_1(); break;
                    case 2: Ejercicio_2(); break;
                    case 3: Ejercicio_3(); break; 
                    case 4: break;
                        Console.Clear();
                    default: Console.WriteLine("Opcion invalida.\nPresiona Enter por favor");
                        Console.ReadLine();
                        break;
                }
            } while (opcion!=4);
        }//Fin del metodo Main

        //Ejercicio 1
        //hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo lleva a precio de costo,
        //si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%,
        //si la persona se lleva más de 5 el descuento es de 20%.
        //El sistema debe solicitar la cantidad de camisas y el precio de las camisas.
/*Metodo 1*/    static void Ejercicio_1()
        {
            float precio = 0f;
            int cantidad = 0;
            
            Console.WriteLine("Digite la cantidad de camisas que lleva el cliente");
            cantidad=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio de las camisas");
            precio = float.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Precio final: {cantidad * precio}");//0% de descuento
            }
            else if (cantidad >= 2 && cantidad <= 5) //si lleva entre 2 y 5 camisas
            {
                float descuento_2_a_5 = cantidad * precio * 0.15f;//15% de descuento
                Console.WriteLine($"Precio final: {((cantidad * precio) - descuento_2_a_5)}");
            }
            else if (cantidad > 5) //si lleva más de 5 camisas
            {
                float descuento_mas_de_5 = cantidad * precio * 0.20f;//20% de descuento
                Console.WriteLine($"Precio final: {((cantidad * precio) - descuento_mas_de_5)}");
            }
            Console.WriteLine("Presiona Enter para salir del ejercicio");
            Console.ReadLine();
        }

        //Ejercicio 2
        //Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación 1. 
        //Deberá leer los siguientes datos para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3.
        //El programa deberá calcular el porcentaje de quices (25%), porcentaje de tareas (30%), y el porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final 
        //y reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas, porcentaje de exámenes, promedio final y condición del estudiante.
        //La condición del estudiante esta con base a: Si el promedio final es mayor o igual a 70 “Aprobado”.
        //si el promedio final es mayor o igual a 50 y menor que 70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”.  
/*Metodo 2*/    static void Ejercicio_2()
        {
            int[] carnet =new int[4];
            String[] nombre = new string[4];
            float[] quiz1 = new float[4];
            float[] quiz2 = new float[4];
            float[] quiz3 = new float[4];
            float[] tarea1 = new float[4];
            float[] tarea2 = new float[4];
            float[] tarea3 = new float[4];
            float[] examen1 = new float[4];
            float[] examen2 = new float[4];
            float[] examen3 = new float[4];
            float[] NotaQuiz = new float[4];
            float[] NotaTarea = new float[4];
            float[] NotaExamen = new float[4];
            float porcentaje_tareas = 0.30f;
            float porcentaje_quices = 0.25f;
            float porcentaje_examenes = 0.45f;
            float[] promedio_final = new float[4];
            String[] condicion = new string[4];

            for (int i = 0; i < carnet.Length; i++)
            {
                Console.Write("Digite el carnet del estudiante: ");
                carnet[i] = int.Parse(Console.ReadLine());

                Console.Write("Digite el nombre del estudiante: ");
                nombre[i]=Console.ReadLine();

                Console.Write("Digite la nota del quiz 1: ");
                quiz1[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del quiz 2: ");
                quiz2[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del quiz 3: ");
                quiz3[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del tarea 1: ");
                tarea1[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del tarea 2: ");
                tarea2[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del tarea 3: ");
                tarea3[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del examen 1: ");
                examen1[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del examen 2: ");
                examen2[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite la nota del examen 3: ");
                examen3[i] = float.Parse(Console.ReadLine());

                NotaQuiz[i] = (((quiz1[i] + quiz2[i] + quiz3[i])/3)*porcentaje_quices);
                NotaTarea[i] = (((tarea1[i]+ tarea2[i]+ tarea3[i])/3)*porcentaje_tareas);
                NotaExamen[i] = (((examen1[i]+ examen2[i]+ examen3[i])/3)*porcentaje_examenes);
                promedio_final[i] = NotaExamen[i] + NotaQuiz[i] + NotaTarea[i];

                if (promedio_final[i]>=70)
                {
                    condicion[i] = "Aprobado";
                }

                else if (promedio_final[i]>=50 && promedio_final[i]<70)
                {
                    condicion[i] = "Aplazado";
                }

                else if (promedio_final[i] < 50)
                {
                    condicion[i] = "Reprobado";
                }
                Console.Clear();
            }
            int indice = 0;
            while (indice< carnet.Length)
            {
                Console.WriteLine($"Carnet: {carnet[indice]} | Estudiante: {nombre[indice]} | %Quices: {NotaQuiz[indice]} " +
                    $"| %Tareas: {NotaTarea[indice]} | %Examenes: {NotaExamen[indice]} " +
                    $"| Nota: {promedio_final[indice]} | Condicion: {condicion[indice]}");
                Console.WriteLine("         ");
                indice++;
            }
            Console.WriteLine("Presiona Enter para salir del ejercicio");
            Console.ReadLine();
        }

        //Ejercicio 3
        //Un vendedor ofrece su producto de la siguiente manera: Si le compran 10 productos o menos, el precio por producto es de $20. Si le compran
        //más de 10 artículos, el precio es de $15 por artículo.
        //muestre como resultado el precio y el total.
/*Metodo 3*/    static void Ejercicio_3()
        {

            int Cantidad_Producto = 0;
            Console.WriteLine("Digite la cantidad del producto que lleva el cliente");
            Cantidad_Producto = int.Parse(Console.ReadLine());

            if (Cantidad_Producto <= 10) //Si le compran 10 productos o menos
            {
                int Precio_Producto = 20;
                Console.WriteLine($"Precio unitario: {Precio_Producto}$ | Precio final: {Cantidad_Producto* Precio_Producto}$");
            }

            else if (Cantidad_Producto > 10)//Si le compran más de 10 artículos
            {
                int Precio_Producto = 15;
                Console.WriteLine($"Precio unitario: {Precio_Producto}$ | Precio final: {Cantidad_Producto * Precio_Producto}$");
            }
            Console.WriteLine("Presiona Enter para salir del ejercicio");
            Console.ReadLine();
        }
    }
}
