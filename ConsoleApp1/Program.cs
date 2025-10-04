using System.Xml.Linq;

namespace programmingClassFirstSession
{
    internal class Program
    {
        public static string response = "0";

        static void Main(string[] args)
        {
            Situation1();
        }

        static void Situation1()
        {
            //string response;

            Console.WriteLine("you are in dark and mystical lands of Pharloom, do you want to: ");
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
                    Console.WriteLine("please choose one of the numbers to play the game!!");

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
                        Console.WriteLine("please choose one of the numbers to play the game!!");
                        Console.ReadLine();
                        Situation2();
                    }

                }
            }

        }

        static void Situation3()
        {

            //string response;


            Console.WriteLine("you head down to the dark and mysterious tunnels of Moss Groto! you hear a bug singing a sharp from bellow and there are lands to explore in your right, where do you go?");
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
                        Console.WriteLine("please choose one of the numbers to play the gmae!!");
                        Console.ReadLine();
                        Situation3();
                    }
                }
            }


        }

        static void Situation4()
        {
            //string response;

            Console.WriteLine("you approached the bug, he tells you about this place, and asks you if you can donate some shells");
        }

        static void Situation5()
        {
            //string response;

            Console.WriteLine("you approached the bug near the lamp, they tell you that they are a pilgrim and they plan to departure to the holy lands soon");
        }

        static void Situation6()
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
                Console.WriteLine("please choose one of the numbers to play the gmae!!");
                Console.ReadLine();
                Situation6();
            }

        }

        static void Situation7()
        {
            //string response;


        }

        static void Situation8()
        {
            //string response;


        }

        static void Situation9()
        {
            //string response;


        }

        static void Situation10()
        {
            //string response;


        }

    }
}
