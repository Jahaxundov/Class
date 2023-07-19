
//HomeWork practice
//static string ReverseWord(string text)
//{
//    string result = "";
//	for (int i = text.Length-1; i >=0; i--)
//	{
//		result += text[i];
//	}
//	return result;
//}

//Console.WriteLine(ReverseWord(("Cavid")));

//static void ToUpperChar(string text,int index)
//{
//    string firstChar = text[index].ToString().ToUpper();
//    var charArray = text.ToCharArray();
//    charArray[index] = Convert.ToChar(firstChar);

//    string result = "";

//    foreach (var item in charArray)
//    {
//        result += item;
//    }
//    Console.WriteLine(result);
//}
//ToUpperChar("salam",2);

//String methods

//string name = "Cahangir";
//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.Trim());
//Console.WriteLine(name.Replace("a", " "));
//Console.WriteLine(name.Substring(1,3));

using ClassWork;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;

//static bool Search(string str,string searchText) =>  str.Trim().ToLower().Contains(searchText.ToLower().Trim());
//{
//    return str.Trim().ToLower().Contains(searchText.ToLower().Trim());
//}


//Console.WriteLine(Search("Azerbaycan","aan"));

//bool result = Search("Azerbaycan", "aan");
//if (result)
//{
//    Console.WriteLine("Found");
//}
//else
//{
//    Console.WriteLine("Notfound");
//}


//Array Methods

//int[] arr = { 1, 2,55,23, 3, 4, 5 };

//Array.Reverse(arr);
//Console.WriteLine(arr.Length);
//Console.WriteLine(arr.FirstOrDefault());
//Console.WriteLine(arr.Any(n=>n==4));
//Array.Sort(arr);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);

//}


//static void Search(string searchText)
//{
//    string[] people = { "Kubra", "Fidan", "Ismayil", "Samir" };

//    foreach (var item in people)
//    {
//        if (item.Trim().ToLower() == searchText.ToLower().ToLower())
//        {
//            Console.WriteLine(item);
//            return;
//        }

//    }
//}
//Search("samir");

//Class

//string name1 = "Cahangir";
//string surname1 = "Axundov";
//int age1 = 20;

//string name2 = "Messi";
//string surname2 = "Leo";
//int age2 = 32;

//string name3 = "Neymar";
//string surname3 = "Junior";
//int age3 = 28;


//var stu1 = new
//{
//    name = "Cahangir",
//    surname = "Axundov",
//    age = 20

//};

//string result = $"{stu1.name} {stu1.surname} {stu1.age}";
//Console.WriteLine(result);

//Student stu1 = new()
//{
//    name = "Cahangir",
//    surname = "Axundov",
//    age = 20,
//    adress = "Suraxani"
//};

//Student stu2 = new()
//{
//    name = "Messi",
//    surname = "Leo",
//    age = 36,
//    adress = "Miami"
//};

//Console.WriteLine("Add your name :");
//string name = Console.ReadLine();

//Console.WriteLine("Add your surname :");
//string surname = Console.ReadLine();

//Console.WriteLine("Add your age :");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Add your adress :");
//string adress = Console.ReadLine();


//Student stu3 = new()
//{
//    name = name,
//    surname = surname,
//    age = age,
//    adress = adress
//};

//Console.WriteLine(stu3.GetFullName());


//Student[] students = { stu1, stu2, stu3 };

//foreach (var item in students)
//{
//    Console.WriteLine(item.name+ " " + item.surname);
//}



