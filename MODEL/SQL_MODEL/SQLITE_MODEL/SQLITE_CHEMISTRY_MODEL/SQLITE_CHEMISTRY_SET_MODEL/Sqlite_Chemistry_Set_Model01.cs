

using SQLite;

namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_SET_MODEL
{
    [Table("ChemistryElement_Category")]
    internal class Sqlite_Chemistry_Set_Model01
    {
        [PrimaryKey, AutoIncrement]
        public string atomic_number { get; set; }
        public string element_name { get; set; }
        public string element_symboles { get; set; }
        public string atomic_mass { get; set; }
        public string protons { get; set; }
        public string electons { get; set; }
        public string neutrons { get; set; }
    }
}
