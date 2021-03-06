﻿using Microsoft.EntityFrameworkCore;
using System;

namespace ow.Framework.Database
{
    public class BaseDbContext : DbContext
    {
        protected BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public int UseAndSave(Action<BaseDbContext> action)
        {
            action(this);
            return SaveChanges();
        }
    }
}