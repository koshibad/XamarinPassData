using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.PassData
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Disciplina { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
