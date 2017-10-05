using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp7
{
    //
    // Expressive
    //
    // Tuples
    // Pattern matching
    // Deconstruction
    public class Tuples
    {
        public void OldSchool(int x, out int y, out int z)
        {
            y = 2 * x;
            z = 3 * x;
        }

        // This does not compile
        //public async Task OldSchoolAsync(int x, out int y, out int z)
        //{
        //    y = 2 * x;
        //    z = 3 * x;
        //}

        public static (int y, int z) CSharp7Tuples(int x)
        {
            return (y: x * 2, z: x * 3);
        }

        public async Task<(int y, int z)> CSharp7TuplesAsync(int x)
        {
            return await Task.FromResult((y: x * 2, z: x * 3));
        }

        public ValueTuple<int, int> CSharp7TuplesCompilesTo(int x)
        {
            return new ValueTuple<int, int>(x * 2, x * 3); // Struct, immutable and stack based
        }

        public void CSharp7TupleLiterals()
        {
            // Unnamed tuple
            (int, bool, string) t = (42, true, "bar");
            var r1 = t.Item2;

            // Named tuple
            (int x, bool b, string z) tNamed = (42, true, "bar");
            var r2 = tNamed.b;

            // Tuple variable
            var c = CSharp7Tuples(42);
            var r3 = c.y; // Preserved in meta data so works over assemblies as well
        }

        public void InferredTupleElementNames()
        {
            // C# 7.0
            int count = 5;
            string label = "a label";

            var tuple = (count: count, label: label);
            var x = tuple.count;


            // C# 7.1 Inferred
            var tuple2 = (count, label);
            var y = tuple.count;
        }

        public void CSharp7TupleExamples()
        {
            var d = new Dictionary<(int x, int y), string>
            {
                { (0, 0), "X" },
                { (0, 1), "_" },
                { (0, 2), "_" },
                { (1, 0), "X" },
                { (1, 1), "O" },
                { (1, 2), "_" },
                { (2, 0), "X" },
                { (2, 1), "O" },
                { (2, 2), "O" },
            };

            if (d.TryGetValue((1, 1), out var value))
            {
                Console.WriteLine(value);
            }
        }

        public void CSharp7TupleDeconstruction()
        {
            var t = CSharp7Tuples(42);
            var y = t.y;
            var z = t.z;

            (int a, int b) = CSharp7Tuples(42);

            (var c, var d) = CSharp7Tuples(42);

            var (e, f) = CSharp7Tuples(42);
        }
    }
}
