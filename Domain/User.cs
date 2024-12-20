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
        public User(string name, string surname, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Password = password;
        }
        public void AddPurchaseOrder(double purchaseOrderPrice, string titleOfDestinationAddress, string titleOfBill, string destinationAddressDescription, string billDescription)
        {
            PurchaseOrders.Add(new PurchaseOrder(Id, purchaseOrderPrice, titleOfDestinationAddress, titleOfBill, destinationAddressDescription, billDescription));
        }
        public void UpdateUser(string name, string surname, string password)
        {
            Name = name;
            Surname = surname;
            Password = password;
        }

    }
}
