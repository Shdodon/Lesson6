//Разбор, готовое решенеи сильно сбивает

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_CORD = 0;
const int Y_CORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

double Promt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Promt($"Введите коэффициент для {numberOfLine} прямой>");
    lineData[CONSTANT] = Promt($"Введите константу для {numberOfLine} прямой");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_CORD] = (lineData2[CONSTANT] - lineData1[CONSTANT]) / (lineData1[COEFFICIENT] - lineData2[COEFFICIENT]);
    coord[Y_CORD] = lineData1[COEFFICIENT] * coord[X_CORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадат");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.WriteLine($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
    Console.WriteLine($"Имеет координаты ({coord[X_CORD]}, {coord[Y_CORD]})");
}