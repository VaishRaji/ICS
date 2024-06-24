
using System;

class Distance

{
    public int dist1;

    public Distance(int d = 0)

    {
        dist1 = d;
    }

    public static Distance operator ++(Distance dis)

    {
        dis.dist1++;
        return dis;
    }

    public static Distance operator +(Distance dis1, Distance dis2)

    {

        Distance temp = new Distance();
        temp.dist1 = dis1.dist1 + dis2.dist1;
        return temp;

    }

}

class OperatorOverloading

{
    static void Main()

    {
        Distance d1 = new Distance(27);
        Distance d2 = new Distance(30);
        Distance totalDistance = d1 + d2;
        totalDistance = d1++;
        Console.WriteLine("Total Distance {0}", totalDistance.dist1);
        Console.Read();

    }

}
