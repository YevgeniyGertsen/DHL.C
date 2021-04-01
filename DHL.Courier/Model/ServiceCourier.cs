using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;


namespace DHL.Courier.Model
{
    public struct ServiceCourier
    {
        public ServiceCourier(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public string connectionString { get; set; }

        /// <summary>
        /// метод по созданию КН
        /// </summary>
        /// <param name="exDelivery"></param>
        /// <returns></returns>
        public bool CreateExDelivery(exDelivery exDelivery)
        {
            try
            {
                using (var db = new LiteDatabase(connectionString))
                {
                    var col = db.GetCollection<exDelivery>("exDelivery");

                    col.Insert(exDelivery);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<exDelivery> GetEverything()
        {
            LiteDatabase db = new LiteDatabase(connectionString);

            var col = db.GetCollection<exDelivery>("exDelivery").FindAll().ToList();

            db.Dispose();
            return col;
        }
    }
}
