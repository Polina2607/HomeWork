// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];    // дабл - так как в условии дробные числа
Random random = new Random();   //создаем объект типа Random, чтобы его использовать для генерации случайных чисел

for(int i=0; i<array.Length; i++)
{
    double randomValue = Math.Round(random.NextDouble()*100,2); // Генерируем вещественное число с ненулевой дробной частью
    // Math.Round - округление числа с плавающей запятой до ближайшего целого числа. 100 - умножь на сто,чтобы не было нулевой дробной части, а двойка после зпт - количество знаков после запятой
    array[i] = randomValue; 
    Console.Write(array[i] + " "); 
}
Console.WriteLine();
double max = array[0];
double min = array[0];

for(int i = 0; i<array.Length; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
    if(array[i]<min)
    {
        min=array[i];
    }
}
double result = Math.Round(max-min,2);
System.Console.WriteLine(result);
