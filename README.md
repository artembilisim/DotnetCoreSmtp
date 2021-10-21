# DotnetCoreSmtp Project

## Author

[Artem Erkal Ucar](https://github.com/artemeu)

## Project setup instructions

This project is a .Net 5.0 Web Api Smtp Service Project.

## Installation

Download and install .Net 5.0 SDK

```bash
https://dotnet.microsoft.com/download
```

## Configuration

Modify EmailSettings content in DotnetCoreSmtp.Api/appsettings.json file with valid sender email information.

```python
  "EfmailSettings": {
    "SenderEmailAddress": "your@email.com",
    "SenderEmailAddressPassword": "password",
    "SenderName": "Sender Name",
    "Port": 587,
    "Host": "Email Host Name"
  },
```

## Run Projcet

In DotnetCoreSmtp.Api project directory run command

```bash
dotnet run
```

## Swagger

This project has swagger implementation

```bash
http://localhost:8034/swagger/index.html
```

## Send Email

POST Smtp Post Api

```python
# /Smtp/send/email
```

Project runs on localhost or local network IP address on port 8034

```python
# localhost:8034/Smtp/send/email
```

## Request Body

Example Value | Schema

```python
{
  "recipientEmailAddress": "user@example.com",
  "emailSubject": "string",
  "emailContent": "string"
}
```
