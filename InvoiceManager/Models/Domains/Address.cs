using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InvoiceManager.Models.Domains
{
    public class Address
    {

        public Address()
        {
            Clients = new Collection<Client>();
        }

        public ICollection<Client> Clients { get; set; }
    }
}