//Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int copyNum = num;    // если мы не создадим копию, то после завершения цикла num=0, а он нам еще нужен
int count =0;
while(num>0)          // определяем сколько элементов в массиве
{
    num=num/10;
    count++;
}

int[] array = new int [count];

for(int i = array.Length - 1; i>=0; i--)
{
    array[i]=copyNum%10;
    copyNum=copyNum/10;
}
for(int i = 0; i<array.Length; i++)
{
    System.Console.Write(array[i]);
}