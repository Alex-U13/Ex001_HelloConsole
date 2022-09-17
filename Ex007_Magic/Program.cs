//Console.Clear(); // очищает консоль
// Console.SetCursorPosition(10, 4) ; // будет "рисовать". в качестве аргумента отсут от левого края и от верхнего
// Console.WriteLine("+++");

int xa = 40, ya = 4;
int xb = 4, yb = 20;
int xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("A");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("B");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("C");

int x = xa, y = xb;

int count = 0;

while(count<15000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
      x = (x +xa) /2;
      y = (y +ya) /2;  
    }

    if(what ==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }

    if(what ==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("0");
    count += 1;

}