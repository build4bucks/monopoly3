//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using UnityEngine.UI; //???
//using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace SNL
{

    public class SNL1 : MonoBehaviour
    {

        //create database
        string[,] array1 = new string[100, 4] //array of Monopoly data from the original version of the game
        {

        //Tile / #TypeColorTeleport
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



        //create database
        string[,] array2 = new string[4, 4] //array of Monopoly data from the original version of the game
        {
        { "0","0","0","0"},
        { "0","0","0","0"},
        { "0","0","0","0"},
        { "0","0","0","0"}
        };


        int dice1; //result of dice1 roll
        int turns_counter = 0;
        int player = 1;
        int tile = 1;
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

            if (Input.GetKeyDown(KeyCode.Space)) //Start of Space Bar Loop  
            { // START OF GETKEYDOWN LOOP (SPACE BAR)

                turns_counter = turns_counter + 1;
                dice1 = Random.Range(1, 7); // 1,7 for 6 sided dice

                tile = tile + dice1;

                if (tile == 2) //Teleport1
                {
                    tile = 23;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 6) //Teleport2
                {
                    tile = 45;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 20) //Teleport3
                {
                    tile = 59;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 43) //Teleport4
                {
                    tile = 17;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 50) //Teleport5
                {
                    tile = 5;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 52) //Teleport6
                {
                    tile = 72;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 56) //Teleport7
                {
                    tile = 8;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 57) //Teleport8
                {
                    tile = 96;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 71) //Teleport9
                {
                    tile = 92;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 73) //Teleport10
                {
                    tile = 15;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 84) //Teleport11
                {
                    tile = 63;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 87) //Teleport12
                {
                    tile = 49;
                    Debug.Log("TELEPORTING!");
                }

                if (tile == 98) //Teleport13
                {
                    tile = 40;
                    Debug.Log("TELEPORTING!");
                }

                Debug.Log("You Rolled = " + dice1);
                Debug.Log("Your on tile = " + tile);

                //if (tile_number > 39) //check for Pass Go  
                //{ 
                //    tile_number = tile_number - 40; 
                //}


                //            tile_name = array1[tile_number, 0];
                //            tile_cost = array1[tile_number, 4]; //added to fix error below. fixed now?

            } //End of the Space Bar Loop

        }
    }
}