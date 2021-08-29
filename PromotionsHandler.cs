using PromotionsTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionsTask.Handlers
{
    public class PromotionsHandler : IPromotionsHandler
    {
        public Task<CartResponse> FetchCartValue(CartQuery cart)
        {
            throw new NotImplementedException();
        }
    }
}
