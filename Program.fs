module Program

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging

[<FunctionName "ServiceBus">]
let invalidations ([<ServiceBusTrigger "servicebus">] event: string, logger: ILogger) = logger.LogInformation event
