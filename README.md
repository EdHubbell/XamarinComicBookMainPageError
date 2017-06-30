# XamarinComicBookMainPageError
This is an example of an error that happens when you use App.Current.MainPage inside 

```
authenticator.Completed(s, ea) =>
                    {
```

**NOTE**: This is the workaround I'm using for now - It addresses this problem. Use it instead of a plain Application.Current.MainPage = new LoggedInPage(loggedIn);

```
Task.Run(async () =>
 {
     await Task.Delay(1000);
     Device.BeginInvokeOnMainThread(() =>
     {
         Application.Current.MainPage = new LoggedInPage(loggedIn);
     });
 });
```

The 1000 is arbitrary; I found that 300 was too small.

Steps to reproduce:

Start app.
Click on 'Logged in page' button. 
See the logged in page. There are 3 buttons, 2 of which are enabled. The enabled buttons both work.

Go back to the starting page. 
Log in using Google auth. This will trigger a call to App.Current.MainPage. 
The app will shift so that the LoggedInPage is the main page.
None of the 3 buttons will work. 

Am I missing an invoke on the 

```
App.Current.MainPage = new LoggedInPage(loggedIn);
```

I don't know. I've tried a few things, but I can't seem to get it to go. Hate to refactor an app just because of this. 

Any help is appreciated.
~Ed
