using System;

public class UserSessionState
{
    public string UserName { get; set; }
    public bool IsAuthenticated { get; set; }

    public void Login(string username)
    {
        UserName = username;
        IsAuthenticated = true;
    }

    public void Logout()
    {
        UserName = null;
        IsAuthenticated = false;
    }
}
