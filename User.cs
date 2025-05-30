using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {
        public int Id { get; set; }
        public string VisitPurpose { get; set; }
        public string Citizenship { get; set; }
        public DateTime DateOfEntry { get; set; }
        public bool HasPolicy { get; set; }
        public bool HasInn { get; set; }
        public bool IsLongStay { get; set; }
        public bool HighQualify { get; set; }
        public bool ProgramResetelment { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasFingerprints { get; set; }
        public bool KnowRussian { get; set; }
        public bool HasPatent { get; set; }
        public DateTime PatentDate { get; set; }
        public string Phone { get; set; }

        public User() 
        {

        }

    }
}
