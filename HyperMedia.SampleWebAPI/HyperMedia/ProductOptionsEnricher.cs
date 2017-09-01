using HyperMedia.SampleWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HyperMedia.SampleWebAPI.Middleware
{
    public class ProductOptionsEnricher : ObjectContentResponseEnricher<ProductOptionsModel>
    {
        protected override Task EnrichModel(ProductOptionsModel content, IUrlHelper urlHelper)
        {
            throw new NotImplementedException();
        }
    }
}