using System;

namespace CSharp7
{
    class TypeCheck
    {
        //
        // Concise
        //
        // Type check
        // Type switch
        // 
        // Expressive
        //
        // Pattern matching

        public int OldSchool(object o)
        {
            if (o is int) //FxCop gaat hier zeuren, dubbele typecasting
            {
                return (int)o;
            }

            string s;
            if ((s = o as string) != null)
            {
                if (int.TryParse(s, out var i))
                {
                    return i;
                }
            }
            throw new InvalidOperationException();
        }

        public int CSharp7TypeChecks(object o)
        {
            if(o is int i)
            {
                return i;
            }
            else if(o is string s && int.TryParse(s, out var j))
            {
                return j;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int CSharp7TypeSwitch(object o)
        {
            // Start of pattern matching
            switch (o)
            {
                case int i:
                    return i;
                case string s when int.TryParse(s, out var i):
                    return i;
                default:
                    throw new InvalidOperationException();
            }
        }

        public int CSharp7PatternMatching(int x,  object o)
        {
            if(x is 0)
            {
                //...
            }

            switch (o)
            {
                case 0:
                case null:
                    return 0;
                case int i:
                    return i;
                case string s when int.TryParse(s, out var i):
                    return i;
                default: // Convention
                    throw new InvalidOperationException();
            }
        }
    }
}
