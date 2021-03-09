using System;
using System.Collections.Generic;

namespace IpServer.Models
{
    public class Marca
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime DataRegisto { get; set; }

        public ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();

        public Marca()
        {

        }

        public Marca(int id, string descricao, DateTime dataRegisto)
        {
            Id = id;
            Descricao = descricao;
            DataRegisto = dataRegisto;
        }

        public void AddMarca(Modelo m)
        {
            Modelos.Add(m);
        }

        public void RemoveMarca(Modelo m)
        {
            Modelos.Remove(m);
        }
    }
}
