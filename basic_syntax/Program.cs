﻿
//basic syntax

string fullName = string.Empty;
int age = 0;
char gender = char.MinValue;
bool working = false;

//Console.Write("please enter your fullName:");
//fullName = Console.ReadLine();
Console.Write("please enter your age:");
age = Convert.ToInt32(Console.ReadLine());
Console.Write("please enter your gender(M/F):");
gender = Convert.ToChar(Console.ReadLine());
Console.Write("please enter your working:");
working = Convert.ToBoolean(Console.ReadLine());



//Console.WriteLine($"entered fullName is {fullName}");
Console.WriteLine($"entered age is {age}");
Console.WriteLine($"entered gender is {gender}");
Console.WriteLine($"entered working is {working}");