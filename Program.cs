// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива
char [,] charArray = new char [3,4]
{
    {'D', 'i', 'm', 'a'},
    {'L', 'e', 'n', 'a'},
    {'V', 'a', 's', 'a'}
};
System.Console.WriteLine("Исходный массив: ");
void CreateArray ()
{
    for (int rows=0; rows < charArray.GetLength(0); rows++)
    {
        for (int columns=0; columns<charArray.GetLength(1); columns++)
        {
            Console.Write(charArray[rows,columns]);
        }
        System.Console.WriteLine();
    }
}
CreateArray();
System.Console.WriteLine("Строка из элементов массива: ");
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