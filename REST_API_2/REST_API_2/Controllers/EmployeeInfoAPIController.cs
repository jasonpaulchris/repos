using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using REST_API_2.Models;
using REST_API_2.Repositories;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using System.Web.Http.Cors;

namespace REST_API_2.Controllers
{
    [EnableCors("*", "*", "*")]
    public class EmployeeInfoAPIController : ApiController
    {
        IRepository<EmployeeInfo, int> repository;
        public EmployeeInfoAPIController(IRepository<EmployeeInfo, int> repository)
        {
            this.repository = repository;
        }

        [ResponseType(typeof(IEnumerable<EmployeeInfo>))]
        public IHttpActionResult Get()
        {
            return Ok(repository.Get());
        }

        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Get(int id)
        {
            var Emp = repository.Get(id);
            if (Emp == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format($"No Employee with ID = {id}")),
                    ReasonPhrase = "Employee Id Not Found"
                });

                }
            return Ok(Emp);                    
            }

        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Post([FromBody]EmployeeInfo emp)
        {
            if (ModelState.IsValid)
            {
                return Ok(repository.Create(emp));
            }
            else
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotAcceptable)
                {
                    Content = new StringContent(String.Format($"Error with Posted Data \n {GetModelErrorMessagesHelper(ModelState)}")),
                    ReasonPhrase = "Employee Data is Invalid"
                });
            }
        }
        [ResponseType(typeof(bool))]
        public IHttpActionResult Put(int id, [FromBody]EmployeeInfo emp)
        {
            if (ModelState.IsValid)
            {
                var res = repository.Update(id, emp);
                if (!res)
                {
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    {
                        Content = new StringContent(string.Format($"No employee with ID = {id}")),
                        ReasonPhrase = "Employee ID Not Found"
                    });
                }
                else
                {
                    return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "Update Successful"));
                }
            }
            else
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotAcceptable)
                {
                    Content = new StringContent(string.Format($"Error with Posted Data \n {GetModelErrorMessagesHelper(ModelState)}")),
                    ReasonPhrase = "Employee Data is Invalid"
                });
            }
        }

        [ResponseType(typeof(bool))]
        public IHttpActionResult Delete(int id)
        {
            var res = repository.Delete(id);
            if (res)
            {
                return new ResponseMessageResult(Request.CreateResponse(HttpStatusCode.OK, "Record Deleted Successfully"));
            }
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
            {
                Content = new StringContent(string.Format($"No Employee with ID = {id}")),
                ReasonPhrase = " Employee ID Not Found"
            });
        }
        /// <summary>
        ///     
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        private string GetModelErrorMessagesHelper(ModelStateDictionary errors)
        {
            string messages = "";
            foreach (var item in errors)
            {
                for (int j=0; j < item.Value.Errors.Count; j++)
                {
                    messages += $"{item.Key.ToString()} \t {item.Value.Errors[j].ErrorMessage} \n";
                }
                
            }
            return messages;
        }
    }
}
