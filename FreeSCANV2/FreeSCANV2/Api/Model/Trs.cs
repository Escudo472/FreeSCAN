namespace FreeSCANV2.Api.External.Model;

public class Trs
{
	public string SName { get; set; }

	public string SType { get; set; }

	public string SFlavor { get; set; }

	public string SVoice { get; set; }

	public string SCity { get; set; }

	public CtId[] SCounty { get; set; }

	public StId[] SState { get; set; }

	public string SCountry { get; set; }

	public decimal Lat { get; set; 	}

	public decimal Lon { get; set; }

	public decimal Range { get; set; }

	public DateTime LastUpdated { get; set; }

	public TrsSysIdDef[] SysId { get; set; }

	public TrsBandplanDef[] Bandplane { get; set; }

	public TrsFleetmap Fleepmap { get; set; }
}