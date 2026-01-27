using E_APP.MODEL.LIFE_STUDY_MODEL.BOOK_OF_ENOCH_MODEL.BOOK_OF_ENOCH_GET_MODEL;
using E_MauiApp01.SERVICES.FILE_SERVICES.TEXT_FILES;


namespace E_APP.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH
{
    internal class Book_of_Enoch01
    {
        private static string[] data01 = new string[100];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<Book_Of_Enoch_Get_Model01> collectiondata01 = new List<Book_Of_Enoch_Get_Model01>();
        private static Read_Textfiles READ = new Read_Textfiles();
        public Book_of_Enoch01()
        {
            load_Enoch_data();
        }
        public string read_full_enoch_text()
        {
            foreach (string a in READ.The_Book_of_Enoch)
            {
                data01[0] += $"{a}\n";

            }

            return data01[0];
        }
        public string get_data01()
        {

            string previous = null;
            for (int i = 0; i < bookname.Count; i++)
            {
                string current = bookname[i];
                if (current == previous)
                {
                    continue;

                }
                else
                {
                    previous = current;
                }
                data01[1] += $"{current}\n";

            }
            return data01[1];
        }
        public string get_data02(string input)
        {
            if (verses.Contains(input) == true)
            {
                foreach (string a in verses)
                {
                    data01[2] = $"{a}\n";
                }
            }
            else
            {
                data01[2] = "cant find";
            }
            return data01[2];
        }

        private void load_Enoch_data()
        {
            string[] lines = READ.The_Book_of_Enoch;


            string previousBook = null;

            foreach (string line in lines)
            {
                thebook.Add(line);

                if (string.IsNullOrWhiteSpace(line))
                {
                    bookname.Add("");
                    continue;
                }
                else
                {

                    int spaceIndex = line.IndexOf(' ');
                    string book = (spaceIndex == -1) ? line : line.Substring(0, spaceIndex);


                    if (book == previousBook)
                    {
                        continue;

                    }
                    else
                    {
                        previousBook = book;
                        bookname.Add(book);
                    }

                }
            }
        }
    }
}