

var numbers = "3989143184935951380950358932531251983928300583219584092398345767103206967678";

var numbersDictionary = new Dictionary<string, int>();

foreach (var ch in numbers.ToCharArray())
{
    if (!numbersDictionary.ContainsKey(ch.ToString()))
    {
        numbersDictionary[ch.ToString()] = 0;
    }


    numbersDictionary[ch.ToString()]++;

}




foreach (var key in numbersDictionary.Keys)
{
    Console.WriteLine($"The key {key} occurs {numbersDictionary[key]}");
}



//------------------------------



/*

var numbers = "3989143184935951380950358932531251983928300583219584092398345767103206967678";

var numbersDictionary = new Dictionary<string, int>
{
    ["0"] = 0,
    ["1"] = 1,
    ["2"] = 2,
    ["3"] = 3,
    ["4"] = 4,
    ["5"] = 5,
    ["6"] = 6,
    ["7"] = 7,
    ["8"] = 8,
    ["9"] = 9
};

foreach (var ch in numbers.ToCharArray())
{
    numbersDictionary[ch.ToString()]++;

}

foreach(var key in numbersDictionary.Keys)
{
Console.WriteLine($"The key {key} occurs {numbersDictionary[key]}");
}


//------------------


var dictionary = new Dictionary<string, string>();
dictionary.Add("1", "Red");
dictionary.Add("2", "White");
dictionary.Add("3", "Blue");
dictionary.Add("4", "Orange");

Console.WriteLine($"The color for 4 is {dictionary[4]}");




//------------------


var aList = new List<int>();
aList.AddRange(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine($"Default capcity is {aList.Capacity}");


    
//------------------


var names = new List<string>();

names.Add("Tony");
names.Add("Megan");
names.Add("Grant");
names.Add("Drew");
names.Add("David");
names.Add("Josh");

names.Remove("Josh");

foreach(var name in names)
{
    Console.Write($"{name} ");
}

*/