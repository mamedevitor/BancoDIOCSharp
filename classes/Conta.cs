using System;

namespace Dio.Bank
{
    public class Conta
    {
        private TipoConta tipoConta {get; set;}

        private double Saldo {get; set;}

        private double Credito {get; set;}

        private string Nome {get; set;}

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome){

           this.tipoConta = tipoConta;
           this.Saldo = saldo;
           this.Credito = credito;
           this.Nome = nome; 
        }

        public bool Sacar(double valorSaque){
            if (this.Saldo - valorSaque < (this.Credito * -1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1} ", this.Nome, this.Saldo);

            return true;
        }
        public void Depositar(double valorDeposito){
            
            this.Saldo += valorDeposito;
            Console.WriteLine($" Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino){
            if(this.Sacar(valorTransferencia)){
            contaDestino.Depositar(valorTransferencia);
        }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "tipoConta " + this.tipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
        }

    }
}