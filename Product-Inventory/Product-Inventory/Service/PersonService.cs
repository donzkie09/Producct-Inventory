using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product_Inventory.Models;
using Product_Inventory.Repository;

namespace Product_Inventory.Service
{

    public interface IPersonService {
        List<Person> GetPerson();

    }

    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        } 

        public List<Person> GetPerson()
        {

            var person = personRepository.GetPerson();

            return person;

        }
    }
}
