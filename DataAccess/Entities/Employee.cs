using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Base;

namespace DataAccess.Entities
{
    [Table("Employee")]
    public class Employee 
        : BaseIdEntity
    {
        [Required(ErrorMessage = "Введите поле имя")]
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите поле фамилия")]
        [DisplayName("Фамилия")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите поле возраст")]
        [DisplayName("Возраст")]

        public int Age { get; set; }

        [Required(ErrorMessage = "Введите поле пол")]
        [DisplayName("Пол")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Введите поле отдел")]
        [DisplayName("Отдел")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Введите поле язык программирования")]
        [DisplayName("Язык программирования")]
        public int ProgrammingLanguageId { get; set; }


        [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }
        [ForeignKey("ProgrammingLanguageId")]
        public virtual ProgrammingLanguage ProgrammingLanguages { get; set; }
    }
}
