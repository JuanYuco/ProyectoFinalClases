﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoFinalClases.Logica.BL
{
    public class States
    {
        public List<Models.DB.States> GetStates()
        {
            DAL.Models.ProyectoFinalClasesContext _context = new DAL.Models.ProyectoFinalClasesContext();

            var listStates = (from _states in _context.States
                              where _states.Active == true
                                  select new Models.DB.States
                                  {
                                      Id = _states.Id,
                                      Name = _states.Name,
                                      Active = _states.Active
                                  }).ToList();

            return listStates;
        }
    }
}
