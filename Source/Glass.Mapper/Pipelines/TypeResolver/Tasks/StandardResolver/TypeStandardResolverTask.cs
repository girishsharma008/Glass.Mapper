﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Pipelines.TypeResolver.Tasks.StandardResolver
{
    public class TypeStandardResolverTask:ITypeResolverTask
    {
        public void Execute(TypeResolverArgs args)
        {
            if(!args.TypeContext.InferType)
            {
                args.Result = args.TypeContext.RequestedType;
                args.AbortPipeline();
            }

        }
    }
}
