﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHub.Notification.Domain.SeedWork
{
    public class ResponseError
    {
        public ResponseError()
        {
            Message= string.Empty;
            Results = new List<ServiceError>();
        }
        public string Message { get; set; }
        public List<ServiceError>? Results { get; set; }
    }
}
