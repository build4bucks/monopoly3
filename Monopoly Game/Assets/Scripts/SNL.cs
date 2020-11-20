//########## Sami & Jack ##########
//########## 11.14.20 4:00pm ##########
//########## Jacky's Desktop ##########


using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI; //???
using System.Runtime.InteropServices;
using UnityEngine;

public class SLN : MonoBehaviour
{

    //create database
    string[,] array1 = new string[100, 4] //array of Monopoly data from the original version of the game
    {

        //Tile / #TypeColorTeleport
        {"Go!","None","Red","0"},
        { "2","Bottom","Dark Yellow","23"},
        { "3","None","Red","0"},
        { "4","None","Blue","0"},
        { "5","Tail","Green","0"},
        { "6","Bottom","Yellow","45"},
        { "7","None","Dark Yellow","0"},
        { "8","Tail","Red","0"},
        { "9","None","Blue","0"},
        { "10","None","Green","0"},
        { "11","None","Red","0"},
        { "12","None","Dark Yellow","0"},
        { "13","None","Yellow","0"},
        { "14","None","Green","0"},
        { "15","Tail","Blue","0"},
        { "16","None","Red","0"},
        { "17","Tail","Dark Yellow","0"},
        { "18","None","Yellow","0"},
        { "19","None","Green","0"},
        { "20","Bottom","Blue","59"},
        { "21","None","Dark Yellow","0"},
        { "22","None","Red","0"},
        { "23","Top","Blue","0"},
        { "24","None","Green","0"},
        { "25","None","Yellow","0"},
        { "26","None","Dark Yellow","0"},
        { "27","None","Red","0"},
        { "28","None","Blue","0"},
        { "29","None","Green","0"},
        { "30","None","Yellow","0"},
        { "31","None","Blue","0"},
        { "32","None","Red","0"},
        { "33","None","Dark Yellow","0"},
        { "34","None","Yellow","0"},
        { "35","None","Green","0"},
        { "36","None","Blue","0"},
        { "37","None","Red","0"},
        { "38","None","Dark Yellow","0"},
        { "39","None","Yellow","0"},
        { "40","Tail","Green","0"},
        { "41","None","Red","0"},
        { "42","None","Blue","0"},
        { "43","Head","Green","17"},
        { "44","None","Yellow","0"},
        { "45","Top","Dark Yellow","0"},
        { "46","None","Red","0"},
        { "47","None","Blue","0"},
        { "48","None","Green","0"},
        { "49","Tail","Yellow","0"},
        { "50","Head","Dark Yellow","5"},
        { "51","None","Green","0"},
        { "52","Bottom","Blue","72"},
        { "53","None","Red","0"},
        { "54","None","Dark Yellow","0"},
        { "55","None","Orange","0"},
        { "56","Head","Green","8"},
        { "57","Bottom","Blue","96"},
        { "58","None","Red","0"},
        { "59","Top","Dark Yellow","0"},
        { "60","None","Yellow","0"},
        { "61","None","Blue","0"},
        { "62","None","Green","0"},
        { "63","Tail","Yellow","0"},
        { "64","None","Dark Yellow","0"},
        { "65","None","Orange","0"},
        { "66","None","Blue","0"},
        { "67","None","Green","0"},
        { "68","None","Yellow","0"},
        { "69","None","Dark Yellow","0"},
        { "70","None","Red","0"},
        { "71","Bottom","Yellow","92"},
        { "72","Top","Green","0"},
        { "73","Head","Blue","15"},
        { "74","None","Red","0"},
        { "75","None","Dark Yellow","0"},
        { "76","None","Yellow","0"},
        { "77","None","Green","0"},
        { "78","None","Blue","0"},
        { "79","None","Red","0"},
        { "80","None","Dark Yellow","0"},
        { "81","None","Green","0"},
        { "82","None","Yellow","0"},
        { "83","None","Dark Yellow","0"},
        { "84","Head","Red","63"},
        { "85","None","Blue","0"},
        { "86","None","Green","0"},
        { "87","Head","Yellow","49"},
        { "88","None","Dark Yellow","0"},
        { "89","None","Red","0"},
        { "90","None","Blue","0"},
        { "91","None","Dark Yellow","0"},
        { "92","Top","Yellow","0"},
        { "93","None","Green","0"},
        { "94","None","Blue","0"},
        { "95","None","Red","0"},
        { "96","None","Dark Yellow","0"},
        { "97","None","Yellow","0"},
        { "98","Head","Green","40"},
        { "99","None","Dark Yellow","0"},
        { "Winner!","Done","Red","0"},
    };

    int dice1; //result of dice1 roll 
               //    int dice2; //result of dice2 roll
    int turns_counter;

    void Start()
    {

    }


    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Start of Space Bar Loop  
        { // START OF GETKEYDOWN LOOP (SPACE BAR)

            //            
            //            
            turns_counter = turns_counter + 1;
            dice1 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice
                                                    //            dice2 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice

            //            if (player = 2) //Teleport
            //            {
            //                tile_number = 23;
            //            }

            //            if (tile_number > 39) //check for Pass Go  
            //            { 
            //                tile_number = tile_number - 40; 
            //            }


            //            tile_name = array1[tile_number, 0];
            //            tile_cost = array1[tile_number, 4]; //added to fix error below. fixed now?

            //            Debug.Log("1. turns_counter=" + turns_counter);
            //            Debug.Log("2. dice1=" + dice1 + " dice2=" + dice2 + " dice_total=" + dice_total);
            //            Debug.Log("3. doubles=" + doubles + " doubles_counter=" + doubles_counter);
            //            Debug.Log("4a. tile_number=" + tile_number + " tile_name=" + tile_name);
            //            Debug.Log("4b. tile_number=" + tile_number + " tile_cost=" + tile_cost); //error?
            //            Debug.Log("5. jailed=" + jailed);

            //            Debug.Log("/////////////////////");  
            //        } //End of the Space Bar Loop
        }
    }
}

