# BS_microservice
This is a small C# microsrvice built using .net and exposes an API that writes log messages from external services to a text file. The messages are to include an id, a date and up to 255 characters of text.

Thanks,

# Installation
- Please give the IUSR (safety) / Everyone (faster but not safe) account write access for the folder once you deploy locally to IIS so to allow the text file to be written to
- All packages should be restored via Nuget first

# Usage

### Routes

##### WriteLogMessage [POST]

```sh
/logging/writelog
```

* id - The id of the log message
* message - The message
* date - The date, formatted as dd-mm-yyyy

> returns a response indicating wether the message was written


# Todo

The task was capped at 3 hours, I was hoping to add in unit testing and mocking but I didn't want to exceed the allotted time limit.

# Frameworks

- ASP.Net MVC
- WebAPI 2
- Unity
- Swagger
- RestSharp
- Newtonsoft.Json
- System.ComponentModel.DataAnnotations 
