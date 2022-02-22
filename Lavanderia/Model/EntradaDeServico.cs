using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia.Model
{
    class EntradaDeServico
    {
        private int id;
        private DateTime dataEntrada;

        private Usuario usuario;
        private Cliente cliente;

        private List<Servico> servicos;
    }
}
