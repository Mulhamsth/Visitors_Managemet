using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Visitors_Management.Data
{
	public class visitor: Person
	{
		public int VisitorId { get; set; }


		public visitor() { }
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
