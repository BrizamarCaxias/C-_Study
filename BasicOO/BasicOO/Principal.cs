using System;
using System.Transactions;

namespace BasicOO {

    public class Principal {
        public static void Main(string[] args) {

            //Medico funcionario = new Pediatra();
            Medico funcionario1 = new Obstreta();

            //funcionario.Operar();
            funcionario1.Operar();
            




        }

    }
}