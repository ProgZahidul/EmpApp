using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpApp.Models
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public string EmployeeName {  get; set; }
		public string Designation { get; set; }
		public DateTime JoinDate { get; set; }
		public decimal Salary { get; set; }
	}
}
