﻿using HomeSeek.Database;
using HomeSeek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSeek.Repository
{
    public class UserRepository : Repository<Photo>
    {
        public UserRepository(MyDatabase context) : base(context)
        {
        }
        public MyDatabase MyDatabase
        {
            get { return Context as MyDatabase; }
        }
    }
}
