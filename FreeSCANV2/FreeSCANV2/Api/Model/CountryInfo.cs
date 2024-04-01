namespace FreeSCANV2.Api.External.Model;

public class CountryInfo
{
	public int CoId { get; set; }

	public string CountryName { get; set; }

	public string CountryCode { get; set; }

	public Agency[] AgencyList { get; set; }

	public State[] StateList { get; set; }
}