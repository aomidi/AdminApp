

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminApp.Domain.Models
{

	[Table( "Employees",Schema = "General")]
	public class Employee
	{

		public int EmployeeId { get; set; }

		[Display(Name = "نام")]
		[Required(ErrorMessage = "درج {0} الزامی است")]
		[MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
		public string FirstName { get; set; }

		[Display(Name = "نام خانوادگی")]
		[Required(ErrorMessage = "درج {0} الزامی است")]
		[MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
		public string LastName { get; set; }

		[Display(Name = "کد ملی")]
		[Required(ErrorMessage = "درج {0} الزامی است")]
		//[MaxLength(10, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
		[StringLength(10,MinimumLength = 10,ErrorMessage = "مقدار {0} نباید کمتر از {1} و بیشتر از {2} باشد")]
		public string NationalCode { get; set; }


		[Display(Name = "شماره تماس")]
		[MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
		public string PhoneNumber { get; set; }

		[Display(Name = "جنسیت")]
		[Required(ErrorMessage = "درج {0} الزامی است")]
		public Gender Gender { get; set; }

		[Display(Name = "شرح")]
		[DataType(DataType.Text)]
		public string Description { get; set; }
	}
}
