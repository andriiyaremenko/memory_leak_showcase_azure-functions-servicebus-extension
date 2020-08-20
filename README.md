## Proof that Service Bus Extension for Azure Functions has a memory leak

### Befor run

Please change:  
`"AzureWebJobsStorage"` and `"AzureWebJobsServiceBus"` inside `local.settings.json`  
and  
```fsharp
let connectionString = "<your AzureWebJobsServiceBus endpoint>"
```
inside `sendEvents.fsx`

### Running this project

1) run `func host start` and `dotnet fsi /langversion:preview sendEvents.fsx` in separate consoles
2) collect memory dumps in any way is suitable for you (i was using `dotnet gcdump`)
