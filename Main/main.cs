// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System.Runtime.CompilerServices;
using System.Text;
class MainProgram
{
   public static void Main(string[] args){
    // primitive datatypes:
//   number dataTypes in c sharp: int, long, uint, ulong
   //   int number = 12;
   //   long l = 4563;
   //   bool a = false;
   //   uint r  = 22; //in this type of number we only save positive number greater than zero
   //   string str = "Preet verma";
   //   String str1 = "Preet Rohilla";
   //   float f = 236466.454f; //4 bytes
   //   double d = 4453.5356335; // 8 bytes
   //   decimal e = 3424.245252M;
   //   Console.WriteLine("integer " + number);
   //   Console.WriteLine("long number " + l);
   //   Console.WriteLine("unsighned number " + r);
   //   Console.WriteLine("long number " + l);
   //   Console.WriteLine(int.MaxValue);
   //   Console.WriteLine(a);
   //   Console.WriteLine(str);
   //   Console.WriteLine(str1);
   //    Console.WriteLine(f);
   //     Console.WriteLine(d);
   //     Console.WriteLine(e);

      //  you have to check whether in main.csProj file having implic using enable, if this is enable then you have not write system otherwise mandatory to import system using System on top of the file 
    //  Console.Write

   //  How to define constants in C sharp

   // const String aer = "sdbdvdbdbdb";
   //    Console.WriteLine(aer);


      // String Parsing conversion between strings to diffrent data types 

      // string rollNumber = "12231";
      // Int32 rollNo = int.Parse(rollNumber);
      // Console.WriteLine(rollNo);
      // // GetType function is gives us data type of dataType
      // // for example 
      // Console.WriteLine(rollNo.GetType());
  

//   Type Casting

//  string str = "2312";
// Convert Object is important for typeCasting
//  int num = Convert.ToInt32(str);
//  Console.WriteLine(num.GetType());

//  string name = "Preet";

// Console.WriteLine("Enter a number:> ");
// string data = Console.ReadLine();
// Console.WriteLine(data);



// String methods 

// basic things charters denoted in '' single quotes and string denotes in double quotes ""
// string str = "Preet";
// string str2 = "Prince"; 
// string newStr = string.Concat(str2, " ", str);
// Console.WriteLine(newStr.Length); // give string length
// Console.WriteLine(newStr); // 
// Console.WriteLine(newStr.ToUpper()); // to convert it into upper case
// Console.WriteLine(newStr.IndexOf('e')); //it give -1 if char not exists 
// string str3 = newStr.Replace('P','N'); // it replace specific value
// string str4 = newStr.Insert(2,"n"); // it insert any value at specific place and it use string not char
// Console.WriteLine(str4);
// string name = "Preet";
// bool isStringWqual = str.Equals(name);  // checking is string is equal or not 
// Console.WriteLine(isStringWqual);

// bool isCharExists = str.Contains('r');
// Console.WriteLine("char exists " + isCharExists);

// string trimmed = "    pre et  "; 
// Console.WriteLine(trimmed.Trim()); // it removed white spaces from first and last not in between

// string Intro = "My name is Preet Verma";
// string sub = Intro.Substring(0); // it create a new substring from existing string
// Console.WriteLine(sub);

// string tot = "Pr,e,t Ve,rm,a";
// string[] tuned = tot.Split(','); 

// for(int i = 0; i<tuned.Length; i++){
//    Console.WriteLine(tuned[i]);
// }
// foreach (string s in tuned)
// {
//     System.Console.WriteLine(s);
// }


// string formating 

// int age = 24;
// string name = "Preet Verma";
// String str = string.Format("Hello my name is {0} and my age is {1}", name, age); // we have to pass index or placeholder for here 
// double d = 1332.3233d;
// string str1 = string.Format("totalPrice {0:c}",d);
// Console.WriteLine(str1);

// Console.WriteLine(str);

// string interpolation 
// string str1 = $"my name is {name} and my age is {age}";
// Console.WriteLine(str1);

// String Builder Class 
StringBuilder dstr = new ("this is a new word and dynamci string");
dstr.Append(", fuck you madarchod");
Console.WriteLine(dstr.Length);
Console.WriteLine(dstr);
Console.WriteLine(dstr.Capacity);

   }
}