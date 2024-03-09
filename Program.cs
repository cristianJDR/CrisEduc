using System;

namespace Proecto_final
{
    class Program
    {
        static void procesos()
        {
            Console.WriteLine("\n¿Qué Proceso desea realizar el dia de hoy?");
            Console.WriteLine("1. Calificar.");
            Console.WriteLine("2. Cálcular el promedio final.");
            Console.WriteLine("3. Editar notas.");
            Console.WriteLine("4. Salir de la plataforma");
        }

        public static void Main()
        {
            const string us1 = "Andres";
            const string pw1 = "1234";
            int option = 0, edition = 0, consult = 01, j, parcial;
            string user, password, name, last_name;
            bool correct = false;
            double final_proyect = 0, promedio, A = 0, B = 0, nota = 0, new_proyect = 0;

            double[] taller = new double[5];
            double[] prueba = new double[2];

            Console.WriteLine("            *******************");
            Console.WriteLine("                 Cris Educ");
            Console.WriteLine("            *******************");

            int intentos = 0, y = 3;
            Console.WriteLine("Cuenta con " + y + " intentos para poder loguearse.");
            while (intentos < y)
            {
                Console.WriteLine("\nPor favor de ingresar su usuario para utilizar el programa");
                Console.WriteLine("Usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("\nPor favor ingrese su contraseña");
                password = Console.ReadLine();
                Console.WriteLine("Tiene " + (y - 1) + " Intentos disponibles");
                intentos++;
                if (user == us1 && password == pw1)
                {
                    correct = true;
                    break;
                }
            }


            if (correct)
            {


                Console.Clear();
                Console.WriteLine("Usuario y contraseña correctos.");
                Console.WriteLine("\nHola profesor " + us1 + ", Bienvenido a la plataforma Cris Educ");

                Console.WriteLine("Ahora ingrese los datos del estudiante de su curso.");
                Console.WriteLine("\nIngrese el nombre del Estudiante :");
                name = Console.ReadLine();
                Console.WriteLine("\nIngrese el apellido del estudiante :");
                last_name = Console.ReadLine();
                Console.WriteLine("\nDatos registrados con exito!");
                procesos();

                do
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {

                        case (1):

                            Console.Clear();
                            for (j = 0; j < 5; j++)
                            {

                                Console.WriteLine("\nCalificación para el taller " + (j + 1) + ":");
                                taller[j] = Convert.ToSingle(Console.ReadLine());
                                A = taller[0] + taller[1] + taller[2] + taller[3] + taller[4];

                            };

                            Console.WriteLine("\nAhora haga lo mismo con los parciales: ");
                            for (parcial = 0; parcial < 2; parcial++)
                            {
                                Console.WriteLine("\nCalificación para el parcial: " + (parcial + 1) + ":");
                                prueba[parcial] = Convert.ToSingle(Console.ReadLine());
                                B = prueba[0] + prueba[1];
                            }
                            Console.WriteLine("\nDigite la nota del proyecto final: ");
                            final_proyect = Convert.ToSingle(Console.ReadLine());
                            procesos();
                            break;

                        case (2):
                            Console.Clear();
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\nPara el estudiante: " + name + " " + last_name);
                            Console.WriteLine("\nLas notas son las siquientes:");
                            for (j = 0; j < 5; j++)
                            {
                                Console.WriteLine("\nCalificación del taller " + (j + 1) + " es:" + taller[j]);
                            }

                            for (parcial = 0; parcial < 2; parcial++)
                            {
                                Console.WriteLine("\nCalificación del parcial " + (parcial + 1) + " es:" + prueba[parcial]);
                            }
                            Console.WriteLine("\nLa nota actual que el estudiante tiene como proyecto final es: " + final_proyect);

                            Console.WriteLine("------------------------------------------");
                            promedio = A + B + final_proyect;
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\nEl estudiante cuenta con: " + promedio + " puntos.");
                            Console.WriteLine("------------------------------------------");
                            promedio = A + B + final_proyect;
                            nota = (promedio) / 8;
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\nLo cual da una nota promedio de : " + nota);
                            Console.WriteLine("------------------------------------------");
                            promedio = A + B + final_proyect;
                            if (nota >= 91)
                            {
                                Console.WriteLine("\nEl promedio final es A, El estudiante a aprobado.");
                                Console.WriteLine("------------------------------------------");
                            }
                            else if (nota >= 81)
                            {
                                Console.WriteLine("\nEl promedio final es B, El estudiante a aprobado.");
                                Console.WriteLine("------------------------------------------");
                            }
                            else if (nota >= 71)
                            {
                                Console.WriteLine("\nEl promedio final es C, El estudiante a aprobado.");
                                Console.WriteLine("------------------------------------------");
                            }
                            else if (nota < 71)
                            {
                                Console.WriteLine("\nEl estudiante a fracasado");
                                Console.WriteLine("------------------------------------------");
                            }
                            procesos();
                            break;

                        case (3):
                            Console.Clear();
                            while (edition != 8)
                            {
                                Console.WriteLine("\n¿Qué nota desea editar?.");
                                Console.WriteLine("5.Talleres.");
                                Console.WriteLine("6.Parciales.");
                                Console.WriteLine("7.Proyecto final.");
                                Console.WriteLine("8.Terminar edición.");
                                edition = Convert.ToInt32(Console.ReadLine());
                                switch (edition)
                                {
                                    case (5):
                                        for (j = 0; j < 5; j++)
                                        {
                                            Console.WriteLine("\nCalificación del taller " + (j + 1) + " es:" + taller[j]);
                                        }

                                        Console.WriteLine("\nIngrese el número del taller a editar");
                                        consult = Convert.ToInt32(Console.ReadLine()) - 1;

                                        Console.WriteLine("\nIngrese nueva nota para el taller " + (consult + 1) + ":");
                                        taller[consult] = Convert.ToSingle(Console.ReadLine());

                                        for (j = 0; j < taller.Length; j++)
                                        {
                                            Console.WriteLine("\nCalificación del taller " + (j + 1) + " es:" + taller[j]);
                                            A = taller[0] + taller[1] + taller[2] + taller[3] + taller[4];
                                        }
                                        break;
                                    case (6):
                                        for (parcial = 0; parcial < 2; parcial++)
                                        {
                                            Console.WriteLine("\nCalificación del parcial " + (parcial + 1) + " es:" + prueba[parcial]);
                                        }

                                        Console.WriteLine("\nIngrese el número del parcial a editar");
                                        consult = Convert.ToInt32(Console.ReadLine()) - 1;

                                        Console.WriteLine("\nIngrese nueva nota para el parcial " + (consult + 1) + ":");
                                        prueba[consult] = Convert.ToSingle(Console.ReadLine());

                                        for (parcial = 0; parcial < prueba.Length; parcial++)
                                        {
                                            Console.WriteLine("\nCalificación del parcial " + (parcial + 1) + " es:" + prueba[parcial]);
                                            B = prueba[0] + prueba[1];
                                        }
                                        break;
                                    case (7):
                                        Console.Clear();
                                        Console.WriteLine("\nIngrese la nueva nota para este proyecto: ");
                                        new_proyect = Convert.ToSingle(Console.ReadLine());
                                        final_proyect = new_proyect;
                                        break;

                                    case (8):
                                        Console.Clear();
                                        Console.WriteLine("Edición terminada.");
                                        break;

                                };
                            }
                            procesos();
                            break;


                        case (4):
                            Console.Clear();
                            Console.WriteLine("\nQue tenga un buen día profesor " + us1 + ", gracias por utilizar nuestros servicios.");
                            break;

                        default:

                            Console.WriteLine("\nLa opción digitada no esta disponible");
                            break;

                    }
                }
                while (option != 4);

                Console.WriteLine("\nPresione Cualquier tecla para salir...");
                Console.ReadKey(true);


            }
            else
            {
                Console.Clear();
                Console.WriteLine("Se excedieron los intentos permitidos");
                Console.WriteLine("Presione Cualquier tecla para salir...");
                Console.ReadKey(true);

            }
        }
    }
}


