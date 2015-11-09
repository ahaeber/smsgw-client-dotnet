AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/tpuar7olx447gjqu/branch/master?svg=true)](https://ci.appveyor.com/project/trydis/smsgw-client-dotnet/branch/master)

## PCL targets ##

- .NET 4.5
- Windows 8
- Windows Phone 8.1
- Xamarin.Android
- Xamarin.iOS

## NuGet package ##
 
```
Install-Package Intelecom.SmsGateway.Client
```

## Example usage ##

```csharp
// Initialize the client
const string baseAddress = "https://...";
var credentials = new SmsGatewayCredentials(1, "foo", "bar");
var client = new SmsGatewayClient(baseAddress, credentials);

// Single recipient, 0 NOK
var message = new Message { Recipient = "+47XXXXXXXX", Content = "This is a test" };
var response = await client.SendAsync(message);
```
