using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Net;

namespace CratorOSUbuntu
{
    class Program
    {

        //Programming Language Start
        public static craterOStextCommands Text = new craterOStextCommands();
        public class craterOStextCommands
        {

            //Random command in programming language "Generate Random Digit"
            public void Rand(int RangeY, int RangeX)
            {
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(RangeY, RangeX);
            }
            //Random command in programming language "Generate Random Digit" And Prints Message
            public void RandSay(int RangeY, int RangeX)
            {
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(RangeY, RangeX);
                Console.WriteLine("the number was:" + randomNumber);
            }
            //Shuts oof system and allows custom message
            public void ShutDown(string shutDownMessage)
            {
                Console.Clear();
                Console.WriteLine(shutDownMessage);
                Console.ReadLine();
                Environment.Exit(0);
            }
            public void ErrorHandler(string errorMessage)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(errorMessage);
                Console.WriteLine("----------------------------------------------");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Show Developers/Testers - Allows message input
            public void Credits(string developerMessage)
            {
                Console.WriteLine("Developed By @ITS_N1GH7OWL, @JavaBoi, And Tested By @Mega_Danz");
                Console.WriteLine(developerMessage);
            }
            //add program call
            public void Add(int X, int Y)
            {
                int totalSum = X + Y;
                Console.WriteLine(X + " + " + Y + " = " + totalSum);
            }
            //subtract program call
            public void Subtract(int X, int Y)
            {
                int totalSum = X - Y;
                Console.WriteLine(X + " - " + Y + " = " + totalSum);
            }
            //multiply program call
            public void Multiply(int X, int Y)
            {
                int totalSum = X * Y;
                Console.WriteLine(X + " x " + Y + " = " + totalSum);
            }
            //Divide program Call
            public void Divide(int X, int Y)
            {
                int totalSum = X / Y;
                Console.WriteLine(X + " / " + Y + " = " + totalSum);
            }
            //Sad textbox!! :(
            public void TextBox(string words)
            {
                Console.WriteLine("|" + words + "|");
            }
            //Screen Write function named SayNX for programming language
            public void SayNX(string words)
            {
                Console.WriteLine(words);
            }
            //Its sad brother to writeNX Wishes it could make new lines
            public void Say(string words)
            {
                Console.Write(words);
            }
            //this reads things, basically the only thing its good at in life
            public void Read()
            {
                Console.ReadLine();
            }
            public string ReadInput()
            {
                return Console.ReadLine();
            }
            //Clears Text Above
            public void Clean()
            {
                Console.Clear();
            }
            //Color Libary for new programming language inside OS
            public void Color(string color)
            {
                if (color == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (color == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (color == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            public static void mainMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome To CratorOS!\nDeveloped By @ITS_N1GH7OWL, @JavaBoi, And Tested By @Mega_Danz");
                Console.WriteLine("||||Version 0.1||||");
                Console.WriteLine("_______________________________");
                string dateString = DateTime.Today.ToShortDateString() + "    |";
                Console.WriteLine("Hello! Today is " + dateString);
                Console.WriteLine("Please Choose An Option:      |");//Choosing Options for the OS
                Console.WriteLine("(1)Open Game Development SDK  |");
                Console.WriteLine("(2)Calculator                 |");
                Console.WriteLine("(3)Number Game                |");
                Console.WriteLine("(4)Text Editor                |");
                Console.WriteLine("(5)CratorOS Command Line      |");
                Console.WriteLine("(6)Text Game                  |");
                Console.WriteLine("(7)To-Do List                 |");
                Console.WriteLine("(8)Shut Down                  |");
                Console.WriteLine("(9)Clear the screen           |");
                Console.WriteLine("______________________________|");
                Console.Write("Please Enter A Digit: ");
                string choice = Console.ReadLine();//User Input
                Console.WriteLine("");
                //Choice Option Arrays
                string[] choiceOptions = new string[11];
                choiceOptions[0] = "1"; choiceOptions[1] = "2"; choiceOptions[2] = "3"; choiceOptions[3] = "4"; choiceOptions[4] = "5"; choiceOptions[5] = "6"; choiceOptions[6] = "7"; choiceOptions[7] = "8";
                choiceOptions[8] = "9";
                //Game Development SDK caller
                if (choice == choiceOptions[0])
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Has Not Been developed Yet\n<Press Any Key To Go Back>");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }
                //Calculator caller
                else if (choice == choiceOptions[1])
                {
                    Calculator();
                }
                //Open page from Browers(Though at the moment it only works on Windows)
                else if (choice == choiceOptions[2])
                {
                  numberGame();
                }
                //Number game caller
                else if (choice == choiceOptions[3])
                {
                  textEditor();
                }

                else if (choice == choiceOptions[4])
                {
                  Console.Clear();
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("---------------------------------------------------------------------------");
                  Console.WriteLine("Has Not Been developed Yet\n<Press Any Key To Go Back>");
                  Console.WriteLine("-------------------------------------------------------------------------");
                  Console.ReadLine();
                  Console.ForegroundColor = ConsoleColor.DarkGreen;
                  mainMenu();
                }
                //Shut Down!
                else if (choice == choiceOptions[5])
                {
                    TextGame();
                }
                else if (choice == choiceOptions[6])
                {
                    ToDoList();
                }
                else if (choice == choiceOptions[7])
                {
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("Are You Sure?(Y/N): ");
                  Console.ResetColor();
                  string closeOSInput = Console.ReadLine();
                  if (closeOSInput == "Y" || closeOSInput == "y")
                  {
                      Environment.Exit(0);
                  }
                  else if (closeOSInput == "N" || closeOSInput == "n")
                  {
                      Console.ForegroundColor = ConsoleColor.DarkGreen;
                      mainMenu();
                  }
                }

                else if (choice == choiceOptions[8])
                {
                  Console.Clear();
                  mainMenu();
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("That is not a valid choice.\n<Press Any Key to Go Back>");
                    Console.WriteLine("----------------------------------------------");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mainMenu();
                }

            }
            //MainMenu of the OS ending

            //Text Game begging
            public static void whatHappened()
            {
                Random randomDigit2 = new Random();
                int randomNumber2 = randomDigit2.Next(1, 11);
                if (randomNumber2 == 1)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 2)
                {
                    Console.WriteLine("You meet a friend and talk for a while and get nothing");
                }
                if (randomNumber2 == 3)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 4)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 5)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }
                if (randomNumber2 == 6)
                {
                    Console.WriteLine("You fall down a hole and lose 2 health");
                }

            }

            //Text Game for User To Play
            public static void TextGame()
            {
                bool gamehastarted = false;
                int level = 1;
                int monstersdefeated = 0;
                int health = 20;
                int maxhealth = 20;
                int monsterhealth = 2;
                int MaxMonsterDamage = 6;
                int Monsterdamage = 0;
                int monstersForLevel = 10;
                int healthpotions = 1;
                bool death = false;
                bool monsterdeath = true;
                bool hasCharacterAttacked = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dungeon Loop!");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("<Press any key to Continue>");
                Console.ReadKey();
                Console.WriteLine("You are inside a dark cavern,torches lit from side to side.");
                Console.WriteLine("In front of you is an seemingly endless hallway,and behind is wall.");
                Console.ReadKey();
                Console.WriteLine("You dont know how you got here. But you Do know....you have to go out");
                Console.ReadKey();
                while(death == false){
                if(health <= 0){
                  Console.WriteLine("You have been defeated young warrior.");
                  Console.WriteLine("Would you like to try again?Y/N");
                  string continues = Console.ReadLine();
                  if(continues == "Y" || continues == "y"){
                    TextGame();
                  }
                  if(continues == "N" || continues == "n"){
                    Console.WriteLine("Alright then. Goodbye. <Press any key to go back to main menu");
                    mainMenu();
                  }
                }
                if(monstersdefeated == monstersForLevel){
                  Console.WriteLine("You have leveled Up!!!!!");
                  level = level + 1;
                  maxhealth = maxhealth + 3;
                  health = maxhealth;
                  monstersForLevel = monstersForLevel + 10;
                  Console.WriteLine("Your health is now:" + health + "/" + maxhealth);
                  monstersdefeated = 0;
                  MaxMonsterDamage = MaxMonsterDamage + 2;
                }
                if(monsterdeath == true){
                  if(gamehastarted == true){
                    if(level > 3){
                    Random winthegame = new Random();
                    int winningthegmae = winthegame.Next(1, 51);
                    if(winningthegmae == 31){
                      Console.WriteLine("You have defeated all the monsters in the dungeon!");
                      Console.WriteLine("Good Job!!!!!");
                      mainMenu();
                    }
                  }
                  Random randomDigit2 = new Random();
                  int monsterhealthchoosen = randomDigit2.Next(1, 9);
                  monsterhealth = monsterhealthchoosen;
                  Console.WriteLine("A monster approaches...its health is:" + monsterhealth);
                  monsterdeath = false;
                }
                  if(gamehastarted == false){
                  Random randomDigit2 = new Random();
                  int monsterhealthchoosen = randomDigit2.Next(1, 9);
                  monsterhealth = monsterhealthchoosen;
                  Console.WriteLine("A monster approaches...its health is:" + monsterhealth);
                  gamehastarted = true;
                  monsterdeath = false;
                }
                }
                  Console.WriteLine("What would you like to do?<insert the number for the choice you want.>");
                  Console.Write("(1)Attack,(2)Try To run,(3)Check stats,(4)Use a healing POTION,(5)Exit the Game: ");
                  string choicegiven = Console.ReadLine();
                  Console.WriteLine("");
                  if (choicegiven == "1"){
                    int[] damage = {1,3,5};
                    Random random = new Random();
                    int start2 = random.Next(0, damage.Length);
                    Console.WriteLine("You go for an attack and do "+damage[start2]+" damage");
                    Console.ReadKey();
                    monsterhealth = monsterhealth - damage[start2];
                    Console.WriteLine("The monster now has "+ monsterhealth +" health");
                    Console.ReadKey();
                    hasCharacterAttacked = true;
                  }
                  if(choicegiven == "2"){
                    Random randomDigit2 = new Random();
                    int randomNumber2 = randomDigit2.Next(1, 3);
                    if (randomNumber2 == 1)
                    {
                        Console.WriteLine("You Successfuly ran away");
                        monsterdeath = true;
                    }
                    if (randomNumber2 == 2)
                    {
                        Console.WriteLine("You couldn't run away!!!");
                        hasCharacterAttacked = true;
                    }

                  }
                  if(choicegiven == "3"){
                    Console.WriteLine("Your current level is:" + level);
                    Console.WriteLine("Your health is:" + health +"/" + maxhealth);
                    Console.WriteLine("Number of health potions:"+ healthpotions);
                    Console.WriteLine("Number of monsters you have defeated in your level:"+ monstersdefeated);
                  }
                  if(choicegiven == "4"){
                    if(healthpotions == 0){
                      Console.WriteLine("You dont have any health potions to use!");
                    }
                    if(healthpotions > 0){
                      Random healthchoosen= new Random();
                      int healthgiven = healthchoosen.Next(3, 5);
                      if(healthgiven + health >= maxhealth){
                        Console.WriteLine("You gained full health!");
                        health = maxhealth;
                        healthpotions = healthpotions - 1;
                      }
                      if(healthgiven < maxhealth){
                      Console.WriteLine("You drink the health potion with an opening you found and gain " + healthgiven + " health");
                      health = health + healthgiven;
                      Console.WriteLine("Your health is now " + health +"/" + maxhealth);
                      healthpotions = healthpotions - 1;
                    }
                    }
                  }
                  if(choicegiven == "5"){
                    Console.WriteLine("Goodbye I guess.");
                    mainMenu();
                  }
                 if(monsterhealth <= 0){
                   hasCharacterAttacked = false;
                   Random healthpotiondrop = new Random();
                   int dropped = healthpotiondrop.Next(1, 6);
                   if(dropped == 5){
                     Console.WriteLine("The monsterhas died!");
                     monstersdefeated = monstersdefeated + 1;
                     Console.WriteLine("THE MONSTER HAD DROPPED A HEALTH POTION!!!");
                     healthpotions = healthpotions + 1;
                     monsterdeath = true;
                   }
                   if(dropped < 5){
                     Console.WriteLine("The monster has died!");
                     monstersdefeated = monstersdefeated + 1;
                     monsterdeath = true;
                   }

                 }
                 if(hasCharacterAttacked == true){
                   Random random2 = new Random();
                   int missedornot = random2.Next(1, 3);
                   Console.WriteLine("The monster is going for an Attack and the result is....<press any Key to see>");
                   Console.ReadKey();
                   if(missedornot == 1){
                     Console.WriteLine("The monster missed the attack!!");
                     hasCharacterAttacked = false;
                   }
                   if(missedornot == 2){
                     Random random3 = new Random();
                     int damagegiven = random3.Next(1, MaxMonsterDamage);
                     Monsterdamage = damagegiven;
                     Console.WriteLine("The monster goes for the attack & does:" + Monsterdamage);
                     health = health - Monsterdamage;
                     Console.WriteLine("Your health is:" + health);
                     hasCharacterAttacked = false;
                   }

                 }
                }

              }
            //Calculator Method
            private static void Calculator()
            {
                Console.Clear();
                Console.WriteLine("What operation would you like to do?");
                Console.WriteLine("(1)Addition.");
                Console.WriteLine("(2)Subtraction.");
                Console.WriteLine("(3)Multiplaction.");
                Console.WriteLine("(4)Division.");
                Console.WriteLine("(5)Exit the Calculator");
                string choice = Console.ReadLine();
                string[] choiceOperations = new String[5];
                choiceOperations[0] = "1"; choiceOperations[1] = "2"; choiceOperations[2] = "3"; choiceOperations[3] = "4"; choiceOperations[4] = "5";
                //Addition Part
                if (choice == choiceOperations[0])
                {
                    Console.WriteLine("Welcome to the Addition Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " + " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt + InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " + " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Subtraction Part
                else if (choice == choiceOperations[1])
                {
                    Console.WriteLine("Welcome to the Subtraction Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " - " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt - InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " - " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Multiplaction Part
                else if (choice == choiceOperations[2])
                {
                    Console.WriteLine("Welcome to the Multiplaction Calculator");
                    Console.Write("Insert Your first number :");
                    string userAnswer = Console.ReadLine();
                    float InputInt = int.Parse(userAnswer);
                    Console.WriteLine(InputInt + " x " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt * InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " x " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                //Division Part
                else if (choice == choiceOperations[3])
                {
                    Console.WriteLine("Welcome to the Division Calculator");
                    Console.Write("Insert Your first number: ");
                    string userAnswer = Console.ReadLine();
                    float InputInt = float.Parse(userAnswer);
                    Console.WriteLine(InputInt + " / " + " ? " + " = ?");
                    Console.Write("Insert Your Second number: ");
                    string userAnswer2 = Console.ReadLine();
                    float InputInt2 = float.Parse(userAnswer2);
                    float userAnswerAdded = InputInt / InputInt2;
                    Console.WriteLine("The answer is: " + InputInt + " / " + InputInt2 + " = " + userAnswerAdded);
                    Console.ReadLine();
                    Console.Clear();
                    mainMenu();
                }
                else if (choice == choiceOperations[4]){
                  mainMenu();
                }
                else{
                  Console.Clear();
                  Console.WriteLine("That is not a valid choice.<Press any key to go back to the Calculator menu>");
                  Console.ReadKey();
                  Calculator();
                }
            }
            //Calculator End!

            //Text editor

            private static void CratorOSCMD(){
            Console.WriteLine("------------------------------");
            Console.WriteLine("[    Welcome To Crator CMD   ]");
            Console.WriteLine("[       Developed By TNO     ]");
            Console.WriteLine("[ For More Info, Type credits]");
            Console.WriteLine("------------------------------");
            Console.Write("Type help For Commands: ");
            string userCommand = Console.ReadLine();
            if(userCommand == "help" || userCommand == "Help"){
              Console.WriteLine("----------");
              Console.WriteLine("|Commands|");
              Console.WriteLine("----------");
              Console.WriteLine("webPull - (Pulls Website Home Page HTML, And Saves To Downlaod");
              Console.WriteLine("text - (Allows User To Write A Program From The Console");
              Console.WriteLine("files - (Allows You To Check Your Projects In The Crator Directory");
           }

            }

            //To-Do List
            public static void ToDoList()
            {
                Console.Clear();
                int line = 1;
                string colin = ".";
                bool writing = true;
                Console.Clear();
                Console.WriteLine("Welcome to the To-Do List");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("type exit to leave the ToDoList");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1)Make a new To-Do List");
                Console.WriteLine("(2)Open a To-Do List");
                Console.WriteLine("(3)Delete a List.");
                Console.WriteLine("(4)Go Back to Main Menu");
                string ToDo = Console.ReadLine();
                if (ToDo == "1")
                {
                    Console.Write("Please Enter The File Name: ");
                    string fileNameList = Console.ReadLine();
                    while (writing == true)
                    {
                        Console.Write(line + colin);
                        string onestring = Console.ReadLine();
                        if (onestring == "End" || onestring == "end" || onestring == "exit" || onestring == "Exit" || onestring == "close" || onestring == "Close" || onestring == "menu" || onestring == "Menu" || onestring == "Escape" || onestring == "escape")
                        {
                            writing = false;
                            Console.WriteLine("saved: " + fileNameList + "\n<Press Any Key To Go To Menu>");
                            Console.ReadLine();
                            ToDoList();
                        }
                        else
                        {
                            File.AppendAllText(@"ToDoLists/" + fileNameList + ".txt", line + colin + onestring + Environment.NewLine);
                            line += 1;
                        }

                    }
                }
                //Opening File
                if (ToDo == "2")
                {
                  Console.WriteLine("FILES IN DIRECTORY");
                  Console.WriteLine("___________________");
                  string[] fileInDirectory = Directory.GetFiles(@"ToDoLists/", "*.txt");
                    foreach (string displayFilesInDirectory in fileInDirectory)
                    {
                        Console.WriteLine(displayFilesInDirectory);
                    }
                  
                    Console.Write("What is the file you wish to Open?: ");
                    string filewished = Console.ReadLine();
                    //Checking for file existing
                    if (File.Exists(@"ToDoLists/" + filewished + ".txt") == true)
                    {
                        string text = System.IO.File.ReadAllText(@"ToDoLists/" + filewished + ".txt");
                        // Display the file contents to the console. Variable text is a string.
                        System.Console.WriteLine(text);
                        Console.WriteLine("Press any Key to Exit.");
                        Console.ReadKey();
                        mainMenu();
                    }
                    else if (File.Exists(@"ToDoLists/" + filewished + ".txt") == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The File That You Searched Does Not Exist...\nPress Any Key To Go Back To To-Do List Menu...");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        ToDoList();
                    }
                }
                if (ToDo == "3")
                {
                  Console.WriteLine("FILES IN DIRECTORY");
                  Console.WriteLine("___________________");
                  string[] fileInDirectory = Directory.GetFiles(@"ToDoLists/", "*.txt");
                    foreach (string displayFilesInDirectory in fileInDirectory)
                    {
                        Console.WriteLine(displayFilesInDirectory);
                    }
                    Console.WriteLine("(Dont Include The .txt Or Folder Name)");
                    Console.Write("Please Enter The name Of the File: ");
                    string deleteFile = Console.ReadLine();
                    if (File.Exists(@"ToDoLists/" + deleteFile + ".txt") == true)
                    {
                        File.Delete(@"ToDoLists/" + deleteFile + ".txt");
                        ToDoList();
                    }
                    if (File.Exists(@"ToDoLists/" + deleteFile + ".txt") == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The File That You Wished To Delet Does Not Exist...\nPress Any Key To Go Back To To-Do List Menu...");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        ToDoList();
                    }
                }
                if (ToDo == "4")
                {
                    mainMenu();
                }
                else{
                  Console.Clear();
                  Console.WriteLine("That is not a valid choice.<Press any key to continue>");
                  Console.ReadKey();
                  ToDoList();
                }

            }
            private static void login()
            {
                StreamReader readUserName = new StreamReader(@"WhichOS_Username.txt");
                string storedUsername = readUserName.ReadToEnd();
                string storedUsernameUsable = storedUsername;
                StreamReader readUserPassword = new StreamReader(@"WhichOS_Password.txt");
                string storedPassword = readUserPassword.ReadToEnd();
                string storedPaswordUsable = storedPassword;
                Console.Clear();
                //Login!
                Console.WriteLine("LOGIN");
                Console.WriteLine("-----------------------");
                Console.Write("Please Enter Your username: ");
                string userNameInputLogin = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                string userPasswordInputLogin = Console.ReadLine();
                if (userNameInputLogin == storedUsernameUsable && userPasswordInputLogin == storedPaswordUsable)
                {
                    Console.WriteLine("You logged in.");
                    mainMenu();
                }
                //If the Username/Password is incorrect...this will show up.
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine("Your Username And/Or Password Was Incorrect!\n<Press Any Key To Go Back>");
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    login();

                }
            }
            private static void textEditor()
            {
              bool writing = true;
              Console.Clear();
              Console.WriteLine("Welcome to the Text Editor!");
              Console.WriteLine("------------------------------------");
              Console.WriteLine("type exit to leave the ToDoList");
              Console.WriteLine("What would you like to do?");
              Console.WriteLine("(1)Make a new Text File");
              Console.WriteLine("(2)Open a Text File");
              Console.WriteLine("(3)Delete a File.");
              Console.WriteLine("(4)Go Back to Main Menu");
              string ToDo = Console.ReadLine();
              if (ToDo == "1")
              {
                  Console.Write("Please Enter The File Name: ");
                  string fileNameList = Console.ReadLine();
                  Console.Clear();
                  Console.WriteLine("                 Text Editor");
                  Console.WriteLine("-----------------------------------------------------");
                  while (writing == true)
                  {
                      string onestring = Console.ReadLine();
                      if (onestring == "End" || onestring == "end" || onestring == "exit" || onestring == "Exit" || onestring == "close" || onestring == "Close" || onestring == "menu" || onestring == "Menu" || onestring == "Escape" || onestring == "escape")
                      {
                          writing = false;
                          Console.WriteLine("saved: " + fileNameList + "\n<Press Any Key To Go To Menu>");
                          Console.ReadLine();
                          textEditor();
                      }
                      else
                      {
                          File.AppendAllText(@"TextFiles/" + fileNameList + ".txt", onestring + Environment.NewLine);
                      }

                  }
              }
              //Opening File
              if (ToDo == "2")
              {
                Console.WriteLine("FILES IN DIRECTORY");
                Console.WriteLine("___________________");
                string[] fileInDirectory = Directory.GetFiles(@"TextFiles/", "*.txt");
                  foreach (string displayFilesInDirectory in fileInDirectory)
                  {
                      Console.WriteLine(displayFilesInDirectory);
                  }
                  Console.Write("What is the file you wish to Open?: ");
                  string filewished = Console.ReadLine();
                  //Checking for file existing
                  if (File.Exists(@"TextFiles/" + filewished + ".txt") == true)
                  {
                      string text = System.IO.File.ReadAllText(@"TextFiles/" + filewished + ".txt");
                      // Display the file contents to the console. Variable text is a string.
                      System.Console.WriteLine(text);
                      Console.WriteLine("Press any Key to Exit.");
                      Console.ReadKey();
                      mainMenu();
                  }
                  else if (File.Exists(@"TextFiles/" + filewished + ".txt") == false)
                  {
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine("The File That You Searched Does Not Exist...\nPress Any Key To Go Back To To-Do List Menu...");
                      Console.ReadKey();
                      Console.ForegroundColor = ConsoleColor.Cyan;
                      textEditor();
                  }
              }
              if (ToDo == "3")
              {
                Console.WriteLine("FILES IN DIRECTORY");
                Console.WriteLine("___________________");
                string[] fileInDirectory = Directory.GetFiles(@"TextFiles/", "*.txt");
                  foreach (string displayFilesInDirectory in fileInDirectory)
                  {
                      Console.WriteLine(displayFilesInDirectory);
                  }
                  Console.WriteLine("(Dont Include The .txt Or Folder Name)");
                  Console.Write("Please Enter The name Of the File: ");
                  string deleteFile = Console.ReadLine();
                  if (File.Exists(@"TextFiles/" + deleteFile + ".txt") == true)
                  {
                      File.Delete(@"TextFiles/" + deleteFile + ".txt");
                      textEditor();
                  }
                  if (File.Exists(@"TextFiles/" + deleteFile + ".txt") == false)
                  {
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine("The File That You Wished To Delet Does Not Exist...\nPress Any Key To Go Back To To-Do List Menu...");
                      Console.ReadKey();
                      Console.ForegroundColor = ConsoleColor.Cyan;
                      textEditor();
                  }
              }
              if (ToDo == "4")
              {
                  mainMenu();
              }
              else{
                Console.Clear();
                Console.WriteLine("That is not a valid choice.<Press any key to continue>");
                Console.ReadKey();
                ToDoList();
              }
            }
            private static void cratorOSCommandLine()
            {
                Console.WriteLine("Welcome To Crator OS Command Line Tool Copyright MojangIsTraash 2k18");
                Console.Write("Please Entern A Command: ");
                string cratorOSCommandInput = Console.ReadLine();

            }
            //Number Game Method
            private static void numberGame()
            {
                Console.Clear();
                Console.WriteLine("Welcome To The Number Game!\nThe Objective Is To Guess The Number Between 1 And 10");
                Console.WriteLine("Answer The Question Correctly To Win!");
                Random randomDigit1 = new Random();
                int randomNumber = randomDigit1.Next(1, 11);
                Console.Write("Please Enter A Digit Between 1 And 10: ");
                //User Input for the number they Choose
                string userAnswerInput = Console.ReadLine();
                int userAnswerInputInt = int.Parse(userAnswerInput);
                //Result of being right!
                if (userAnswerInputInt == randomNumber)
                {
                    Console.Write("You Win! Play Again?(y/n): ");
                    string playAgainWin = Console.ReadLine();
                    if (playAgainWin == "y" || playAgainWin == "Y")
                    {
                        Console.Clear();
                        numberGame();
                    }

                    else if (playAgainWin == "n" || playAgainWin == "N")
                    {
                        Console.Clear();
                        mainMenu();
                    }
                }
                //Result of Being Wrong...
                else if (userAnswerInputInt != randomNumber)
                {
                    Console.Write("You Lose... Try Again?(Y/N): ");
                    string playAgainLose = Console.ReadLine();
                    if (playAgainLose == "y" || playAgainLose == "Y")
                    {
                        Console.Clear();
                        numberGame();
                    }
                    else if (playAgainLose == "n" || playAgainLose == "N")
                    {
                        Console.Clear();
                        mainMenu();
                    }
                }

                //Text editor method!


                Console.ReadLine();
            }

            //Static method called in the begging of the script
            public static void Main(string[] args)
            {

                //Background Color and ForegroundColor set
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                try
                {
                    //Checking if the user has made an account before by checking the txt files
                    if (File.Exists(@"WhichOS_Username.txt") && File.Exists(@"C:\Users\Public\WhichOS_Password.txt") || File.Exists(@"WhichOS_Username.txt") && File.Exists(@"WhichOS_Password.txt"))
                    {
                        login();
                    }
                }
                //If the file given could not have been read
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("The file could not be read");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }



                //  Create Account Screen
                if (File.Exists(@"WhichOS_Username.txt") == false && File.Exists(@"WhichOS_Password.txt") == false)
                {
                    Random randMotoNumberPicker = new Random();
                    int randMoto = randMotoNumberPicker.Next(1, 9);
                    string randMotoOutput = "";
                    if (randMoto == 1)
                    {
                        randMotoOutput = "Watch For Astroids!";
                    }
                    else if (randMoto == 2)
                    {
                        randMotoOutput = "Wait For Impact!";
                    }
                    else if (randMoto == 3)
                    {
                        randMotoOutput = "Oh No, Its Coming Down!";
                    }
                    else if (randMoto == 4)
                    {
                        randMotoOutput = "ITS A BIRD, ITS A PLANE, ITS...An OS?";
                    }
                    else if (randMoto == 5)
                    {
                        randMotoOutput = "Who Knew An OS Could Be So Powerful...";
                    }
                    else if (randMoto == 6)
                    {
                        randMotoOutput = "Wow! Whats That In The Sky...";
                    }
                    else if (randMoto == 7)
                    {
                        randMotoOutput = "Hey, I Didn't See That Crator Yesterday!";
                    }
                    else if (randMoto == 8)
                    {
                        randMotoOutput = "Is It A Meteor, Or An Astroid? Okay, Im Confused.";
                    }

                    Console.WriteLine("Welcome To CratorOS, " + randMotoOutput);
                    Console.WriteLine("    CREATE ACCOUNT");
                    Console.WriteLine("------------------------");
                    Console.Write("Please Enter Your username: ");
                    string userNameInputCreate = Console.ReadLine();
                    Console.Write("Please Enter Password: ");
                    string userPasswordInputCreate = Console.ReadLine();
                    System.IO.File.WriteAllText(@"WhichOS_Username.txt", userNameInputCreate);
                    System.IO.File.WriteAllText(@"WhichOS_Password.txt", userPasswordInputCreate);
                    Console.Clear();
                    Console.WriteLine("Thank You For Choosing CratorOS!\nPress Any Key To Continue...");
                    Directory.CreateDirectory(@"ToDoLists");
                    Directory.CreateDirectory(@"TextFiles");
                    System.IO.File.WriteAllText(@"ToDoLists/DirectoryCreated.txt", "The Directory Was created Successfuly!");
                    System.IO.File.WriteAllText(@"TextFiles/Directory2Created.txt", "The Directory Was created Successfuly!");
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    Console.ReadLine();

                }
            }
        }
    }
}

