﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalPassport.Models.ViewModels
{
    public class DashboardViewModel
    {
        public User User { get; set; }

        public List<TaskCompletion> TaskCompletions { get; set; }
      
    }
}
