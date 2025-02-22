using Microsoft.AspNetCore.SignalR;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRDAL.Context;

namespace SignalRApi.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IProductManager _productManager;
        private readonly IOrderManager _orderManager;
        private readonly IOrderDetailManager _orderDetailManager;
        private readonly IMoneyCasesManager _moneyCasesManager;
        private readonly INotificationManager _notificationManager;
        private readonly IMenuTableManager _menuTableManager;

        public SignalRHub(ICategoryManager categoryManager, IProductManager productManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, IMoneyCasesManager moneyCasesManager, INotificationManager notificationManager, IMenuTableManager menuTableManager)
        {

            _categoryManager = categoryManager;
            _productManager = productManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _moneyCasesManager = moneyCasesManager;
            _notificationManager = notificationManager;
            _menuTableManager = menuTableManager;
        }
        public async Task SendStatistic()
        {
            var value = _categoryManager.GetCategoryCount();
            await Clients.All.SendAsync("RecieveCategoryCount", value);

            var value2 = _productManager.GetProductCount();
            await Clients.All.SendAsync("RecieveProductCount", value2);

            var value11 = _orderManager.TotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderManager.ActiveTotalOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = _orderManager.LastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13);

            var value14 = _moneyCasesManager.TotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14);
        }
        public async Task SendProgress()
        {
            var value = _moneyCasesManager.TotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value);

            var value2 = _orderManager.ActiveTotalOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);
        }

        public async Task SendNotifications()
        {
            var value = _notificationManager.GetPassiveNotificationCount();
            await Clients.All.SendAsync("ReceivePassiveNotificationCount", value);

            var value1 = _notificationManager.GetPassiveNotifications();
            await Clients.All.SendAsync("ReceivePassiveNotifications", value);
        }
        public async Task GetMenuTableStatus()
        {
            var value = _menuTableManager.GetAll();
            await Clients.All.SendAsync("ReceiveMenuTableStatus", value);
        }
    }
}
