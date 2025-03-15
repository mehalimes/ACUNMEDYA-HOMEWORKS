using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class TechnologyRepository
    {
        private List<Technology> _technologies = new();
        public void Add(Technology entity) => _technologies.Add(entity);
        public List<Technology> GetAll() => _technologies;
    }
}
