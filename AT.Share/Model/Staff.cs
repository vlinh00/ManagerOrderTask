﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Share.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int GroupUserId { get; set; }
        public int DepartmentId { get; set; }
    }
}
