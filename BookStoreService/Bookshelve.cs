using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    [DataContract]
    public class Bookshelve
    {
        [DataMember]
        public Int64 ISBN { get; set; }
        [DataMember]
        public int idStore { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}
