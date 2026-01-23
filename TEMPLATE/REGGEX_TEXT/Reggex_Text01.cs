namespace E_APP.TEMPLATE.REGGEX_TEXT
{
    internal class Reggex_Text01
    {
        private static string[] Regex01_ = { @"[^a-zA-Z0-9]",
                                             @"^[^@\s]+@[^@\s]+\.[^@\s]+$"};

        public static string[] Regex01
        {
            get { return Regex01_; }
            set { Regex01_ = value; }
        }
    }
}
