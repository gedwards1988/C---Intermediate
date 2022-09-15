namespace ClassesE2
{
    public class Post
    {

        // Properties and Fields
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private int votes;

        public string Title
        {
            get => _title; 
            private set => _title = value;
        }
        public string Description
        {
            get => _description; 
            private set => _description = value;
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
        }

        public void UpVote()
        {
            votes++;
            Console.WriteLine("++");
        }

        public void DownVote()
        {
            votes--;
            Console.WriteLine("--");
        }

        public void DisplayVotes()
        {
            Console.WriteLine("Votes: {0}", votes);
        }

        // Constructor
        public Post(string title, string description)
        {
            _createdAt = DateTime.Now;
            Title = title;
            Description = description;
        }

    }
}