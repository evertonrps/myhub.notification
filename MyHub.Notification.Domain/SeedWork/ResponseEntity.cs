﻿using MyHub.Notification.Domain.Enuns;

namespace MyHub.Notification.Domain.SeedWork
{
    public class ResponseEntity
    {
        public ENotiticationType? Type { get; set; }
        public ENotificationProvider? Provider { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}