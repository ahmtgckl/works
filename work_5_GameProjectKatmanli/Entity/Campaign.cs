using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Abstract;

namespace work_5_GameProjectKatmanli.Entity
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }
    }
}