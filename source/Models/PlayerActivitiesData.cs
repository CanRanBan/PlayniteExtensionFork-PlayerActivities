﻿using CommonPluginsShared.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerActivities.Models
{
    public class PlayerActivitiesData : PluginDataBaseGame<Activity>
    {
        private List<Activity> _Items = new List<Activity>();
        public override List<Activity> Items
        {
            get => _Items;

            set
            {
                _Items = value;
                OnPropertyChanged();
            }
        }


        public bool IsFirst()
        {
            return Items.Where(x => x.Type == ActivityType.PlaytimeFirst) == null;
        }
    }
}
