using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness
{
    public class TechnologyManager
    {
        private readonly TechnologyRepository _repository = new();

        public void AddTechnology(string name, int langId)
        {
            var newTech = new Technology { Id = _repository.GetAll().Count + 1, Name = name, ProgrammingLanguageId = langId };
            _repository.Add(newTech);
        }

        public List<Technology> GetAllTechnologies() => _repository.GetAll();
    }
}
