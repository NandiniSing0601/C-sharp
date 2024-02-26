// See https://aka.ms/new-console-template for more information
using ConditionalsAndLoops;

Console.WriteLine("Hello, World!");

//// Conditionals
///*
//  Syntax of If-else :

//   if( check condition T or F)
//  {
//    //body
//  }
//  else 
//  {
//    //body
//  }
 
// */
//int salary = 25000;
//if(salary>20000)
//{
//    salary = salary + 2000;
//}
//else if(salary>10000)
//{
//    salary = salary + 3000;
//}
//else
//{
//    salary = salary + 1000;
//}
//Console.WriteLine(salary);


//// Loops (to iterate or perform repititive tasks)
//// print numbers from 1 to n
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();
//Console.WriteLine("Printing numbers from 1 to n using For loop");
//// for loops

///*
  
// synatx:
   
//  for(initilaisation;condition;increment)

// */

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(i);
//}

//// while loops

///*
  
// synatx:

//  while(condition)
//  {
//   // body
//  } 

// */

//Console.WriteLine();
//Console.WriteLine("Printing numbers from 1 to n using While loop");

//int j = 1;
//while(j <= n)
//{
//    Console.WriteLine(j);
//    j++;
//}

//// do while loops

///*
  
// synatx:

//  do
//  {
//   // body
//  } while(condition)

// */

//Console.WriteLine();
//Console.WriteLine("Printing numbers from 1 to n using do While loop");
//int k = 1;
//do
//{
//    Console.WriteLine(k);
//    k++;
//}
//while(k <= n);

//int x = 98, y = 77, z = 66;
//Console.WriteLine();
//Console.WriteLine("Largest of two numbers");
//Console.WriteLine(Math.Max(y, z));
//Console.WriteLine(Math.Max(x, Math.Max(y, z)));
string text = Console.ReadLine();
CaseCheck caseCheck = new CaseCheck();
caseCheck.CheckCase(text);
Console.ReadLine();

