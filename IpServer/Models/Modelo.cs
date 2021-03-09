using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IpServer.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public DateTime DataRegisto { get; set; }
        public Marca Marca { get; set; }


        public Modelo()
        {

        }
        public Modelo(int id, string descricao, DateTime dataRegisto, Marca marca)
        {
            Id = id;
            Descricao = descricao;
            DataRegisto = dataRegisto;
            Marca = marca;
        }

       
    }
}
