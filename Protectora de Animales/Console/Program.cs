using System;
using System.Collections.Generic;
using Services;
using Shared;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Usuarios");
            Console.WriteLine("2. Adopciones");
            Console.WriteLine("3. Seguimientos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MenuUsuarios();
                    break;
                case "2":
                    MenuAdopciones();
                    break;
                case "3":
                    MenuSeguimientos();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MenuUsuarios()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Usuarios ===");
            Console.WriteLine("1. Cargar usuario");
            Console.WriteLine("2. Mostrar todos");
            Console.WriteLine("0. Volver");
            Console.Write("Seleccione una opción: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Iniciando Carga de Usuario...");
                    User newUser = CreateNewUser();
                    UserService.Instance.Save(newUser);
                    break;
                case "2":
                    Console.WriteLine("Mostrando todos los usuarios...");
                    List<User> users = UserService.Instance.GetAll();
                    users.ForEach(x => Console.WriteLine($"{x.Name} - {x.Id}"));

                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void MenuAdopciones()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Adopciones ===");
            Console.WriteLine("1. Registrar adopción");
            Console.WriteLine("2. Ver historial");
            Console.WriteLine("0. Volver");
            Console.Write("Seleccione una opción: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (UserService.Instance.IsEmpty())
                    {
                        Console.WriteLine("No existen usuarios cargados. Abortando carga de Adopción.");
                        break;
                    }
                    Console.WriteLine("Ingrese los datos de adopción...");
                    // TODO: lógica
                    break;
                case "2":
                    Console.WriteLine("Historial de adopciones...");
                    // TODO
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void MenuSeguimientos()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Seguimientos ===");
            Console.WriteLine("1. Nuevo seguimiento");
            Console.WriteLine("2. Ver seguimientos");
            Console.WriteLine("0. Volver");
            Console.Write("Seleccione una opción: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Creando seguimiento...");
                    // TODO
                    break;
                case "2":
                    Console.WriteLine("Listado de seguimientos...");
                    // TODO
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    private static User CreateNewUser()
    {
        string name;
        string dni;
        Console.WriteLine("Ingrese nombre del Usuario:");
        name = Console.ReadLine();
        Console.WriteLine("Ingrese DNI del usuario:");
        dni = Console.ReadLine();

        User newUser = new User(
            Guid.NewGuid().ToString(),
            name,
            dni);
        return newUser;
    }
}