using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Base;

namespace DataAccess.Entities
{
    [Table("Department")]
    public class Department 
        : BaseIdEntity
    {
        [Required(ErrorMessage = "Введите поле название отдела")]
        [DisplayName("Название отдела")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите поле этаж отдела")]
        [DisplayName("Этаж отдела")]
        public int BuildingFloor { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
