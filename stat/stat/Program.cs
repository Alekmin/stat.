
//program wskazuje ile jakich liczb jest w 2002
using System.Diagnostics.Metrics;

Console.WriteLine("Wybrana liczba 2002");
int number = 2002;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach (var letter in letters)
{
 int cont = 0;
 foreach (var sing in letters)
 {
 if (letter == sing)
 {
 cont++;
 }
}
 Console.WriteLine(letter + "W wybranej liczbie jest " + cont);
 }
    

