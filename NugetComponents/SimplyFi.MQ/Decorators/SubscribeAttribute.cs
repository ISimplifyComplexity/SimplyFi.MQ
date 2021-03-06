﻿using System;

namespace SimplyFi.MQ.Core.Decorators
{
    public class SubscribeAttribute : Attribute
    {
        public string QueueName { get; }
        public Type MessageType { get; }

        public SubscribeAttribute(string queueName, Type messageType)
        {
            QueueName = queueName;
            MessageType = messageType;
        }
    }
}