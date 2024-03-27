namespace Api.External.Model
{
    public class AgencyInfo
	{
		public int AId { get; set; }

		public string AgencyName { get; set; }

		public string AgencyType { get; set; }

		public int CtId { get; set; }

		public int StId { get; set; }

		public decimal Lat { get; set; }

		public decimal Lon { get; set; }

		public decimal Range { get; set; }

		public DateTime LastUpdated { get; set; }

		public Cat[] Cats { get; set; }
	}
}