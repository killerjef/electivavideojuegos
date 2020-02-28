using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {

            Console.WriteLine("\nSeleccione el numero de jugadores (2-4)");
            string plyrs = Console.ReadLine();

            if (!plyrs.Equals("")) 
            {
                int numplayers = int.Parse(plyrs);

                while ( numplayers > 4 || numplayers < 2)
                {
                    Console.WriteLine("Seleccione el numero de jugadores (2-4) ");
                    plyrs = Console.ReadLine();
                }

                Console.WriteLine("\nSeleccione el tablero a jugar");
                Console.WriteLine("1. Nivel básico (Tablero de 20 posiciones)");
                Console.WriteLine("2. Nivel intermedio (Tablero de 30 posiciones)");
                Console.WriteLine("3. Nivel avanzado (Tablero de 50 posiciones)");
                String board = Console.ReadLine();

                if (!board.Equals(""))
                {
                    while (!board.Equals("1")&& !board.Equals("2")&& !board.Equals("3"))
                    {
                        Console.WriteLine("Seleccione el tablero a jugar");
                        Console.WriteLine("1. Nivel básico (Tablero de 20 posiciones)");
                        Console.WriteLine("2. Nivel intermedio (Tablero de 30 posiciones)");
                        Console.WriteLine("3. Nivel avanzado (Tablero de 50 posiciones)");
                        board = Console.ReadLine();
                    }                   
                }

                int goal = 0;
                switch (board)
                {
                    case "1":
                        goal = 20;
                        break;
                    case "2":
                        goal = 30;
                        break;
                    case "3":
                        goal = 50;
                        break;
                    default:
                        Console.WriteLine("ERROR, no se encontro el tablero");
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine("Presiona enter para comenzar");
                Console.ReadKey();
                Console.WriteLine("\n ████    █████     ███       █████     █████");
                Console.WriteLine("█    █     █      █   █     █     █      █");
                Console.WriteLine("█          █     █     █    █      █     █");
                Console.WriteLine(" █         █    █       █   █     █      █");
                Console.WriteLine("  ██       █    █       █   █    █       █");
                Console.WriteLine("    █      █    █ █████ █   █  █         █");
                Console.WriteLine("     █     █    █       █   █    █       █");
                Console.WriteLine("█    █     █    █       █   █     █      █");
                Console.WriteLine(" ████      █    █       █   █     █      █");

                int[] scores = new int[numplayers];
                int[] par = new int[numplayers];
                int i = 0;

                while (scores[i] < goal || par[i] == 3)
                {

                    Console.WriteLine("\nJugador "+(i+1)+ " presiona enter para lanzar los dados");
                    Console.ReadKey();

                    int dice1 = new Random().Next(1, 7);
                    int dice2 = new Random().Next(1, 7);

                    if (dice1 == dice2)
                    {
                        par[i]++;
                    }
                    else
                    {
                        par[i] = 0;
                    }

                    scores[i] += dice1 + dice2;
                    Console.WriteLine("\nPosicion: " + scores[i]);

                    switch (dice1)
                    {
                        case 1:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 2:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██     ██           ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██           ██     ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 3:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██  ██              ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██              ██  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 4:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 5:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 6:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                    }

                    switch (dice2)
                    {
                        case 1:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 2:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██     ██           ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██           ██     ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 3:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██  ██              ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██              ██  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 4:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 5:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██        ██        ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                        case 6:
                            Console.WriteLine("");

                            Console.WriteLine("  ██████████████████");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("██    ██      ██    ██");
                            Console.WriteLine("██                  ██");
                            Console.WriteLine("  ██████████████████");
                            break;
                    }

                    if (scores[i] < goal)
                    {
                        i++;
                    }

                    if (i == scores.Length)
                    {
                        i = 0;
                    }                   
                }

                Console.WriteLine("Felicidades jugador "+(i+1)+" ¡GANASTE! UwU\n");
                Console.WriteLine("¿Quieres volver a jugar?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                string opagain = Console.ReadLine();
                if (!opagain.Equals(""))
                {
                    while (!opagain.Equals("1") && !opagain.Equals("2"))
                    {
                        Console.WriteLine("¿Quieres volver a jugar?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                    }
                    if (opagain.Equals("1"))
                    {
                        start();
                    }
                    else if (opagain.Equals("2"))
                    {

                    }
                }
            }
        }
    }
}
