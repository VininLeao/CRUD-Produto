using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Produto
{
    class Produto
    {
        private static int proximoId = 1;
        public int Id { get; set; }
        public string Nome { get; set; }

        public Produto()
        {
            Id = proximoId;
            proximoId++;
        }
    }
}