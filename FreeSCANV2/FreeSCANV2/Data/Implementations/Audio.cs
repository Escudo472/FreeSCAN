using System.Data;

namespace FreeSCANV2.Data.Implementations;

public class Audio
{
	public DataTable GetSoundDeviceStructure()
	{
		var table = new DataTable();

		table.Columns.Add(new DataColumn("Manufacturer"));
		table.Columns.Add(new DataColumn("Name"));
		table.Columns.Add(new DataColumn("PNPDeviceID"));
		table.Columns.Add(new DataColumn("ProductName"));

		return table;
	}

	public void AddSoundDevice(DataTable table, string manufacturer, string name, string pnpDeviceId, string productName)
	{
		var row = table.NewRow();

		row["Manufacturer"] = manufacturer;
		row["Name"] = name;
		row["PNPDeviceID"] = pnpDeviceId;
		row["ProductName"] = productName;

		table.Rows.Add(row);
	}

	public void AddMotherBoardDevice(DataTable table, string deviceId, string primaryBusType, string secondaryBusType)
	{
		var row = table.NewRow();

		row["DeviceID"] = deviceId;
		row["PrimaryBusType"] = primaryBusType;
		row["SecondaryBusType"] = secondaryBusType;

		table.Rows.Add(row);
	}

	public DataTable GetBusStructure()
	{
		var table = new DataTable();

		table.Columns.Add(new DataColumn("BusType"));
		table.Columns.Add(new DataColumn("DeviceID"));
		table.Columns.Add(new DataColumn("SystemName"));
		table.Columns.Add(new DataColumn("SystemName"));

		return table;
	}

	public void AddBus(DataTable table, string busType, string deviceId, string pnpDeviceId, string systemName)
	{
		var row = table.NewRow();

		row["BusType"] = busType;
		row["DeviceID"] = deviceId;
		row["PNPDeviceID"] = pnpDeviceId;
		row["SystemName"] = systemName;

		table.Rows.Add(row);
	}

	public void AddStructureRow(DataTable table, string property, string value)
	{
		var row = table.NewRow();

		row["Property"] = property;
		row["Value"] = value;

		table.Rows.Add(row);
	}

	public DataTable GetStructure()
	{
		var table = new DataTable();

		table.Columns.Add(new DataColumn("Property"));
		table.Columns.Add(new DataColumn("Value"));

		return table;
	}
}
