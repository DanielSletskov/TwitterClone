namespace TweetService.Models;

public class Tweets
{
    public int Tweetid { get; set; }
    public string? Content { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    
}