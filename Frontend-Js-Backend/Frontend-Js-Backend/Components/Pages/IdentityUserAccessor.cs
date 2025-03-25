using Frontend_Js_Backend.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Frontend_Js_Backend.Components.Pages
{
    public class IdentityUserAccessor
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityUserAccessor(IDbContextFactory<ApplicationDbContext> dbContextFactory, UserManager<ApplicationUser> userManager)
        {
            _dbContextFactory = dbContextFactory;
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var userId = _userManager.GetUserId(context.User);

            if (string.IsNullOrEmpty(userId))
                throw new InvalidOperationException("No logged-in user found.");

            await using var dbContext = await _dbContextFactory.CreateDbContextAsync();

            var user = await dbContext.Users
                .AsTracking()
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user ?? throw new InvalidOperationException("User not found.");
        }
    }
}
