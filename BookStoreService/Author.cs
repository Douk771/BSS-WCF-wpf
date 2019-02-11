using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    [DataContract]
    public class Author
    {
        [DataMember]
        public int idAuthor { get; set; }

        [DataMember]
        public string FIO { get; set; }

    }
}
