using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace Chep.Test.API.Controllers.Api
{
    public class RolesController : ApiController
    {
        // GET api/roles
        public IEnumerable<Role> Get()
        {
            using (var context = new ChepAerospaceContext())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var roles = context.Role
                    .Include(r => r.Users)
                    .ToList();

                return roles;
            }
        }
    }
}
