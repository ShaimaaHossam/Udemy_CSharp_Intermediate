class Post{
    private string _title;
    private string _desc;
    private DateTime _createdAt;

    private int _votes;
    
    public Post(string title, string desc, DateTime createdAt){
        _title = title;
        _desc = desc;
        _createdAt = createdAt;
        _votes = 0; //default value

        Console.WriteLine($"Post created Successfully at {_createdAt}");
        Console.WriteLine($"Current votes = {_votes}");
    }

    public void UpVote(){
        _votes ++;
        Console.WriteLine($"Post now has {_votes} votes");
    }
    public void DownVote(){
        _votes --;
        Console.WriteLine($"Post now has {_votes} votes");
    }
}