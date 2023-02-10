Console.Clear();

//parte do "robô"
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Imagine que você está discutindo. O que você diria para vencer a discussão?");
Console.ResetColor();

//parte do usuário
Console.ForegroundColor = ConsoleColor.Magenta;
string semberrar = Console.ReadLine()!;
string BERRANDO = semberrar.ToUpper();  
Console.ResetColor();

//resultado
Console.WriteLine("\nE VOCÊ É UM CABEÇUDO!!!");
Console.ReadKey();

Console.WriteLine($"\n{BERRANDO}!!!!");
