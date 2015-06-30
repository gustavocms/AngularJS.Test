namespace Chep.Test.API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Role"), DataContract(IsReference = true)]
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [DataMember]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public virtual ICollection<User> Users { get; set; }
    }
}
