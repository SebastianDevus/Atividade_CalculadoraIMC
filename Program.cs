double massa, altura, imc;

Console.WriteLine(); // Espacamento

// Solicitando e armazenando altura e peso
Console.Write("Digite sua altura em metros..: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite seu peso em kg........: ");
massa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(); // Espacamento

// Calculando e exibindo IMC
imc = massa / Math.Pow(altura, 2);
Console.WriteLine($"Seu IMC é {imc:N2} kg/m².");

// Verifica o IMC, e age de acordo
if (imc < 17)
{
    // Exibe em vermelho que o usuário está muito abaixo do peso
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Diagnóstico: Muito abaixo do peso");
    Console.ResetColor();
}
else if (imc < 18.49)
{
    // Exibe em amarelo que o usuário está abaixo do peso
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Diagnóstico: Abaixo do peso");
    Console.ResetColor();
}
else if (imc < 24.99)
{
    // Exibe em verde que o usuário está no peso normal
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Diagnóstico: Peso normal");
    Console.ResetColor();
}
else if (imc < 29.99)
{
    // Exibe em amarelo que o usuário está acima do peso
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Diagnóstico: Acima do peso");
    Console.ResetColor();
}
else if (imc < 34.99)
{
    // Exibe em vermelho "escuro" que o usuário está obeso
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Diagnóstico: Obesidade");
    Console.ResetColor();
}
else if (imc < 39.99)
{
    // Exibe em vermelho que o usuário está severamente obeso
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Diagnóstico: Obesidade severa");
    Console.ResetColor();
}
else if (imc >= 40)
{
    // Exibe em magenta escuro que o usuário está mórbidamente obeso
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Diagnóstico: Obesidade mórbida");
    Console.ResetColor();
}

Console.WriteLine(); // Espacamento