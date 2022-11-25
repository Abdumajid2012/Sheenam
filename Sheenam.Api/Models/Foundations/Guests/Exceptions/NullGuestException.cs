//=================================================
// Copyright (c) Coalition Of Good-Hearts Engineers
// Free To Use To Finfd Comfort And Peace
//=================================================

using System;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class NullGuestException : Xeption
    {
        public NullGuestException() 
          : base(message:"Guest is null")
        {}
    }
}
