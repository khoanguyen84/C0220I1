using System;
using System.Dynamic;

namespace ForumManagement
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int PostId = 0;
        static void Main(string[] args)
        {
            Process();
        }

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine("FORUM MANAGEMENT");
                Console.WriteLine("1. Create post");
                Console.WriteLine("2. Update post");
                Console.WriteLine("3. Remove post");
                Console.WriteLine("4. Show post");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.Write("Please select an option (1-7): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 7)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 7);
        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();
                            CreatePost();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            UpdatePost();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            RemovePost();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            forum.Show();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            SearchPost();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Rating();
                            break;
                        }
                    case 7:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 7);
        }

        public static void CreatePost()
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Author: ");
            var author = Console.ReadLine();
            Console.Write("Content: ");
            var content = Console.ReadLine();

            PostId += 1;
            var post = new Post()
            {
                Id = PostId,
                Author = author,
                Content = content,
                Title = title
            };
            forum.Add(post);
        }

        public static void Rating()
        {
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Give rate value (1 to 5):");
            var rateValue = int.Parse(Console.ReadLine());
            forum.Rating(id, rateValue);
        }

        public static void UpdatePost()
        {
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Content:");
            var content = Console.ReadLine();
            forum.Update(content, id);
        }

        public static void RemovePost()
        {
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            forum.Remove(id);
        }

        public static void SearchPost()
        {
            Console.Write("Enter keyword: ");
            var keyword = Console.ReadLine();
            forum.Search(keyword);
        }
    }
}
