using AutoMapper;
using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;


namespace CleanStructure.Services
{
    public class ImportService
    {
        #region Fields
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public ImportService(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

    }
}
