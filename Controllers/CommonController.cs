using Microsoft.AspNetCore.Mvc;
using OnlineJobApplication.Models;
using OnlineJobApplication.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Controllers
{
    public class CommonController : Controller
    {

         private CommonService _commonServices;

        public CommonController()
        {
            _commonServices = new CommonService();

        }

        #region Countries
        [HttpGet]
        [Route("CountriesList")]
        public IActionResult GetCountries()
        {
            try
            {
                return Ok(UtilService.GetResponse<List<DDLDTO>>(_commonServices.GetCountries()));
            }
            catch (Exception ex)
            {
                return Ok(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region States
        [HttpGet]
        [Route("StatesList")]
        public IActionResult GetStates()
        {
            try
            {
                return Ok(UtilService.GetResponse<List<DDLDTO>>(_commonServices.GetStates()));
            }
            catch (Exception ex)
            {
                return Ok(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region States
        [HttpGet]
        [Route("DriverTypeList")]
        public IActionResult GetDriverTypes()
        {
            try
            {
                return Ok(UtilService.GetResponse<List<DDLDTO>>(_commonServices.GetDriverTypes()));
            }
            catch (Exception ex)
            {
                return Ok(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion
    }
}
