using E_APP.MODEL.LIFE_STUDY_MODEL.THE_BOOK_OF_JUBILEES_MODEL.THE_BOOK_OF_JUBLIEES_GET_MODEL;
using E_APP.SERVICES.FILE_SERVICES.PDF_FILES;
using System.Text;

namespace E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES
{
    internal class The_Book_Of_Jubilees01
    {
        public static List<string> BibleChunks = new();
        private static string[] data01 = new string[10];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<The_Book_Of_Jubliees_Get_Model01> collectiondata01 = new List<The_Book_Of_Jubliees_Get_Model01>();
        private static Read_Pdf_Files01 READ = new Read_Pdf_Files01();
        private static Read_Pdf_Files01 Read_Pdf01 = new Read_Pdf_Files01();
        private static bool _chunksLoaded = false;
        public string read_full_jubiless_text()
        {
            foreach (string a in Read_Pdf01.book_of_jubilees.Split("\n"))
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

        private void load_Jubiless_data()
        {
            string[] lines = Read_Pdf01.book_of_jubilees.Split("\n");
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
        public void LoadJubilessChunks()
        {
            if (_chunksLoaded)
                return;

            // Load once from embedded text
            string[] lines = Read_Pdf01.book_of_jubilees.Split('\n');

            const int versesPerChunk = 8;
            var sb = new StringBuilder();
            int count = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                sb.AppendLine(line);
                count++;

                if (count >= versesPerChunk)
                {
                    BibleChunks.Add(sb.ToString());
                    sb.Clear();
                    count = 0;
                }
            }

            if (sb.Length > 0)
                BibleChunks.Add(sb.ToString());

            _chunksLoaded = true;
        }
    }
}