using Microsoft.AspNetCore.Identity;
using SignalRDAL.Context;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;

        public AppUserRepository(MyContext db,UserManager<AppUser> userManager) : base(db)
        {
            _userManager = userManager; 
        }

        public async Task<bool> AddUser(AppUser user)
        {
            IdentityResult result = await _userManager.CreateAsync(user, user.PasswordHash);
            if (result.Succeeded) return true;
            //List<IdentityError> errors = new List<IdentityError>();
            //foreach (IdentityError error in result.Errors)
            //{
            //    errors.Add(error);
            //}
            return false;
        }
    }
}
