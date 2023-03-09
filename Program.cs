//Сформировать трёхмерный массив из двузначных неповторяющихся чисел
//Вывести элементы этого массива с указанием их позиций в массиве
Console.WriteLine("Введите кол-во элементов в массиве не более 90:");
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по диагонали в массиве:");
int z = Convert.ToInt32(Console.ReadLine());
int [ , , ] mas = new int [x,y,z];
if ((x*y*z) < 90)
{
int buf = 10;
for (int count1 = 0; count1 < x; count1++)
{
    for (int count2 = 0; count2 < y; count2++)
    {
        for (int count3 = 0; count3 < z; count3++)
        {
        mas[count1,count2,count3] = buf;
        buf++;
        Console.Write(" " + mas[count1,count2,count3] + "(" + count1 + "," + count2 + "," + count3 + ")");
        }
        Console.WriteLine();
    }    
    Console.WriteLine();
}
}
else
{
    Console.WriteLine("Кол-во элементов в массиве превысило 90:");
}


