﻿//###### 2020.10.22 @ 11:00pm ######// 
//###### Level 1 - Dad's Desktop @ Home ######// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Added by Sami to fix convert command 

public class Game : MonoBehaviour
{

    //create database
    string[,] arr2d = new string[40, 18]

    {

//0name1type2color3tile4cost5mortgage6house_price7rent_08rent_19rent_210rent_311rent_412rent_hotel13owner14monopoly15mortgaged16houses17hotels
{"Go","no_type","no_color","0","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Mediterranean Avenue","street","purple","1","60","30","50","2","10","30","90","160","250","bank","FALSE","FALSE","0","0"},
{"Community Chest A","no_type","no_color","2","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Baltic Avenue","street","purple","3","60","30","50","4","20","60","180","320","450","bank","FALSE","FALSE","0","0"},
{"Income Tax","no_type","no_color","4","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Reading RR","railroad","black","5","200","100","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Oriental Avenue","street","lightblue","6","100","50","50","6","30","90","270","400","550","bank","FALSE","FALSE","0","0"},
{"Chance A","no_type","no_color","7","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Vermont Avenue","street","lightblue","8","100","50","50","6","30","90","270","400","550","bank","FALSE","FALSE","0","0"},
{"Connecticut Avenue","street","lightblue","9","120","60","50","8","40","100","300","450","600","bank","FALSE","FALSE","0","0"},
{"Jail","no_type","no_color","10","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"St. Charles Place","street","violet","11","140","70","100","10","50","150","450","625","750","bank","FALSE","FALSE","0","0"},
{"Electric Company","utility","white","12","150","75","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"States Avenue","street","violet","13","140","70","100","10","50","150","450","625","750","bank","FALSE","FALSE","0","0"},
{"Virginia Avenue","street","violet","14","160","80","100","12","60","180","500","700","900","bank","FALSE","FALSE","0","0"},
{"Pennsylvania RR","railroad","black","15","200","100","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"St. James Place","street","orange","16","180","90","100","14","70","200","550","750","950","bank","FALSE","FALSE","0","0"},
{"Community Chest B","no_type","no_color","17","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Tennessee Avenue","street","orange","18","180","90","100","14","70","200","550","750","950","bank","FALSE","FALSE","0","0"},
{"New York Avenue","street","orange","19","200","100","100","16","80","220","600","800","1000","bank","FALSE","FALSE","0","0"},
{"Free Parking","no_type","no_color","20","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Kentucky Avenue","street","red","21","220","110","150","18","90","250","700","875","1050","bank","FALSE","FALSE","0","0"},
{"Chance B","no_type","no_color","22","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Indiana Avenue","street","red","23","220","110","150","18","90","250","700","875","1050","bank","FALSE","FALSE","0","0"},
{"Illinois Avenue","street","red","24","240","120","150","20","100","300","750","925","1100","bank","FALSE","FALSE","0","0"},
{"B&O RR","railroad","black","25","200","100","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Atlantic Avenue","street","yellow","26","260","130","150","22","110","330","800","975","1150","bank","FALSE","FALSE","0","0"},
{"Ventnor Avenue","street","yellow","27","260","130","150","22","110","330","800","975","1150","bank","FALSE","FALSE","0","0"},
{"Water Works","utility","white","28","150","75","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Marvin Gardens","street","yellow","29","280","140","150","24","120","360","850","1025","1200","bank","FALSE","FALSE","0","0"},
{"Go To Jail","no_type","no_color","30","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Pacific Avenue","street","darkgreen","31","300","150","200","26","130","390","900","1100","1275","bank","FALSE","FALSE","0","0"},
{"N. Carolina Avenue","street","darkgreen","32","300","150","200","26","130","390","900","1100","1275","bank","FALSE","FALSE","0","0"},
{"Community Chest C","no_type","no_color","33","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Pennsylvania Avenue","street","darkgreen","34","320","160","200","28","150","450","1000","1200","1400","bank","FALSE","FALSE","0","0"},
{"Short Line RR","railroad","black","35","200","100","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Chance C","no_type","no_color","36","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Park Place","street","darkblue","37","350","175","200","35","175","500","1100","1300","1500","bank","FALSE","FALSE","0","0"},
{"Luxury Tax","no_type","no_color","38","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Boardwalk","street","darkblue","39","400","200","200","50","200","600","1400","1700","2000","bank","FALSE","FALSE","0","0"}
//{"Jailed","no_type","no_color","50","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},

    };

    //create more database 
    int turns_counter; //how many turns played so far by current player 
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

 // Start is called before the first frame update 
    void Start() 
        { 
            jailed = false; 
        }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        { //Start of the D Loop



        } //End of the D Loop

        if (Input.GetKeyDown(KeyCode.M))
        {  //Start of the M Loop  
            Debug.Log("Press M.............MENU");
            Debug.Log("Press SPACE.........ROLL DICE");
            Debug.Log("Press B.............BUY LAND");
            Debug.Log("Press S.............SELL LAND");
            Debug.Log("Press A.............AUCTION LAND");
            Debug.Log("Press T.............TRADE / MODIFIES DB");
            Debug.Log("Press 4.............MORTGAGE LAND");
            Debug.Log("Press 5.............UN-MORTGAGE LAND");
            Debug.Log("Press D.............VIEW ALL LAND OWNERSHIP");
            Debug.Log("Press K.............SHOW GAME STATUS, MONEY, ETC.");
        } //End of the M Loop 


        if (Input.GetKeyDown(KeyCode.T))
        {  //Start of the T Loop
            arr2d[1, 0] = "Sami's Place1"; //Sami
            arr2d[2, 0] = "Jack's Place2"; //Sami
            arr2d[3, 0] = "Sami's Place3"; //Sami
            arr2d[4, 0] = "Jack's Place4"; //Sami
            arr2d[5, 0] = "Sami's Place5"; //Sami
            arr2d[6, 0] = "Jack's Place6"; //Sami
            arr2d[7, 0] = "Sami's Place7"; //Sami
            arr2d[8, 0] = "Jack's Place8"; //Sami
            arr2d[9, 0] = "Sami's Place9"; //Sami
            arr2d[10, 0] = "Jack's Place10"; //Sami
            //Debug.Log("TEST=" + arr2d[tile_number, 16]);

            Debug.Log("tile1_name=" + arr2d[1, 0]);
            Debug.Log("tile2_name=" + arr2d[2, 0]);
            Debug.Log("tile3_name=" + arr2d[3, 0]);
            Debug.Log("tile4_name=" + arr2d[4, 0]);
            Debug.Log("tile5_name=" + arr2d[5, 0]);
            Debug.Log("tile6_name=" + arr2d[6, 0]);
            Debug.Log("tile7_name=" + arr2d[7, 0]);
            Debug.Log("tile8_name=" + arr2d[8, 0]);
            Debug.Log("tile9_name=" + arr2d[9, 0]);
            Debug.Log("tile10_name=" + arr2d[10, 0]);
            //arr2d[tile_number, 16] = "hello"; //Sami
            //Debug.Log("TEST=" + arr2d[tile_number, 16]);

        } //End of the T Loop

        //if (Input.GetKeyDown(KeyCode.Keypad1)) //stopped working in Unity 2020, Why?
        // The Start of the 1 Loop
        if (Input.GetKeyDown(KeyCode.B))
        { //Start of the B Loop

            tile_name = arr2d[tile_number, 0];
            tile_cost = arr2d[tile_number, 4];
            Debug.Log("tile_name=" + tile_name);
            Debug.Log("tile_cost=" + tile_cost);
            tile_cost_i = Convert.ToInt16(tile_cost);
            Debug.Log("before purchase");
            Debug.Log("money_banker=" + money_banker);
            Debug.Log("money_player1=" + money_player1);
            Debug.Log("money_player2=" + money_player2);
            Debug.Log("money_all=" + money_all);
            Debug.Log("before owner=" + arr2d[tile_number, 13]);
                
            money_player1 = money_player1 - tile_cost_i;
            money_banker = money_banker + tile_cost_i;
            money_all = money_banker + money_player1 + money_player2;
            arr2d[tile_number, 13] = "playerX"; //Sami

            Debug.Log("after owner=" + arr2d[tile_number, 13]);
            Debug.Log("after purchase");
            Debug.Log("money_banker=" + money_banker);
            Debug.Log("money_player1=" + money_player1);
            Debug.Log("money_player2=" + money_player2);
            Debug.Log("money_all=" + money_all);
            //tile_data2 = Convert.ToInt32("100"); 
        } //End of the B Loop 

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

        if (Input.GetKeyDown(KeyCode.Space)) //Start of Space Bar Loop  
            { // START OF GETKEYDOWN LOOP (SPACE BAR)
        
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


                tile_name = arr2d[tile_number, 0];
                tile_cost = arr2d[tile_number, 4]; //added to fix error below. fixed now?

                Debug.Log("1. turns_counter=" + turns_counter);
                Debug.Log("2. dice1=" + dice1 + " dice2=" + dice2 + " dice_total=" + dice_total);
                Debug.Log("3. doubles=" + doubles + " doubles_counter=" + doubles_counter);
                Debug.Log("4a. tile_number=" + tile_number + " tile_name=" + tile_name);
                Debug.Log("4b. tile_number=" + tile_number + " tile_cost=" + tile_cost); //error?
                Debug.Log("5. jailed=" + jailed);

                Debug.Log("/////////////////////");  
            } //End of the Space Bar Loop
    } 
}

