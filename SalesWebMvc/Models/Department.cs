using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //construtores
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //métodos

        //Adicionar um vendedor
        public void AddSellers(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Calcular o total de vendas de um departamento
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
