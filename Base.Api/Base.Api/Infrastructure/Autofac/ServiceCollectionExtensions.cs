﻿using System;
using System.Collections.Generic;
using Autofac;
using Base.Api.Infrastructure.MediatR;

namespace Base.Api.Infrastructure.Autofac
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// A centralised place for registering all interfaces and modules which help bring the app together
        /// </summary>
        /// <param name="builder"></param>
        public static void RegisterApplicationModules(this ContainerBuilder builder)
        {
            var asm = typeof(Startup).Assembly;
            builder.RegisterModule(new MediatRModule(asm));
        }
    }
}

