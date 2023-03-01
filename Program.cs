Console.Clear();

//apresentação

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Imagine que você está discutindo. O que você diria para vencer a discussão?");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\npressione uma tecla para continuar...");
Console.ResetColor();
Console.ReadKey();

Console.Clear();

//parte do usuário

Console.Write("Escreva:");
Console.ForegroundColor = ConsoleColor.Magenta;
string semberrar = Console.ReadLine()!;
string BERRANDO = semberrar.ToUpper();  
Console.ResetColor();

Console.Clear();

//"robô"

Console.Write("Adversário:");
Console.WriteLine(" E VOCÊ É UM PALERMA!!!");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\npressione uma tecla para continuar...");
Console.ResetColor();
Console.ReadKey();


//usuário

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\n{BERRANDO}!!!!");
Console.ResetColor();
