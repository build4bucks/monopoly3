//###### 2020.10.12 @ 5:00pm ######// 
//###### Level 1 - Jackson's Laptop @ Office ######// 
//########## 2020.10.10 @ 9:11pm - Level 1 ##########// 
//create database string[,] arr2d = new string[40, 13]
//########## Next To Do - Work on M Loop ##########// 
//########## Level 1 - Sami's Desktop @ Home ##########//
//########## 10/16/2020 Test Add By RK, Sami & Jack ##########// 
//########## 10/16/2020 Test Add from Sami's computer ##########//
//########## 10/16/2020 Test Add #2 from Sami's web browser ##########//
//########## 10/16/2020 Test Add #1 from Dad's computer via notepad++ ##########//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Added by Sami to fix convert command 

public class Game : MonoBehaviour
{

    //create database
    string[,] arr2d = new string[40, 13] 
    {
//{"name","type","color","tile_number","cost","mortgage","house_price" ,"rent_0","rent_1","rent_2","rent_3","rent_4","rent_hotel"}, 
{"Go","","","0","","","","","","","","",""}, 
{"Mediterranean","street","purple","1","60","30","50","2","10","30","9 0","160","250"},
{"Community Chest A","","","2","","","","","","","","",""},
{"Baltic","street","purple","3","60","30","50","4","20","60","180","32 0","450"},
{"Income Tax","","","4","","","","","","","","",""},
{"Reading RR","railroad","","5","200","100","","","","","","",""}, 
{"Oriental","street","lightblue","6","100","50","50","6","30","90","27 0","400","550"},
{"Chance A","","","7","0","","","","","","","",""},
{"Vermont","street","lightblue","8","100","50","50","6","30","90","270 ","400","550"},
{"Connecticut","street","lightblue","9","120","60","50","8","40","100" ,"300","450","600"},
{"Jail","","","10","","","","","","","","",""},
{"St. Charles","street","violet","11","140","70","100","10","50","150","450" ,"625","750"}, 
{"Electric Company","utility","","12","150","75","","","","","","",""},
{"States","street","violet","13","140","70","100","10","50","150","450 ","625","750"}, 
{"Virginia","street","violet","14","160","80","100","12","60","180","5 00","700","900"},
{"Pennsylvania RR","railroad","","15","200","100","","","","","","",""},
{"St.James","street","orange","16","180","90","100","14","70","200","550"," 750","950"}, 
{"Community Chest B","","","17","","","","","","","","",""},
{"Tennessee","street","orange","18","180","90","100","14","70","200"," 550","750","950"},
{"New York","street","orange","19","200","100","100","16","80","220","600"," 800","1000"}, 
{"Free Parking","","","20","","","","","","","","",""},
{"Kentucky","street","red","21","220","110","150","18","90","250","700 ","875","1050"},
{"Chance B","","","22","0","","","","","","","",""},
{"Indiana","street","red","23","220","110","150","18","90","250","700" ,"875","1050"},
{"Illinois","street","red","24","240","120","150","20","100","300","75 0","925","1100"},
{"B&O RR","railroad","","25","200","100","","","","","","",""},
{"Atlantic","street","yellow","26","260","130","150","22","110","330", "800","975","1150"},
{"Ventnor","street","yellow","27","260","130","150","22","110","330"," 800","975","1150"},
{"Water Works","utility","","28","150","75","","","","","","",""},
{"Marvin Gardens","street","yellow","29","280","140","150","24","120","360","85 0","1025","1200"}, 
{"Go To Jail","","","30","","","","","","","","",""},
{"Pacific","street","darkgreen","31","300","150","200","26","130","390 ","900","1100","1275"},
{"N. Carolina","street","darkgreen","32","300","150","200","26","130","390" ,"900","1100","1275"}, 
{"Community Chest C","","","33","","","","","","","","",""},
{"Pennsylvania","street","darkgreen","34","320","160","200","28","150" ,"450","1000","1200","1400"},
{"Short Line RR","railroad","","35","200","100","","","","","","",""},
{"Chance C","","","36","0","","","","","","","",""},
{"Park Place","street","darkblue","37","350","175","200","35","175","500","11 00","1300","1500"}, 
{"Luxury Tax","","","38","","","","","","","","",""},
{"Boardwalk","street","darkblue","39","400","200","200","50","200","60 0","1400","1700","2000"}
//{"Jailed","","","50","","","","","","","","",""}, 
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

        //if (Input.GetKeyDown(KeyCode.Keypad1)) // The Start of the 1 Loop
            if (Input.GetKeyDown(KeyCode.B)) // The Start of the B Loop
            {
                Debug.Log("hello");
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
                money_player1 = money_player1 - tile_cost_i;
                money_banker = money_banker + tile_cost_i;
                money_all = money_banker + money_player1 + money_player2;
                Debug.Log("after purchase");
                Debug.Log("money_banker=" + money_banker);
                Debug.Log("money_player1=" + money_player1);
                Debug.Log("money_player2=" + money_player2);
                Debug.Log("money_all=" + money_all);
                //tile_data2 = Convert.ToInt32("100"); 
            } // The End of the B Loop 

        if (Input.GetKeyDown(KeyCode.Keypad3)) // The Start of the 3 Loop 
            {
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
            } // The End of the 3 Loop 

        if (Input.GetKeyDown(KeyCode.K)) // The Start of the K Loop  
            { // START OF GETKEYDOWN LOOP (K KEY) 
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
            } // END OF GETKEYDOWN LOOP (K KEY)

        if (Input.GetKeyDown(KeyCode.M)) // The Start of the M Loop  
            { 
                Debug.Log("Menu");
                Debug.Log("Press 1 to Buy Land");
                Debug.Log("Press 2 to Sell Land");
                Debug.Log("Press 3 to Auction Land");
                Debug.Log("Press 4 to Mortgage Land");
                Debug.Log("Press 5 to Un-Mortgage Land"); 
                Debug.Log("Press 6 to View All Land Ownership");  
            } // The End of the M Loop 

        if (Input.GetKeyDown(KeyCode.Space)) // The Space Bar Loop  
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
            } // END OF GETKEYDOWN LOOP (SPACE BAR) 
    } 
}

