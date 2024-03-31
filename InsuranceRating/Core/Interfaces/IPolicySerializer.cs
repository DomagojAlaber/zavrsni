using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InsuranceRating
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromString(string policyString);
    }
}
