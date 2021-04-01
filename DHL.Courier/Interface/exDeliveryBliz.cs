using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHL.Courier.Interface
{
    public interface exDeliveryBliz
    {
       int ContentId { get; set; }
       string SchemeDeliver { get; set; }

        void GetReceiverPhones();
        void GetSenderPhones();
        

        
       
    }
}
