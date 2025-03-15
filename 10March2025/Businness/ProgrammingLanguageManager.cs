using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness
{
    public class ProgrammingLanguageManager
    {
        private readonly ProgrammingLanguageRepository _repository = new();

        public void AddLanguage(string name)
        {
            var newLang = new ProgrammingLanguage { Id = _repository.GetAll().Count + 1, Name = name };
            _repository.Add(newLang);
        }

        public List<ProgrammingLanguage> GetAllLanguages() => _repository.GetAll();
    }
}
