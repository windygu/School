﻿using System;

namespace Sparkle.Student.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Int16 RollNumber { get; set; }

        public Byte[] Image { get; set; }

        public Category.Dto Category { get; set; }

        public Sparkle.School.Facade.Class.Dto Class { get; set; }

        public PersonalInformation.Dto PersonalInformation { get; set; }

    }

}