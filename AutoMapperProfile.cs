using AutoMapper;
using OnlineJobApplication.Data.Database.Tables;
using OnlineJobApplication.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication
{
    public class AutoMapperProfile
    {

        public class UserProfile : Profile
        {
            public UserProfile()
            {


                #region PreQualification
                CreateMap<PreQualificationDTO, PreQualification>();

                CreateMap<PreQualification, PreQualificationDTO>();


                #endregion

                #region Registration
                CreateMap<RegistrationDTO, RegistrationPersonalInformation>();

                CreateMap<RegistrationAddressDTO, RegistrationAddress>();

                CreateMap<RegistrationQuestionDTO, RegistrationQuestions>();


                #endregion

                #region BackgroundInformation

                CreateMap<BackgroundInformationDTO, BackgroundQuestionsMaster>();

                CreateMap<BackgroundQuestiondDetailsDTO, BackgroundQuestionDetails>();

                #endregion

                #region WorkHistory

                CreateMap<WorkHistoryDTO, WorkHistory>();

                CreateMap<WorkHistoryReferencesDTO, WorkHistoryReferences>();

                #endregion

                #region DriverLicense

                CreateMap<DriverLicenseDTO, DriverLicense>();


                #endregion

                #region AdditionalInformation

                CreateMap<AdditionalInformationDTO, AdditionalInformation>();

                #endregion

                #region TrafficAccidents

                CreateMap<TrafficAccidentsDTO, Traffic_Accidents>();


                #endregion

                #region TrafficConvictions

                CreateMap<TrafficConvictionsDTO, Traffic_Convictions>();


                #endregion


            }
        }
    }
}

