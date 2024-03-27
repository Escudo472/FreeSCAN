namespace Api.External.Model
{
    public class SubCat
	{
		public int ScId { get; set; }

		public string SCName { get; set; }

		public decimal Lat { get; set; }

		public decimal Lon { get; set; }

		public decimal Range { get; set; }

		public Sid[] Sids { get; set; }
	}
}