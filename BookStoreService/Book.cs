using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public Int64 ISBN { get; set; }
        [DataMember]
        public int idSupplier { get; set; }
        [DataMember]
        public string Title { get; set; }
    }
}
