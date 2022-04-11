﻿using MyHub.Notification.Domain.Entities;

namespace MyHub.Notification.Domain.Interfaces.Services
{
    public interface IPushNotificationService
    {
        Task<bool> SendPushNotification(Message message);
    }
}