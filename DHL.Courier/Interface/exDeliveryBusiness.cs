using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHL.Courier.Interface
{
    public interface exDeliveryBusiness
    {       
        int KindTariffId { get; set; }
        int WeightActual { get; set; }
        int WeightVolume { get; set; }

        void GetReceiverPhones();
        void GetSenderPhones();
    }
}
