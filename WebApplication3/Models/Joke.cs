namespace WebApplication3.Models;

public class Joke
{
    //phím tắt: gõ prop + 2tab
    public int Id { get; set; }
    public string JokeQuestion { get; set; }
    public string JokeAnswer { get; set; }
  //phím tắt:  gõ ctor + tab
    public Joke()
    {
        
    }
}
