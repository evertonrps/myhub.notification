﻿using Microsoft.Extensions.Logging;
using MyHub.Notification.Domain.Entities;
using MyHub.Notification.Domain.Enuns;
using MyHub.Notification.Domain.SeedWork;
using MyHub.Notification.ExternalService.Interfaces.Handler;

namespace MyHub.Notification.ExternalService.Providers.FirebaseProvider
{
    public class FirebasePushService : IPushNotificationHandler
    {
        private readonly ILogger<FirebasePushService> _logger;

        public ENotificationProvider NotificationProvider => ENotificationProvider.Firebase;

        public FirebasePushService(ILogger<FirebasePushService> logger)
        {
            _logger = logger;
        }

        public Task<ResponseEntity> SendPushNotification(Message message)
        {
            _logger.LogInformation("Sended Push by Firebase");
            return Task.FromResult(new ResponseEntity { Type = ENotiticationType.PushNotification, Provider = NotificationProvider, Success = true, Message = "Sended Push by Firebase" });
        }
    }
}