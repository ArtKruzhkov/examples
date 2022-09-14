int distance = 10000;
int fFS = 2;
int sFS = 1;
int DS = 5;
int f = 2;
int count = 0;

while(distance > 10)
{
    int time;
    if(f == 1)
    {
        time = distance / (DS+fFS);
        f = 2;
    }
    else
    {
        time = distance / (DS+sFS);
        f = 1;
    }
    distance = distance - (fFS+sFS) * time;
    count = count + 1;
}
Console.WriteLine(count);