using System;
using System.Collections.Generic;    //for list class

namespace ListofObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int menuSelected = 0;
            bool isValid = false;

            //Create a new list of Participant
            List<Participant> participants = new List<Participant>();
            //create a new Participant for Kevin and set LeaveTime to 5 minutes from now
            /*Participant participant1 = new Participant("Kevin");
            participant1.Leavetime = DateTime.Now.AddMinutes(5);
            //Add participant1 to our list of participant
            participants.Add(participant1);

            //Create a new participant for nino and set LeaveTime to 10 minutes from now
            Participant participant2 = new Participant("Nino");
            participant2.Leavetime = DateTime.Now.AddMinutes(10);
            participants.Add(participant2);

            //Create and add a new participant for Prabin and set LeaveTime to 15 minutes from now
            Participant participant3 = new Participant("Prabin");
            participant3.Leavetime = DateTime.Now.AddMinutes(15);
            participants.Add(participant3);

            //Display the Name, JoinTime, and LeaveTime for each participant
            foreach (Participant currentParticipant in participants)
            {
                *//*Console.WriteLine($"{currentParticipant.Name,-15} {currentParticipant.JoinTime, -10} {currentParticipant.Leavetime, -10} ");*//*
                Console.WriteLine(currentParticipant);
            }*/


            /*Create a menu system
             * 1) Set participant name
             * 2) Set participant Join Time
             * 3) Set Participant Leave Time
             * 4) Show current participant
             * 5) Add participant
             * 6) Show all paricipants
             * 7) Remove participant
             * 8) Exit Program
             * 
             */

            string[] menuOptions = { "Set Participant Name", "Set Participant Join Time", "Set Participant Leave Time", "Show current Participant", "Add Participant", "Show All Participants", "Remove participant", "Exit program" };

            int currentParticipantCount = 0;
            string participantName = "";
            string currentParticipantName = "";
            int leaveTime;
            int removeParticipant;

            Participant participant = new Participant();

            while (isValid == false || menuSelected > 1 || menuSelected <menuOptions.Length)
            {
                Console.WriteLine($"current participant count : {currentParticipantCount}");
                Console.WriteLine($"Current participant name: {participantName}");
                Console.WriteLine($"Current Join Time: {participant.JoinTime}");
                Console.WriteLine($"Current Leave Time: {participant.Leavetime}");

                MenuUtilities.CreateMenuTitle("List of Participant");
                MenuUtilities.CreateMenuOptions(menuOptions);
                menuSelected = MenuUtilities.GetMenuChoice(1, menuOptions.Length);

                switch (menuSelected)
                {
                    case 1:
                        Console.Clear();
                        currentParticipantCount++;
                        for (int index = 0 + currentParticipantCount; index <= currentParticipantCount; index++)
                        {
                            Console.Write("Participant Name: ");
                            participant.Name = Console.ReadLine();
                           /* participantName = Console.ReadLine();*/
                            /*participant.Name = participantName;*/
                            MenuUtilities.PauseAndExit();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        participant.JoinTime = DateTime.Now;
                        Console.WriteLine($"{participant.JoinTime}");
                        Console.WriteLine($"Set Join time to {participant.JoinTime}");
                        MenuUtilities.PauseAndExit();
                        break;

                    case 3:
                        Console.Clear();
                        leaveTime = MenuUtilities.GetSafeInt("Add minutes: ");
                        participant.Leavetime = DateTime.Now.AddMinutes(leaveTime);
                        MenuUtilities.PauseAndExit();
                        break;

                    case 4:
                        Console.Clear();
                        MenuUtilities.CreateMenuTitle("Current Participant");
                        Console.WriteLine($"Name: {participant.Name}");
                        Console.WriteLine($"Time Joined: {participant.JoinTime}");
                        Console.WriteLine($"Leave Time: {participant.Leavetime}");
                        MenuUtilities.PauseAndExit();

                        break;

                    case 5:
                        Console.Clear();
                        participants.Add(participant);
                        Console.WriteLine("Participant added.");
                        MenuUtilities.PauseAndExit();
                        break;

                    case 6:
                        Console.Clear();
                        /*foreach (Participant currentParticipant in participants)
                        {
                            for (int index = 0; index < participants.Count; index++)
                            {
                                Console.WriteLine($"Participant {index + 1}: {participant}");
                            }
                        }*/

                        for (int index = 0; index < participants.Count; index++)
                        {
                            Console.WriteLine($"Participant {index + 1}: {participants[index]}");
                        }
                        MenuUtilities.PauseAndExit();
                        break;

                    case 7:
                        Console.Clear();
                        foreach (Participant currentParticipant in participants)
                        {
                            for (int index = 0; index < participants.Count; index++)
                            {
                                Console.WriteLine($"Participant {index + 1}: {participant}");
                            }
                        }
                        Console.WriteLine();
                        removeParticipant = MenuUtilities.IsValidNumber("Select the participant number you want to remove: ", 1, participants.Count);
                        participants.RemoveAt(removeParticipant - 1);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
