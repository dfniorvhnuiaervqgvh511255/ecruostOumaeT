﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolCup.Models.POCO
{
  public class Location
  {
    public int LocationId { get; set; }
    public String Street { get; set; }
    public String HomeNumber { get; set; }
    public String ZipCode { get; set; }
    public String City { get; set; }
    public String State { get; set; }

    public int CountryId { get; set; }
    public Country Country { get; set; }
  }
}