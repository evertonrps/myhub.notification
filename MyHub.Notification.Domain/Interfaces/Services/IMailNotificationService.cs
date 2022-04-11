﻿using MyHub.Notification.Domain.Entities;

namespace MyHub.Notification.Domain.Interfaces.Services
{
    public interface IMailNotificationService
    {
        Task<bool> SendMail(Message message);
    }
}