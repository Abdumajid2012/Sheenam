//=================================================
// Copyright (c) Coalition Of Good-Hearts Engineers
// Free To Use To Finfd Comfort And Peace
//=================================================

using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests{get; set;}
    }
}