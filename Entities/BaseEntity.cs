using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MDS.Entities
{

    public abstract class BaseEntity
   {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual int Id { get; set; }

        public virtual bool IsNew
        {
            get
            {
                return this.Id < 1;
            }
        }

        private DateTime dateCreated = DateTime.Now;

        public DateTime DateCreated
        {
            get
            {
                return this.dateCreated;
            }
            private set
            {
                this.dateCreated = value;
            }
        }

        private DateTime dateUpdated = DateTime.Now;

        public DateTime DateUpdated
        {
            get
            {
                return this.dateUpdated;
            }
            private set
            {
                this.dateUpdated = value;
            }
        }

        #endregion

        #region Methods

        public virtual void SetDateCreated()
        {
            if (this.IsNew)
            {
                this.DateCreated = DateTime.Now;
            }

            this.SetDateUpdated();
        }

        public virtual void SetDateUpdated()
        {
            this.DateUpdated = DateTime.Now;
        }

        #endregion
    }
}
