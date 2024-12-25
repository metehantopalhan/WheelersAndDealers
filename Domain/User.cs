using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        private User()
        {

        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<PurchaseOrder> PurchaseOrders = new List<PurchaseOrder>();
        public User(string name, string surname, string email, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
        public PurchaseOrder AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            PurchaseOrders.Add(purchaseOrder);
            return purchaseOrder;
        }
        public void UpdateUser(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }

    }
}
