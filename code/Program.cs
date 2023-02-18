string[] array = {"hello", "why", "no", "yes", "stop"};
string result = "";

for (int count = 0; count < array.Length; count++)
{
    if (array[count].Length <= 3)
    {
        result += array[count] + "_";
    }
}

string[] newArray = result.Split("_");


for (int i = 0; i < newArray.Length; i++) Console.Write(newArray[i] + " ");