using System.Collections.Generic;
using System.Collections.ObjectModel;
using ChiliDomain.DbObjects;

namespace NoweChili.Models
{
    public class TransportModel
    {
        private static List<TransportDbObject> TransportDbObjects { get; set; }
        public ObservableCollection<TransportDbObject> OTransportDbObjects { get; set; }

        public TransportModel()
        {
            TransportDbObjects = new List<TransportDbObject>();
            TransportDbObjects = Services.transportService.GetAll();
            OTransportDbObjects = new ObservableCollection<TransportDbObject>(TransportDbObjects);

        }
    }
}
