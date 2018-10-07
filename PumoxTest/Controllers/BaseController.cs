﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PumoxTest.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PumoxTest.Controllers
{
    public class BaseController : Controller
    {
        protected IUnitOfWork _unitOfWork;
        protected IConfiguration _configuration { get; set; }
        protected IMapper _mapper;

        public BaseController(IConfiguration config, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _configuration = config;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    }
}
