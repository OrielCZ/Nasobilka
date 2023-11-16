string inputstr;
string input2str;
string okolikstr;
int input;
int input2;
int okolik;
Console.WriteLine("První číslo: ");
inputstr = Console.ReadLine();
input = Convert.ToInt32(inputstr);

Console.WriteLine("Druhé číslo: ");
input2str = Console.ReadLine();
input2 = Convert.ToInt32(input2str);

Console.WriteLine("Okolik ");
okolikstr = Console.ReadLine();
okolik = Convert.ToInt32(okolikstr);

for (int i = input; i <= input2; i += okolik ) 
{
  Console.Write(i + ", " );
}
