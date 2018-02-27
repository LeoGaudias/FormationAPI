using System;
using System.Collections.Generic;

namespace FormationApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
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
        public string Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Lastname { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Firstname { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Gender { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Photo { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Twitter { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Slack { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Github { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Linkedin { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Url { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ContactInfoPro ContactInfoPro { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string FunctionName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string FunctionDescription { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Entity { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CurrentClient { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Workcity { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string WorkAdress { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Manager { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Department { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Skill> Skills { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime EntryDate { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime BirthDate { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SocialNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ContactInfoPerso ContactInfoPerso { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EmergencyContact { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EmergencyPhoneNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string DriverLicence { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TshirtSize { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int NumberOfChild { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Geo Geo { get; set; }
    }
}