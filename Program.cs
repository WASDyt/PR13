using System.Text;
// исходные данные  x и y
// 
// результат pp2

string path = @"Input.txt";
double p1=0, v1=0, v2=0; //Фактические значения
try
{
    p1 = double.Parse(Console.ReadLine());
    v1 = double.Parse(Console.ReadLine());
    v2 = double.Parse(Console.ReadLine());
    InputData(path, p1, v1, v2);
    ReadData(path);
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");

}
//Метод записи в файл
static void InputData(string p, double pp1, double vv1, double vv2) //Формальные значения
{
    
        StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
    
    sw.WriteLine(pp1);
    sw.WriteLine(vv1);
    sw.WriteLine(vv2);
        sw.Close();
    }
//Перегрузка метода записи
//static void InputData(string p, double zz)
//{
//    StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
//    sw.WriteLine(zz);
//    sw.Close();
//}
//метод чтения из файла
static void ReadData(string p)
{
    StreamReader sr = new StreamReader(p, Encoding.Default);
    double pp1 = double.Parse(sr.ReadLine());
    double vv1 = double.Parse(sr.ReadLine());
    double vv2 = double.Parse(sr.ReadLine());
    double pp2 = (pp1*vv1)/(vv1+vv2);
    Console.WriteLine($"Результат p2 = {pp2}");
    InputData(@"Rezuly.txt", pp2, 0, 0);
}
//Метод вычисления результата
static double Solve(double vv2, double pp1, double vv1)
{ 
    return ((pp1 * vv1) / (vv1 + vv2)); 
};