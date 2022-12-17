int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}

int a1 = 21;
int a2 = 2;
int a3 = 3422;
int b1 = 111;
int b2 = 953;
int b3 = 67;
int c1 = 43;
int c2 = 19;
int c3 = 9;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3),Max(c1, c2, c3) );

Console.WriteLine(max);