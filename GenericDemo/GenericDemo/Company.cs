using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Company
    {
        public Company(string name, int established)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Established = established;
        }

        public string Name { get; set; }
        public int Established { get; set; }

        public override string ToString()
        {
            return $"{Name.PadRight(25)} {Established}";
        }
    }
}