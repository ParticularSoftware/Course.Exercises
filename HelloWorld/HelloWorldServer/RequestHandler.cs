﻿namespace HelloWorldServer
{
	using Messages;
	using NServiceBus;
	using NServiceBus.Logging;

	class RequestHandler : IHandleMessages<RequestMessage>
    {
        public void Handle(RequestMessage message)
        {
            LogManager.GetLogger("RequestHandler").Info(message.SaySomething);
        }
    }
}