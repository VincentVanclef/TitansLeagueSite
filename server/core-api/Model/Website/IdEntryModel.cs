﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace server.Model.Website
{
    public class IdEntryModel
    {
        [Required]
        public int Id { get; set; }
    }
}
