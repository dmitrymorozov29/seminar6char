﻿// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива
System.Console.WriteLine("*Reshaem zadachu No 1*");
char [,] charArray = new char [3,4]
{
    {'D', 'i', 'm', 'a'},
    {'L', 'e', 'n', 'a'},
    {'V', 'a', 's', 'a'}
};
Console.WriteLine("Исходный массив: ");
void CreateArray ()
{
    for (int rows=0; rows < charArray.GetLength(0); rows++)
    {
        for (int columns=0; columns<charArray.GetLength(1); columns++)
        {
            Console.Write(charArray[rows,columns]);
        }
        Console.WriteLine();
    }
}
CreateArray();
Console.WriteLine("Строка из элементов массива: ");
void CreateStringFromArray()
{
    for (int rows=0; rows < charArray.GetLength(0); rows++)
    {
        for (int columns=0; columns<charArray.GetLength(1); columns++)
        {
            Console.Write(charArray[rows,columns]);
        }
    }    
}
CreateStringFromArray ();

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.
Console.WriteLine();
Console.WriteLine("*Reshaem zadachu No 2*");
Console.WriteLine("Исходная строка: ");
string myString = "fjKHNDkndkrhKaioP";
Console.WriteLine(myString);
void TransformLetters ()
{
    myString = myString.ToLower();
    // for (int i=0; i==myString.Length; i++)
    // {
    //     // string letter;
    //     letter=myString.Tolower(i);
    //     System.Console.WriteLine(letter);
    // }
    Console.WriteLine("Izmenennaya stroka: " + myString);
}
TransformLetters();