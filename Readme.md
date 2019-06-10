# EbulkSmsNet

A .NET core client for sending sms via EbulkSms Nigeria.

## Getting Started

### Installation

- In Visual Studio, open the Nuget Package Manager and search for `EbulkSmsNet` then install it.

- In Visual Studio code or Package Manager Console, run the following command

    `dotnet add package EbulkSmsNet`

### Usage

```csharp
var auth = new EbulkSmsAuth
{
    ApiKey = [apiKey],
    Sender = [sender],
    UserName = [username]
};
```

```csharp
var result = await EbulkSmsClient.SendMessageAsync(auth, phoneNumber, message);
```

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details


## How can you thank me?
You can like this repo, follow me on [github](https://github.com/mojoblanco) and [twitter](https://twitter.com/themojoblanco)
Thanks.

