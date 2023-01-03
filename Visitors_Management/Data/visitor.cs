using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Visitors_Management.Data
{
	public class visitor: IPerson
	{
		public int VisitorId { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string city { get; set; }
		public DateOnly birth_day { get; set; }
		public string email { get; set; }
		public string phone_number { get; set; }

		public visitor(int VisitorId, string first_name, string last_name, string city, DateOnly birth_day, string email, string phone_number) 
		{ 
			this.VisitorId = VisitorId;
			this.first_name = first_name;
			this.last_name = last_name;
			this.city = city;
			this.birth_day = birth_day;
			this.email = email;
			this.phone_number = phone_number;
		}
	}
}
