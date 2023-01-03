using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Visitors_Management.Data
{
	public interface IPerson
	{
		[Required(ErrorMessage = "Firstname is required")]
		public string first_name { get; set; }
		[Required(ErrorMessage = "Lastname is required")]
		public string last_name { get; set; }
		public DateFormat birth_day { get; set; }

		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
		public string email { get; set; }
		[DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
		public string phone_number { get; set; }
	}
}
