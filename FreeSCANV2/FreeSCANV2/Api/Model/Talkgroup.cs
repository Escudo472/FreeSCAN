namespace FreeSCANV2.Api.External.Model;

public class Talkgroup
{
	public int tgId { get; set; }

	/// <remarks/>
	public int TgDec { get; set; }

	/// <remarks/>
	public string TgSubfleet { get; set; }

	/// <remarks/>
	public bool TgLtr { get; set; }

	/// <remarks/>
	public string TgSlot { get; set; }

	/// <remarks/>
	public string TgDescr { get; set; }

	/// <remarks/>
	public string TgAlpha { get; set; }

	/// <remarks/>
	public string TgMode { get; set; }

	/// <remarks/>
	public int Enc { get; set; }

	/// <remarks/>
	public Tag[] Tags { get; set; }

	/// <remarks/>
	public int TgCid { get; set; }

	/// <remarks/>
	public int TgSort { get; set; }

	/// <remarks/>
	public DateTime TgDate { get; set; }
}