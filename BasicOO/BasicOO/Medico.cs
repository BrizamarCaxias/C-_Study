using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOO {
    abstract class Medico : Funcionario {
        String CRM;
        abstract public void Operar();
    }
}
