Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int x0 = 35, y0 = 1,
    x1 = 1, y1 = 30,
    x2 = 70, y2 = 30,
    xc = 1, yc = 1,
    count = 0;

int what = 0;

Console.SetCursorPosition(x0, y0);
Console.WriteLine("+");

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

what = new Random().Next(0, 3);
if (what == 0)
{
    xc = (x1 + x0) / 2;
    yc = (y1 + y0) / 2;
    Console.SetCursorPosition(xc, yc);
    Console.WriteLine("+");
}

if (what == 1)
{
    xc = (x0 + x2) / 2;
    yc = (y0 + y2) / 2;
    Console.SetCursorPosition(xc, yc);
    Console.WriteLine("+");
}
if (what == 2)
{
    xc = (x2 + x1) / 2;
    yc = (y2 + y1) / 2;
    Console.SetCursorPosition(xc, yc);
    Console.WriteLine("+");
}
while (count < 1000)
{
    what = new Random().Next(0, 3);
    switch (what)
        {
            case 0: 
                xc = (xc + x0) / 2;
                yc = (yc + y0) / 2;
                Console.SetCursorPosition(xc, yc);
                Console.WriteLine("+");
                //Console.WriteLine("0");
                break;
             case 1: 
                xc = (xc + x1) / 2;
                yc = (yc + y1) / 2;
                Console.SetCursorPosition(xc, yc);
                Console.WriteLine("+");
                //Console.WriteLine("1");
                break;
            case 2:
                xc = (xc + x2) / 2;
                yc = (yc + y2) / 2;
                Console.SetCursorPosition(xc, yc);
                Console.WriteLine("+");
                //Console.WriteLine("2");
                break;   
        }
/*
    if (what == 0)
    {
        xc = (xc + x0) / 2;
        yc = (yc + y0) / 2;
        Console.SetCursorPosition(xc, yc);
        Console.WriteLine("+");
        Console.WriteLine("0");
    }

    if (what == 1)
    {
        xc = (x0 + x2) / 2;
        yc = (y0 + y2) / 2;
        Console.SetCursorPosition(xc, yc);
        Console.WriteLine("+");
        Console.WriteLine("1");
    }
    if (what == 2)
    {
        xc = (x2 + x1) / 2;
        yc = (y2 + y1) / 2;
        Console.SetCursorPosition(xc, yc);
        Console.WriteLine("+");
        Console.WriteLine("2");
    }*/
    count = count + 1;
}
Console.SetCursorPosition(0,31);