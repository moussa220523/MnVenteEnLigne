using Microsoft.Extensions.Localization;

namespace EhodVenteEnLigne
{
    public class SharedResource
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public SharedResource(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }

        public string ErrorMissingName => GetString("ErrorMissingName");
        public string ErrorMissingAddress => GetString("ErrorMissingAddress");
        public string ErrorMissingCity => GetString("ErrorMissingCity");
        public string ErrorMissingZipCode => GetString("ErrorMissingZipCode");
        public string ErrorMissingCountry => GetString("ErrorMissingCountry");

        private string GetString(string key)
        {
            return _localizer[key];
        }
    }
}
