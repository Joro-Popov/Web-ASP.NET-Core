using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Eventures.Web.Filters
{
    public class InvalidModelStateFilter : ExceptionFilterAttribute
    {
        private readonly IModelMetadataProvider dataProvider;

        public InvalidModelStateFilter(IModelMetadataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult();
            result.ViewData = new ViewDataDictionary(this.dataProvider, context.ModelState);

            result.ViewData.Add("Exception", context.ModelState.Values); 
            context.Result = result;
        }
    }
}
