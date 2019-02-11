using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int idStore { get; set; }
        [DataMember]
        public string StoreName { get; set; }
        [DataMember]
        public string FullAddress { get; set; }
    }
}
