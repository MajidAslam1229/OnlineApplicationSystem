using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanStructure.Services.Common
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
    }
}
