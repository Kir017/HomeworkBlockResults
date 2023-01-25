
string[] FillArray()
{
  Console.WriteLine("Заполните массив (данные вводятся через пробел):  ");
  return Console.ReadLine()!.Split(" ");
}

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int CountElemetNewArray(string[] text, int numberСharacters)
{
  int count = 0;
  for (int i = 0; i < text.Length; i++)
  {
    if (text[i].Length <= numberСharacters)
    {
      count++;
    }
  }
  return count;
}

string[] CountLetter(string[] text, int lengthNewArray, int numberСharacters)
{
  string[] arrayLetter = new string[lengthNewArray];
  for (int i = 0, j = 0; i < text.Length; i++)
  {
    if (text[i].Length <= numberСharacters)
    {
      arrayLetter[j] = text[i];
      j++;
    }
  }
  return arrayLetter;
}

string PrintArray(string[] prArray)
{
  string output = String.Empty;
  for (int i = 0; i < prArray.Length; i++)
  {
    output = output + $"{prArray[i]} ";
  }
  return output;
}

string[] stringArray = FillArray();
int countSymbols = GetValue("Введите максимальное количество символов строки в новом массиве (по условию задачи, 3): ");
string[] newStringArray = CountLetter(stringArray, CountElemetNewArray(stringArray, countSymbols), countSymbols);
string print = PrintArray(stringArray);
string newPrint = PrintArray(newStringArray);
Console.WriteLine($"\nЗаданный массива строк: [{print}] => новый массив из строк, длина которых меньше,"
                + $" либо равна {countSymbols} символам:  [{newPrint}]\n");
