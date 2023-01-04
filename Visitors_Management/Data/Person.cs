using System.ComponentModel.DataAnnotations;

namespace Visitors_Management.Data
{
	public class Person
	{
		[Required(ErrorMessage = "Firstname is required")]
		public string first_name { get; set; }

		[Required(ErrorMessage = "Lastname is required")]
		public string last_name { get; set; }
		public DateOnly birth_day { get; set; }

		[MaxLength(50, ErrorMessage = "City can not be more than 50 characters long")]
		public string city { get; set; }

		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
		public string email { get; set; }
		[MinLength(12, ErrorMessage = "Phone Number is short")]
		public string phone_number { get; set; }
	}
}
