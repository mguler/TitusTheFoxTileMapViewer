//const int LZW = 0x10;
//const int CLEAR_CODE = 0x100;
//const int END_CODE = 0x101;
//const int MAX_TABLE = 0x1000;

//var fileStream = new FileStream("LEVEL0.SQZ", FileMode.Open);
//var data = new byte[fileStream.Length];
//var sizeHi = fileStream.ReadByte();
//var algorithm = fileStream.ReadByte();
//var sizeLo = fileStream.ReadByte();

//fileStream.ReadByte();
//int b = 0;

//var result = new List<byte>();
//var dictionary = new List<long>();

//for (var i = 0; i < 255; i++)
//{
//    dictionary.Add(i);
//}

//var memoryStream = new MemoryStream();
//var streamWriter = new StreamWriter(memoryStream);
//var streamReader = new StreamReader(memoryStream);
//var br = new BinaryReader(memoryStream);


//while ((b = fileStream.ReadByte()) != -1)
//{
//    if(dictionary.Contains(b));
//    streamWriter.Write(b);
//    memoryStream.ToArray();
//}


bool IsScopeBalanced(string input)
{
    var opening = new char[] { '[', '(', '{' };
    var closing = new char[] { ']', ')', '}' };
    var stack = new Stack<char>();

    for (var index = 0; index < input.Length; index++)
    {
        if (opening.Contains(input[index]))
        {
            stack.Push(input[index]);
        }
        else if (closing.Contains(input[index]))
        {
            //Instead of following if block we could use try-catch block and return false in catch
            if (stack.Count == 0)
            {
                return false;
            }

            var openingChar = stack.Pop();
            var openingIndex = Array.IndexOf(opening, openingChar);
            var closingIndex = Array.IndexOf(closing, input[index]);
            if (openingIndex != closingIndex)
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}

var opt1 = "(2+[1+3] + 1)";
var opt2 = "( 2 + [3) - 1)";

Console.WriteLine(IsScopeBalanced(opt1));
Console.WriteLine(IsScopeBalanced(opt2));
Console.WriteLine(IsScopeBalanced("] + 1 + ( 4 + 1 ) ["));

Console.ReadLine();