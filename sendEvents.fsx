#r "nuget:Microsoft.Azure.ServiceBus"
#r "nuget:Newtonsoft.Json"

open Microsoft.Azure.ServiceBus.Core
open Microsoft.Azure.ServiceBus
open System

let connectionString = "<your AzureWebJobsServiceBus endpoint>"

let sender =
    MessageSender(ServiceBusConnection connectionString, "serviceBus")

let events =
    Array.init 10000 (string >> Text.Encoding.UTF8.GetBytes >> Message)

for chunk in events |> Array.chunkBySize 1000 do sender.SendAsync(chunk).Wait()
