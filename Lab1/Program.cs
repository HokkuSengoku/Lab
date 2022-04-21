System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
Random rn = new Random();

int[] IntMassive()
{
    Console.WriteLine("Одномерный массив d типа Int:");
    var d = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    var q = 3;
    for (var i = 0; i < 12 && q <= 25; i++, q += 2)
    {
        d[i] = q;
        Console.Write(d[i] + " ");
        Console.WriteLine(q);
    }
    Console.WriteLine();
    return d;
}

double[] DoubleMassive()
{
    Console.WriteLine("Одномерный массив x типа Double:");
    var x = new[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
    for (var j = 0; j < 15; j++)
    {
        x[j] = Convert.ToDouble(rn.Next(-6, 8));
        Console.Write("{0:0.00}", x[j]); Console.Write(" ");


    }
    Console.WriteLine();
    return x;
}

void MultiMassive(int[] d1, double[] x)
{
    Console.WriteLine("Двумерный массив d типа Double:");
    double[,] d = new double[12, 15];

    for (var i = 0; i < 12; i++)
    {
        for (var j = 0; j < 15; j++)
        {
            switch (d1[i])
            {
                case 19:
                    d[i, j] = Math.Pow((Math.Atan((0.2 * x[j] + 1) / 14)), 0.25 / (Math.Asin(Math.Pow((double.Epsilon), ((-1) * Math.Abs(x[j])))) * (-1)));
                    break;
                case 5:
                case 9:
                case 11:
                case 13:
                case 17:
                case 23:
                    d[i, j] = Math.Cos(Math.Cos(Math.Pow(x[j], 1.0 / 3)));
                    break;
                default:
                    d[i, j] = Math.Pow((0.25 - Math.Pow((Math.Pow(Math.Pow(x[j], x[j] - 0.75), 1.0 / 3)), 3 + Math.Cos(Math.Pow(x[j], 1.0 / 3))))
                        , Math.Asin(double.Epsilon * Math.Pow((-1) * Math.Pow(4 / Math.Abs(x[j]), x[j]), 1.0 / 3)));
                    break;
            }
        }
    }

    for (var i = 0; i < 12; i++)
    {
        for (var j = 0; j < 15; j++)
        {
            Console.Write("{0:0.0000}", d[i, j]); Console.Write(" ");
        }
        Console.WriteLine();
    }
}
MultiMassive(IntMassive(), DoubleMassive());

