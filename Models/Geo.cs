using System.ComponentModel.DataAnnotations.Schema;

namespace FormationApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Geo
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
        public double Latitude { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Person Person { get; set; }
    }
}