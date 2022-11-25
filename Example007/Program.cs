Console.Clear();
//Console.SetCursorPozition(10, 4);
//Console.WriteLine("+");

int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 40, yc = 30;

Console.SetCursorPozition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPozition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPozition(xc, yc);
Console.WriteLine("+");

/* int x = xa, y = xb
int count=0

while (count<1000);
{
    int what = new Random().Next(0, 3); //[0,3] 0, 1, 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPozition(x, y);
    Console.WriteLine("+");
    count = Count + 1;
} */