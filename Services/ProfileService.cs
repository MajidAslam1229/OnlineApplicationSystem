using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineJobApplication.Data.Database.Tables;
using OnlineJobApplication.Models.DTOs;
using OnlineJobApplication.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Services
{
    public class ProfileService
    {

        #region Fields
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public ProfileService(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion
        #region PreQualification
        public PreQualificationDTO SavePreQualification(PreQualificationDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    if (model.Id == 0)
                    {
                        ////Mapping Values
                        var objprequalification = this._mapper.Map<PreQualification>(model);
                        //////


                        objprequalification.RecordStatus = true;
                        objprequalification.CreatedBy = UserId;
                        objprequalification.CreatedDate = UtilService.GetPkCurrentDateTime();



                        db.PreQualification.Add(objprequalification);


                        //db.Entry(objprequalification).State = EntityState.Modified;

                        db.SaveChanges();

                        model.Id = objprequalification.Id;

                        trans.Commit();

                        return model;
                       

                    }
                    

                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region Registration
        public RegistrationDTO SaveRegistrationInfo(RegistrationDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    if (model.Id == 0)
                    {
                        ////Mapping registration personal information Values
                        var objregistrationpersonalinfo = this._mapper.Map<RegistrationPersonalInformation>(model);
                        //////


                        objregistrationpersonalinfo.RecordStatus = true;
                        objregistrationpersonalinfo.CreatedBy = UserId;
                        objregistrationpersonalinfo.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.RegistrationPersonalInformation.Add(objregistrationpersonalinfo);


                        db.SaveChanges();

                        model.Id = objregistrationpersonalinfo.Id;

                        /////Save Address

                        if (model.Address.Count > 0 && model.Id > 0)
                        {
                            foreach (var Address in model.Address)
                            {

                                ////Mapping registration personal information Values
                                var objregistrationaddress = this._mapper.Map<RegistrationAddress>(Address);
                                //////

                                objregistrationaddress.RegistrationId = model.Id;
                                objregistrationaddress.RecordStatus = true;
                                objregistrationaddress.CreatedBy = UserId;
                                objregistrationaddress.CreatedDate = UtilService.GetPkCurrentDateTime();

                                db.RegistrationAddress.Add(objregistrationaddress);


                                db.SaveChanges();

                                Address.Id = objregistrationaddress.Id;

                            }
                        }


                        ///

                        //Save Registration Questions

                        ////Mapping registration personal information Values
                        var objregistrationquestions = this._mapper.Map<RegistrationQuestions>(model.registrationQuestionDTO);
                        //////

                        objregistrationquestions.RegistrationId = model.Id;
                        objregistrationquestions.RecordStatus = true;
                        objregistrationquestions.CreatedBy = UserId;
                        objregistrationquestions.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.RegistrationQuestions.Add(objregistrationquestions);


                        db.SaveChanges();

                        model.Id = objregistrationquestions.Id;


                        ///

                        trans.Commit();

                        return model;


                    }


                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region BackgroundInformation
        public BackgroundMainDTO SaveBackgroundInformation(BackgroundMainDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    foreach (var BackgroundInformationDTO in model.backgroundInformationDTOs)
                    {

                        ////Mapping BackgroundInformationDTO
                        var objbackgroundinformationmaster = this._mapper.Map<BackgroundQuestionsMaster>(BackgroundInformationDTO);
                        //////


                        objbackgroundinformationmaster.RecordStatus = true;
                        objbackgroundinformationmaster.CreatedBy = UserId;
                        objbackgroundinformationmaster.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.BackgroundQuestionsMaster.Add(objbackgroundinformationmaster);


                        db.SaveChanges();

                        BackgroundInformationDTO.Id = objbackgroundinformationmaster.Id;

                        /////Save BackgroundInformationDetails

                        if (BackgroundInformationDTO.backgroundQuestiondDetailsDTOs.Count > 0 && BackgroundInformationDTO.Answer==true && BackgroundInformationDTO.Id > 0)
                        {
                            foreach (var backgroundQuestiondDetailsDTO in BackgroundInformationDTO.backgroundQuestiondDetailsDTOs)
                            {

                                ////Mapping BackgroundInformationDetails
                                var objbackgroundquestiondetails = this._mapper.Map<BackgroundQuestionDetails>(backgroundQuestiondDetailsDTO);
                                //////

                                objbackgroundquestiondetails.BackgroudQuestionMasterId = objbackgroundinformationmaster.Id;
                                objbackgroundquestiondetails.RecordStatus = true;
                                objbackgroundquestiondetails.CreatedBy = UserId;
                                objbackgroundquestiondetails.CreatedDate = UtilService.GetPkCurrentDateTime();

                                db.BackgroundQuestionDetails.Add(objbackgroundquestiondetails);


                                db.SaveChanges();

                                backgroundQuestiondDetailsDTO.Id = objbackgroundquestiondetails.Id;

                            }
                        }

                    }

                    trans.Commit();

                    return model;
                  
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region WorkHistory
        public WorkHistoryDTO SaveWorkHistory(WorkHistoryDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    if (model.Id == 0)
                    {
                        ////Mapping Work History Values
                        var objworkhistory = this._mapper.Map<WorkHistory>(model);
                        //////

                        objworkhistory.RegistrationId = model.RegistrationId;
                        objworkhistory.RecordStatus = true;
                        objworkhistory.CreatedBy = UserId;
                        objworkhistory.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.WorkHistory.Add(objworkhistory);


                        db.SaveChanges();

                        model.Id = objworkhistory.Id;

                        /////Save Address

                        if (model.workHistoryReferencesDTOs.Count > 0 && model.Id > 0)
                        {
                            foreach (var WorkHistoryReferencesdto in model.workHistoryReferencesDTOs)
                            {

                                ////Mapping registration personal information Values
                                var objworkhistoryreference = this._mapper.Map<WorkHistoryReferences>(WorkHistoryReferencesdto);
                                //////

                                objworkhistoryreference.WorkHistoryId = model.Id;
                                objworkhistoryreference.RecordStatus = true;
                                objworkhistoryreference.CreatedBy = UserId;
                                objworkhistoryreference.CreatedDate = UtilService.GetPkCurrentDateTime();

                                db.WorkHistoryReferences.Add(objworkhistoryreference);


                                db.SaveChanges();

                                WorkHistoryReferencesdto.Id = objworkhistoryreference.Id;

                            }
                        }


                        trans.Commit();

                        return model;


                    }


                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region DriverLicense
        public DriverLicenseMainDTO SaveDriverLicense(DriverLicenseMainDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    foreach (var driverLicenseDTO in model.driverLicenseDTOs)
                    {

                        ////Mapping BackgroundInformationDTO
                        var objdriverlicense = this._mapper.Map<DriverLicense>(driverLicenseDTO);
                        //////


                        objdriverlicense.RecordStatus = true;
                        objdriverlicense.CreatedBy = UserId;
                        objdriverlicense.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.DriverLicense.Add(objdriverlicense);


                        db.SaveChanges();

                        driverLicenseDTO.Id = objdriverlicense.Id;

                    }

                    trans.Commit();

                    return model;

                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region AdditionalInformation
        public AdditionalInformationDTO SaveAdditionalInformation(AdditionalInformationDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    if (model.Id == 0)
                    {
                        ////Mapping Values
                        var objadditionalinfo = this._mapper.Map<AdditionalInformation>(model);
                        //////


                        objadditionalinfo.RecordStatus = true;
                        objadditionalinfo.CreatedBy = UserId;
                        objadditionalinfo.CreatedDate = UtilService.GetPkCurrentDateTime();



                        db.AdditionalInformation.Add(objadditionalinfo);


                        //db.Entry(objprequalification).State = EntityState.Modified;

                        db.SaveChanges();

                        model.Id = objadditionalinfo.Id;

                        trans.Commit();

                        return model;


                    }


                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region TrafficAccidents
        public TrafficAccidentsMainDTO SaveTrafficAccidents(TrafficAccidentsMainDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    foreach (var trafficaccident in model.trafficAccidentsDTOs)
                    {

                        ////Mapping BackgroundInformationDTO
                        var objtrafficaccident = this._mapper.Map<Traffic_Accidents>(trafficaccident);
                        //////


                        objtrafficaccident.RecordStatus = true;
                        objtrafficaccident.CreatedBy = UserId;
                        objtrafficaccident.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.Traffic_Accidents.Add(objtrafficaccident);


                        db.SaveChanges();

                        trafficaccident.Id = objtrafficaccident.Id;

                    }

                    trans.Commit();

                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion

        #region TrafficConvictions
        public TrafficConvictionsMainDTO SaveTrafficConvictions(TrafficConvictionsMainDTO model, string UserId)
        {

            using (var db = new OJADbContext())
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    foreach (var trafficonviction in model.trafficConvictionsDTOs)
                    {

                        ////Mapping BackgroundInformationDTO
                        var objtrafficconviction = this._mapper.Map<Traffic_Convictions>(trafficonviction);
                        //////


                        objtrafficconviction.RecordStatus = true;
                        objtrafficconviction.CreatedBy = UserId;
                        objtrafficconviction.CreatedDate = UtilService.GetPkCurrentDateTime();

                        db.Traffic_Convictions.Add(objtrafficconviction);


                        db.SaveChanges();

                        trafficonviction.Id = objtrafficconviction.Id;

                    }

                    trans.Commit();

                    return model;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }

            }
        }
        #endregion
    }
}
