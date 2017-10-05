using System;
using System.Threading.Tasks;

namespace CSharp7
{
    //
    // Improvements (possibly not)
    //
    // Throw expressions
    // Generalized async method return types
    class Improvements
    {
        public int CSharp7ThrowExpressions(string s)
        {
            var a = s ?? throw new ArgumentNullException(nameof(s));

            return int.TryParse(a, out int i) ? i : throw new Exception();
        }

        public async ValueTask<int> CSharp7ValueTask(string s) //Struct so Stack allocated
        {
            await Task.Delay(5);
            if (int.TryParse(s, out int i))
                return i;
            else
                throw new InvalidOperationException();
        }
    }
}
