﻿//### 2020.11.02 @2:15pm ###//
//### Level 1 - Dad's Desktop @ Office ###//
//### updated array notes, fixed {} alignments on multiple loops ###//

//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using UnityEngine.UI; //???
//using System.Runtime.InteropServices;
//using System.Diagnostics;

using UnityEngine;
using System; //Added by Sami to fix 'convert' command @ ~ line # 214

namespace MNPLY
{

    public class M_Main : MonoBehaviour
    {

        //array1 was located here...
        //array1 now located @ M_Data.array3

        //array2 was located here...
        //array2 now located @ M_Data.array3

        //array3 was located here...
        //array3 now located @ M_Data.array3

        //create more database type items 
        int dice1; //result of dice1 roll 
        int dice2; //result of dice2 roll 
        int dice_total; //result of adding dice1 + dice2 
        int doubles_counter; //keeps track of consecutive doubles  
                             //int tile_number; //keeps track of consecutive doubles  
        int tile_number; //Where are you on the game board  
        string tile_name; //Name info from DB about the tile you're on   
        string tile_cost; //Cost info from DB about the tile you're on  
        int tile_cost_i; //Cost info (adjusted) from DB about the tile you're on 
        bool jailed = false; //JK, is player currently in jail? True / False 
        bool doubles = false; //if dice1 = dice2 
        int money_player1 = 1500;
        int money_player2 = 1500;
        int money_banker = 9000;
        int money_all = 12000;
        int auction_money;
        bool auction_active = false; //if the auction is still going
        bool bidder_player1_active = false;
        bool bidder_player2_active = false;
        bool bidder_player3_active = false;
        int cupsInTheSink = 10;
        string str1;
        string str2;
        string str3;
        bool toggle1 = false;
        bool toggle2 = false;
        bool toggle3 = false;
        int turn = 0;
        int turns_counter; //how many turns played so far by current player 

        //string customText;
        //rect = new Rect(0, 0, 400, 200);

        // Start is called before the first frame update 
        void Start()
        {
            jailed = false;
        }

        void OnGUI()
        {

            GUI.Box(new Rect(300, 200, 200, 90), M_Data.array1[1, 0].ToString());
            //GUI.Box(new Rect(300, 300, 100, 90), str.ToString());

            //if (Time.time < 10)
            if (toggle1 == true)
            {
                GUIStyle style = new GUIStyle();
                style.richText = true;
                GUILayout.Label("<size=16><color=yellow>"
                            + str1 +
                            "</color></size>", style);
            }

            if (toggle2 == true)
            {
                GUIStyle style = new GUIStyle();
                style.richText = true;
                GUILayout.Label("<size=16><color=yellow>"
                            + str2 +
                            "</color></size>", style);
            }

            if (toggle3 == true)
            {
                GUIStyle style = new GUIStyle();
                style.richText = true;
                GUILayout.Label("<size=16><color=yellow>"
                            + str3 +
                            "</color></size>", style);
            }

            if (GUI.Button(new Rect(250, 50, 75, 20), "Inventory"))
            {
                //Debug.Log("Your inventory opens");
                GUI.Box(new Rect(400, 10, 300, 200), "Inventory");
            }

        }

        // Update is called once per frame 
        void Update()
        {
            //KeyCode.P was here...


            void BuyLand()
            {
                tile_name = M_Data.array1[tile_number, 0];
                tile_cost = M_Data.array1[tile_number, 4];
                Debug.Log("tile_name=" + tile_name);
                Debug.Log("tile_cost=" + tile_cost);
                tile_cost_i = Convert.ToInt16(tile_cost);
                Debug.Log("before purchase");
                Debug.Log("money_banker=" + money_banker);
                Debug.Log("money_player1=" + money_player1);
                Debug.Log("money_player2=" + money_player2);
                Debug.Log("money_all=" + money_all);
                Debug.Log("before owner=" + M_Data.array1[tile_number, 13]);

                money_player1 = money_player1 - tile_cost_i;
                money_banker = money_banker + tile_cost_i;
                money_all = money_banker + money_player1 + money_player2;
                M_Data.array1[tile_number, 13] = "playerX"; //Sami

                Debug.Log("after owner=" + M_Data.array1[tile_number, 13]);
                Debug.Log("after purchase");
                Debug.Log("money_banker=" + money_banker);
                Debug.Log("money_player1=" + money_player1);
                Debug.Log("money_player2=" + money_player2);
                Debug.Log("money_all=" + money_all);
            }

            void Check4monopolies()
            {
                int monopolies_counter = 0;

                //START OF CHECKING FOR monopoly1
                string monopolies1_owner = "";
                Debug.Log("CHECKING FOR DARK PURPLE monopolies...");
                if ((M_Data.array1[1, 13] == M_Data.array1[3, 13])
                    && (M_Data.array1[1, 13] != "bank5"))
                {
                    M_Data.array2[0, 1] = "True"; //Always x,1
                    monopolies1_owner = M_Data.array1[6, 13];
                    M_Data.array2[0, 2] = monopolies1_owner; //Always x,2
                    Debug.Log("You have a DARK PURPLE monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a DARK PURPLE monopoly!");
                }
                //END OF CHECKING FOR monopoly1

                //START OF CHECKING FOR monopoly2
                string monopolies2_owner = "";
                Debug.Log("CHECKING FOR LIGHT BLUE monopolies...");
                if ((M_Data.array1[6, 13] == M_Data.array1[8, 13])
                    && (M_Data.array1[8, 13] == M_Data.array1[9, 13])
                    && (M_Data.array1[6, 13] != "bank5"))
                {
                    M_Data.array2[1, 1] = "True"; //Always x,1
                    monopolies2_owner = M_Data.array1[6, 13];
                    M_Data.array2[1, 2] = monopolies2_owner; //Always x,2
                    Debug.Log("You have a LIGHT BLUE monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a LIGHT BLUE monopoly!");
                }
                //END OF CHECKING FOR monopoly2

                //START OF CHECKING FOR monopoly3
                string monopolies3_owner = "";
                Debug.Log("CHECKING FOR LIGHT PURPLE monopolies...");
                if ((M_Data.array1[11, 13] == M_Data.array1[13, 13])
                    && (M_Data.array1[13, 13] == M_Data.array1[14, 13])
                    && (M_Data.array1[11, 13] != "bank5"))
                {
                    M_Data.array2[2, 1] = "True"; //Always x,1
                    monopolies3_owner = M_Data.array1[11, 13];
                    M_Data.array2[2, 2] = monopolies3_owner; //Always x,2
                    Debug.Log("You have a LIGHT PURPLE monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a LIGHT PURPLE monopoly!");
                }
                //END OF CHECKING FOR monopoly3

                //START OF CHECKING FOR monopoly4
                string monopolies4_owner = "";
                Debug.Log("CHECKING FOR ORANGE monopolies...");
                if ((M_Data.array1[13, 13] == M_Data.array1[15, 13])
                    && (M_Data.array1[15, 13] == M_Data.array1[16, 13])
                    && (M_Data.array1[13, 13] != "bank5"))
                {
                    M_Data.array2[3, 1] = "True"; //Always x,1
                    monopolies4_owner = M_Data.array1[13, 13];
                    M_Data.array2[3, 2] = monopolies4_owner; //Always x,2
                    Debug.Log("You have a ORANGE monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a ORANGE monopoly!");
                }
                //END OF CHECKING FOR monopoly4

                //START OF CHECKING FOR monopoly5
                string monopolies5_owner = "";
                Debug.Log("CHECKING FOR RED monopolies...");
                if ((M_Data.array1[21, 13] == M_Data.array1[23, 13])
                    && (M_Data.array1[23, 13] == M_Data.array1[24, 13])
                    && (M_Data.array1[21, 13] != "bank5"))
                {
                    M_Data.array2[4, 1] = "True"; //Always x,1
                    monopolies5_owner = M_Data.array1[21, 13];
                    M_Data.array2[4, 2] = monopolies5_owner; //Always x,2
                    Debug.Log("You have a RED monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a RED monopoly!");
                }
                //END OF CHECKING FOR monopoly5

                //START OF CHECKING FOR monopoly6
                string monopolies6_owner = "";
                Debug.Log("CHECKING FOR YELLOW monopolies...");
                if ((M_Data.array1[26, 13] == M_Data.array1[27, 13])
                    && (M_Data.array1[27, 13] == M_Data.array1[29, 13])
                    && (M_Data.array1[26, 13] != "bank5"))
                {
                    M_Data.array2[5, 1] = "True"; //Always x,1
                    monopolies6_owner = M_Data.array1[26, 13];
                    M_Data.array2[5, 2] = monopolies6_owner; //Always x,2
                    Debug.Log("You have a YELLOW monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a YELLOW monopoly!");
                }
                //END OF CHECKING FOR monopoly6

                //START OF CHECKING FOR monopoly7
                string monopolies7_owner = "";
                Debug.Log("CHECKING FOR GREEN monopolies...");
                if ((M_Data.array1[31, 13] == M_Data.array1[32, 13])
                    && (M_Data.array1[32, 13] == M_Data.array1[34, 13])
                    && (M_Data.array1[31, 13] != "bank5"))
                {
                    M_Data.array2[6, 1] = "True"; //Always x,1
                    monopolies7_owner = M_Data.array1[31, 13];
                    M_Data.array2[6, 2] = monopolies7_owner; //Always x,2
                    Debug.Log("You have a GREEN monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a GREEN monopoly!");
                }
                //END OF CHECKING FOR monopoly7

                //START OF CHECKING FOR monopoly8
                string monopolies8_owner = "";
                Debug.Log("CHECKING FOR DARK BLUE monopolies...");
                if ((M_Data.array1[37, 13] == M_Data.array1[39, 13])
                    && (M_Data.array1[37, 13] != "bank5"))
                {
                    M_Data.array2[7, 1] = "True"; //Always x,1
                    monopolies8_owner = M_Data.array1[37, 13];
                    M_Data.array2[7, 2] = monopolies8_owner; //Always x,2
                    Debug.Log("You have a DARK BLUE monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a DARK BLUE monopoly!");
                }
                //END OF CHECKING FOR monopoly8

                //START OF CHECKING FOR monopoly9
                string monopolies9_owner = "";
                Debug.Log("CHECKING FOR UTILITIES monopolies...");
                if ((M_Data.array1[12, 13] == M_Data.array1[28, 13])
                    && (M_Data.array1[12, 13] != "bank5"))
                {
                    M_Data.array2[8, 1] = "True"; //Always x,1
                    monopolies9_owner = M_Data.array1[37, 13];
                    M_Data.array2[8, 2] = monopolies9_owner; //Always x,2
                    Debug.Log("You have a UTILITIES monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a UTILITIES monopoly!");
                }
                //END OF CHECKING FOR monopoly9

                //START OF CHECKING FOR monopoly10
                string monopolies10_owner = "";
                Debug.Log("CHECKING FOR RAILROADS monopolies...");
                if ((M_Data.array1[5, 13] == M_Data.array1[15, 13])
                    && (M_Data.array1[15, 13] == M_Data.array1[25, 13])
                    && (M_Data.array1[25, 13] == M_Data.array1[35, 13])
                    && (M_Data.array1[5, 13] != "bank5"))
                {
                    M_Data.array2[9, 1] = "True"; //Always x,1
                    monopolies10_owner = M_Data.array1[37, 13];
                    M_Data.array2[9, 2] = monopolies10_owner; //Always x,2
                    Debug.Log("You have a RAILROADS monopoly!");
                    monopolies_counter = monopolies_counter + 1;
                }
                else
                {
                    Debug.Log("You DO NOT have a RAILROADS monopoly!");
                }
                //END OF CHECKING FOR monopoly 10

                Debug.Log("monopolies_counter = " + monopolies_counter);
            }

            if (Input.GetKeyDown(KeyCode.B))
            { //Start of the B Loop

                BuyLand();
                Check4monopolies();

                //tile_data2 = Convert.ToInt32("100"); 
            } //End of the B Loop

            if (Input.GetKeyDown(KeyCode.K))
            { //Start of the K Loop  
                Debug.Log("K1. turns_counter=" + turns_counter);
                Debug.Log("K2. dice1=" + dice1 + " dice2=" + dice2 + " dice_total=" + dice_total);
                Debug.Log("K3. doubles=" + doubles + " doubles_counter=" + doubles_counter);
                Debug.Log("K4a. tile_number=" + tile_number + " tile_name=" + tile_name);
                Debug.Log("K4b. tile_number=" + tile_number + " tile_cost=" + tile_cost);
                Debug.Log("K5. jailed=" + jailed);
                Debug.Log("K6. money_banker=" + money_banker);
                Debug.Log("K7. money_player1=" + money_player1);
                Debug.Log("K8. money_player2=" + money_player2);
                Debug.Log("K/////////////////////");

            } // End of the K Loop

            if (Input.GetKeyDown(KeyCode.D))
            { //Start of the D Loop

                Debug.Log("0,0=" + M_Data.array2[0, 0]);
                Debug.Log("0,1=" + M_Data.array2[0, 1]);
                Debug.Log("0,2=" + M_Data.array2[0, 2]);
                Debug.Log("1,0=" + M_Data.array2[1, 0]);
                Debug.Log("1,1=" + M_Data.array2[1, 1]);
                Debug.Log("1,2=" + M_Data.array2[1, 2]);

            } //End of the D Loop



            if (Input.GetKeyDown(KeyCode.Z))
            { //Start of the Z Loop
                for (int i = 0; i < 4; i++) //(rows) tiles
                {
                    for (int j = 0; j < 4; j++) //(columns) info on each tile
                    {
                        str3 = str3 + M_Data.array3[i, j] + " ";
                    }
                    str3 = str3 + "\n";
                }

                toggle3 = true;

            } //End of the Z Loop

            void ShowArray3()
            //if (Input.GetKeyDown(KeyCode.Z))
            { //Start of the Z Loop
                for (int i = 0; i < 4; i++) //(rows) tiles
                {
                    for (int j = 0; j < 4; j++) //(columns) info on each tile
                    {
                        str3 = str3 + M_Data.array3[i, j] + " ";
                    }
                    str3 = str3 + "\n";
                }

                toggle3 = true;

            } //End of the Z Loop

            if (Input.GetKeyDown(KeyCode.X))
            { //Start of the X Loop
                for (int i = 0; i < 11; i++) //(rows) tiles
                {
                    for (int j = 0; j < 3; j++) //(columns) info on each tile
                    {
                        str2 = str2 + M_Data.array2[i, j] + " ";
                    }
                    str2 = str2 + "\n";
                }

                toggle2 = true;

            } //End of the X Loop

            if (Input.GetKeyDown(KeyCode.C))
            { //Start of the C Loop
                for (int i = 0; i < 40; i++) //(rows) tiles
                {
                    for (int j = 0; j < 18; j++) //(columns) info on each tile
                    {
                        str1 = str1 + M_Data.array1[i, j] + " ";
                    }
                    str1 = str1 + "\n";
                }

                toggle1 = true;

            } //End of the C Loop

            void ClearScreenGUI()  //clear GUI
                                   //if (Input.GetKeyDown(KeyCode.V))
            { //Start of the V Loop
                str1 = "";
                str2 = "";
                str3 = "";
                toggle1 = false;
                toggle2 = false;
                toggle3 = false;

            } //End of the V Loop

            if (Input.GetKeyDown(KeyCode.V))
            { //Start of the V Loop
                str1 = "";
                str2 = "";
                str3 = "";
                toggle1 = false;
                toggle2 = false;
                toggle3 = false;

            } //End of the V Loop

            //KeyCode.M was here...

            if (Input.GetKeyDown(KeyCode.T))
            {  //Start of the T Loop
                M_Data.array1[1, 0] = "Sami's Place1"; //Sami
                M_Data.array1[2, 0] = "Jack's Place2"; //Sami
                M_Data.array1[3, 0] = "Sami's Place3"; //Sami
                M_Data.array1[4, 0] = "Jack's Place4"; //Sami
                M_Data.array1[5, 0] = "Sami's Place5"; //Sami
                M_Data.array1[6, 0] = "Jack's Place6"; //Sami
                M_Data.array1[7, 0] = "Sami's Place7"; //Sami
                M_Data.array1[8, 0] = "Jack's Place8"; //Sami
                M_Data.array1[9, 0] = "Sami's Place9"; //Sami
                M_Data.array1[10, 0] = "Jack's Place10"; //Sami
                                                  //Debug.Log("TEST=" + M_Data.array1[tile_number, 16]);

                Debug.Log("tile1_name=" + M_Data.array1[1, 0]);
                Debug.Log("tile2_name=" + M_Data.array1[2, 0]);
                Debug.Log("tile3_name=" + M_Data.array1[3, 0]);
                Debug.Log("tile4_name=" + M_Data.array1[4, 0]);
                Debug.Log("tile5_name=" + M_Data.array1[5, 0]);
                Debug.Log("tile6_name=" + M_Data.array1[6, 0]);
                Debug.Log("tile7_name=" + M_Data.array1[7, 0]);
                Debug.Log("tile8_name=" + M_Data.array1[8, 0]);
                Debug.Log("tile9_name=" + M_Data.array1[9, 0]);
                Debug.Log("tile10_name=" + M_Data.array1[10, 0]);
                //M_Data.array1[tile_number, 16] = "hello"; //Sami
                //Debug.Log("TEST=" + M_Data.array1[tile_number, 16]);

            } //End of the T Loop

            //if (Input.GetKeyDown(KeyCode.Keypad1)) //stopped working in Unity 2020, Why?
            // The Start of the 1 Loop


            if (Input.GetKeyDown(KeyCode.Keypad3))
            {  //Start of the 3 Loop 
                auction_active = true;
                bidder_player1_active = true;
                bidder_player2_active = true;
                bidder_player3_active = true;

                {
                    Debug.Log("I've washed a cup! current cupsInTheSink: " + cupsInTheSink);
                    cupsInTheSink--;
                }

                //int auction_money; 
                //bool auction_active = false; //if the auction is still going 
                //bool bidder_player1_active = false; 
                //bool bidder_player2_active = false; 
                //bool bidder_player3_active = false; 
            } //End of the 3 Loop 

            //RollDice method was located here...

            void RollDice()
            {

                //if (Input.GetKeyDown(KeyCode.Space)) //Start of Space Bar Loop  
                //{ // START OF GETKEYDOWN LOOP (SPACE BAR)

                //tile_number = Convert.ToInt16(M_Data.array3[turn, 1]); //tells us where is player now!
                cupsInTheSink = cupsInTheSink + 10;
                doubles = false;
                turns_counter = turns_counter + 1;
                dice1 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice
                dice2 = UnityEngine.Random.Range(1, 7); // 1,7 for 6 sided dice
                dice_total = dice1 + dice2;

                //if ( tile_number == 10 && jailed == true) //JK 
                if (jailed == false) //JK 
                { //JK 
                    tile_number = tile_number + dice_total;
                } //JK 

                if (dice1 == dice2) //check for doubles 
                {
                    doubles = true;
                    jailed = false; //JK 
                    //Debug.Log("DOUBLES!"); 
                    doubles_counter = doubles_counter + 1;
                    //Debug.Log("doubles_counter=" + doubles_counter); 

                    if (doubles_counter == 3) //GO TO JAIL     
                    {
                        Debug.Log("GO TO JAIL!");
                        jailed = false;
                        //JK (leave at false for now)
                        //until we have a way to get out of jail
                        //for now jailed is always false, until we allow for jail releases
                        //via doubles, $50 fine or Get Out Of Jail Free card
                        doubles_counter = 0;
                        tile_number = 10;
                    }
                }

                if (tile_number == 30) //GO TO JAIL (this checks AFTER doubles check) 
                {
                    tile_number = 10;
                    jailed = false;
                    //JK (leave at false for now)
                    //until we have a way to get out of jail
                    //for now jailed is always false, until we allow for jail releases
                    //via doubles, $50 fine or Get Out Of Jail Free card
                }

                if (tile_number > 39) //check for Pass Go  
                {
                    tile_number = tile_number - 40;
                }


                tile_name = M_Data.array1[tile_number, 0];
                tile_cost = M_Data.array1[tile_number, 4]; //added to fix error below. fixed now?

                Debug.Log("1. turns_counter=" + turns_counter);
                Debug.Log("2. dice1=" + dice1 + " dice2=" + dice2 + " dice_total=" + dice_total);
                Debug.Log("3. doubles=" + doubles + " doubles_counter=" + doubles_counter);
                Debug.Log("4a. tile_number=" + tile_number + " tile_name=" + tile_name);
                Debug.Log("4b. tile_number=" + tile_number + " tile_cost=" + tile_cost); //error?
                Debug.Log("5. jailed=" + jailed);

                Debug.Log("/////////////////////");
                //} //End of the Space Bar Loop

                turn = turn + 1;
                if (turn == 3)
                {
                    turn = 1;
                }

            }


            if (Input.GetKeyDown(KeyCode.A)) //Start of A Loop  
            { // START OF GETKEYDOWN LOOP (A)

                ClearScreenGUI();
                //tile = Convert.ToInt16(M_Data.array3[turn, 1]); //this should be moved here
                tile_number = Convert.ToInt16(M_Data.array3[0, 1]);
                Debug.Log("BEFORE M_Data.array3[0,1] = " + M_Data.array3[0, 1]);
                RollDice();
                M_Data.array3[0, 1] = tile_number.ToString(); //add string data
                //M_Data.array3[0, 1] = "A"; //add string data
                Debug.Log("Player --A-- Rolled the Dice");
                Debug.Log("AFTER M_Data.array3[0,1] = " + M_Data.array3[0, 1]);
                ShowArray3();

            } //End of the A Loop

            if (Input.GetKeyDown(KeyCode.L)) //Start of L Loop  
            { // START OF GETKEYDOWN LOOP (L)

                ClearScreenGUI();
                //tile = Convert.ToInt16(M_Data.array3[turn, 1]); //this should be moved here
                tile_number = Convert.ToInt16(M_Data.array3[1, 1]);
                Debug.Log("BEFORE M_Data.array3[1,1] = " + M_Data.array3[1, 1]);
                RollDice();
                M_Data.array3[1, 1] = tile_number.ToString(); //add string data
                //M_Data.array3[1, 1] = tile.ToString(); //add string data
                //M_Data.array3[1, 1] = "L"; //add string data
                Debug.Log("Player --L-- Rolled the Dice");
                Debug.Log("AFTER M_Data.array3[1,1] = " + M_Data.array3[1, 1]);
                ShowArray3();

            } //End of the L Loop
        }
    }

}