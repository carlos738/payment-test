using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api_Pottencial.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public int VendedorID{ get; set; }
        public List<Item> Itens { get; set; }
        public Vendedor vendedor { get; set; }
        
        
        
        
    }
}