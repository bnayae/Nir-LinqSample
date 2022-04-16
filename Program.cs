// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;

string stars = 5.Stars();
//string stars = Extensions.Stars(5);
Console.WriteLine(stars);

var arr = new List<int>(new []{ 1,2,3,4,5,6,7,8,9,10 });

var e1 = arr.OnlyEven();
var e2 = arr.Where(x => x % 2 == 0)
            .Select(x => new { Date = DateTime.Now.AddDays(x), Num = x })
            .Transform(x => $"{x.Date.DayOfWeek} is {x.Num}");
            //.ToArray();

Console.WriteLine(String.Join(",", arr));
Console.WriteLine(String.Join(",", e1));

Console.WriteLine(String.Join(",", e2));
arr.Clear();
arr.Add(2);
Console.WriteLine(String.Join(",", e2));

Console.WriteLine();


// use "Animal farm" text (https://gutenberg.net.au/ebooks01/0100011.txt)
// Find 10 most used words.
// not includes words like is, are, yes, no, ....
// not includes words with less than 2 char

// hints
//   use Where, GroupBy, Select, 
