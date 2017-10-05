using System;

namespace CSharp7
{
    public class Discards
    {
        public string OldSchool(string x)
        {
            if(int.TryParse(x, out var i))
            {
                return $"\"{x}\" is a valid integer.";
            }
            return $"\"{x}\" is not a valid integer.";
        }

        public string CSharp7Discard(string x)
        {
            if (int.TryParse(x, out _))
            {
                return $"\"{x}\" is a valid integer.";
            }
            return $"\"{x}\" is not a valid integer.";
        }

        public void CSharp7TupleDecompositionOldSchool()
        {
            var (e, f) = Tuples.CSharp7Tuples(42);

            Console.WriteLine($"'{42} Square is {e}.");
        }

        public void CSharp7TupleDecompositionDiscard()
        {
            var (g, _) = Tuples.CSharp7Tuples(42); 

            Console.WriteLine($"'{42} Square is {g}.");
        }
    }
}