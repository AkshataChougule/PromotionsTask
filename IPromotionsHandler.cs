using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PromotionsTask.Models;


namespace PromotionsTask.Handlers
{
    interface IPromotionsHandler
    {
        Task<CartResponse> FetchCartValue(CartQuery cart);
    }
}
