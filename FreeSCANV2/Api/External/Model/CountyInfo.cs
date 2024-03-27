namespace Api.External.Model
{
    public class CountyInfo
	{
		public int CtId { get; set; }

		public string CountyName { get; set; }

		public string CountyHeader { get; set; }

		public int StId { get; set; }

		public decimal Lat { get; set; }

		public decimal Lon { get; set; }

		public decimal Range { get; set; }

		public string Fips { get; set; }

		public DateTime LastUpdated { get; set; }

		public Cat[] Cats { get; set; }

		public TrsListDef[] TrsList { get; set; }

		public Agency[] AgencyList { get; set; }
	}
}