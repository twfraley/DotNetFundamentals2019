using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();

        public void Run()
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add content to list\n" +
                    "2. Display playlist\n" +
                    "3. Exit");
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContent();
                        break;
                    case 2:
                        DisplayContent();
                        break;
                    case 3:
                        runProgram = false;
                        break;
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }

        private void AddContent()
        {
            //Title Genre Length IsMature Rating
            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Enter the title:");
            newContent.ContentTitle = Console.ReadLine();

            Console.WriteLine("Enter the genre:");
            newContent.Genre = Console.ReadLine();

            Console.WriteLine("Enter the length in minutes:");
            string lengthString = Console.ReadLine();
            newContent.Length = float.Parse(lengthString);

            Console.WriteLine("Is the content mature?");
            string matureString = Console.ReadLine().ToLower();
            if (matureString == "yes")
            {
                newContent.IsMature = true;
            }
            else
            {
                newContent.IsMature = false;
            }

            Console.WriteLine("What is the rating?");
            newContent.Rating = int.Parse(Console.ReadLine());

            _contentRepo.AddContentToList(newContent);
        }

        private void DisplayContent()
        {
            List<StreamingContent> contentList = _contentRepo.GetStreamingContentList();

            foreach (StreamingContent content in contentList)
            {
                Console.WriteLine($"{content.ContentTitle} is {content.Length} minutes long.");
            }

            Console.ReadKey();
        }
    }
}