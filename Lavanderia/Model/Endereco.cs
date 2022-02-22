using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia.Model
{
    class Endereco
    {
        private int _id;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _cep;
        private string _cidade;
        private string _estado;
        public Endereco()
        {

        }

        public Endereco(int id, string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Id = id;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public int Id { get => _id; set => _id = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }


        public override string ToString()
        {
            return "Id " + _id
                    + " Rura " + _rua
                    + " Numero " + _numero
                    + " Bairro " + _bairro
                    + " Cep "    + _cep
                    + " Cidade " + _cidade
                    + " Estado " + _estado ;
        }
    }
}