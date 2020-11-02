using System;

namespace StackOverflow_Post
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new post");
            Console.WriteLine("Enter Title: ");
            var titleInput = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            var descInput = Console.ReadLine();

            Console.WriteLine("Enter Post message: ");
            var postInput = Console.ReadLine();

            var post = new Post(titleInput, descInput, postInput);

            Console.WriteLine("Your post created!");
            Console.WriteLine("Type 'Up' to up-vote\n 'Down' to down-vote\n 'Show' to see your post and it's stats\n 'Quit' to exit the program");
            

            while (true)
            {
                var input = Console.ReadLine();
                if (input=="Show")
                {
                    ShowPost(post);
                    continue;
                }
                else if(input=="Up")
                {
                    post.VoteUp();
                    Console.WriteLine("You voted up.\n Current rating: " + post.Votes);
                }
                else if (input=="Down")
                {
                    post.VoteDown();
                    Console.WriteLine("You voted down.\n Current rating: " + post.Votes);
                }
                else if(input=="Quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid command");
                }
            }
            


            
        }

        private static void ShowPost(Post post)
        {
            Console.WriteLine(@"Your post: 
Tytle: {0}
Description: {1}
Content: {2}
Created: {3}
Votes: {4}", post.Title, post.Description, post.Content, post.Created, post.Votes);
        }
    }
}
