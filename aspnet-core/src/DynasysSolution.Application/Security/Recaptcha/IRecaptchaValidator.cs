using System.Threading.Tasks;

namespace DynasysSolution.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}