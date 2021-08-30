using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineJobApplication.Data.Database.Tables;
using OnlineJobApplication.Models.DTOs;
using OnlineJobApplication.Services;
using OnlineJobApplication.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        #region Fields
        private ProfileService _ProfileService;
        #endregion

        #region Constructor
        public ProfileController(IMapper mapper)
        {
            _ProfileService = new ProfileService(mapper);
        }
        #endregion

        #region PreQualification
        [HttpPost]
        [Route("Prequalification")]
        public IActionResult SavePreQualification([FromBody] PreQualificationDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SavePreQualification(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region Registration
        [HttpPost]
        [Route("Registration")]
        public IActionResult SaveRegistration([FromBody] RegistrationDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveRegistrationInfo(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region BackgroundInformation
        [HttpPost]
        [Route("BackgroundInformation")]
        public IActionResult SaveBackgroundInformation([FromBody] BackgroundMainDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveBackgroundInformation(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region WorkHistory
        [HttpPost]
        [Route("WorkHistory")]
        public IActionResult SaveWorkHistory([FromBody] WorkHistoryDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveWorkHistory(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region DriverLicense
        [HttpPost]
        [Route("DriverLicense")]
        public IActionResult SaveDriverLicense([FromBody] DriverLicenseMainDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveDriverLicense(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region AdditionalInformation
        [HttpPost]
        [Route("AdditionalInformation")]
        public IActionResult SaveAdditionalInformation([FromBody] AdditionalInformationDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveAdditionalInformation(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region TrafficAccident
        [HttpPost]
        [Route("TrafficAccident")]
        public IActionResult SaveTrafficAccidents([FromBody] TrafficAccidentsMainDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveTrafficAccidents(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion

        #region TrafficConvictions
        [HttpPost]
        [Route("TrafficConvictions")]
        public IActionResult SaveTrafficConvictions([FromBody] TrafficConvictionsMainDTO model)
        {
            try
            {
                /////Get userId

                //string userid = this.GetUserId();

                ////////////////

                var res = _ProfileService.SaveTrafficConvictions(model, "admin");

                return Ok(UtilService.GetResponse(res));

            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }
        }
        #endregion
    }
}
