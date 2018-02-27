using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FormationApi.Models;
using FormationApi.Context;
using FormationApi.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FormationApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public PeopleController(ApplicationDbContext context) => this._context = context;

        #region GET

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getById")]
        public Person GetById(int personId)
        {
            return _context.Persons.SingleOrDefault(p => p.Id == personId);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getByName")]
        public List<Person> GetByName(string query)
        {
            if(!string.IsNullOrEmpty(query))
            {
                string[] splitQuery = query.Split(' ');
                
                if(splitQuery.Length == 1)
                {
                    if(!string.IsNullOrEmpty(splitQuery[0]))
                    {
                        return _context.Persons.Where(p => p.Firstname.ToLowerInvariant().Contains(splitQuery[0].ToLowerInvariant()) || p.Lastname.Contains(splitQuery[0].ToLowerInvariant())).ToList();
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return _context.Persons.Where(p => (p.Firstname.ToLowerInvariant().Contains(splitQuery[0].ToLowerInvariant()) || p.Lastname.ToLowerInvariant().Contains(splitQuery[0].ToLowerInvariant())) && 
                                                    (p.Firstname.ToLowerInvariant().Contains(splitQuery[1].ToLowerInvariant()) || p.Lastname.ToLowerInvariant().Contains(splitQuery[1].ToLowerInvariant()))).ToList();
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getBySkill")]
        public List<Person> GetBySkill(string skill)
        {
            return _context.Persons.Where(p => p.Skills.Any(s => s.Name.ToLowerInvariant().Contains(skill.ToLowerInvariant()))).ToList();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getRandom")]
        public Person GetRandom()
        {
            Random rand = new Random();
            Person res = null;
            
            int countRows = _context.Persons.ToList().Count;

            while(res == null)
            {
                res = _context.Persons.SingleOrDefault(p => p.Id == rand.Next(countRows + 1));
            }

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getAll")]
        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        #endregion

        #region POST
        
        /// <summary>
        /// 
        /// </summary>
        [HttpPost, Route("create")]
        public void Create(PersonFormViewModel vm)
        {
            try
            {
                Person p = new Person(); 

                p.Firstname = vm.Firstname;
                p.Lastname = vm.LastName;
                
                // The datetime cannot be null
                // For the example we put a default datetime 
                DateTime date = DateTime.Now;
                p.BirthDate = date;
                p.EntryDate = date;

                // NumberOfChild cannot be null 
                p.NumberOfChild = 0;

                ContactInfoPerso cip = new ContactInfoPerso();
                cip.Mail = vm.Email;
                cip.MobilePhone = vm.Phone;

                p.ContactInfoPerso = cip;

                _context.Persons.Add(p);
                _context.SaveChanges();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw ;
            }
        }

        #endregion

        #region PUT

        /// <summary>
        /// 
        /// </summary>
        [HttpPut, Route("update")]
        public void Update(PersonFormViewModel vm)
        {
            try
            {
                if(vm.Id.HasValue)
                {
                    Person p = _context.Persons.Include(pers => pers.ContactInfoPerso).SingleOrDefault(pers => pers.Id == vm.Id.Value);
                    
                    if(p != null)
                    {
                        p.Firstname = vm.Firstname;
                        p.Lastname = vm.LastName;
                        p.ContactInfoPerso.Mail = vm.Email;
                        p.ContactInfoPerso.MobilePhone = vm.Phone;

                        _context.SaveChanges();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        #endregion

        #region DELETE
        
        /// <summary>
        /// 
        /// </summary>
        [HttpDelete, Route("delete")]
        public void Delete(int Id)
        {
            try
            {
                Person p = _context.Persons.Include(pers => pers.ContactInfoPerso).SingleOrDefault(pers => pers.Id == Id);
                
                if(p != null)
                {
                    _context.Persons.Remove(p);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        #endregion
    }
}