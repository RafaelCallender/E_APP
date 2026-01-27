using SQLite;

namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL
{
    [Table("ChemistryElements")]
    internal class Sqlite_Chemistry_Get_Model01
    {
         [PrimaryKey, AutoIncrement]
         public int Id { get; set; }
        public int atomic_number { get; set; }
        public string element_name { get; set; }
        public string element_symboles { get; set; }
        public double atomic_mass { get; set; }
        public int protons { get; set; }
        public int electons { get; set; }
        public int neutrons { get; set; }


    }
}
