namespace Api.External.Model
{
	public class FccCallsignDetails
	{
		public string Licensee { get; set; }

		public string Callsign { get; set; }

		public string Status { get; set; }

		public string grantDate { get; set; }

		public string RadioService { get; set; }

		public string Notes { get; set; }

		public FccLocation[] Locations { get; set; }

		public FccFrequency[] Frequencies { get; set; }
	}
}