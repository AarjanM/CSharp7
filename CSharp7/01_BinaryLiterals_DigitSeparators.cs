using System;

namespace CSharp7
{
    //
    // Concise
    //
    // Binary literals
    // Digit seperators

    [Flags]
    public enum OldSchool
    {
        None = 0,
        A = 1,
        B = 2,
        C = 4,
        D = 8,
        E = 16,
        All = A | B | C | D | E
    }

    [Flags]
    public enum CSharp7BinaryLiterals
    {
        None = 0b000000000000000000000000000000000,
        a    = 0b000000000000000000000000000000001,
        b    = 0b000000000000000000000000000000010,
        c    = 0b000000000000000000000000000000100,
        d    = 0b000000000000000000000000000001000,
        e    = 0b000000000000000000000000000010000,
        All = a | b | c | d | e
    }

    [Flags]
    public enum CSharp7DigitalSeparators
    {
        None = 0b0000_0000,
        a    = 0b0000_0001,
        b    = 0b0000_0010,
        c    = 0b0000_0100,
        d    = 0b0000_1000,
        e    = 0b0001_0000,
        All = a | b | c | d | e
    }

    public static class Examples_DigitalSepartors
    {
        public const long BigNumber = 13_986_999;
        public const double TeslaPrice = 24_999.95;
    }
}
