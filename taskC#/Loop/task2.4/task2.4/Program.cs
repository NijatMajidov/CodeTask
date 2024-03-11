int num = 1221;

int orgnlNum = num;
int revsNum = 0;
int digit = 0;

while (num > 0)
{
    digit = num % 10;
    revsNum = revsNum * 10 + digit;
    num -= digit;
    num /= 10;
}

if (orgnlNum == revsNum)
    Console.WriteLine(" Palindrom ededdir");
else
    Console.WriteLine(" Palindrom eded deyil");