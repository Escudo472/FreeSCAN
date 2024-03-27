namespace Api.External.Model
{
    public class TrsSite
	{
		public int SiteId { get; set; }

		public int SId { get; set; }

		public int SiteNumber { get; set; }

		public string SiteDescr { get; set; }

		public int ZoneNumber { get; set; }

		public string ZoneDescr { get; set; }

		public int Rfss { get; set; }

		public string Nac { get; set; }

		public int Ran { get; set; }

		public string SiteNeighbors { get; set; }

		public string SiteLocation { get; set; }

		public int SiteCtId { get; set; }

		public string SiteCt { get; set; }

		public string SiteModulation { get; set; }

		public string SiteNotes { get; set; }

		public decimal Lat { get; set; }

		public decimal Lon { get; set; }

		public decimal Range { get; set; }

		public int Splinter { get; set; }

		public int Rebanded { get; set; }

		public TrsSiteLicense[] SiteLicenses { get; set; }

		public TrsSiteFreq[] SiteFreqs { get; set; }

		public TrsBandplanDef[] Bandplan { get; set; }
	}
}