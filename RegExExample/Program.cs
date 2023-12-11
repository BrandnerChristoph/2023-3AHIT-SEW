using System;
using System.Text.RegularExpressions;

// Papa Regex
    Console.WriteLine("pa: " + IsRegexFound(@"\b(pa){2}\b", "pa"));
    Console.WriteLine("papa: " + IsRegexFound(@"\b(pa){2}\b", "papa"));
    Console.WriteLine("papapa: " + IsRegexFound(@"\b(pa){2}\b", "papapa"));

// Positionen von tt finden
string inTT = "Hallo Otto, können wir uns morgen in Amstetten in der Hütte treffen?";
    CheckRegex(@"t{2}", inTT);

// Katze (ganzes Wort)
string[] catInfos = { "Katze", "Katzenzungen", "Großkatze", "Katzen" };
    foreach (string s in catInfos)
        CheckRegex(@"\bKatze\b", s);

// Klassenbezeichnungen in der HTL
string[] classes = { "1AHIT", "6BHMBA", "3XHMBA", "2AHM", "5BHMBA", "3XHMBA", "2AHMBA"};
    foreach(string s in classes)
        CheckRegex(@"\b[1-5][A-B]H(IT|MBA|WIM|ET)?\b", s);

// Mobiltelefon
    Console.WriteLine("Phonenumber: " + IsRegexFound(@"^\d{4}(\/)\d{7,9}", "0664/75081131"));
    Console.WriteLine("Phonenumber: " + IsRegexFound(@"^\d{4}(\/)\d{7,9}", "065/123456"));
    Console.WriteLine("Phonenumber: " + IsRegexFound(@"^\d{4}(\/)\d{7,9}", "0650/1612897"));

    Console.WriteLine("--------------------------------------");

// IBAN
    Console.WriteLine("IBAN: " + IsRegexFound(@"\bAT\d{2}\s?\d{4}\s?\d{4}\s?\d{4}\s?\d{4}\b", "AT123456789012345678"));
    Console.WriteLine("IBAN: " + IsRegexFound(@"\bAT\d{2}\s?\d{4}\s?\d{4}\s?\d{4}\s?\d{4}\b", "AT12 3456 7890 1234 5678"));
    Console.WriteLine("IBAN (fail): " + IsRegexFound(@"\bAT\d{2}\s?\d{4}\s?\d{4}\s?\d{4}\s?\d{4}\b", "AT12 3456 7890 1234 567X"));

    Console.WriteLine("--------------------------------------");

// KFZ Kennzeichen
    Console.WriteLine("Kennzeichen: " + IsRegexFound(@"\b[A-Z]{1,2}\s?\d{2,4}[A-Z]{1,2}\b", "WY123U"));
    Console.WriteLine("Kennzeichen: " + IsRegexFound(@"\b[A-Z]{1,2}\s?\d{2,4}[A-Z]{1,2}\b", "WY 123U"));
    Console.WriteLine("Kennzeichen: " + IsRegexFound(@"\b[A-Z]{1,2}\s?\d{2,4}[A-Z]{1,2}\b", "O123456"));

    Console.WriteLine("--------------------------------------");

void CheckRegex(string pattern, string text)
{
    // Create a Regex
    Regex regex = new Regex(pattern);

    // Get all matches
    MatchCollection matchedStrings = regex.Matches(text);

    // no math found
    if (matchedStrings.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"no match for: {text}");
        Console.ResetColor();
    }
    else
    {
        // Print all matched strings
        for (int count = 0; count < matchedStrings.Count; count++)
            Console.WriteLine(matchedStrings[count].Value + " -> " + matchedStrings[count].Index);
    }
    Console.WriteLine("--------------------------------------");
}


bool IsRegexFound(string pattern, string text)
{
    // Create a Regex
    Regex regex = new Regex(pattern);

    // finds the regex in the text
    return regex.IsMatch(text);
}