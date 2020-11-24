using UnityEngine;
using UnityEngine.UI;
using System;

namespace SNL
{

    public class SNL3 : MonoBehaviour
    {

        //create database
        string[,] array1 = new string[100, 4]
        {

        //player1 / #TypeColorTeleport
        {"Go!","None","Red","0"},
        { "2","Bottom","Orange","23"},
        { "3","None","Red","0"},
        { "4","None","Blue","0"},
        { "5","Tail","Green","0"},
        { "6","Bottom","Yellow","45"},
        { "7","None","Orange","0"},
        { "8","Tail","Red","0"},
        { "9","None","Blue","0"},
        { "10","None","Green","0"},
        { "11","None","Red","0"},
        { "12","None","Orange","0"},
        { "13","None","Yellow","0"},
        { "14","None","Green","0"},
        { "15","Tail","Blue","0"},
        { "16","None","Red","0"},
        { "17","Tail","Orange","0"},
        { "18","None","Yellow","0"},
        { "19","None","Green","0"},
        { "20","Bottom","Blue","59"},
        { "21","None","Orange","0"},
        { "22","None","Red","0"},
        { "23","Top","Blue","0"},
        { "24","None","Green","0"},
        { "25","None","Yellow","0"},
        { "26","None","Orange","0"},
        { "27","None","Red","0"},
        { "28","None","Blue","0"},
        { "29","None","Green","0"},
        { "30","None","Yellow","0"},
        { "31","None","Blue","0"},
        { "32","None","Red","0"},
        { "33","None","Orange","0"},
        { "34","None","Yellow","0"},
        { "35","None","Green","0"},
        { "36","None","Blue","0"},
        { "37","None","Red","0"},
        { "38","None","Orange","0"},
        { "39","None","Yellow","0"},
        { "40","Tail","Green","0"},
        { "41","None","Red","0"},
        { "42","None","Blue","0"},
        { "43","Head","Green","17"},
        { "44","None","Yellow","0"},
        { "45","Top","Orange","0"},
        { "46","None","Red","0"},
        { "47","None","Blue","0"},
        { "48","None","Green","0"},
        { "49","Tail","Yellow","0"},
        { "50","Head","Orange","5"},
        { "51","None","Green","0"},
        { "52","Bottom","Blue","72"},
        { "53","None","Red","0"},
        { "54","None","Orange","0"},
        { "55","None","Orange","0"},
        { "56","Head","Green","8"},
        { "57","Bottom","Blue","96"},
        { "58","None","Red","0"},
        { "59","Top","Orange","0"},
        { "60","None","Yellow","0"},
        { "61","None","Blue","0"},
        { "62","None","Green","0"},
        { "63","Tail","Yellow","0"},
        { "64","None","Orange","0"},
        { "65","None","Orange","0"},
        { "66","None","Blue","0"},
        { "67","None","Green","0"},
        { "68","None","Yellow","0"},
        { "69","None","Orange","0"},
        { "70","None","Red","0"},
        { "71","Bottom","Yellow","92"},
        { "72","Top","Green","0"},
        { "73","Head","Blue","15"},
        { "74","None","Red","0"},
        { "75","None","Orange","0"},
        { "76","None","Yellow","0"},
        { "77","None","Green","0"},
        { "78","None","Blue","0"},
        { "79","None","Red","0"},
        { "80","None","Orange","0"},
        { "81","None","Green","0"},
        { "82","None","Yellow","0"},
        { "83","None","Orange","0"},
        { "84","Head","Red","63"},
        { "85","None","Blue","0"},
        { "86","None","Green","0"},
        { "87","Head","Yellow","49"},
        { "88","None","Orange","0"},
        { "89","None","Red","0"},
        { "90","None","Blue","0"},
        { "91","None","Orange","0"},
        { "92","Top","Yellow","0"},
        { "93","None","Green","0"},
        { "94","None","Blue","0"},
        { "95","None","Red","0"},
        { "96","None","Orange","0"},
        { "97","None","Yellow","0"},
        { "98","Head","Green","40"},
        { "99","None","Orange","0"},
        { "Winner","Done","Red","0"}
        };

        ////create database
        //int[,] array3 = new int[100, 2]
        //{

        //    {"0","1"},
        //    {"23","2"},
        //    {"0","3"},
        //    {"0","4"},
        //    {"0","5"},
        //    {"45","6"},
        //    {"0","7"},
        //    {"0","8"},
        //    {"0","9"},
        //    {"0","10"},
        //    {"0","11"},
        //    {"0","12"},
        //    {"0","13"},
        //    {"0","14"},
        //    {"0","15"},
        //    {"0","16"},
        //    {"0","17"},
        //    {"0","18"},
        //    {"0","19"},
        //    {"59","20"},
        //    {"0","21"},
        //    {"0","22"},
        //    {"0","23"},
        //    {"0","24"},
        //    {"0","25"},
        //    {"0","26"},
        //    {"0","27"},
        //    {"0","28"},
        //    {"0","29"},
        //    {"0","30"},
        //    {"0","31"},
        //    {"0","32"},
        //    {"0","33"},
        //    {"0","34"},
        //    {"0","35"},
        //    {"0","36"},
        //    {"0","37"},
        //    {"0","38"},
        //    {"0","39"},
        //    {"0","40"},
        //    {"0","41"},
        //    {"0","42"},
        //    {"17","43"},
        //    {"0","44"},
        //    {"0","45"},
        //    {"0","46"},
        //    {"0","47"},
        //    {"0","48"},
        //    {"0","49"},
        //    {"5","50"},
        //    {"0","51"},
        //    {"72","52"},
        //    {"0","53"},
        //    {"0","54"},
        //    {"0","55"},
        //    {"8","56"},
        //    {"96","57"},
        //    {"0","58"},
        //    {"0","59"},
        //    {"0","60"},
        //    {"0","61"},
        //    {"0","62"},
        //    {"0","63"},
        //    {"0","64"},
        //    {"0","65"},
        //    {"0","66"},
        //    {"0","67"},
        //    {"0","68"},
        //    {"0","69"},
        //    {"0","70"},
        //    {"92","71"},
        //    {"0","72"},
        //    {"15","73"},
        //    {"0","74"},
        //    {"0","75"},
        //    {"0","76"},
        //    {"0","77"},
        //    {"0","78"},
        //    {"0","79"},
        //    {"0","80"},
        //    {"0","81"},
        //    {"0","82"},
        //    {"0","83"},
        //    {"63","84"},
        //    {"0","85"},
        //    {"0","86"},
        //    {"49","87"},
        //    {"0","88"},
        //    {"0","89"},
        //    {"0","90"},
        //    {"0","91"},
        //    {"0","92"},
        //    {"0","93"},
        //    {"0","94"},
        //    {"0","95"},
        //    {"0","96"},
        //    {"0","97"},
        //    {"40","98"},
        //    {"0","99"},
        //    {"0","100"}

        //};



        //create database
        string[,] array2 = new string[4, 4] //array of Monopoly data from the original version of the game
        {
        { "0","0","0","0"},
        { "0","0","0","0"},
        { "0","0","0","0"},
        { "0","0","0","0"}
        };


        int dice1; //result of dice1 roll
        int dice2; //result of dice2 roll
        int turns_counter = 0;
        int player1 = 1;
        int player2 = 1;
        string turn;
        //string thePlayers2;

        void Start()
        {
            Debug.Log("How many players???");

            //public Text Username_field;
            //then drag and drop the Username_field

            //string userID = Username_field.text.ToString();

        }


        // Update is called once per frame 
        void Update()
        {
            //Debug.Log("" + thePlayers);
            //turn = SNL2.thePlayers;
            //turn = SNL2.test;
            //turn = SNL2.Equals.gameObject.
            //thePlayers2 = SNL2.thePlayers;
            //Debug.Log("thePlayers2 = " + thePlayers2);
            //turn = SNL2.thePlayers; //works
            //Debug.Log("thePlayers = " + SNL2.thePlayers);// Works needs back

            if (Input.GetKeyDown(KeyCode.W)) //Start of W Bar Loop  
            {

                player1 = player1 + dice1;
                dice1 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice

                if (player1 == 2) //Teleport1
                {
                    player1 = 23;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 6) //Teleport2
                {
                    player1 = 45;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 20) //Teleport3
                {
                    player1 = 59;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 43) //Teleport4
                {
                    player1 = 17;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 50) //Teleport5
                {
                    player1 = 5;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 52) //Teleport6
                {
                    player1 = 72;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 56) //Teleport7
                {
                    player1 = 8;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 57) //Teleport8
                {
                    player1 = 96;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 71) //Teleport9
                {
                    player1 = 92;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 73) //Teleport10
                {
                    player1 = 15;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 84) //Teleport11
                {
                    player1 = 63;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 87) //Teleport12
                {
                    player1 = 49;
                    Debug.Log("TELEPORTING!");
                }

                if (player1 == 98) //Teleport13
                {
                    player1 = 40;
                    Debug.Log("TELEPORTING!");
                }

                Debug.Log("You Rolled = " + dice1);
                Debug.Log("Your on tile " + player1 + " player1");

                if (player1 == player2)
                {
                    player2 = 0;
                }

            };

            /////////////////////////////////////////////////////
            if (Input.GetKeyDown(KeyCode.A))
            {
                dice2 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice
                player2 = player2 + dice2;

                if (player2 == 2) //Teleport1
                {
                    player2 = 23;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 6) //Teleport2
                {
                    player2 = 45;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 20) //Teleport3
                {
                    player2 = 59;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 43) //Teleport4
                {
                    player2 = 17;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 50) //Teleport5
                {
                    player2 = 5;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 52) //Teleport6
                {
                    player2 = 72;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 56) //Teleport7
                {
                    player2 = 8;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 57) //Teleport8
                {
                    player2 = 96;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 71) //Teleport9
                {
                    player2 = 92;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 73) //Teleport10
                {
                    player2 = 15;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 84) //Teleport11
                {
                    player2 = 63;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 87) //Teleport12
                {
                    player2 = 49;
                    Debug.Log("TELEPORTING!");
                }

                if (player2 == 98) //Teleport13
                {
                    player2 = 40;
                    Debug.Log("TELEPORTING!");
                }

                Debug.Log("You Rolled = " + dice2);
                Debug.Log("Your on tile " + player2 + " player2");

                if (player2 == player1)
                {
                    player1 = 0;
                }

            };

            //if (player1_number > 39) //check for Pass Go  
            //{ 
            //    player1_number = player1_number - 40; 
            //}


            //            player1_name = array1[player1_number, 0];
            //            player1_cost = array1[player1_number, 4]; //added to fix error below. fixed now?

        } //End of the Space Bar Loop

    };
};
