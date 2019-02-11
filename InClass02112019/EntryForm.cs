using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass02112019
{
    class EntryForm
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }
        public EntryForm(string name, string address, int ZipCode)
        {
            name = name;
            address = address;
            ZipCode = ZipCode;
        }
        public override string ToString()
        {
            string EntryForm = $"{name} lives @ {address} {zipCode}";
            return EntryForm;
        }

    }
}
