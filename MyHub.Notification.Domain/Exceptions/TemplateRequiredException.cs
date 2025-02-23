﻿using MyHub.Notification.Domain.SeedWork;
using System.Runtime.Serialization;

namespace MyHub.Notification.Domain.Exceptions
{
    public class TemplateRequiredException : Exception
    {
        private readonly List<ResponseEntity>? results;

        public List<ServiceError>? Results
        {
            get { return results?.ConvertAll<ServiceError>(new Converter<ResponseEntity, ServiceError>(ResutlToError)); }
        }

        public TemplateRequiredException()
        {
        }

        public TemplateRequiredException(string? message, List<SeedWork.ResponseEntity> results) : base(message)
        {
            this.results = results;
        }

        public TemplateRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TemplateRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static ServiceError ResutlToError(ResponseEntity entity)
        {
            return new ServiceError { Message = entity.Message, Provider = entity.Provider, Success = entity.Success, Type = entity.Type };
        }
    }
}