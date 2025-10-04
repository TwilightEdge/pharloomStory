using System.Xml.Linq;

namespace programmingClassFirstSession
{
    internal class Program
    {
        public static string response = "0";

        public static bool haveRosaries = false;

        public static bool havePaper = false;

        public static bool haveMap = false;

        public static bool treasureFound = false;

        public static bool given100 = false;

        public static bool haveKey = false;

        public static bool given500 = false;

        public static bool trained = false;


        static void Main(string[] args)
        {
            Situation1();
        }

        static void Situation1() //needs update about the locked door
        {
            //string response;

            Console.WriteLine("you are in dark and mystical lands of Pharloom, do you want to: ");
            Console.WriteLine();
            Console.WriteLine("1_ go explore the bone bottom");
            Console.WriteLine("2_ go down into the Moss Groto");
            response = Console.ReadLine();



            if (response == "1")
            {

                //go to bone bottom sit 2
                Situation2();



                //talk to the builder bug


            }
            else
            {
                if (response == "2")
                {
                    // sit 3
                    Situation3();
                }
                else
                {
                    Console.WriteLine("please choose one of the options to play the game!!");

                    Console.ReadLine();
                    Situation1();


                }


            }
            Console.ReadLine();
        }

        static void Situation2()
        {
            //string response;

            Console.WriteLine("you continue down the path in the bone bottom, reaching a small gathering of bugs that seems to be pilgrims");
            Console.WriteLine();
            Console.WriteLine("1_ talk to the bug with a hammer in hand");
            Console.WriteLine("2_ talk to the bug sitting on what apears to be a camp lamp");
            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {
                //sit 4
                Situation4();
            }
            else
            {
                // talk to the bug near camp
                if (response == "2")
                {

                    //sit 5
                    Situation5();
                }
                else //other inputs in
                {


                    if (response == "b" || response == "B")
                    {

                        //go back to pharloom sit 1
                        Situation1();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation2();
                    }

                }
            }

        }

        static void Situation3()
        {




            Console.WriteLine("you head down to the dark and mysterious tunnels of Moss Groto! you hear a bug singing a sharp from bellow and there are lands to explore in your right, where do you go?");
            Console.WriteLine();
            Console.WriteLine("1_ go find out where the sound comming from");
            Console.WriteLine("2_ continue to the right to explore more of moss groto");
            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {

                //go to bone bottom sit 6
                Situation6();



                //talk to the builder bug


            }
            else
            {
                if (response == "2")
                {
                    // sit 7
                    Situation7();
                }
                else
                {
                    if (response == "b" || response == "B")
                    {

                        //go back to pharloom sit 1
                        Situation1();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation3();
                    }
                }
            }


        }

        static void Situation4()
        {

            if (!given500)
            {
                Console.WriteLine("you go and talk to the builder bug and he tells you that if you give him 500 rosaries he can rebuild bone bottom again for the pilgrims to come");
                Console.WriteLine();
                Console.WriteLine("1_ give him 500 rosarhes! (require 500 rosaries)");

                Console.WriteLine();
                Console.WriteLine("to go back press [B]ack");
                response = Console.ReadLine();

                if (response == "1")
                {
                    if (haveRosaries == true)
                    {
                        //vin con

                        Console.WriteLine("ayy now I can rebuild bone bottoom for the new pilgrims! thanks miss spider!!");
                        Console.WriteLine();
                        Console.WriteLine("here, let me give you a token of my gratitude for what you did for all the pilgrims that would come in the future:");
                        Console.WriteLine();
                        Console.WriteLine("YOU GOT A SILVER KEY!");
                        Console.ReadLine();

                    }
                    else
                    {

                        Console.WriteLine("but you don't have the rosaries!");
                        Console.WriteLine("maybe there would be others who you can ask around about where you can find some?");
                        Console.ReadLine();
                        Situation4();

                    }


                }
                else
                {

                    if (response == "b" || response == "B")
                    {

                        //go back to bone bottom
                        Situation2();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation4();
                    }

                }

            }
            else //gave 500 already
            {

                Console.WriteLine("thank you again so much for your kind donation miss spider!");
                Console.WriteLine();
                Console.WriteLine("to go back press [B]ack");
                response = Console.ReadLine();

                if (response == "b" || response == "B")
                {

                    //go back to bone bottom
                    Situation2();

                }
                else
                {
                    Console.WriteLine("please choose one of the options to play the game!!");
                    Console.ReadLine();
                    Situation4();
                }

            }

        }

        static void Situation5()
        {
            if (!haveMap) // you dont have the map
            {

                Console.WriteLine("you start talking to a bug sitting on a camp fire that appear to be a warrior and they tell you about a treasure hidden somewhere down there");
                Console.WriteLine();
                Console.WriteLine("hey! I would tell you the exact location but I need to draw you a map and I dont have paper! but if you found it you have to pay me 100 rosaries what ever it was! I trust you!");
                Console.WriteLine();
                Console.WriteLine("1_ accept the deal and give the bug a paper! (requie paper)");

                Console.WriteLine();
                Console.WriteLine("to go back press [B]ack");
                response = Console.ReadLine();

                if (response == "1")
                {

                    //go to bone bottom sit 6
                    if (havePaper)
                    {
                        haveMap = true;
                        Console.WriteLine("here you go miss spider! this is the spot I was talking about! just dont forget about my 100 rosaries ok?");
                        Console.WriteLine();
                        Console.WriteLine("you got a map!!! you look the spot they draw on the map");
                        Console.WriteLine("it should be the right side of the Moss Groto, way down!");
                    }
                    else
                    {
                        Console.WriteLine("you do not have the paper miss spider!");
                        Situation5();
                    }


                }
                else
                {

                    if (response == "b" || response == "B")
                    {

                        //go back to bone bottom
                        Situation2();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation5();
                    }

                }
            }
            else //you already got the map
            {

                Situation10();

            }

        }

        static void Situation6() //needs update about paper offering
        {
            //string response;

            Console.WriteLine("you walk towards a bug singing and making sharp sounds with smashing two golden ring, she introduces herself as Shakra,");
            Console.WriteLine("a warrior and she tells you that there is a locked door somewhere in the right side of the moss groto");
            Console.WriteLine();
            Console.WriteLine("press [B]ack");

            response = Console.ReadLine();



            if (response == "b" || response == "B")
            {

                //go to bone bottom sit 3
                Situation3();

            }
            else
            {
                Console.WriteLine("please choose one of the options to play the game!!");
                Console.ReadLine();
                Situation6();
            }

        }

        static void Situation7()
        {
            


        }

        static void Situation8()
        {
           


        }

        static void Situation9()
        {
            


        }

        static void Situation10()
        {
            //you already got the map (previous sit 5)

            Console.WriteLine("hello again miss spider! I already give you the map didn't I?");
            Console.WriteLine();
            if (!given100)
            {
                Console.WriteLine("tell me, did you find the treasure?");
                Console.WriteLine();
                Console.WriteLine("1_ actually I did! (requires finding the treasure)");
                Console.WriteLine("2_ no I didn't!");

                Console.WriteLine();
                Console.WriteLine("to go back press [B]ack");
                response = Console.ReadLine();

                if (response == "1")
                {


                    if (treasureFound)
                    {
                        //let him know you have his rosaries
                        Situation11();
                    }
                    else
                    {
                        Console.WriteLine("you are lying arent you? come back when you have my rosaries!");
                        Console.ReadLine();
                        Situation10();
                    }


                }
                else
                {
                    if (response == "2")
                    {
                        Console.WriteLine("oh you didnt went down to the right of Moss Groto yet? well I can wait! just remember to pay me my 100 rosaries after!");
                        Console.ReadLine();
                        Situation10();
                    }
                    else
                    {
                        if (response == "b" || response == "B")
                        {

                            //go back to bone bottom
                            Situation2();

                        }
                        else
                        {
                            Console.WriteLine("please choose one of the options to play the game!!");
                            Console.ReadLine();
                            Situation5();
                        }
                    }

                }

            }
            else //given him 100 rosaries already
            {

                Console.WriteLine("I thank you again for keeping you promiss, one doesn't see bugs like you everyday, specially a spider! yes of course I knew, thats why I taught you that skill in the first place! I have high expectations of you miss spider!");
                Console.WriteLine("pharloom might be doomed but as long as bugs like you would still be around there is hope! I wish you best of luck miss spider :)");
                Console.WriteLine();
                Console.WriteLine("to go back press [B]ack");
                Console.ReadLine();

                response = Console.ReadLine();

                if (response == "b" || response == "B")
                {

                    //go back to bone bottom
                    Situation2();

                }
                else
                {
                    Console.WriteLine("please choose one of the options to play the game!!");
                    Console.ReadLine();
                    Situation10();
                }

            }
        }

        static void Situation11()
        {
            //the warrior asks for the rosaries after releazes you have them

            Console.WriteLine("oh you did find it! warrior to warrior promiss, I wont ask you how much you found and you give me my 100 rosaries");
            Console.WriteLine();
            Console.WriteLine("1_ here, take the 100 rosaries I owe you");
            Console.WriteLine("2_ I dont owe you anything!");

            Console.WriteLine();
            //Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {

                given100 = true;
                Console.WriteLine("wow you kept your promiss, color me impressed!");
                Console.WriteLine("as a warrior I already know youre a great deal, but youre a little rusty arent you? or maybe there is something wrong with you? lets duel, Ill teach you some nail arts too!");
                trained = true;
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine("you two spend some time training, and you learned a new nail art!");
                Console.WriteLine();
                Console.WriteLine("off you go miss spider! I know that whatever is going to be your goal here in oharlkoom, you can achieve it!");
                Console.WriteLine();

                Console.WriteLine("to go back press [B]ack");
                response = Console.ReadLine();

                if (response == "b" || response == "B")
                {

                    //go back to bone bottom
                    Situation2();

                }
                else
                {
                    Console.WriteLine("please choose one of the options to play the game!!");
                    Console.ReadLine();
                    Situation10();
                }

                
            }
            else // you refuse to hand over 100 rosaries
            {
                if (response == "2")
                {
                    Console.WriteLine("ok you choose this then!");
                    Console.ReadLine();
                    Console.WriteLine("the warrior bug suddenly jumps forward and stabs you in your stomach");
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine("you can't believe this, you knew you were feeling weak but dying? like this? who is he anyway?!");
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine("as you slowly lose your sight, you wish you did keep your promiss");
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine("and you die");
                    Console.ReadLine();

                    Exit();
                }
                else
                {
                    if (response == "b" || response == "B")
                    {

                        //go back to bone bottom
                        Situation2();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation5();
                    }
                }

            }

        }

        static void Situation12()
        {
            //string response;


        }

        static void Situation13()
        {

            //game ending

            

        }

        static void Exit()
        {            
            Environment.Exit(0);
        }

    }
}
