## Build status ##

Windows|Ubuntu/OS X
---|---
[![Build status](https://ci.appveyor.com/api/projects/status/tpuar7olx447gjqu/branch/net-standard-lib?svg=true)](https://ci.appveyor.com/project/trydis/smsgw-client-dotnet/branch/net-standard-lib)|[![Build Status](https://travis-ci.org/Intelecom/smsgw-client-dotnet.svg?branch=net-standard-lib)](https://travis-ci.org/Intelecom/smsgw-client-dotnet)

## Supported platforms ##

.NET Standard Library 1.1

- .NET Core
- .NET 4.5+
- Universal Windows Platform
- Windows 8.x
- Windows Phone 8.1
- Mono/Xamarin Platforms
- Portable Class Libraries, profile 7 & 111

Read more about the .NET Standard Library [here](https://docs.microsoft.com/en-us/dotnet/articles/standard/library). 

## NuGet ##

[![NuGet version](https://badge.fury.io/nu/intelecom.smsgateway.client.svg)](https://www.nuget.org/packages/intelecom.smsgateway.client)

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
