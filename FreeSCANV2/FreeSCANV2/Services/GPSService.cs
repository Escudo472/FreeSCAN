using Microsoft.VisualBasic;

namespace FreeSCANV2.Services;
public class GPSService
{
	public const string DEFAULT_LAT = "00000000N";
	public const string DEFAULT_LONG = "00000000E";

	public string DecToDMS(float decimalDeg, bool lat)
	{
		int degrees;
		float minutes;
		float seconds;
		float millisecond;
		var direction = "E";

		if (decimalDeg < 0 && lat)
		{
			direction = "S";
		}
		else if (decimalDeg >=0 && lat)
		{
			direction = "N";
		}
		else if (decimalDeg <= 0 && !lat)
		{
			direction = "W";
		}

		if (decimalDeg < 0)
		{
			decimalDeg *= -1;
		}

		degrees = Convert.ToInt32(decimalDeg);
		minutes = (decimalDeg - degrees) * 60;
		seconds = (minutes - Convert.ToInt32(minutes)) * 60;
		millisecond = (seconds - Convert.ToInt32(seconds)) * 100;

		if (millisecond >= 100)
		{
			seconds += 1;
			millisecond -= 100;
		}

		if (seconds >= 60)
		{
			minutes += 1;
			seconds -= 60;
		}

		if (minutes >= 60)
		{
			degrees += 1;
			minutes -= 60;
		}

		return $"{Strings.Format(degrees, "000")}.{Strings.Format(Convert.ToInt32(minutes), "00")}{Strings.Format(Convert.ToInt32(seconds), "00")}{Strings.Format(Convert.ToInt32(millisecond))}{direction}";
	}

	public string DMSToDec(string degreeDeg)
	{
		double degrees;
		double minutes;
		double seconds;
		double milliseconds;
		int precision;
		string direction;
		int mult = 0;

		direction = Strings.Right(degreeDeg, 1);

		if (direction == "S" || direction == "W")
		{
			mult = -1;
		}
		else if (direction == "N" || direction == "E")
		{
			mult = 1;
		}

		if (mult != 0)
		{
			degreeDeg = Strings.Left(degreeDeg, degreeDeg.Length - 1);
		}

		if (int.Parse(degreeDeg) > 10000)
		{
			degreeDeg = (int.Parse(degreeDeg) / 1000000).ToString();
		}

		if (!degreeDeg.Contains("'"))
		{
			return "0.00000000";
		}

		degrees = Convert.ToDouble(Strings.Left(degreeDeg, Strings.InStr(degreeDeg, ".") - 1));
		minutes = Convert.ToInt32(Strings.Mid(degreeDeg, Strings.InStr(degreeDeg, ".") + 1, 2)) / 60;
		seconds = Convert.ToInt32(Strings.Mid(degreeDeg, Strings.InStr(degreeDeg, "'") + 1, 4)) / 3600 / 100;

		var result = $"{degrees}{minutes}{seconds}";

		if (mult == -1)
		{
			result = (Convert.ToDouble(result) * - 1).ToString();
		}

		return result;
	}

	public void SaveGoogleViewDeg(string latitude, string longitude, string range, int currentGroup)
	{
		string page;
		string tempDir;
		int file;
		StreamWriter writer;
		string shellCode;
		string title;
		int zoomLevel;

		if (currentGroup != 0)
		{
			//title = 
		}
	}
}