using System.ComponentModel.DataAnnotations.Schema;

namespace FormationApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactInfoPerso
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Mail { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string FixedPhone { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string MobilePhone { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Street { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Person Person { get; set; }
    }
}