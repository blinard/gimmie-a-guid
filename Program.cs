using System;
using TextCopy;

namespace GimmieAGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var newGuid = Guid.NewGuid().ToString();
            Clipboard.SetText(newGuid);
            Console.WriteLine(newGuid);
        }
    }
}
