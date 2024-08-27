using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Candflow.WebUI.Services;

/// <summary>
/// Authentication State Service.
/// </summary>
public class AuthenticationStateService : AuthenticationStateProvider
{
    /// <inheritdoc/>
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
    }
}
