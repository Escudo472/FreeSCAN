namespace Api.External.Model
{
	public class FccFrequency
	{
		public int LocationNumber { get; set; }

		public decimal Frequency { get; set; }

		public string Emission { get; set; }

		public string Class { get; set; }

		public decimal Power { get; set; }

		public int Mobiles { get; set; }

		public int Pagers { get; set; }
	}
}