namespace FreeSCANV2.Api.External.Model;

public class Freq
{
	public int FId { get; set; }

	public decimal Out { get; set; }

	public decimal In { get; set; }

	public string Callsign { get; set; }

	public string Descr { get; set; }

	public string Alpha { get; set; }

	public string Tone { get; set; }

	public string ColorCode { get; set; }

	public string Tg { get; set; }

	public string Slot { get; set; }

	public string Mode { get; set; }

	public int End { get; set; }

	public string Class { get; set; }

	public Tag[] Tags { get; set; }

	public int ScId { get; set; }

	public int Sort { get; set; }

	public DateTime LastUpdated { get; set; }
}