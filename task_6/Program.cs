// Задача 6. Является ли число четным
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN % 2 != 1)
{
   Console.WriteLine("число "+ numberN +" является четным"); 
}
else
{
    Console.WriteLine("число "+ numberN +" является нечетным");
}
