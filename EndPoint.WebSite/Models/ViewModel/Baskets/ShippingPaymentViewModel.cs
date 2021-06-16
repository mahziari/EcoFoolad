using System.Collections.Generic;
using Application.Services.BackEnd.User.Addresses;
using Application.Services.FrontEnd.Basket;

namespace EndPoint.WebSite.Models.ViewModel.Baskets
{
    public class ShippingPaymentViewModel
    {
        public BasketDto basket { get; set; }
        public List<UserAddressDto> UserAddresses { get; set; }
    }
}