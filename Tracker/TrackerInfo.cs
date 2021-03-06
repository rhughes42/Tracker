﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Tracker
{
    public class TrackerInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Tracker";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "Supports real-time motion tracking with OptiTrack camera systems using NaturalPoint's NatNet API.";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("CF473A4D-483F-4556-B3FA-91ED21096B82");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Axis Consulting";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "rhu@axisarch.tech";
            }
        }
    }
}
