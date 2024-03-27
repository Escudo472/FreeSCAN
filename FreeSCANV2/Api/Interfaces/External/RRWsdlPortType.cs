using Api.External.Model;

namespace Api.Interfaces.External
{
    public interface RRWsdlPortType
	{
		Task<Talkgroup[]> GetTrsTalkgroupsAsync(int sid, int tgCid, int tgTag, int tgDec, AuthInfo authInfo);
		Task<TalkgroupCat[]> GetTrsTalkgroupCatsAsync(int sid, AuthInfo authInfo);
		Task<Trs> GetTrsDetailsAsync(int sid, AuthInfo authInfo);
		Task<TrsListDef[]> GetTrsBySysIdAsync(string sysId, AuthInfo authInfo);
		Task<TrsSite[]> GetTrsSitesAsync(int sid, AuthInfo authInfo);
		Task<State[]> GetStatesByListAsync(StId[] request, AuthInfo authInfo);
		Task<County[]> GetCountiesByListAsync(CtId[] request, AuthInfo authInfo);
		Task<Tag[]> GetTagAsync(int id, AuthInfo authInfo);
		Task<Mode[]> GetModeAsync(int mode, AuthInfo authInfo);
		Task<TrsTypeDef[]> GetTrsTypeAsync(int id, AuthInfo authInfo);
		Task<TrsFlavorDef[]> GetTrsFlavorAsync(int id, AuthInfo authInfo);
		Task<TrsVoiceDef[]> GetTrsVoiceAsync(int id, AuthInfo authInfo);
		Task<Country[]> GetCountryListAsync();
		Task<CountryInfo> GetCountryInfoAsync(int coid, AuthInfo authInfo);
		Task<StateInfo> GetStateInfoAsync(int stid, AuthInfo authInfo);
		Task<CountyInfo> GetCountyInfoAsync(int ctid, AuthInfo authInfo);
		Task<AgencyInfo> GetAgencyInfoAsync(int aid, AuthInfo authInfo);
		Task<Freq[]> GetSubcatFreqsAsync(int scid, AuthInfo authInfo);
		Task<SearchFreqResult[]> SearchCountyFreqAsync(int ctid, decimal freq, string tone, AuthInfo authInfo);
        Task<SearchFreqResult[]> SearchStateFreqAsync(int stid, decimal freq, string tone, AuthInfo authInfo);
        Task<SearchFreqResult[]> SearchMetroFreqAsync(int mid, decimal freq, string tone, AuthInfo authInfo);
        Task<Freq[]> GetCountyFreqsByTagAsync(int ctid, int tag, AuthInfo authInfo);
        Task<Freq[]> GetAgencyFreqsByTagAsync(int aid, int tag, AuthInfo authInfo);
        Task<Metro[]> GetMetroAreaAsync(int mid, AuthInfo authInfo);
        Task<County[]> GetMetroAreaInfoAsync(int mid, AuthInfo authInfo);
        Task<ZipInfo> GetZipcodeInfoAsync(int zipcode, AuthInfo authInfo);
        Task<FccCallsignDetails> FccGetCallsignAsync(string callsign, AuthInfo authInfo);
        Task<FccRadioServiceCode[]> FccGetRadioServiceCodeAsync(string code, AuthInfo authInfo);
        Task<ProxCallsignResult[]> FccGetProxCallsignsAsync(decimal lat, decimal lon, decimal range, string unit, AuthInfo authInfo);
        Task<UserInfo> GetUserDataAsync(AuthInfo authInfo);
		Task<UserFeedBroadcast[]> GetUserFeedBroadcastsAsync(AuthInfo authInfo);
	}
}