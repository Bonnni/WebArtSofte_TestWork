using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Base;

namespace DataAccess.Entities
{
    [Table("ProgrammingLanguage")]
    public class ProgrammingLanguage
        : BaseIdEntity
    {   
        [Required(ErrorMessage = "Введите поле язык программирования")]
        [DisplayName("Язык программирования")]
        public string Name { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
