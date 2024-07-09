using System;

public class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }

    public User(int userID, string userName, string email)
    {
        UserID = userID;
        UserName = userName;
        Email = email;
    }

    public string GetUserDetails()
    {
        return $"User: {UserName}, Email: {Email}";
    }
}
