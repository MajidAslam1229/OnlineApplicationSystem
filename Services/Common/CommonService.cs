using AutoMapper;
using OnlineJobApplication.Data.Database.Tables;
using OnlineJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Services.Common
{
    public class CommonService
    {
        #region Fields
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public CommonService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public CommonService()
        {

        }
        #endregion

        #region GetCountries
        public List<DDLDTO> GetCountries()
        {
            try
            {
                using (var db = new OJADbContext())
                {

                    return db.Country.Where(x => x.RecordStatus == true).Select(x => new DDLDTO { Id = x.Id, Name = x.Name }).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GetStates
        public List<DDLDTO> GetStates()
        {
            try
            {
                using (var db = new OJADbContext())
                {

                    return db.States.Where(x => x.RecordStatus == true).Select(x => new DDLDTO { Id = x.Id, Name = x.Name }).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GetDriverTypes
        public List<DDLDTO> GetDriverTypes()
        {
            try
            {
                using (var db = new OJADbContext())
                {

                    return db.DriverType.Where(x => x.RecordStatus == true).Select(x => new DDLDTO { Id = x.Id, Name = x.Name }).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
