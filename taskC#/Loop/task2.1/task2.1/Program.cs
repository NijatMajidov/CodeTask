int num = 4285;
int digit = 0;
int res = 1;
while(num != 0)
{
    digit = num % 10;
    res *= digit;
    num -= digit;
    num /= 10;
}

Console.WriteLine(res);