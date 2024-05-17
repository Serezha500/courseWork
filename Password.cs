using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork
{
    static internal class Password
    {
        static uint minLength, maxLength, days;
        static bool upCase, specSym;

        public static uint MinLength { get => minLength; set => minLength = value; }
        public static uint MaxLength { get => maxLength; set => maxLength = value; }
        public static uint Days { get => days; set => days = value; }
        public static bool UpCase { get => upCase; set => upCase = value; }
        public static bool SpecSym { get => specSym; set => specSym = value; }

        static public bool CheckPassword(string password)
        {
            if (password.Length < minLength)
                return false;
            if (password.Length > maxLength)
                return false;
            if (!upCase && password.Any(Char.IsUpper))
                return false;
            if (!specSym && password.IndexOfAny("!@#$%^&*()_+|=-\\/.;№'][:~".ToCharArray())>=0)
                return false;
            return true;
        }
    }
}
