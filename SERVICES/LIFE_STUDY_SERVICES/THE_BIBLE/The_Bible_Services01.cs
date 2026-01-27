using E_APP.MODEL.LIFE_STUDY_MODEL.THE_BIBLE_MODEL.THE_BIBLE_GET_MODEL;
using E_APP.SERVICES.FILE_SERVICES.PDF_FILES;
using E_MauiApp01.SERVICES.FILE_SERVICES.TEXT_FILES;


namespace E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE
{
    internal class The_Bible_Services01
    {
        public static List<string> BibleChunks = new();
        private static string[] data01 = new string[100];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<The_Bible_Get_Model01> collectiondata01 = new List<The_Bible_Get_Model01>();
        private static Read_Textfiles READ = new Read_Textfiles();

        private static Read_Pdf_Files01 Read_Pdf01 = new Read_Pdf_Files01();
        public The_Bible_Services01()
        {
            load_bible_data();
        }


        public string read_full_bible_text()
        {
            foreach (string a in READ.The_Bible_KJV)
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

        public string string_read_kjv()
        {
            data01[3] = Read_Pdf01.The_Holy_Bible_KJV;
            return data01[3];
        }
        private void load_bible_data()
        {
            string[] lines = READ.The_Bible_KJV;
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
        private void load_bible01()
        {
            int chunkSize = 800; // characters
            for (int i = 0; i < READ.The_Bible_KJV.Length; i += chunkSize)
            {
                int len = Math.Min(chunkSize, READ.The_Bible_KJV.Length - i);
                BibleChunks.Add(string.Join("\n", READ.The_Bible_KJV).Substring(i, len));
            }
        }
        public string RetrieveBibleContext(string question, int maxChunks = 3)
        {
            load_bible01();
            var matches = BibleChunks
                .Where(c => question
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Any(word => c.Contains(word, StringComparison.OrdinalIgnoreCase)))
                .Take(maxChunks);

            return string.Join("\n\n", matches);
        }
    }
}