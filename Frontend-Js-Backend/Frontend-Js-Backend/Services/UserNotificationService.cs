using Frontend_Js_Backend.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FrontendJsBackend.Services;

public class UserNotificationService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, AuthenticationStateProvider authProvider)
{
    private readonly ApplicationDbContext _context = context;
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly AuthenticationStateProvider _authProvider = authProvider;

    public async Task UpdatePreferencesAsync(string email, bool subscribe)
    {
        var authState = await _authProvider.GetAuthenticationStateAsync();
        var user = await _userManager.GetUserAsync(authState.User);

        if (user != null)
        {
            user.NewsletterEmail = email;
            user.IsSubscribedToNewsletter = subscribe;
            await _context.SaveChangesAsync();
        }
    }

    public async Task<(string? Email, bool Subscribed)> GetPreferencesAsync()
    {
        var authState = await _authProvider.GetAuthenticationStateAsync();
        var user = await _userManager.GetUserAsync(authState.User);

        return (user?.NewsletterEmail, user?.IsSubscribedToNewsletter ?? false);
    }
}

