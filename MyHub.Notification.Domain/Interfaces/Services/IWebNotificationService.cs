﻿using MyHub.Notification.Domain.Entities;

namespace MyHub.Notification.Domain.Interfaces.Services
{
    public interface IWebNotificationService
    {
        Task<bool> SendWebNotification(Message message);
    }
}