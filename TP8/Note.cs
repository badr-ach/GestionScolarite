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
        public string code_eleve;
        public string code_mat;
        public decimal note;

        public Note()
        {
        }

        public Note(string codeEleve, string codeMat, decimal note)
        {
            this.code_eleve = codeEleve;
            this.code_mat = codeMat;
            this.note = note;
        }
    }
}
