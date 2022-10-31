using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

class Program
{
    // 1-1
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    //    //**************ここからコードを書いて下さい**************
    //    var numbers2 = numbers.Select(x => x * 2 + 2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var number2 in numbers2)
    //    {
    //        Console.WriteLine(number2);
    //    }
    //}

    // 1-2
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    //    //**************ここからコードを書いて下さい**************
    //    var numbers2 = numbers.Where(x => x % 2 == 0).Select(x  => x * 3);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var number2 in numbers2)
    //    {
    //        Console.WriteLine(number2);
    //    }
    //}

    // 1-3
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 15235, 15436, 15423, 15243, 15432 };
    //    //**************ここからコードを書いて下さい**************
    //    var maxnumber = numbers.Max();
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(maxnumber);
    //}

    // 1-4
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman", "Bomberman" };
    //    //**************ここからコードを書いて下さい**************
    //    var robotname7 = robots.Where(x => x.Length == 7);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in robotname7)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 1-5
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman", "Bomberman" };
    //    //**************ここからコードを書いて下さい**************
    //    var Rrobots = robots.Where(x => x.StartsWith("R"));
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var Rrobot in Rrobots)
    //    {
    //        Console.WriteLine(Rrobot);
    //    }
    //}

    // 2-1
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 10, 5, 6, 3, 2 };
    //    //**************ここからコードを書いて下さい**************
    //    var exist = numbers.Any(x => x % 2 == 0);
    //    //**************ここまでコードを書いて下さい**************
    //    if (exist)
    //    {
    //        Console.WriteLine("配列内に偶数が存在します。");
    //    }
    //    else
    //    {
    //        Console.WriteLine("配列内に偶数が存在しません。");
    //    }
    //}

    // 2-2
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    //    //**************ここからコードを書いて下さい**************
    //    var number = numbers.Where(x => x % 2 == 1).Sum();
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(number);
    //}

    // 2-3
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var manrobots = robots.Where(x => x.Contains("man"));
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var manrobot in manrobots)
    //    {
    //        Console.WriteLine(manrobot);
    //    }
    //}

    // 2-4
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
    //    //**************ここからコードを書いて下さい**************
    //    var olds = numbers.Where(x => x % 2 == 0).Select(x => x.ToString() + " years old");
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var old in olds)
    //    {
    //        Console.WriteLine(old);
    //    }
    //}

    // 2-5
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 5, 6, 8, 2, 4, 6, 2, 6, 9, 6, 2, 4, 6, 2, 1 };
    //    //**************ここからコードを書いて下さい**************
    //    var kosuu = numbers.Where(x => x % 3 == 0).Count();
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(kosuu);
    //}

    // 3-1
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 10, 5, 6, 3, 2 };
    //    //**************ここからコードを書いて下さい**************
    //    var exist = numbers.All(x => x % 2 == 0);
    //    //**************ここまでコードを書いて下さい**************
    //    if (exist)
    //    {
    //        Console.WriteLine("全ての値が偶数です。");
    //    }
    //    else
    //    {
    //        Console.WriteLine("配列内に奇数が存在します。");
    //    }
    //}

    // 3-2
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    //    //**************ここからコードを書いて下さい**************
    //    var number = numbers.Take(5).Average();
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(number);
    //}

    // 3-3
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    //var robot = robots.First();
    //    var robot = robots.FirstOrDefault(); // 要素が存在しない場合にnullを返す
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(robot);
    //}

    // 3-4
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var arrrobots = robots.Skip(2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var strrobot in arrrobots)
    //    {
    //        Console.WriteLine(strrobot);
    //    }
    //}

    // 3-5
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 5, 6, 8, 2, 4, 6, 2, 6, 9, 6, 2, 4, 6, 2, 1 };
    //    //**************ここからコードを書いて下さい**************
    //    var arrnumbers = numbers.Distinct();
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var number in arrnumbers)
    //    {
    //        Console.WriteLine(number);
    //    }
    //}

    // 4-1
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman", "Bomberman" };
    //    //**************ここからコードを書いて下さい**************
    //    var orobots = robots.Where(x => x.Contains("o"));
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var orobot in orobots)
    //    {
    //        Console.WriteLine(orobot);
    //    }
    //}

    // 4-2
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman" };
    //    string[] robots2 = new string[] { "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var tmprobots = robots.Concat(robots2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var tmprobot in tmprobots)
    //    {
    //        Console.WriteLine(tmprobot);
    //    }
    //}

    // 4-3
    //static void Main(string[] args)
    //{
    //    string[] robots = new string[] { "Rockman", "Fireman", "Rollchan" };
    //    string[] robots2 = new string[] { "Rockman", "Fireman", "Rollchan" };
    //    //**************ここからコードを書いて下さい**************
    //    var exist = robots.SequenceEqual(robots2);
    //    //**************ここまでコードを書いて下さい**************
    //    if (exist)
    //    {
    //        Console.WriteLine("配列の内容は一致してます。");
    //    }
    //    else
    //    {
    //        Console.WriteLine("配列の内容は一致してません。");
    //    }
    //}

    // 4-4
    //static void Main(string[] args)
    //{
    //    //**************ここからコードを書いて下さい**************
    //    var array = Enumerable.Repeat("Rockman", 5).ToList();
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var item in array)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    // 4-5
    //static void Main(string[] args)
    //{
    //    int[] numbers = new int[] { 1, 5, 6, 8, 2, 4, 6, 2, 6, 9, 6, 2, 4, 6, 2, 1 };
    //    //**************ここからコードを書いて下さい**************
    //    var arrnumbers = numbers.OrderBy(x => x);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var number in arrnumbers)
    //    {
    //        Console.WriteLine(number);
    //    }
    //}

    // 5-1
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr.Light", "Blue"));
    //    robotlist.Add(new Robot("Fireman", "Dr.Wily", "Red"));
    //    robotlist.Add(new Robot("Rollchan", "Dr.Light", "Pink"));
    //    robotlist.Add(new Robot("Iceman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Airman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Bubbleman", "Dr.Wily", "Green"));
    //    robotlist.Add(new Robot("Quickman", "Dr.Wily", "Red"));

    //    //**************ここからコードを書いて下さい**************
    //    var wilyrobots = robotlist.Where(n => n.getMaker() == "Dr.Wily").Select(n => n.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var wilyrobot in wilyrobots)
    //    {
    //        Console.WriteLine(wilyrobot);
    //    }
    //}

    // 5-2
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr.Light", "Blue"));
    //    robotlist.Add(new Robot("Fireman", "Dr.Wily", "Red"));
    //    robotlist.Add(new Robot("Rollchan", "Dr.Light", "Pink"));
    //    robotlist.Add(new Robot("Iceman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Airman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Bubbleman", "Dr.Wily", "Green"));
    //    robotlist.Add(new Robot("Quickman", "Dr.Wily", "Red"));

    //    //**************ここからコードを書いて下さい**************
    //    var Bluerobots = robotlist.Where(n => n.getColor() == "Blue").Select(n => n.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var wilyrobot in Bluerobots)
    //    {
    //        Console.WriteLine(wilyrobot);
    //    }
    //}

    // 5-3
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr.Light", "Blue"));
    //    robotlist.Add(new Robot("Fireman", "Dr.Wily", "Red"));
    //    robotlist.Add(new Robot("Rollchan", "Dr.Light", "Pink"));
    //    robotlist.Add(new Robot("Iceman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Airman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Bubbleman", "Dr.Wily", "Green"));
    //    robotlist.Add(new Robot("Quickman", "Dr.Wily", "Red"));

    //    //**************ここからコードを書いて下さい**************
    //    var redcount = robotlist.Where(n => n.getColor() == "Red").Count();
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(redcount);
    //}

    // 5-4
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr.Light", "Blue"));
    //    robotlist.Add(new Robot("Fireman", "Dr.Wily", "Red"));
    //    robotlist.Add(new Robot("Rollchan", "Dr.Light", "Pink"));
    //    robotlist.Add(new Robot("Iceman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Airman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Bubbleman", "Dr.Wily", "Green"));
    //    robotlist.Add(new Robot("Quickman", "Dr.Wily", "Red"));

    //    //**************ここからコードを書いて下さい**************
    //    var Wilyrobots = robotlist.Where(x => x.getMaker() == "Dr.Wily").Select(x => x.getName()).OrderBy(x => x);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var Wilyrobot in Wilyrobots)
    //    {
    //        Console.WriteLine(Wilyrobot);
    //    }
    //}

    // 5-5
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr.Light", "Blue"));
    //    robotlist.Add(new Robot("Fireman", "Dr.Wily", "Red"));
    //    robotlist.Add(new Robot("Rollchan", "Dr.Light", "Pink"));
    //    robotlist.Add(new Robot("Iceman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Airman", "Dr.Wily", "Blue"));
    //    robotlist.Add(new Robot("Bubbleman", "Dr.Wily", "Green"));
    //    robotlist.Add(new Robot("Quickman", "Dr.Wily", "Red"));

    //    //**************ここからコードを書いて下さい**************
    //    var Wilybluerobots = robotlist.Where(x => x.getMaker() == "Dr.Wily" && x.getColor() == "Blue").Select(x => x.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var Wilybluerobot in Wilybluerobots)
    //    {
    //        Console.WriteLine(Wilybluerobot);
    //    }
    //}

    // 6-1
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr Light", "Blue", 1, 5));
    //    robotlist.Add(new Robot("Rollchan", "Dr Light", "Pink", 1, 1));
    //    robotlist.Add(new Robot("Heatman", "Dr Wily", "Red", 2, 2));
    //    robotlist.Add(new Robot("Fireman", "Dr Wily", "Red", 1, 3));
    //    robotlist.Add(new Robot("Iceman", "Dr Wily", "Blue", 1, 4));
    //    robotlist.Add(new Robot("Quickman", "Dr Wily", "Red", 2, 5));
    //    robotlist.Add(new Robot("Shadowman", "Dr Wily", "Blue", 3, 5));
    //    robotlist.Add(new Robot("Snakeman", "Dr Wily", "Green", 3, 3));
    //    robotlist.Add(new Robot("Woodman", "Dr Wily", "Green", 2, 3));
    //    robotlist.Add(new Robot("Sparkman", "Dr Wily", "Red", 3, 4));
    //    //**************ここからコードを書いて下さい**************
    //    var robotslists = robotlist.OrderBy(x => x.getSeries()).ThenByDescending(x => x.getStrength());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var rlist in robotslists)
    //    {
    //        Console.WriteLine("Series:" + rlist.getSeries() +
    //                          " Strength:" + rlist.getStrength() +
    //                          " Name:" + rlist.getName());
    //    }
    //}

    // 6-2
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr Light", "Blue", 1, 5));
    //    robotlist.Add(new Robot("Rollchan", "Dr Light", "Pink", 1, 1));
    //    robotlist.Add(new Robot("Heatman", "Dr Wily", "Red", 2, 2));
    //    robotlist.Add(new Robot("Fireman", "Dr Wily", "Red", 1, 3));
    //    robotlist.Add(new Robot("Iceman", "Dr Wily", "Blue", 1, 4));
    //    robotlist.Add(new Robot("Quickman", "Dr Wily", "Red", 2, 5));
    //    robotlist.Add(new Robot("Shadowman", "Dr Wily", "Blue", 3, 5));
    //    robotlist.Add(new Robot("Snakeman", "Dr Wily", "Green", 3, 3));
    //    robotlist.Add(new Robot("Woodman", "Dr Wily", "Green", 2, 3));
    //    robotlist.Add(new Robot("Sparkman", "Dr Wily", "Red", 3, 4));
    //    //**************ここからコードを書いて下さい**************
    //    var robotslists = robotlist.Where(x => x.getSeries() == 2 && x.getStrength() == 5).Select(x => x.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var rlist in robotslists)
    //    {
    //        Console.WriteLine("Name:" + rlist);
    //    }
    //}

    // 6-3
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr Light", "Blue", 1, 5));
    //    robotlist.Add(new Robot("Rollchan", "Dr Light", "Pink", 1, 1));
    //    robotlist.Add(new Robot("Heatman", "Dr Wily", "Red", 2, 2));
    //    robotlist.Add(new Robot("Fireman", "Dr Wily", "Red", 1, 3));
    //    robotlist.Add(new Robot("Iceman", "Dr Wily", "Blue", 1, 4));
    //    robotlist.Add(new Robot("Quickman", "Dr Wily", "Red", 2, 5));
    //    robotlist.Add(new Robot("Shadowman", "Dr Wily", "Blue", 3, 5));
    //    robotlist.Add(new Robot("Snakeman", "Dr Wily", "Green", 3, 3));
    //    robotlist.Add(new Robot("Woodman", "Dr Wily", "Green", 2, 3));
    //    robotlist.Add(new Robot("Sparkman", "Dr Wily", "Red", 3, 4));
    //    //**************ここからコードを書いて下さい**************
    //    var robotslists = robotlist.Where(x => x.getSeries() == 3).OrderBy(x => x.getStrength()).Select(x => x.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var rlist in robotslists)
    //    {
    //        Console.WriteLine("Name:" + rlist);
    //    }
    //}

    // 6-4
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr Light", "Blue", 1, 5));
    //    robotlist.Add(new Robot("Rollchan", "Dr Light", "Pink", 1, 1));
    //    robotlist.Add(new Robot("Heatman", "Dr Wily", "Red", 2, 2));
    //    robotlist.Add(new Robot("Fireman", "Dr Wily", "Red", 1, 3));
    //    robotlist.Add(new Robot("Iceman", "Dr Wily", "Blue", 1, 4));
    //    robotlist.Add(new Robot("Quickman", "Dr Wily", "Red", 2, 5));
    //    robotlist.Add(new Robot("Shadowman", "Dr Wily", "Blue", 3, 5));
    //    robotlist.Add(new Robot("Snakeman", "Dr Wily", "Green", 3, 3));
    //    robotlist.Add(new Robot("Woodman", "Dr Wily", "Green", 2, 3));
    //    robotlist.Add(new Robot("Sparkman", "Dr Wily", "Red", 3, 4));
    //    //**************ここからコードを書いて下さい**************
    //    var robotslists = robotlist.Where(x => x.getName().StartsWith("S")).OrderByDescending(x => x.getStrength()).Select(x => x.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var rlist in robotslists)
    //    {
    //        Console.WriteLine("Name:" + rlist);
    //    }
    //}

    // 6-5
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Dr Light", "Blue", 1, 5));
    //    robotlist.Add(new Robot("Rollchan", "Dr Light", "Pink", 1, 1));
    //    robotlist.Add(new Robot("Heatman", "Dr Wily", "Red", 2, 2));
    //    robotlist.Add(new Robot("Fireman", "Dr Wily", "Red", 1, 3));
    //    robotlist.Add(new Robot("Iceman", "Dr Wily", "Blue", 1, 4));
    //    robotlist.Add(new Robot("Quickman", "Dr Wily", "Red", 2, 5));
    //    robotlist.Add(new Robot("Shadowman", "Dr Wily", "Blue", 3, 5));
    //    robotlist.Add(new Robot("Snakeman", "Dr Wily", "Green", 3, 3));
    //    robotlist.Add(new Robot("Woodman", "Dr Wily", "Green", 2, 3));
    //    robotlist.Add(new Robot("Sparkman", "Dr Wily", "Red", 3, 4));
    //    //**************ここからコードを書いて下さい**************
    //    var robotslists = robotlist.Where(x => x.getMaker() == "Dr Wily" && x.getColor() != "Blue").Select(x => x.getName());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var rlist in robotslists)
    //    {
    //        Console.WriteLine("Name:" + rlist);
    //    }
    //}

    // ------------------------中級------------------------
    // 1-1
    //static void Main(string[] args)
    //{
    //    int[] numberarray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    //**************ここからコードを書いて下さい**************
    //    var result = numberarray.Aggregate((x, y) => x * y);
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(result);
    //}

    // 1-2
    //static void Main(string[] args)
    //{
    //    string[] robotarray = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };

    //    //**************ここからコードを書いて下さい**************
    //    if (robotarray.Any(x => x == "Rollchan"))
    //    //**************ここまでコードを書いて下さい**************
    //    {
    //        Console.WriteLine("Rollchanはいます");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Rollchanはいません");
    //    }
    //}

    // 1-3
    //static void Main(string[] args)
    //{
    //    string[] robotarray = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    string[] robotarray2 = new string[] { "Quickman", "Woodman", "Airman" };
    //    //**************ここからコードを書いて下さい**************
    //    var robotarray3 = robotarray.Union(robotarray2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in robotarray3)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 1-4
    //static void Main(string[] args)
    //{
    //    string[] robotarray = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var robotarray2 = robotarray.Append("Quickman");
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in robotarray2)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 1-5
    //static void Main(string[] args)
    //{
    //    string[] robotarray = new string[] { "Rockman", "Fireman", "Rollchan", "Iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    //var robots = string.Join(" and ", robotarray);
    //    var robots = robotarray.Aggregate((a, b) => a + " and " + b);
    //    //**************ここまでコードを書いて下さい**************
    //    Console.WriteLine(robots);
    //}

    // 2-1
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Mr Light", "Blue", 5));
    //    robotlist.Add(new Robot("Quickman", "Mr Wily", "Red", 5));
    //    robotlist.Add(new Robot("Airman", "Mr Wily", "Blue", 3));
    //    robotlist.Add(new Robot("Rollchan", "Mr Light", "Pink", 1));
    //    robotlist.Add(new Robot("Woodman", "Mr Wily", "Green", 3));
    //    robotlist.Add(new Robot("Bubbleman", "Mr Wily", "Green", 4));
    //    robotlist.Add(new Robot("Fireman", "Mr Wily", "Red", 3));
    //    robotlist.Add(new Robot("Iceman", "Mr Wily", "Blue", 4));
    //    robotlist.Add(new Robot("Heatman", "Mr Wily", "Red", 2));

    //    //**************ここからコードを書いて下さい**************
    //    var makerrobots = robotlist.GroupBy(x => x.getMaker());
    //    //**************ここまでコードを書いて下さい**************

    //    foreach (var robots in makerrobots)
    //    {
    //        foreach (var robot in robots)
    //        {
    //            Console.WriteLine(robot.getName());
    //        }
    //        Console.WriteLine("-------------");
    //    }
    //}

    // 2-2
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Mr Light", "Blue", 5));
    //    robotlist.Add(new Robot("Quickman", "Mr Wily", "Red", 5));
    //    robotlist.Add(new Robot("Airman", "Mr Wily", "Blue", 3));
    //    robotlist.Add(new Robot("Rollchan", "Mr Light", "Pink", 1));
    //    robotlist.Add(new Robot("Woodman", "Mr Wily", "Green", 3));
    //    robotlist.Add(new Robot("Bubbleman", "Mr Wily", "Green", 4));
    //    robotlist.Add(new Robot("Fireman", "Mr Wily", "Red", 3));
    //    robotlist.Add(new Robot("Iceman", "Mr Wily", "Blue", 4));
    //    robotlist.Add(new Robot("Heatman", "Mr Wily", "Red", 2));

    //    //**************ここからコードを書いて下さい**************
    //    var colorrobots = robotlist.GroupBy(x => x.getColor());
    //    //**************ここまでコードを書いて下さい**************

    //    foreach (var robots in colorrobots)
    //    {
    //        foreach (var robot in robots)
    //        {
    //            Console.WriteLine(robot.getName() + ":" + robot.getColor());
    //        }
    //        Console.WriteLine("-------------");
    //    }
    //}

    // 2-3
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Mr Light", "Blue", 5));
    //    robotlist.Add(new Robot("Quickman", "Mr Wily", "Red", 5));
    //    robotlist.Add(new Robot("Airman", "Mr Wily", "Blue", 3));
    //    robotlist.Add(new Robot("Rollchan", "Mr Light", "Pink", 1));
    //    robotlist.Add(new Robot("Woodman", "Mr Wily", "Green", 3));
    //    robotlist.Add(new Robot("Bubbleman", "Mr Wily", "Green", 4));
    //    robotlist.Add(new Robot("Fireman", "Mr Wily", "Red", 3));
    //    robotlist.Add(new Robot("Iceman", "Mr Wily", "Blue", 4));
    //    robotlist.Add(new Robot("Heatman", "Mr Wily", "Red", 2));

    //    //**************ここからコードを書いて下さい**************
    //    var colorwilyrobots = robotlist.Where(x => x.getMaker() == "Mr Wily").GroupBy(x => x.getColor());
    //    //**************ここまでコードを書いて下さい**************

    //    foreach (var robots in colorwilyrobots)
    //    {
    //        foreach (var robot in robots)
    //        {
    //            Console.WriteLine(robot.getName() + ":" + robot.getColor());
    //        }
    //        Console.WriteLine("-------------");
    //    }
    //}

    // 2-4
    //static void Main(string[] args)
    //{
    //    List<Robot> robotlist = new List<Robot>();
    //    robotlist.Add(new Robot("Rockman", "Mr Light", "Blue", 5));
    //    robotlist.Add(new Robot("Quickman", "Mr Wily", "Red", 5));
    //    robotlist.Add(new Robot("Airman", "Mr Wily", "Blue", 3));
    //    robotlist.Add(new Robot("Rollchan", "Mr Light", "Pink", 1));
    //    robotlist.Add(new Robot("Woodman", "Mr Wily", "Green", 3));
    //    robotlist.Add(new Robot("Bubbleman", "Mr Wily", "Green", 4));
    //    robotlist.Add(new Robot("Fireman", "Mr Wily", "Red", 3));
    //    robotlist.Add(new Robot("Iceman", "Mr Wily", "Blue", 4));
    //    robotlist.Add(new Robot("Heatman", "Mr Wily", "Red", 2));

    //    //**************ここからコードを書いて下さい**************
    //    var strengthrobots = robotlist.OrderByDescending(x => x.getstrength()).GroupBy(x => x.getstrength());
    //    //**************ここまでコードを書いて下さい**************

    //    foreach (var robots in strengthrobots)
    //    {
    //        foreach (var robot in robots)
    //        {
    //            Console.WriteLine(robot.getName() + ":" + robot.getstrength());
    //        }
    //        Console.WriteLine("-------------");
    //    }
    //}

    // 3-1
    //static void Main(string[] args)
    //{
    //    var robotarray = new string[] { "rockman", "rollchan", "fireman", "iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var robots = robotarray.Select(x => x.ToUpper());
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in robots)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 3-2
    //static void Main(string[] args)
    //{
    //    var robotarray = new string[] { "rockman  ", " rollchan", "fireman  ", "  iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var robotlist = robotarray.Select(x => x.Trim()).ToList();
    //    //**************ここまでコードを書いて下さい**************
    //    robotlist.Add("quickman");
    //    foreach (var robot in robotlist)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 3-3
    //static void Main(string[] args)
    //{
    //    var robotarray = new string[] { "rockman", "rollchan", "fireman", "iceman" };
    //    var robotarray2 = new string[] { "fireman", "iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var Lightrobots = robotarray.Except(robotarray2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in Lightrobots)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 3-4
    //static void Main(string[] args)
    //{
    //    var robotarray = new string[] { "rockman", "rollchan", "fireman", "iceman" };
    //    var robotarray2 = new string[] { "fireman", "iceman" };
    //    //**************ここからコードを書いて下さい**************
    //    var Lightrobots = robotarray.Intersect(robotarray2);
    //    //**************ここまでコードを書いて下さい**************
    //    foreach (var robot in Lightrobots)
    //    {
    //        Console.WriteLine(robot);
    //    }
    //}

    // 3-5
    static void Main(string[] args)
    {
        var robotarray = new string[] { "rockman", "rollchan", "fireman", "iceman" };
        var makerarray = new string[] { "Dr_Light", "Dr_Light", "Dr_Wily", "Dr_Wily" };
        //**************ここからコードを書いて下さい**************
        var Lightrobots = robotarray.Zip(makerarray);
        //**************ここまでコードを書いて下さい**************
        foreach (var robot in Lightrobots)
        {
            Console.WriteLine(robot);
            Console.WriteLine("robot;" + robot.First);
            Console.WriteLine("maker:" + robot.Second);
        }
    }
}


// 5 Robot class
//class Robot
//{
//    string name, maker, color;
//    public Robot(string _name, string _maker, string _color)
//    {
//        name = _name;
//        maker = _maker;
//        color = _color;
//    }

//    public string getName()
//    {
//        return name;
//    }
//    public string getMaker()
//    {
//        return maker;
//    }
//    public string getColor()
//    {
//        return color;
//    }
//}

// 6 Robot class
//class Robot
//{
//    string name, maker, color;
//    int series, strength;
//    public Robot(string _name, string _maker, string _color, int _series, int _strength)
//    {
//        name = _name;
//        maker = _maker;
//        color = _color;
//        series = _series;
//        strength = _strength;
//    }

//    public string getName()
//    {
//        return name;
//    }
//    public string getMaker()
//    {
//        return maker;
//    }
//    public string getColor()
//    {
//        return color;
//    }

//    public int getSeries()
//    {
//        return series;
//    }

//    public int getStrength()
//    {
//        return strength;
//    }
//}

// 中級 2 Robot class
class Robot
{
    string name, maker, color;
    int strength;
    public Robot(string _name, string _maker, string _color, int _strength)
    {
        name = _name;
        maker = _maker;
        color = _color;
        strength = _strength;
    }

    public string getName()
    {
        return name;
    }
    public string getMaker()
    {
        return maker;
    }
    public string getColor()
    {
        return color;
    }

    public int getstrength()
    {
        return strength;
    }
}