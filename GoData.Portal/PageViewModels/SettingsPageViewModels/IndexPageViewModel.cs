﻿using GoData.Entities.Entities;
using GoData.Portal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoData.Portal.PageViewModels.SettingsViewModels
{
    public class IndexPageViewModel : BasePageViewModel
    {
        public IndexPageViewModel(int userId) : base(userId)
        {
        }

        public IEnumerable<Organization> Organizations { get; set; }

    }
}
