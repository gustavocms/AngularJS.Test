namespace Chep.Test.API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [Table("User"), DataContract(IsReference=true)]
    public partial class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        [DataMember]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [DataMember]
        public string Login { get; set; }

        [Required]
        [StringLength(30)]
        [DataMember]
        public string Password { get; set; }

        [StringLength(100)]
        [DataMember]
        public string FullName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
