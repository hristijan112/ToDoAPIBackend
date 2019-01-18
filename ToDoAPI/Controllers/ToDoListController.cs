using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoBLL;
using ToDoEF;
using ToDoEF.DataRepository;
using ToDoEF.Contracts;
using System.Web.Http.Cors;


namespace ToDoAPI.Controllers
{

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/list")]
    public class ToDoListController : ApiController
    {
        private readonly ToDoBLLKlasa _liService = new ToDoBLLKlasa(
            new ToDoEF.DataRepository.ListRepository(new ToDoEF.DataAccess.DbAccess()));

        public ToDoListController()
        {

        }

        //get all lists
        [HttpGet]
        [Route("get")]
        public IHttpActionResult getListInfo()
        {
            try
            {
                var result = _liService.getTodoListInfos();
                return Ok(result);
            }
            catch (Exception e)
            {
                return new System.Web.Http.Results.ResponseMessageResult(
                            Request.CreateErrorResponse((HttpStatusCode)500,
                                new HttpError(e.InnerException.Message)));
            }
        }

        //get a list by id
        [HttpGet]
        [Route("get/{id:int}")]
        public IHttpActionResult getList(int id)
        {
            try
            {
                var result = _liService.getTodoListInfo(id);
                return Ok(result); ;
            }
            catch (Exception e)
            {
                return new System.Web.Http.Results.ResponseMessageResult(
                            Request.CreateErrorResponse((HttpStatusCode)500,
                                new HttpError(e.InnerException.Message)));
            }
        }

        //Create a new list
        [HttpPost]
        [Route("post")]

        public IHttpActionResult postNewList(ToDoListInfo listPost)
        {
            try
            {
                _liService.addList(listPost);
                return Ok();
            }            
            catch (Exception e)
            {
                return new System.Web.Http.Results.ResponseMessageResult(
                            Request.CreateErrorResponse((HttpStatusCode)500,
                                new HttpError(e.InnerException.Message)));
            }
        }


        //edit a list
        [HttpPut]
        [Route("put/{id:int}")]
        public IHttpActionResult editList(int id, ToDoListInfo listEdit)
        {
            try
            {
                _liService.editList(id, listEdit);
                return Ok();
            }
            catch (Exception e)
            {
                return new System.Web.Http.Results.ResponseMessageResult(
                            Request.CreateErrorResponse((HttpStatusCode)500,
                                new HttpError(e.InnerException.Message)));
            }
        }

        //delete a list
        [HttpDelete]
        [Route("delete/{id:int}")]
        public IHttpActionResult deleteList(int id)
        {
            try
            {
                _liService.deleteList(id);
                return Ok();
            }
            catch (Exception e)
            {
                return new System.Web.Http.Results.ResponseMessageResult(
                            Request.CreateErrorResponse((HttpStatusCode)500,
                                new HttpError(e.InnerException.Message)));
            }
        }

    }
}