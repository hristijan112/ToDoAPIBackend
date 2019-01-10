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


namespace ToDoAPI.Controllers
{
    [RoutePrefix("api/v1/list")]
    public class ToDoListController : ApiController
    {
        private readonly ToDoBLLKlasa _liService = new ToDoBLLKlasa(
            new ToDoEF.DataRepository.ListRepository(new ToDoEF.DataAccess.DbAccess()));

        public ToDoListController()
        {

        }
        [HttpGet]
        [Route("get")]
        public IHttpActionResult GetListInfo()
        {
            try
            {
                var result = _liService.GetTodoListInfos();
                return Ok(result);
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
//Get all cities
/*[HttpGet]
[Route("get")]
public IHttpActionResult GetCityInfo()
{
    try
    {
        var result = _evService.GetCityInfo();
        return Ok(result);
    }
    catch (Exception e)
    {
        return new System.Web.Http.Results.ResponseMessageResult(
                    Request.CreateErrorResponse((HttpStatusCode)500,
                        new HttpError(e.InnerException.InnerException.Message)));
    }
}
*/