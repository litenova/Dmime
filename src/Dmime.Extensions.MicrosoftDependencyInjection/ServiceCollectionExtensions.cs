﻿using Dmime.Abstractions;
using Dmime.Internal;
using Dmime.Internal.Registry;
using Microsoft.Extensions.DependencyInjection;

namespace Dmime.Extensions.MicrosoftDependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMimeDetector(this IServiceCollection services)
    {
        services.AddSingleton(SignatureRegistryAccessor.Registry);
        services.AddTransient<IMimeDetector, MimeDetector>();

        return services;
    }
}