using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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

        public static bool doorOpened = false;

        public static bool haveSkill = false;


        static void Main(string[] args)
        {
            Menu();


        }

        static void Situation1() //needs update about the locked door
        {
            Devider();

            Console.WriteLine("you are in dark and mystical lands of Pharloom, do you want to: ");
            Console.WriteLine();
            Console.WriteLine("1_ go explore the bone bottom");
            Console.WriteLine("2_ go down into the Moss Groto");
            Console.WriteLine("3_ check the big door right beside you");
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
                    if (response == "3")
                    {
                        if (!doorOpened)
                        {

                            Situation12();

                        }
                        else // already openned the door
                        {

                            Console.WriteLine("you already openned this door!");
                            Console.ReadLine();
                            Console.WriteLine("you decide to go back");
                            Situation1(); // go back to sit 1
                        }
                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");

                        Console.ReadLine();
                        Situation1();
                    }

                }


            }
            Console.ReadLine();
        }

        static void Situation2()
        {

            Devider();

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
            Devider();

            Console.WriteLine("you head down to the dark and mysterious tunnels of Moss Groto! you hear a bug singing in a sharp tune from bellow and there are lands to explore in your right, where do you go?");
            Console.WriteLine();
            Console.WriteLine("1_ go find out where the sound is comming from");
            Console.WriteLine("2_ continue to the right to explore more of Moss Groto");
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
            Devider();

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
            Devider();

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

        static void Situation6() 
        {
            Devider();

            //offers paper!

            if (!havePaper) // if you dont have paper already
            {
                Console.WriteLine("you walk towards a bug singing and making sharp sounds with smashing two golden ring, she introduces herself as Shakra,");
                Console.WriteLine("a warrior and she tells you that she enjoys making maps and have paper to spare if you want some");
                Console.WriteLine();
                Console.WriteLine("you aquire paper!");
                Console.ReadLine();
                havePaper = true;
            }
            else // if you have paper already!
            {

                Console.WriteLine("I alread gave you my spare paper young warrior");
                Console.WriteLine("*she smashes the two golden ring again with sharp sound*");
                Console.WriteLine("may my song be with you");

            }

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
            Devider();

            Console.WriteLine("you dontinue right in the green lands of Moss groto untill you reach a cross road, you can either:");
            Console.WriteLine();
            Console.WriteLine("1_ go inspect what it seems to be a bunch of webs woven together");
            Console.WriteLine("2_ go down through a hole deeper into the Moss Groto");

            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {

                Situation8();

            }
            else
            {
                if (response == "2")
                {
                    Situation9();
                }
                else
                {
                    if (response == "b" || response == "B")
                    {

                        //go back to bone bottom
                        Situation3();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation7();
                    }

                }

            }

        }

        static void Situation8() // you approach silk woven together
        {
            Devider();

            Console.WriteLine("you inspect the interwoven pile of silk more carefully and try to srike it down, but it resist and regenerates fast...");
            Console.WriteLine("you dont seem to able to cut through, unless you cut deep an all at once?");
            Console.WriteLine("but with a close inspection, there is also seem to be a very big bug trapped deep inside this interwoven web of silk that is still moving!");
            Console.WriteLine("...you can help yourself but to think, wow what a beast....");

            Console.WriteLine();
            Console.WriteLine("1_ cut the silks (requires skill)");
            

            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {
                if (haveSkill)
                {

                    Situation13();

                }
                else // you dont have the skill to cut through
                {

                    Console.WriteLine("you dont seem to have the skill to cut through!");

                }

            }
            else
            {
                
                    if (response == "b" || response == "B")
                    {

                        //go back to bone bottom
                        Situation7();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation8();
                    }

                

            }

        }

        static void Situation9() // you go down into the hole
        {

            Devider();

            if (!treasureFound) // if you dont have treasure yet
            {

                if (haveMap) // you can dig the treasure
                {
                    treasureFound = true;
                    haveRosaries = true;
                    Console.WriteLine("you read the map carefully and after trying a few spots you dig and find a chest full of beads!");
                    Console.WriteLine();
                    Console.WriteLine("YOU FOUND 600 ROSARIES!");

                }
                else // you dont know where the treasure is
                {

                    Console.WriteLine("you find yourself in a very big underground area, you explore a little but you dont seem to find anything");

                }


            }
            else // if you already have the treasure
            {

                Console.WriteLine("you already dug the treasure, there doesnt seem to be anything else here");

            }

            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "b" || response == "B") //go back to sit 7 **
            {

               
                Situation7();

            }
            else
            {
                Console.WriteLine("please choose one of the options to play the game!!");
                Console.ReadLine();
                Situation9();
            }

        }

        static void Situation10()
        {

            Devider();
            
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
            Devider();

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
            Devider();

            //you inteacted with the door

            Console.WriteLine("you check the big door, it appears to be locked with a big silver lock");
            Console.WriteLine();
            Console.WriteLine("1_ open the door (requires silver key)");
            
            Console.WriteLine();
            Console.WriteLine("to go back press [B]ack");
            response = Console.ReadLine();

            if (response == "1")
            {
                if(haveKey) //open the door with key
                {

                    doorOpened = true;
                    haveSkill = true;
                    Console.WriteLine("you put the silver key that you got from builder bug in the silver big lock and it opens with a sharp sound");
                    Console.WriteLine();
                    Console.WriteLine("inside you see a small dusty dark room with a stature of a weaver inside, you go towards it and interact with it by instinct");
                    Console.ReadLine();
                    Console.Write(".");
                    Console.ReadLine();
                    Console.Write(".");
                    Console.ReadLine();
                    Console.WriteLine(".");
                    Console.ReadLine();
                    Console.WriteLine("you aquired a skill! you now can throw your weapon to deal with larg amount of silk!");
                    Console.ReadLine();

                    Situation1();

                }
                else // dont have the key
                {

                    Console.WriteLine("you do not have the key!");
                    Console.ReadLine();
                    
                    Situation12();
                }
            }
            else
            {
                // you can go back to sit 1
                


                    if (response == "b" || response == "B")
                    {

                        //go back to pharloom sit 1
                        Situation1();

                    }
                    else
                    {
                        Console.WriteLine("please choose one of the options to play the game!!");
                        Console.ReadLine();
                        Situation12();
                    }

                
            }

        }

        static void Situation13()
        {
            Devider();

            //you cut through the web!

            Console.WriteLine("you cut through the interwoven web of silk with one single thrust of skill of your blade, as it fells apart you see the beast gets free! but instead of any graduation it charges towards you!!!");
            Console.WriteLine();

            if (trained)
            {

                Console.WriteLine("thanks to the training you had with the warrior in the bone bottom your body moves on its own!");
                Console.WriteLine("you jump in the air and dodge the beast charge at you, and as it passes you you throw yourself at it backwards and struck the beast diagnolly with your blade!");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("you then watch the beast calming down, as if its respecting you now? it even pounds the ground with its feet to sygnal something at you!");
                Console.WriteLine("you mount the beast as it then goes into the ground and you say goodbye to pharloom for now!");
                Console.WriteLine();
                Console.WriteLine("VICTORY!!!");

                Exit();

            }
            else // you are rusty - death!
            {

                Console.WriteLine("you can't seem to believe the beast charging at you right after you freed from that nasty web of silk! your body freez as the giant beast hits you...");
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine("and slowly");
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine("everything fades to black");
                Console.WriteLine(".");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("YOU DIE!");
                Console.ReadLine();

                Exit();

            }
            



        }

        static void Exit()
        {            
            Environment.Exit(0);
        }

        static void Devider()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            return;
        }

        static void Menu() // its not functional yet
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                          WELCOME TO SILK MUSIC!                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                          P TO [P]LAY THE GAME                                                        |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                          E TO [E]XIT THE GAME                                                        |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            response = Console.ReadLine();


        }

    }
}
