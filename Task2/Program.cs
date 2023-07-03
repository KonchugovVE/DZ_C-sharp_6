// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterRandom()
{
    Random rnd = new Random();
    double num = Convert.ToDouble(rnd.Next(1, 11));
    return num;
}

double[] lineСoordinates()
{
    double[] myArray = new double[2];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = EnterRandom();
        System.Console.WriteLine(myArray[i]);
    }
    return myArray;
}

(double x, double y) intersectionPoint(double[] line1, double[] line2, int b, int k)
{
    double x = (line1[b] - line2[b]) / (line2[k] - line1[k]);
    double y = line1[k] * x + line1[b];
    return (x, y);
}

bool VolidatingNum(double[] line1, double[] line2, int b, int k)
{
    if (line1[k] == line2[k])
    {
        if (line1[b] == line2[b])
        {
            System.Console.WriteLine("линии совпадают");
            return false;
        }
        System.Console.WriteLine("линии паралельны");
        return false;
    }
    return true;
}

int b = 0;

int k = 1;





double[] line1 = lineСoordinates();

double[] line2 = lineСoordinates();

if (VolidatingNum(line1, line2, b, k))
{

    intersectionPoint(line1, line2, b, k);
    System.Console.WriteLine($"Координаты точки пересечения двух прямых = {intersectionPoint(line1, line2, b, k)}");
}