// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива
char [,] charArray = new char [3,4]
{
    {'d', 'i', 'm', 'a'},
    {'l', 'e', 'n', 'a'},
    {'v', 'a', 's', 'a'}
};
void CreateArray ()
{
    for (int rows=0; rows < charArray.GetLength(0); rows++)
    {
        for (int columns=0; columns<charArray.GetLength(1); columns++)
        {
            // charArray[rows,columns]=charArray[rows,columns++];
            Console.Write(charArray[rows,columns]);
        }
        System.Console.WriteLine();
    }
}
CreateArray();