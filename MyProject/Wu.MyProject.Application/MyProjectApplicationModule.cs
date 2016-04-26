﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Wu.MyProject
{
    [DependsOn(typeof(MyProjectCoreModule), typeof(AbpAutoMapperModule))]
    public class MyProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //We must declare mappings to be able to use AutoMapper
            DtoMappings.Map();
        }
    }
}
