namespace Api.External.Model
{
	public class UserFeedBroadcast
	{
		public int FeedId { get; set; }

		public string Descr { get; set; }

		public string HostName { get; set; }

		public string Port { get; set; }

		public string Mount { get; set; }

		public string Password { get; set; }
	}
}