using SilencerData.Client.Models;
using SilencerData.Client.Models.SilencerData.Client.Models;

namespace SilencerData.Client.Interfaces
{
    public interface ISilencerDataService
    {
        Task<IEnumerable<Silencer>> GetSilencerDataAsync();

    }
}
