using System;

// Definimos la función de forma simple para probar
int SumNumbers(int n)
{
    if (n <= 1)
        return 1;
    
    return n + SumNumbers(n - 1);
}

// Ejecutamos la prueba
Console.WriteLine("--- Prueba de Suma Recursiva ---");
int n = 5;
int resultado = SumNumbers(n);
Console.WriteLine($"La suma de 1 a {n} es: {resultado}");