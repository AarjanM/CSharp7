namespace CSharp7
{
    class OutVariables
    {
        //
        // Concise
        //
        // Out variables

        public int OldSchool(string s)
        {
            int i;
            if(int.TryParse(s, out i))
            {
                //....
            }
            // Or
            var j = default(int);
            if(int.TryParse(s, out j))
            {
                // ..
            }
            return i;
        }

        public int CSharp7OutParameters(string s)
        {
            if(int.TryParse(s, out int i))
            {
                //...
            }
            // Or even
            if (int.TryParse(s, out var j))
            {
                //...
            }
            return i;
        }
        
    }
}
