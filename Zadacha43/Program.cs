const int K = 0;
const int B = 1;
const int LINE1 = 1;
const int LINE2 = 2;
const int X = 0;
const int Y = 1;

double Input(string arg)
{
    System.Console.WriteLine(arg);
    double result = Convert.ToDouble(System.Console.ReadLine());
    return result;
}

double[] InputLine(int lineN)
{
    double[] line = new double[2];
    line[K] = Input($"Введите k{lineN}");
    line[B] = Input($"Введите b{lineN}");
    return line;
}

double[] FindCords(double[] line1, double[] line2)
{
    double[] cords = new double[2];
    cords[X] = (line1[B] - line2[B]) /  (line2[K] - line1[K]);
    cords[Y] = line1[K]*cords[X] + line1[B];
    return cords;
}

double[] line1 = InputLine(LINE1);
double[] line2 = InputLine(LINE2);
double[] cords = FindCords(line1, line2);
Console.WriteLine($"b1 = {line1[B]}, k1 = {line1[K]}, b2 = {line2[B]}, k2 = {line2[K]} -> ({cords[X]}, {cords[Y]})");