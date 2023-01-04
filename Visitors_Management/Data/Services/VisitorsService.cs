namespace Visitors_Management.Data.Services
{
	public class VisitorsService : IVisitorsService
	{
		
		public DateTime CreationTime { get; set; }
		public List<visitor> Visitors { get ; set; }

		public VisitorsService()
		{
			Visitors = new List<visitor>();
			Visitors.Add(new visitor(1, "James", "Smith", "NÖ", DateOnly.Parse("1.1.1998"), "test@fake.com", "0123456789"));
			Visitors.Add(new visitor(2, "Robert", "Johnson", "NÖ", DateOnly.Parse("1.1.2000"), "test@fake.com", "0123456789"));
			Visitors.Add(new visitor(3, "John", "Williams", "NÖ", DateOnly.Parse("1.1.1999"), "test@fake.com", "0123456789"));
			Visitors.Add(new visitor(4, "Michael", "Brown", "NÖ", DateOnly.Parse("1.1.2005"), "test@fake.com", "0123456789"));
			Visitors.Add(new visitor(5, "David", "Jones", "NÖ", DateOnly.Parse("1.1.1984"), "test@fake.com", "0123456789"));
			Visitors.Add(new visitor(6, "William", "Miller", "NÖ", DateOnly.Parse("1.1.1989"), "test@fake.com", "0123456789"));
		}

		public DateTime GetCreatedDate()
		{
			return CreationTime;
		}

		public string GetVersion()
		{
			return "v1";
		}

		public visitor GetVisitorById(int visitorid)
		{
			return Visitors.Where(vis => vis.VisitorId == visitorid).FirstOrDefault();
		}

		public List<visitor> GetVisitors()
		{
			return Visitors;
		}

		public void SaveVisitor(visitor v)
		{
			Visitors.Add(v);
		}
	}
}
