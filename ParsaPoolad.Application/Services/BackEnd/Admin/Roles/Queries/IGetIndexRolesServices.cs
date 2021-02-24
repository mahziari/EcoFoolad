﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities.Identity;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Roles.Queries
{
    public interface IGetIndexRolesServices
    {
        ResultGetIndexRolesDto Execute();
    }

    public class GetIndexRolesServices : IGetIndexRolesServices
    {
        private readonly RoleManager<Role> _roleManager;
        public GetIndexRolesServices(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }


        public ResultGetIndexRolesDto Execute()
        {
            var roles = _roleManager.Roles
                .Where(r=>r.Name!="User")
                .Where(r=>r.Name!="Owner")
                .ToList();

            
            return new ResultGetIndexRolesDto
            {
                 Roles = roles,
            };
        }
    }

    public class ResultGetIndexRolesDto
    {
        public List<Role> Roles { get; set; }
    }
    
   
    
    
}