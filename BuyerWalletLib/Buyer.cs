using System;
using System.Threading.Tasks;

namespace BuyerWalletLib
{
    public class Buyer : IBuyer
    {
        public string GetName()
        {
            return "test";
        }

        public async Task<string> GetNameAsync()
        {
            await Task.Delay(100);
            return "test async";
        }
    }
}
