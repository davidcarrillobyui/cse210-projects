public class User
{
    // Properties for User
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Constructor to initialize User properties
    public User(int userId, string name, string email)
    {
        UserId = userId;
        Name = name;
        Email = email;
    }

    // Method to get user details
    public string GetUserDetails()
    {
        return $"User ID: {UserId}, Name: {Name}, Email: {Email}";
    }
}
