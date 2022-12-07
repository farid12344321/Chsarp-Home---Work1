
//1) verilmish n-ededinin 3 e bolunub-bolunmemesini tapin

int n = 42;

if (n % 3 == 0 && n % 7 == 0)
{
    Console.WriteLine("bolunur");
}
else
{
    Console.WriteLine("bolunmur");
}


//2) n,m ededleri verilir. eger n ve m ededleri her ikisi cutdurse n ve m ededlerini cemini hesablayin

int n = 11;
int m = 20;

if (n % 2 == 0 && m % 2 == 0)
{
    Console.WriteLine(n + m);
}
else
{
    Console.WriteLine("duzgun eded daxil edin");
}


//3) verilmish n ve m (n<m) ededleri arasindaki tek ededlerini cemini tapin

int n = 10;
int m = 30;
int sum = 0;
for (int i = n; i < m; i++)
{
    if (i % 2 == 1)
    {
        sum += i;

    }
}
Console.WriteLine(sum);



//4) verilmish arrayin icindeki tek ededleri cemini tapin

int[] number = { 5, 10, 7,  1, 5, 8, 2, 1 };
int result = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 1)

    {
        result = result + number[i];
    }
};
Console.WriteLine(result);




//5)verilmish arrayin icindeki cut ededlerin sayini tapin


int[] number = { 5, 7, 8, 9, 2, 10, 19, 15, 16, 22 };
int result = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        number[i] = result++;
    }
}

Console.WriteLine(result);


















