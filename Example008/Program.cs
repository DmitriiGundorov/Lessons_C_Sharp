// Максимальное из 9-ти чисел. Стихийный метод
int a1 = 10;
int b1 = 12;
int c1 = 15;
int a2 = 16;
int b2 = 185;
int c2 = 20;
int a3 = 22;
int b3 = 25;
int c3 = 30;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);