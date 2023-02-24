// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string controlCarta = string.Empty;
string message = string.Empty;
string switchControl = "menu";
System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("Welcome al C A S I N O");
    Console.WriteLine("¿Cuantos creditos deseas? \n Ingresa un número entero \n Necesitas 1 por ronda. ");
    platziCoins = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        Console.WriteLine($"Te quedan {platziCoins - i} creditos");
        totalJugador = 0;
        totalDealer = 0;


        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("Escriba '21' para jugar al BlackJack ");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta");
                    Console.WriteLine($"Te salio la carta {num} ");
                    Console.WriteLine($"Tus puntos son: {totalJugador}");
                    Console.WriteLine("¿Deseas otra carta?");
                    controlCarta = Console.ReadLine();
                    Console.WriteLine("");

                } while (controlCarta == "Si" || controlCarta == "si" || controlCarta == "sI");

                totalDealer = random.Next(14, 21);
                Console.WriteLine($"El Dealer tiene: {totalDealer} y tu tienes {totalJugador} \n ");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades \n";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste VS el dealer, te pasaste de 21 \n";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste VS el Dealer, lo siento \n";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condicion no válida \n";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no válida en el C A S I N O \n");
                switchControl = "menu";
                break;
        }
    }
}