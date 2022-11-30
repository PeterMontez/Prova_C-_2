using System;

double[] array = new double[]
{
    8.4, 8.6, 8.4, 7.0, 7.2, 10.0, 7.2, 9.4, 9.8
};
Console.WriteLine(mediaEspecial(array));

double mediaEspecial(double[] array)
{
    Array.Sort(array);
    if (array.Count() >=4)
    {
        double soma = array[0] + array[1] + array[array.Count()-1] + array[array.Count()-2];
        return (float)(soma/4.0);
    }
    else
    {
        double soma = 0;
        foreach (var item in array)
        {
            soma += item;
        }
        return (float)(soma/(float)array.Count());
    }
}