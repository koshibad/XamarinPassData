using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.PassData
{
    public class ViewModelBasePassingData
    {
        public object Paramete { get; set; }
        public enum TipoNav
        {
            Inserir,
            Alterar,
            Remover,
            Visualizar
        }
    }
}
