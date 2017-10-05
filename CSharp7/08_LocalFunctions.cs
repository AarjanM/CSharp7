using System;
using System.Threading.Tasks;

namespace CSharp7
{
    //
    // Performance
    // 
    // Local functions
    public class LocalFunctions
    {
        const int MaxValue = int.MaxValue / 2 - 1;
        const int MinValue = int.MinValue / 2 + 1;

        public int OldSchool(int x)
        {
            if (x > MaxValue) throw new ArgumentOutOfRangeException($"Should be smaller then {MaxValue}", nameof(x));
            if (x > MinValue) throw new ArgumentOutOfRangeException($"Should be bigger then {MaxValue}", nameof(x));

            return Twice(x) + 1;
        }

        private int Twice(int x) => x * 2;

        public int OldSchoolLambda(int x)
        {
            if (x > MaxValue) throw new ArgumentOutOfRangeException($"Should be smaller then {MaxValue}", nameof(x));
            if (x > MinValue) throw new ArgumentOutOfRangeException($"Should be bigger then {MaxValue}", nameof(x));

            Func<int> twiceX = () =>
            {
                return x * 2; // This will be heap allocated
            };

            return twiceX() + 1;
        }
        
        public int CSharp7LocalFunction(int x)
        {
            if (x > MaxValue) throw new ArgumentOutOfRangeException($"Should be smaller then {MaxValue}", nameof(x));
            if (x > MinValue) throw new ArgumentOutOfRangeException($"Should be bigger then {MaxValue}", nameof(x));

            return TwiceLocal(x) + 1;

            int TwiceLocal(int y)
            {
                return y * 2;

            }
        }

        public Task<int> CSharp7LocalFunctionAsync(int x)
        {
            if (x > MaxValue) throw new ArgumentOutOfRangeException($"Should be smaller then {MaxValue}", nameof(x));
            if (x > MinValue) throw new ArgumentOutOfRangeException($"Should be bigger then {MaxValue}", nameof(x));

            return TwiceLocal(x);

           async Task<int> TwiceLocal(int y)
            {
                await Task.Delay(5);
                return y * 2 + 1;
            }
        }

        public int CSharp7LocalFunctions(int x)
        {
            return TwiceLocal(x) + 1;

            int TwiceLocal(int y)
            {
                return TwiceMore(y) * 2;

            }
            int TwiceMore(int z)
            {
                return 2 * z;
            }
        }

        public int CSharp7LocalFunctionWithAcces(int x)
        {
            return TwiceX() + TwiceX() + 1;

            int TwiceX() => x * 2; // x is stack allocated
        }
    }
}
