using System;
using System.Diagnostics;

int numItems = 999999999;
//int numItems = 9;
int[] sortedArray = new int[numItems];
for(int i = 0; i < numItems; i++)
    sortedArray[i] = i+1;   // +1 damit die Werte bei 1 starten

Random rnd = new Random();
int searchValue = sortedArray[sortedArray.Length-1]; // rnd.Next(numItems);

Console.WriteLine($"\n\tgesuchter Wert: {searchValue}\n");




//////////////////////////////////////////////////////////////////////////////////////////////////
/// Binäre Suche in sortierter Liste (Rekursiv)
    Stopwatch swBinSearch = Stopwatch.StartNew();
    int idxBinSearch = BinarySearchRecursive(sortedArray, searchValue, 0, sortedArray.Length - 1);
    swBinSearch.Stop();

    if (idxBinSearch == -1)
        Console.WriteLine($"Elementwert wurde nicht gefunden");
    else
        Console.WriteLine($"{"binäre Suche (Rekursion) ".PadRight(30, '.')} Element wurde am Index {idxBinSearch} in {swBinSearch.ElapsedTicks} Ticks gefunden");



//////////////////////////////////////////////////////////////////////////////////////////////////
/// Binäre Suche in sortierter Liste (iterativ)
/*
    Stopwatch swBinSearchIter = Stopwatch.StartNew();
    int idxBinSearchIter = BinarySearchIterativ(sortedArray, searchValue);
    swBinSearchIter.Stop();

    if (idxBinSearchIter == -1)
        Console.WriteLine($"Elementwert wurde nicht gefunden");
    else
        Console.WriteLine($"{"binäre Suche (iterativ) ".PadRight(30, '.')} Element wurde am Index {idxBinSearchIter} in {swBinSearchIter.ElapsedTicks} Ticks gefunden");
*/

//////////////////////////////////////////////////////////////////////////////////////////////////
/// Lineare Suche in sortierter Liste
Stopwatch swLinearSearch = Stopwatch.StartNew();
int idxLinearSearch = LinearSearch(sortedArray, searchValue);
swLinearSearch.Stop();

if (idxLinearSearch == -1)
    Console.WriteLine($"Elementwert wurde nicht gefunden");
else
    Console.WriteLine($"{"lineare Suche ".PadRight(30, '.')} Element wurde am Index {idxLinearSearch} in {swLinearSearch.ElapsedTicks} Ticks gefunden");


/***
 * Lineare Suche nach einen Wert (searchValue) in einem sortierten Array
 * 
 */
int LinearSearch(int[] array, int searchValue)
{
    int idx = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchValue)
            idx = i;
    }
    return idx;
}

/***
 * binäre Suche nach einem Wert (searchValue) in einem sortierten Array
 * 
 */
int BinarySearchIterativ(int[] array, int searchValue)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (array[mid] == searchValue)
            return mid; // Position gefunden, Index zurückgeben
        else if (array[mid] < searchValue)
            left = mid + 1;     // Mitte ist kleiner als der gesuchte Wert -> rechts weitersuchen
        else
            right = mid - 1;    // Mitte ist größer als der gesuchte Wert -> links weitersuchen
    }
    return -1;  // Position nicht gefunden
}

int BinarySearchRecursive(int[] array, int searchValue, int left, int right)
{
    if (left <= right)
    {
        int middle = left + (right-left) / 2;
        if (array[middle] == searchValue)
            return middle;  // Position gefunden
        else if (array[middle] < searchValue)
            return BinarySearchRecursive(array, searchValue, middle + 1, right); // Mitte ist kleiner als der gesuchte Wert -> rechts weitersuchen
        else
            return BinarySearchRecursive(array, searchValue, left, middle - 1); // Mitte ist größer als der gesuchte Wert -> links weitersuchen
    }
    return -1;  // Position nicht gefunden

}