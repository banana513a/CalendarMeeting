﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBEntity;

namespace MeetingCanlendar.Models
{
    public class MySqlDBModel
    {
        public mc_dbEntities db = new mc_dbEntities();

        public static mc_dbEntities staticDb = new mc_dbEntities();

        public int SaveChange()
        {
            return db.SaveChanges();
        }
    }
}