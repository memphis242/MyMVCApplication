﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        //[Display( Name="Name" )]
        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}