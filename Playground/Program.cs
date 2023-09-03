
var str = "aA";
HashSet<char> charSet = new HashSet<char>();

foreach(char c in str){

    charSet.Add(c);
}
Console.WriteLine(charSet.Count);

