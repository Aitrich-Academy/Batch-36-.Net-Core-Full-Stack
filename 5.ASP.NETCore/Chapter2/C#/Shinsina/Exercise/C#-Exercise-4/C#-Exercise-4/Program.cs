using System;

internal class Program
{
    struct Company
    {
        public string Name;
        public string Email;
        public string Website;
        public int PhoneNumber;
        public string Location;
        public string Password;
    }

    struct Interview
    {
        public string JobPost;
        public string Date;
        public string Time;
        public string InterviewLocation;
    }

    private static void Main(string[] args)
    {
        Company[] company = new Company[2];
        int companyCount = 0;

        Interview[] interviews = new Interview[3];
        int interviewCount = 0;

        Console.WriteLine("--------------------------------------------------Welcome to Job Seeker Portal!!-----------------------------------------------------");

        while (true)
        {
            Console.WriteLine("\nWelcome to Job Portal!!");
            Console.WriteLine("1. Register Your Company");
            Console.WriteLine("2. Login Company");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (companyCount < company.Length)
                    {

                        
                        Console.WriteLine("\n---------------------------------------------------Company Registration Form!!!------------------------------------------------------");
                        Console.Write("\nCompany Name: ");
                        company[companyCount].Name = Console.ReadLine();

                        Console.Write("Email: ");
                        company[companyCount].Email = Console.ReadLine();

                        Console.Write("Website: ");
                        company[companyCount].Website = Console.ReadLine();

                        Console.Write("Phone Number: ");
                        company[companyCount].PhoneNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Location: ");
                        company[companyCount].Location = Console.ReadLine();

                        Console.Write("Password: ");
                        company[companyCount].Password = Console.ReadLine();

                        companyCount++;
                        Console.WriteLine("----Registration Completed Successfully!----");
                    }
                    else
                    {
                        Console.WriteLine("----Company Limit Reached!----");
                    }
                    break;

                case "2":
                    

                    Console.WriteLine("\n----------------------------------------------------------Company  Login  Form!!!----------------------------------------------------");
                    Console.Write("\nEnter Company Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    bool found = false;

                    for (int i = 0; i < companyCount; i++)
                    {
                        if (company[i].Email == email &&
                            company[i].Password == password)
                        {
                            found = true;

                            Console.WriteLine("\n----Login Successful!----");
                            Console.WriteLine("Welcome " + company[i].Name);

                            // Company Dashboard Loop
                            while (true)
                            {
                                Console.WriteLine("\n----------------------------------------------------------Company Dashboard!!--------------------------------------------------------");
                                Console.WriteLine("1. Schedule Interview");
                                Console.WriteLine("2. View Scheduled Interviews");
                                Console.WriteLine("3. Logout");
                                Console.Write("\nEnter choice: ");

                                string companyChoice = Console.ReadLine();

                                if (companyChoice == "1")
                                {
                                     Console.WriteLine("\n------------------------------------------------------Schedule Interview-------------------------------------------------------------");
                                    Console.Write("How many interviews to schedule? ");
                                    int count = Convert.ToInt32(Console.ReadLine());

                                    for (int j = 0; j < count; j++)
                                    {
                                        if (interviewCount < interviews.Length)
                                        {
                                            Console.WriteLine("\nInterview " + (j + 1));

                                            Console.Write("Enter the name of job: ");
                                            interviews[interviewCount].JobPost = Console.ReadLine();

                                            Console.Write("Enter the date(dd-mm-yyyy) of interview: ");
                                            interviews[interviewCount].Date = Console.ReadLine();

                                            Console.Write("Enter the time(hh:mm) of interview: ");
                                            interviews[interviewCount].Time = Console.ReadLine();

                                            Console.Write("Location of scheduled interview: ");
                                            interviews[interviewCount].InterviewLocation = Console.ReadLine();

                                            Console.WriteLine("----Registered successfully----");

                                            interviewCount++;
                                           
                                        }
                                        else
                                        {
                                            Console.WriteLine("Interview storage full!");
                                        }
                                    }
                                }
                                else if (companyChoice == "2")
                                {
                                    Console.WriteLine("\n----------------------------------------------------------Scheduled Interview List --------------------------------------------------");

                                    if (interviewCount == 0)
                                    {
                                        Console.WriteLine("No interviews scheduled yet.");
                                    }
                                    else
                                    {
                                        for (int k = 0; k < interviewCount; k++)
                                        {
                                            Console.WriteLine("\nInterview " + (k + 1));
                                            Console.WriteLine("Job Post: " + interviews[k].JobPost);
                                            Console.WriteLine("Date: " + interviews[k].Date);
                                            Console.WriteLine("Time: " + interviews[k].Time);
                                            Console.WriteLine("Location: " + interviews[k].InterviewLocation);
                                        }
                                    }
                                }
                                else if (companyChoice == "3")
                                {
                                    
                                    Console.WriteLine("\n----------------------------------------------------------Logged Out Successfully!---------------------------------------------------");
                                    break; // Exit dashboard
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice!");
                                }
                            }

                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Invalid Email or Password!");
                    }

                    break;

                case "3":
                    Console.WriteLine("Exiting Program...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}