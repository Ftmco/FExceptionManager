# FExceptionManager
Exception Manager For Asp.net Core 

<h1>Friends Exception Handler</h1>

Handel All Internal Server Errors For Asp.net Core /Razor Pages/Api/MVC/SPA/Blazor 
Can Send Email For You When An Internal Server Error Occurred 

<h4>Use this with middlewares</h4>
1.Install Package From Nuget Gallery 
2.Get On Startup.cs and Add this To Middlewares 'app.UseFExceptionHandler();' This Code auto redirect app to /500err when exception occurred 
3.Run  Application 


<h4>Custome Redirect Path</h4>
Can Set Custome Redirect Path For Exception Handeling Like This 'app.UseFExceptionHandler("/500");'

<h4>Sned Email Options</h4>
For Send Email To You When Exception Occurred You must fill in the option email Like this  

  app.UseFExceptionHandler(new FTServerEmailOptions
            {
                DisplayName = "",
                EnableSSL = true,
                From = "user@exam.com",
                Password = "215%%^/:|}kd",
                Port = 25,
                SmtpServer = "smtp.exam.com",
                UserName = "user@exam.com"
            });
            
  
