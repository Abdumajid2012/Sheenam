//=================================================
// Copyright (c) Coalition Of Good-Hearts Engineers
// Free To Use To Finfd Comfort And Peace
//=================================================

using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class GuestValidationException : Xeption
    {
        public GuestValidationException() 
            :base(message: "Guest validaton error oc")
        {}
    }
}
