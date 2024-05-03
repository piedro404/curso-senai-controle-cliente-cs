namespace Atividade_Controle_Cliente
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float valor){
            this.valor = valor;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}