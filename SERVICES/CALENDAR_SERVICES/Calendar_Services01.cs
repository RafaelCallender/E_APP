namespace E_APP.SERVICES.CALENDAR_SERVICES
{
    internal class Calendar_Services01
    {
        private  DateTime date01 = DateTime.Now;
        private List<string> calenderdate = new List<string>();
        private  string[] dateformate01 = { "yyyy-MM-dd",
    "yyyy/MM/dd",
    "yyyyMMdd",
    "dd-MM-yyyy",
    "dd/MM/yyyy",
    "dd.MM.yyyy",
    "MM-dd-yyyy",
    "MM/dd/yyyy",
    "MM.dd.yyyy",
    "yyyy-MM-dd HH:mm:ss",
    "yyyy/MM/dd HH:mm:ss",
    "yyyy-MM-ddTHH:mm:ss",
    "yyyy-MM-ddTHH:mm:ssZ",
    "dd-MM-yyyy HH:mm:ss",
    "dd/MM/yyyy HH:mm:ss",
    "MM-dd-yyyy HH:mm:ss",
    "MM/dd/yyyy HH:mm:ss",
    "yyyy-MM-dd HH:mm:ss.fff",
    "yyyy-MM-ddTHH:mm:ss.fff",
    "dd MMM yyyy",
    "MMM dd, yyyy",
    "dddd, dd MMMM yyyy" };


        public Calendar_Services01()
        {
            for (int i = 0; i < dateformate01.Length; i++)
            {
                calenderdate.Add(date01.ToString(dateformate01[i]));
            }
        }
        public string[] calenderdateNow_array => calenderdate.ToArray();  





    }
}
