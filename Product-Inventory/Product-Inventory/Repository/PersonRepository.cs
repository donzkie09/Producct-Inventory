using Product_Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Inventory.Repository
{

    public interface IPersonRepository
    {
        List<Person> GetPerson();
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly ProductInventoryContext productInventoryContext;

        public PersonRepository(ProductInventoryContext productInventoryContext)
        {
            this.productInventoryContext = productInventoryContext;
        }


        public List<Person> GetPerson()
        {
            var p = productInventoryContext.Person.Where(p => p.PersonId == 1).ToList();

            return p;

        }
    }
}
