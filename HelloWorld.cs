using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)  
        {    
            /* Crear un array que deba de contener el siguiente menú de opciones:
             * 1 - Registrar los datos en el array y tres datos a registrar.
             * 2 - Buscar los datos en el array.
             * 3 - Modificar los datos del array.  
             * 4 - Eliminar los datos del array.
             * 5 - Mostrar la información del array.
             * 6 - Salir o terminar la ejecución.
             * Nota: Para eliminar el elemento del array; preguntaremos cuantos 
             * indices tendrá el array.
            */
            
            // Declaración de variables:
            int opcion = 0, numeroAnimal = 0, cantIndice = 0;
            string buscarAnimal = "", nuevoAnimal = "";
            Console.WriteLine("Indique la cantidad de elementos que ingresará:");
            cantIndice = int.Parse(Console.ReadLine());
            string[] animales = new string[cantIndice];
            
            // Menú:
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Registrar.");
                Console.WriteLine("2 - Buscar.");
                Console.WriteLine("3 - Modificar.");
                Console.WriteLine("4 - Eliminar.");
                Console.WriteLine("5 - Mostrar.");
                Console.WriteLine("6 - Salir.");
                Console.WriteLine("****************");
                // Leemos la variable por teclado.
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: 
                        // Registrar:
                        Console.Clear(); // Borra anterior.
                        for (int i = 0; i < animales.Length; i++)
                        {
                            numeroAnimal = i + 1;
                            Console.WriteLine("Ingrese el nombre del animal Nº: " + numeroAnimal);
                            animales[i] = Console.ReadLine();
                        }
                        break;
                    case 2: 
                        // Buscar:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del animal");
                        buscarAnimal = Console.ReadLine();
                        foreach (string item in animales)
                        {
                            if (item == buscarAnimal)
                            {
                                Console.WriteLine("Se ha encontrado el resultado: " + item);
                            }
                            else
                            {
                                Console.WriteLine("No se ha encontrado la búsqueda realizada");
                            }
                        }
                        break;
                    case 3: 
                        // Modificar:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del animal a modificar:");
                        buscarAnimal = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo nombre para el animal:");
                        nuevoAnimal = Console.ReadLine();
                        for (int i = 0; i < animales.Length; i++)
                        {
                            if (animales[i] == buscarAnimal)
                            {
                                animales[i] = nuevoAnimal;
                                Console.WriteLine("Los datos han sido modificados.");
                            }
                        }
                        break;
                    case 4: 
                        // Eliminar:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del animal a eliminar:");
                        buscarAnimal = Console.ReadLine();
                        for (int i = 0; i < animales.Length; i++)
                        {
                            if (animales[i] == buscarAnimal)
                            {
                                animales[i] = "";
                            }
                        }
                        // for para rellenar el espacio vacio al eliminar un elemento:
                        int indiceEncontrado = 0;
                        for (int i = 0; i < animales.Length; i++)
                        {
                            if (animales[i] == "")
                            {
                                indiceEncontrado = i;
                            }
                        }
                        animales = animales.Where((source, index) => index != indiceEncontrado).ToArray();
                        break;
                    case 5: 
                        // Mostrar:
                        Console.Clear();
                        foreach (string item in animales)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 6: 
                        // Salir:
                        Console.WriteLine("Saliendo del programa...");
                        break;  
                    default:
                    Console.WriteLine("La opción ingresada no es válida.");
                        break;
                }
            } while (opcion < 6);
        } 
    }   
}


