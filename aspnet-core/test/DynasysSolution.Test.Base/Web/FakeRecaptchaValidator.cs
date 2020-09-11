using System.Threading.Tasks;
using DynasysSolution.Security.Recaptcha;

namespace DynasysSolution.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
