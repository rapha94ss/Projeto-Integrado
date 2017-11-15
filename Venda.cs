using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Venda
    {
        public int CodVenda { set; get; }
        public string ItemVendido { set; get; }
        public decimal Preco { set; get; }
        public int Quantidade { set; get; }
        public string Cpf { set; get; }
        public string FormaPagamento { set; get; }
        public int Parcelas { set; get; }
    }
}
