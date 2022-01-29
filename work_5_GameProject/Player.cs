using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_5_GameProject
{
    internal class Player
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
