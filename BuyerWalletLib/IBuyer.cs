using System.Threading.Tasks;

namespace BuyerWalletLib
{
    public interface IBuyer
    {
        string GetName();
        Task<string> GetNameAsync();
    }
}