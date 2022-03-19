using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Models
{
    public class Note : Model
    {
        public string codeEleve;
        public string codeMat;
        public float note;

        public Note()
        {
        }

        public Note(string codeEleve, string codeMat, float note)
        {
            this.codeEleve = codeEleve;
            this.codeMat = codeMat;
            this.note = note;
        }
    }
}
