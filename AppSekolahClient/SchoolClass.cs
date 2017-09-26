using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSekolahClient
{
    class Subjects
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Kelas
    {
        public string id { get; set; }
        public string class_name { get; set; }
        public string school_level { get; set; }
        public string years_id { get; set; }
        public string teacher_id { get; set; }
        public string last_modified_by { get; set; }
    }

    class Keuangan
    {
        public string id { get; set; }
        public string tanggal { get; set; }
        public string debit { get; set; }
        public string kredit { get; set; }
        public string keterangan { get; set; }
    }
}
