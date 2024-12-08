namespace Hexa.NET.SDL3
{
    using System;

    public struct Msg : IEquatable<Msg>
    {
        public nint Hwnd;
        public uint Message;
        public nuint WParam;
        public nint LParam;
        public uint Time;
        public Point32 Pt;

        public Msg(nint hwnd, uint message, nuint wParam, nint lParam, uint time, Point32 pt)
        {
            Hwnd = hwnd;
            Message = message;
            WParam = wParam;
            LParam = lParam;
            Time = time;
            Pt = pt;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is Msg msg && Equals(msg);
        }

        public readonly bool Equals(Msg other)
        {
            return Hwnd.Equals(other.Hwnd) &&
                   Message == other.Message &&
                   WParam.Equals(other.WParam) &&
                   LParam.Equals(other.LParam) &&
                   Time == other.Time &&
                   Pt.Equals(other.Pt);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Hwnd, Message, WParam, LParam, Time, Pt);
        }

        public static bool operator ==(Msg left, Msg right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Msg left, Msg right)
        {
            return !(left == right);
        }
    }
}