﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog
{
  public class StamdataDto
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int killometer { get; set; }
    public string Name { get; set; }
    public string LicensePlate { get; set; }
  }
}