namespace FreeSCANV2.Api.External.Model;

public class FccLocation
{
	public int LocationNumber { get; set; }

	public string TowerId { get; set; }

	public string Type { get; set; }

	public decimal AntennaHeight { get; set; }

	public decimal StructureHeight { get; set; }

	public decimal Elevation { get; set; }

	public string Address { get; set; }

	public decimal Lat { get; set; }

	public decimal Lon { get; set; }

	public string City { get; set; }

	public string County { get; set; }

	public string State { get; set; }
}