namespace FreeSCANV2.Api.External.Model;

public class Cat
{
	public int CId { get; set; }

	public string CName { get; set; }

	public SubCat[] SubCats { get; set; }
}