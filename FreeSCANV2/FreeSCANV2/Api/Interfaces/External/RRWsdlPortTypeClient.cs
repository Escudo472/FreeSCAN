using System.ServiceModel;
using System.ServiceModel.Description;
using FreeSCANV2.Api.External.Model;
using Binding = System.ServiceModel.Channels.Binding;

namespace FreeSCANV2.Api.Interfaces.External;

public partial class RRWsdlPortTypeClient : ClientBase<RRWsdlPortType>, RRWsdlPortType
{
	static partial void ConfigureEndpoint(ServiceEndpoint serviceEndpoint, ClientCredentials clientCredentials);

	public RRWsdlPortTypeClient()
		: base(GetDefaultBinding(), GetDefaultEndpointAddress())
	{
		Endpoint.Name = EndpointConfiguration.RRWsdlPort.ToString();
		ConfigureEndpoint(Endpoint, ClientCredentials);
	}

	public RRWsdlPortTypeClient(EndpointConfiguration endpointConfiguration)
		: base(GetBindingForEndpoint(endpointConfiguration), GetEndpointAddress(endpointConfiguration))
	{
		Endpoint.Name = endpointConfiguration.ToString();
		ConfigureEndpoint(Endpoint, ClientCredentials);
	}

	public RRWsdlPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) 
		: base(GetBindingForEndpoint(endpointConfiguration), new EndpointAddress(remoteAddress))
	{
		Endpoint.Name = endpointConfiguration.ToString();
		ConfigureEndpoint(Endpoint, ClientCredentials);
	}

	public RRWsdlPortTypeClient(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress)
		: base(GetBindingForEndpoint(endpointConfiguration), remoteAddress)
	{
		Endpoint.Name = endpointConfiguration.ToString();
		ConfigureEndpoint(Endpoint, ClientCredentials);
	}

	public RRWsdlPortTypeClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	public Task<Talkgroup[]> GetTrsTalkgroupsAsync(int sid, int tgCid, int tgTag, int tgDec, AuthInfo authInfo)
	{
		return Channel.GetTrsTalkgroupsAsync(sid, tgCid, tgTag, tgDec, authInfo);
	}
	
	public Task<TalkgroupCat[]> GetTrsTalkgroupCatsAsync(int sid, AuthInfo authInfo)
	{
		return Channel.GetTrsTalkgroupCatsAsync(sid, authInfo);
	}

	public Task<Trs> GetTrsDetailsAsync(int sid, AuthInfo authInfo)
	{
		return Channel.GetTrsDetailsAsync(sid, authInfo);
	}

	public Task<TrsListDef[]> GetTrsBySysIdAsync(string sysId, AuthInfo authInfo)
	{
		return Channel.GetTrsBySysIdAsync(sysId, authInfo);
	}
	
	public Task<TrsSite[]> GetTrsSitesAsync(int sid, AuthInfo authInfo)
	{
		return Channel.GetTrsSitesAsync(sid, authInfo);
	}
	
	public Task<State[]> GetStatesByListAsync(StId[] request, AuthInfo authInfo)
	{
		return Channel.GetStatesByListAsync(request, authInfo);
	}
	
	public Task<County[]> GetCountiesByListAsync(CtId[] request, AuthInfo authInfo)
	{
		return Channel.GetCountiesByListAsync(request, authInfo);
	}
	
	public Task<Tag[]> GetTagAsync(int id, AuthInfo authInfo)
	{
		return Channel.GetTagAsync(id, authInfo);
	}
	
	public Task<Mode[]> GetModeAsync(int mode, AuthInfo authInfo)
	{
		return Channel.GetModeAsync(mode, authInfo);
	}
	
	public Task<TrsTypeDef[]> GetTrsTypeAsync(int id, AuthInfo authInfo)
	{
		return Channel.GetTrsTypeAsync(id, authInfo);
	}
	
	public Task<TrsFlavorDef[]> GetTrsFlavorAsync(int id, AuthInfo authInfo)
	{
		return Channel.GetTrsFlavorAsync(id, authInfo);
	}
	
	public Task<TrsVoiceDef[]> GetTrsVoiceAsync(int id, AuthInfo authInfo)
	{
		return Channel.GetTrsVoiceAsync(id, authInfo);
	}
	
	public Task<Country[]> GetCountryListAsync()
	{
		return Channel.GetCountryListAsync();
	}
	
	public Task<CountryInfo> GetCountryInfoAsync(int coid, AuthInfo authInfo)
	{
		return Channel.GetCountryInfoAsync(coid, authInfo);
	}
	
	public Task<StateInfo> GetStateInfoAsync(int stid, AuthInfo authInfo)
	{
		return Channel.GetStateInfoAsync(stid, authInfo);
	}
	
	public Task<CountyInfo> GetCountyInfoAsync(int ctid, AuthInfo authInfo)
	{
		return Channel.GetCountyInfoAsync(ctid, authInfo);
	}
	
	public Task<AgencyInfo> GetAgencyInfoAsync(int aid, AuthInfo authInfo)
	{
		return Channel.GetAgencyInfoAsync(aid, authInfo);
	}
	
	public Task<Freq[]> GetSubcatFreqsAsync(int scid, AuthInfo authInfo)
	{
		return Channel.GetSubcatFreqsAsync(scid, authInfo);
	}
	
	public Task<SearchFreqResult[]> SearchCountyFreqAsync(int ctid, decimal freq, string tone, AuthInfo authInfo)
	{
		return Channel.SearchCountyFreqAsync(ctid, freq, tone, authInfo);
	}
	
	public Task<SearchFreqResult[]> SearchStateFreqAsync(int stid, decimal freq, string tone, AuthInfo authInfo)
	{
		return Channel.SearchStateFreqAsync(stid, freq, tone, authInfo);
	}
	
	public Task<SearchFreqResult[]> SearchMetroFreqAsync(int mid, decimal freq, string tone, AuthInfo authInfo)
	{
		return Channel.SearchMetroFreqAsync(mid, freq, tone, authInfo);
	}
	
	public Task<Freq[]> GetCountyFreqsByTagAsync(int ctid, int tag, AuthInfo authInfo)
	{
		return Channel.GetCountyFreqsByTagAsync(ctid, tag, authInfo);
	}
	
	public Task<Freq[]> GetAgencyFreqsByTagAsync(int aid, int tag, AuthInfo authInfo)
	{
		return Channel.GetAgencyFreqsByTagAsync(aid, tag, authInfo);
	}
	
	public Task<Metro[]> GetMetroAreaAsync(int mid, AuthInfo authInfo)
	{
		return Channel.GetMetroAreaAsync(mid, authInfo);
	}
	
	public Task<County[]> GetMetroAreaInfoAsync(int mid, AuthInfo authInfo)
	{
		return base.Channel.GetMetroAreaInfoAsync(mid, authInfo);
	}
	
	public Task<ZipInfo> GetZipcodeInfoAsync(int zipcode, AuthInfo authInfo)
	{
		return base.Channel.GetZipcodeInfoAsync(zipcode, authInfo);
	}
	
	public Task<FccCallsignDetails> FccGetCallsignAsync(string callsign, AuthInfo authInfo)
	{
		return Channel.FccGetCallsignAsync(callsign, authInfo);
	}
	
	public Task<FccRadioServiceCode[]> FccGetRadioServiceCodeAsync(string code, AuthInfo authInfo)
	{
		return Channel.FccGetRadioServiceCodeAsync(code, authInfo);
	}
	
	public Task<ProxCallsignResult[]> FccGetProxCallsignsAsync(decimal lat, decimal lon, decimal range, string unit, AuthInfo authInfo)
	{
		return Channel.FccGetProxCallsignsAsync(lat, lon, range, unit, authInfo);
	}
	
	public Task<UserInfo> GetUserDataAsync(AuthInfo authInfo)
	{
		return Channel.GetUserDataAsync(authInfo);
	}
	
	public Task<UserFeedBroadcast[]> GetUserFeedBroadcastsAsync(AuthInfo authInfo)
	{
		return Channel.GetUserFeedBroadcastsAsync(authInfo);
	}
	
	public virtual Task OpenAsync()
	{
		return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
	}

	private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
	{
		if (endpointConfiguration == EndpointConfiguration.RRWsdlPort)
		{
			var result = new BasicHttpBinding
			{
				MaxBufferSize = int.MaxValue,
				ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
				MaxReceivedMessageSize = int.MaxValue,
				AllowCookies = true
			};
			return result;
		}
		throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
	}
	
	private static EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
	{
		if (endpointConfiguration == EndpointConfiguration.RRWsdlPort)
		{
			return new EndpointAddress("http://api.radioreference.com/soap2/index.php");
		}
		throw new InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
	}
	
	private static Binding GetDefaultBinding()
	{
		return GetBindingForEndpoint(EndpointConfiguration.RRWsdlPort);
	}
	
	private static EndpointAddress GetDefaultEndpointAddress()
	{
		return GetEndpointAddress(EndpointConfiguration.RRWsdlPort);
	}
}