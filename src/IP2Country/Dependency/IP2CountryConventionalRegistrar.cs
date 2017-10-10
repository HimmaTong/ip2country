﻿using Abp.Dependency;
using Castle.MicroKernel.Registration;

namespace IP2Country.Dependency
{
    public class IP2CountryConventionalRegistrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IRirStatsSource>()
                    .WithService.Self()
                    .WithService.AllInterfaces()
                    .LifestyleSingleton()
            );
        }
    }
}