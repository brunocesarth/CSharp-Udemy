using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo_043 {
    class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
    }
}
