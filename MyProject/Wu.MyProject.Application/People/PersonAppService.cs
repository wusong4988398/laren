using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Wu.MyProject.People.Dtos;

namespace Wu.MyProject.People
{
    public class PersonAppService : ApplicationService,IPersonAppService //Optionally, you can derive from ApplicationService as we did for TaskAppService class.
    {
        private readonly IRepository<Person> _personRepository;

        //ABP provides that we can directly inject IRepository<Person> (without creating any repository class)
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        public async  Task<GetAllPeopleOutput> GetAllPeople()
        {
            var people = await _personRepository.GetAllListAsync();
            return new GetAllPeopleOutput
            {
                People = people.MapTo<List<PersonDto>>()
            };
        }


    }
}
