using System;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
