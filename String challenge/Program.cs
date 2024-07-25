string s = "My very educated mother just showed us nine planets";

string[] subs = s.Split(' ');

foreach (var sub in subs)
{
char[] value = sub.ToCharArray();
Array.Reverse(value);
 string result = String.Join("", value);
Console.WriteLine(result);
 }
