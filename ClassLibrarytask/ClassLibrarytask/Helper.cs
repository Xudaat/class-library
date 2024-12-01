  namespace LibrarySystem
  {
        public static class Helper
        {
            public static string CreateBookCode(string name, int number)
            {
                if (string.IsNullOrWhiteSpace(name) || number < 0)
                    throw new ArgumentException("Invalid name or number");

                return name.Substring(0, Math.Min(2, name.Length)).ToUpper() + number;
            }
        }
   }


