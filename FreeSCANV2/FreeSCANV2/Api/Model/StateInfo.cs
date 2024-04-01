namespace FreeSCANV2.Api.External.Model;

public class StateInfo
{
	public int StId { get; set; }

	public string StateName { get; set; }

	public string StateEntityType { get; set; }

	public TrsListDef[] TrsList { get; set; }

	public Agency[] AgencyList { get; set; }

	public County[] CountyList { get; set; }
}