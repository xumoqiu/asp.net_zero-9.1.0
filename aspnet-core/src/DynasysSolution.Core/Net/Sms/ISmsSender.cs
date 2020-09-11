using System.Threading.Tasks;

namespace DynasysSolution.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}