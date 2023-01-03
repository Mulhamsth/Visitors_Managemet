namespace Visitors_Management.Data.Services
{
	public interface IVisitorsService
	{
		public DateTime CreationTime { get; set; }
		public List<visitor> Visitors { get; set; }
		public List<visitor> GetVisitors();
		public visitor GetVisitorById(int visitorid);
		public DateTime GetCreatedDate();
		public string GetVersion();
	}
}
