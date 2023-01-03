using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Visitors_Management.Data
{
	public class visitor: IPerson
	{
		public int VisitorId { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public DateFormat birth_day { get; set; }
		public string email { get; set; }
		public string phone_number { get; set; }
	}
}
