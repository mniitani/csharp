using ConsoleApp2;

Random rdm = new System.Random();
int r = rdm.Next(0, 3);
Console.WriteLine("r=" + r);

IShain shain;

if (r == 0)
{
    shain = new Hira();
}
else if (r == 1)
{
    shain = new Kacho();
}
else
{
    shain = new Bucho();
}

shain.standup();