﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DynasysSolution.Authorization;

namespace DynasysSolution
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(DynasysSolutionApplicationSharedModule),
        typeof(DynasysSolutionCoreModule)
        )]
    public class DynasysSolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionApplicationModule).GetAssembly());
        }
    }
}