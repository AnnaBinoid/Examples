int number1 = 1;
int number2 = 2;
int number3 = 6;
int number4 = 8;
int number5 = 4;

int max = number1;

if ( number1 > max ) max = number1;
if ( number2 > max ) max = number2;
if ( number3 > max ) max = number3;
if ( number4 > max ) max = number4;

Console.WriteLine ("Max number is " + max);