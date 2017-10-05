using System.Diagnostics;

namespace CSharp7
{
    //
    // Performance
    // 
    // Ref locals and ref returns (maybe)
    class RefLocalsRefReturns
    {
        public void OldSchool()
        {
            int x = 1;
            int y = 0;
            int z = 3;

            AssignMaxWithValue(ref x, ref y, ref z, 42);

            Debug.Assert(x == 1);
            Debug.Assert(y == 0);
            Debug.Assert(z == 42);
        }

        private void AssignMaxWithValue(ref int var1, ref int var2, ref int var3, int value)
        {
            if (var1 > var2 && var1 > var3)
                var1 = value;
            else if (var2 > var1 && var2 > var3)
                var2 = value;
            else
                var3 = value;
        }

        public void CSharp7RefReturns()
        {
            int x = 1;
            int y = 0;
            int z = 3;

            Max(ref x, ref y, ref z) = 42;

            Debug.Assert(x == 1);
            Debug.Assert(y == 0);
            Debug.Assert(z == 42);
        }

        public ref int Max(ref int var1, ref int var2, ref int var3)
        {
            ref var max = ref var1;
            if (var2 >= max) max = var2;
            if (var3 >= max) max = var3;

            return ref max;
        }
    }
}
