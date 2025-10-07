using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; } 
        public int Idade { get; set; }
        public Conta Conta { get; set; }

        public Cliente(string nome, string cpf, int idade, Conta conta)
        {
            if (idade < 18)
                throw new ArgumentException("O cliente deve ter mais de 18 anos.");
            if (cpf.Length != 11)
                throw new ArgumentException("O CPF deve conter 11 dígitos (sem ponto e traço).");

            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Conta = conta;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Idade: {Idade}, Conta: {Conta.Numero}, Saldo: {Conta.Saldo:C}";
        }
    }
}

  