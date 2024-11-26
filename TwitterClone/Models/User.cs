namespace TwitterClone.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public ICollection<Post> Posts { get; set; }
    public ICollection<Follow> Followers { get; set; }
    public ICollection<Follow> Following { get; set; }
}