using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProyectoFinalClases.Logica.BL
{
    public class Tenants
    {
        public List<Models.DB.Tenants> GetTenants(string userId)
        {
            DAL.Models.ProyectoFinalClasesContext _context = new DAL.Models.ProyectoFinalClasesContext();

            var listTenants = (from _tenants in _context.Tenants
                              join _aspNetUsers in _context.AspNetUsers on _tenants.Id equals _aspNetUsers.TenantId
                              where _aspNetUsers.Id.Equals(userId)
                              select new Models.DB.Tenants {
                                  Id = _tenants.Id,
                                  Name = _tenants.Name,
                                  Plan = _tenants.Plan,
                                  CreatedAt = _tenants.CreatedAt,
                                  UpdatedAt = _tenants.UpdatedAt
                              }).ToList();

            return listTenants;
        }
    }
}
