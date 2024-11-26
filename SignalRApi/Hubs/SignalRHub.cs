using Microsoft.AspNetCore.SignalR;
using SignalRDAL.Context;

namespace SignalRApi.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly MyContext _context;

        public SignalRHub(MyContext context)
        {
            _context = context;
        }

        public async Task CategoryCounter()
        {
            var value = _context.Categories.Count();
            await Clients.All.SendAsync("RecieveCategoryCount",value);
        }
    }
}
