using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
namespace Models
{
    public class Moyenne:Model
    {
        public string code_eleve;
        public string code_fil;
        public string niveau;
        public decimal moyenne;
        public Moyenne()
        {

        }
    }
}
