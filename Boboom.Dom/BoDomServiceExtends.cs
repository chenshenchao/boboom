using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Boboom.Dom;

public static class BoDomServiceExtends
{
    public static IServiceCollection AddBoboomDomService(this IServiceCollection services)
    {
        // Wasm 允许 IJSruntime 是单例，但是 Server 不允许。
        // 单页 和 多页面 的 JS 运行时也是 单个和多个。
        services.AddScoped(sp => new BoDomService(sp.GetRequiredService<IJSRuntime>()));
        return services;
    }
}
