namespace Api.External.Model
{
    public class TalkgroupCat
	{
		public int TgCId { get; set; }

		public int SId { get; set; }

		public string TgCName { get; set; }

		public int TgSort { get; set; }

		public int TgSortBy { get; set; }

		public decimal Lat { get; set; }

		public decimal Lon { get; set; }

		public decimal Range { get; set; }

		public DateTime LastUpdated { get; set; }
	}
}