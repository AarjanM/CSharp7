using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp7
{
    public class AsyncMainOldSchool
    {
        // Old school
        internal static int Main()
        {
            return DoAsyncWork().GetAwaiter().GetResult();
        }

        private static async Task<int> DoAsyncWork()
        {
            await Task.Delay(5);
            return 1;
        }
    }

    public class AsyncMainCSharp71
    {
        // C# 7.1 Async main
        internal static async Task<int> Main()
        {
            return await DoAsyncWork();
        }

        private static async Task<int> DoAsyncWork()
        {
            await Task.Delay(5);
            return 1;
        }
    }

    public class DefaultLiteralExpression
    {
        public void OldSchool()
        {
            int i = default(int);
            var j = default(int);

            Dictionary<string, IEnumerable<int>> y = default(Dictionary<string, IEnumerable<int>>);
        }

        public void CSharp71()
        {
            int i = default;
            var j = default(int);

            Dictionary<string, IEnumerable<int>> y = default;
        }
    }

}