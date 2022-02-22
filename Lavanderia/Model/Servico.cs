using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia.Model
{
    class Servico
    {
        private int _id;
        private string _nome;               
        private string _turno;
        private double _pesoSujo;
        private double _pesoLimpo;
        private double _subtotal;
        private double _totalDoDia;
        private string _descricao;

        private EntradaDeServico entradaDeServico;

    }
}
