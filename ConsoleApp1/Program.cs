using ConsoleApp1;
using System.Collections;

// 1)
/////////////////////////////////////////////////////////////////////

string str1 = "raCecar";

Console.Write("Output 1: ");
Polindrom.isPolindrom(str1);
Console.WriteLine();


// 2a)
/////////////////////////////////////////////////////////////////////

string str2 = "race";
string str3 = "racecar";

Console.WriteLine($"Output 2a: {LonestCommon.LonestCommonSubSeq(str2, str3)}");


// 2b)
/////////////////////////////////////////////////////////////////////

int[] arr = { 234, 43, 32, 54, 76, 87, 32, 67 };

MergeSort.mergeSort(arr, 0, arr.Length - 1);
Console.Write($"Output 2b: ");
MergeSort.printArray(arr);


// 3)
/////////////////////////////////////////////////////////////////////

ListWithArrays <int> arrayList = new ListWithArrays <int>();

arrayList.Add(45);
arrayList.Add(56);
arrayList.Add(67);
arrayList.Add(78);
arrayList.Add(89);


arrayList.RemoveLast();
arrayList.RemoveLast();
arrayList.RemoveLast();

