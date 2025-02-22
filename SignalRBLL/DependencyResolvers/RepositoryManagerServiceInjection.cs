using Microsoft.Extensions.DependencyInjection;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDAL.Repositories.Abstracts;
using SignalRDAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.DependencyResolvers
{
    public static class RepositoryManagerServiceInjection
    {
        public static IServiceCollection AddRepositoryManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutManager, AboutManager>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactManager, ContactManager>();
            services.AddScoped<IDiscountRepository, DiscountRepository>();
            services.AddScoped<IDiscountManager, DiscountManager>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IFeatureManager, FeatureManager>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<ISocialMediaManager, SocialMediaManager>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<ITestimonialManager, TestimonialManager>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IMoneyCase, MoneyCaseRepository>();
            services.AddScoped<IMoneyCasesManager, MoneyCasesManager>();
            services.AddScoped<IMenuTableRepository, MenuTableRepository>();
            services.AddScoped<IMenuTableManager, MenuTableManager>();
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<ISliderManager, SliderManager>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
            services.AddScoped<IShoppingCartManager, ShoppingCartManager>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationManager, NotificationManager>();



            return services;

        }
    }
}
