using Microsoft.Extensions.DependencyInjection;
using Boboom.Js;
using Boboom.Dom;

namespace Boboom;

public static class BoboomServiceExtends
{
    public static IServiceCollection AddBoboomService(this IServiceCollection services)
    {
        services.AddBoboomJsService()
            .AddBoboomDomService();
        return services;
    }
}
