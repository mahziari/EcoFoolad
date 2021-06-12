using System.Collections.Generic;
using Application.Services.FrontEnd.Basket;
using Application.Services.FrontEnd.User.Addresses;

namespace EndPoint.WebSite.Models.ViewModel.Baskets
{
    public class ShippingPaymentViewModel
    {
        public BasketDto basket { get; set; }
        public List<UserAddressDto> UserAddresses { get; set; }
    }
}