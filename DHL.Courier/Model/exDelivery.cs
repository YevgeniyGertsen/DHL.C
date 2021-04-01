using DHL.Courier.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHL.Courier.Model
{
    public struct exDelivery : exDeliveryBliz, exDeliveryBusiness
    {
        public int Id { get; set; }

        public string PhoneSender { get; set; }
        public string SenderName { get; set; }
        public int KindTariffId { get; set; }
        public int WeightActual { get; set; }
        public int WeightVolume { get; set; }
        public int ContentId { get; set; }
        public string SchemeDeliver { get; set; }

        public void GetReceiverPhones()
        {
            throw new NotImplementedException();
        }

        public void GetSenderPhones()
        {
            throw new NotImplementedException();
        }
    }
}
