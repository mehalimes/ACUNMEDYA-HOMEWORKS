using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class ProgrammingLanguageRepository
    {
        private List<ProgrammingLanguage> _programmingLanguages = new();

        public void Add(ProgrammingLanguage entity) => _programmingLanguages.Add(entity);
        public List<ProgrammingLanguage> GetAll() => _programmingLanguages;
    }
}
