using System;

namespace CSharp7
{
    //
    // Concise
    //
    // Expression body members

    class ExpressionBodiedMembers
    {
        private string _label;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // C# 6.0
        public override string ToString() => $"{LastName}, {FirstName}";

        public string FullName => $"{FirstName} {LastName}";

        // C# 7.0
        public ExpressionBodiedMembers(string label) => _label = label;

        ~ExpressionBodiedMembers() => Console.Error.WriteLine("Finalized");

        public string Label
        {
            get => _label;
            set => _label = value ?? "Default label";
        }
    }
}
