using System.Data;

namespace FreeSCANV2.Data.Interfaces;
public interface IAudio
{
	DataTable GetSoundDeviceStructure();
	void AddSoundDevice(DataTable table, string manufacturer, string name, string pnpDeviceId, string productName);
	void AddMotherBoardDevice(DataTable table, string deviceId, string primaryBusType, string secondaryBusType);
	DataTable GetBusStructure();
	void AddBus(DataTable table, string busType, string deviceId, string pnpDeviceId, string systemName);
	void AddStructureRow(DataTable table, string property, string value);
	DataTable GetStructure();
}