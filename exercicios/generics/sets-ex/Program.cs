using System;
using System.Collections.Generic;


    HashSet<string> set = new HashSet<string>();

    set.Add("notebook");
    set.Add("tv");
    set.Add("phone");

    foreach(string p in set)
{
    Console.Write(p + " ");
}

Console.WriteLine();

SortedSet<int> a = new SortedSet<int>(){0, 2, 4, 5, 6, 8, 10};
SortedSet<int> b = new SortedSet<int>(){5, 6, 7, 8, 9, 10};

SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);

PrintCollection(a);
PrintCollection(c);


    static void PrintCollection <T>(IEnumerable<T> collection)
{
    foreach(T obj in collection)
    {
        Console.Write(obj + " ");
    }

    Console.WriteLine();
} 