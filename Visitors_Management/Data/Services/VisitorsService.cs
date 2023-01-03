namespace Visitors_Management.Data.Services
{
	public class VisitorsService : IVisitorsService
	{
		public DateTime CreationTime { get; set; }
		public List<visitor> Visitors { get ; set; }

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
	}
}
