using System.Data;

namespace ClassesE2
{


    class Program
    {
        static void Main(string[] args)
        {
            var user_vote = "null";

            Console.WriteLine("Welcome to the Stack Overflow Post Program");

            Console.WriteLine("Type 'Exit' to quit");
            Console.WriteLine("Please enter a title for your post:\n>>");

            var user_title = Console.ReadLine();

            Console.WriteLine("Please enter a description:\n>>");
            var user_description = Console.ReadLine();

            var post = new Post(user_title, user_description);

            Console.Clear();

            Console.WriteLine("Your post has been successful");
            Console.WriteLine(user_title);
            Console.WriteLine(user_description);
            Console.WriteLine("{0}\n\n", post.CreatedAt);

            Console.WriteLine("Type 'Up' to like the post\nType 'Down' to dislike the post\nType 'total' to see votes\nType 'exit' to quit\n>>");

            while(user_vote != "exit")
            {
                user_vote = Console.ReadLine().ToLower();
                switch (user_vote)
                {
                    case "up":
                        post.UpVote();
                        break;
                    case "down":
                        post.DownVote();
                        break;
                    case "total":
                        post.DisplayVotes();
                        break;

                    default:
                        break;
                        
                }
            }

        }
    }
}