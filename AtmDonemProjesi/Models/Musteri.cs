using System;
using System.Collections.Generic;

namespace AtmDonemProjesi.Models
{
    public partial class Musteri
    {
        public int Id { get; set; }
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int Balance { get; set; }
        public DateTime DateTime { get; set; }
    }
}
