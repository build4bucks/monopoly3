//### 2020.11.02 @2:15pm ###//
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

public class Monopoly : MonoBehaviour
{

    //create database
    string[,] array1 = new string[40, 18] //array of Monopoly data from the original version of the game
    {

//0name1type2color3tile4cost5mortgage6house_price7rent_08rent_19rent_210rent_311rent_412rent_hotel13owner14monopoly15mortgaged16houses17hotels
{"Go","no_type","no_color","0","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Mediterranean Avenue","street","purple","1","60","30","50","2","10","30","90","160","250","bank","FALSE","FALSE","0","0"},
{"Community Chest A","no_type","no_color","2","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Baltic Avenue","street","purple","3","60","30","50","4","20","60","180","320","450","bank","FALSE","FALSE","0","0"},
{"Income Tax","no_type","no_color","4","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Reading RR","railroad","black","5","200","100","0","25","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Oriental Avenue","street","lightblue","6","100","50","50","6","30","90","270","400","550","bank","FALSE","FALSE","0","0"},
{"Chance A","no_type","no_color","7","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Vermont Avenue","street","lightblue","8","100","50","50","6","30","90","270","400","550","bank","FALSE","FALSE","0","0"},
{"Connecticut Avenue","street","lightblue","9","120","60","50","8","40","100","300","450","600","bank","FALSE","FALSE","0","0"},
{"Jail","no_type","no_color","10","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"St. Charles Place","street","violet","11","140","70","100","10","50","150","450","625","750","bank","FALSE","FALSE","0","0"},
{"Electric Company","utility","white","12","150","75","0","410","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"States Avenue","street","violet","13","140","70","100","10","50","150","450","625","750","bank","FALSE","FALSE","0","0"},
{"Virginia Avenue","street","violet","14","160","80","100","12","60","180","500","700","900","bank","FALSE","FALSE","0","0"},
{"Pennsylvania RR","railroad","black","15","200","100","0","25","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"St. James Place","street","orange","16","180","90","100","14","70","200","550","750","950","bank","FALSE","FALSE","0","0"},
{"Community Chest B","no_type","no_color","17","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Tennessee Avenue","street","orange","18","180","90","100","14","70","200","550","750","950","bank","FALSE","FALSE","0","0"},
{"New York Avenue","street","orange","19","200","100","100","16","80","220","600","800","1000","bank","FALSE","FALSE","0","0"},
{"Free Parking","no_type","no_color","20","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Kentucky Avenue","street","red","21","220","110","150","18","90","250","700","875","1050","bank","FALSE","FALSE","0","0"},
{"Chance B","no_type","no_color","22","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Indiana Avenue","street","red","23","220","110","150","18","90","250","700","875","1050","bank","FALSE","FALSE","0","0"},
{"Illinois Avenue","street","red","24","240","120","150","20","100","300","750","925","1100","bank","FALSE","FALSE","0","0"},
{"B&O RR","railroad","black","25","200","100","0","25","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Atlantic Avenue","street","yellow","26","260","130","150","22","110","330","800","975","1150","bank","FALSE","FALSE","0","0"},
{"Ventnor Avenue","street","yellow","27","260","130","150","22","110","330","800","975","1150","bank","FALSE","FALSE","0","0"},
{"Water Works","utility","white","28","150","75","0","410","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Marvin Gardens","street","yellow","29","280","140","150","24","120","360","850","1025","1200","bank","FALSE","FALSE","0","0"},
{"Go To Jail","no_type","no_color","30","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Pacific Avenue","street","darkgreen","31","300","150","200","26","130","390","900","1100","1275","bank","FALSE","FALSE","0","0"},
{"N. Carolina Avenue","street","darkgreen","32","300","150","200","26","130","390","900","1100","1275","bank","FALSE","FALSE","0","0"},
{"Community Chest C","no_type","no_color","33","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Pennsylvania Avenue","street","darkgreen","34","320","160","200","28","150","450","1000","1200","1400","bank","FALSE","FALSE","0","0"},
{"Short Line RR","railroad","black","35","200","100","0","25","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Chance C","no_type","no_color","36","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Park Place","street","darkblue","37","350","175","200","35","175","500","1100","1300","1500","bank","FALSE","FALSE","0","0"},
{"Luxury Tax","no_type","no_color","38","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},
{"Boardwalk","street","darkblue","39","400","200","200","50","200","600","1400","1700","2000","bank","FALSE","FALSE","0","0"}
//{"Jailed","no_type","no_color","50","0","0","0","0","0","0","0","0","0","bank","FALSE","FALSE","0","0"},

    };

    string[,] array2 = new string[,]  //array of "monopolies" (ownership of all properties in a particular group)
    //Railroads are last because they have "mini-monopolies"
    {
        {"m1","FALSE1","bank1"}, //DARK PURPLE
        {"m2","FALSE2","bank2"}, //LIGHT BLUE
        {"m3","FALSE","bank"}, //LIGHT PURPLE
        {"m4","FALSE","bank"}, //ORANGE
        {"m5","FALSE","bank"}, //RED
        {"m6","FALSE","bank"}, //YELLOW
        {"m7","FALSE","bank"}, //GREEN
        {"m8","FALSE","bank"}, //DARK BLUE
        {"m9","FALSE","bank"}, //UTILITIES
        {"m10","FALSE","bank"}, //RAILROADS1
        {"m11","FALSE","bank"} //RAILROADS2
    };

    //create database
    string[,] array3 = new string[4, 4] //array of Monopoly data from the original version of the game
    {
        { "1","0","0","0"},     //not used
        { "2","0","0","0"},     //player # //tile #
        { "3","0","0","0"},     //player # //tile #
        { "4","0","0","0"}      //not used
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
    string str1;
    string str2;
    string str3;
    bool toggle1 = false;
    bool toggle2 = false;
    bool toggle3 = false;
    int turn = 1;

    //string customText;
    //rect = new Rect(0, 0, 400, 200);

    // Start is called before the first frame update 
    void Start()
    {
        jailed = false;
    }

    void OnGUI()
    {

        GUI.Box(new Rect(300, 200, 200, 90), array1[1, 0].ToString());
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
        if (Input.GetKeyDown(KeyCode.P))
        { //Start of the P Loop

            Check4monopolies();

        } //End of the P Loop

        void BuyLand()
        {
            tile_name = array1[tile_number, 0];
            tile_cost = array1[tile_number, 4];
            Debug.Log("tile_name=" + tile_name);
            Debug.Log("tile_cost=" + tile_cost);
            tile_cost_i = Convert.ToInt16(tile_cost);
            Debug.Log("before purchase");
            Debug.Log("money_banker=" + money_banker);
            Debug.Log("money_player1=" + money_player1);
            Debug.Log("money_player2=" + money_player2);
            Debug.Log("money_all=" + money_all);
            Debug.Log("before owner=" + array1[tile_number, 13]);

            money_player1 = money_player1 - tile_cost_i;
            money_banker = money_banker + tile_cost_i;
            money_all = money_banker + money_player1 + money_player2;
            array1[tile_number, 13] = "playerX"; //Sami

            Debug.Log("after owner=" + array1[tile_number, 13]);
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
            if ((array1[1, 13] == array1[3, 13])
                && (array1[1, 13] != "bank5"))
            {
                array2[0, 1] = "True"; //Always x,1
                monopolies1_owner = array1[6, 13];
                array2[0, 2] = monopolies1_owner; //Always x,2
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
            if ((array1[6, 13] == array1[8, 13])
                && (array1[8, 13] == array1[9, 13])
                && (array1[6, 13] != "bank5"))
            {
                array2[1, 1] = "True"; //Always x,1
                monopolies2_owner = array1[6, 13];
                array2[1, 2] = monopolies2_owner; //Always x,2
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
            if ((array1[11, 13] == array1[13, 13])
                && (array1[13, 13] == array1[14, 13])
                && (array1[11, 13] != "bank5"))
            {
                array2[2, 1] = "True"; //Always x,1
                monopolies3_owner = array1[11, 13];
                array2[2, 2] = monopolies3_owner; //Always x,2
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
            if ((array1[13, 13] == array1[15, 13])
                && (array1[15, 13] == array1[16, 13])
                && (array1[13, 13] != "bank5"))
            {
                array2[3, 1] = "True"; //Always x,1
                monopolies4_owner = array1[13, 13];
                array2[3, 2] = monopolies4_owner; //Always x,2
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
            if ((array1[21, 13] == array1[23, 13])
                && (array1[23, 13] == array1[24, 13])
                && (array1[21, 13] != "bank5"))
            {
                array2[4, 1] = "True"; //Always x,1
                monopolies5_owner = array1[21, 13];
                array2[4, 2] = monopolies5_owner; //Always x,2
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
            if ((array1[26, 13] == array1[27, 13])
                && (array1[27, 13] == array1[29, 13])
                && (array1[26, 13] != "bank5"))
            {
                array2[5, 1] = "True"; //Always x,1
                monopolies6_owner = array1[26, 13];
                array2[5, 2] = monopolies6_owner; //Always x,2
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
            if ((array1[31, 13] == array1[32, 13])
                && (array1[32, 13] == array1[34, 13])
                && (array1[31, 13] != "bank5"))
            {
                array2[6, 1] = "True"; //Always x,1
                monopolies7_owner = array1[31, 13];
                array2[6, 2] = monopolies7_owner; //Always x,2
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
            if ((array1[37, 13] == array1[39, 13])
                && (array1[37, 13] != "bank5"))
            {
                array2[7, 1] = "True"; //Always x,1
                monopolies8_owner = array1[37, 13];
                array2[7, 2] = monopolies8_owner; //Always x,2
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
            if ((array1[12, 13] == array1[28, 13])
                && (array1[12, 13] != "bank5"))
            {
                array2[8, 1] = "True"; //Always x,1
                monopolies9_owner = array1[37, 13];
                array2[8, 2] = monopolies9_owner; //Always x,2
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
            if ((array1[5, 13] == array1[15, 13])
                && (array1[15, 13] == array1[25, 13])
                && (array1[25, 13] == array1[35, 13])
                && (array1[5, 13] != "bank5"))
            {
                array2[9, 1] = "True"; //Always x,1
                monopolies10_owner = array1[37, 13];
                array2[9, 2] = monopolies10_owner; //Always x,2
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

            Debug.Log("0,0=" + array2[0, 0]);
            Debug.Log("0,1=" + array2[0, 1]);
            Debug.Log("0,2=" + array2[0, 2]);
            Debug.Log("1,0=" + array2[1, 0]);
            Debug.Log("1,1=" + array2[1, 1]);
            Debug.Log("1,2=" + array2[1, 2]);

        } //End of the D Loop



        if (Input.GetKeyDown(KeyCode.Z))
        { //Start of the Z Loop
            for (int i = 0; i < 4; i++) //(rows) tiles
            {
                for (int j = 0; j < 4; j++) //(columns) info on each tile
                {
                    str3 = str3 + array3[i, j] + " ";
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
                    str3 = str3 + array3[i, j] + " ";
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
                    str2 = str2 + array2[i, j] + " ";
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
                    str1 = str1 + array1[i, j] + " ";
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
            Debug.Log("Press D.............VIEW AL nmbvhL LAND OWNERSHIP");
            Debug.Log("Press K.............SHOW GAME STATUS, MONEY, ETC.");
            Debug.Log("Press P.............CHECK/SHOW monopolies");
        } //End of the M Loop 

        if (Input.GetKeyDown(KeyCode.T))
        {  //Start of the T Loop
            array1[1, 0] = "Sami's Place1"; //Sami
            array1[2, 0] = "Jack's Place2"; //Sami
            array1[3, 0] = "Sami's Place3"; //Sami
            array1[4, 0] = "Jack's Place4"; //Sami
            array1[5, 0] = "Sami's Place5"; //Sami
            array1[6, 0] = "Jack's Place6"; //Sami
            array1[7, 0] = "Sami's Place7"; //Sami
            array1[8, 0] = "Jack's Place8"; //Sami
            array1[9, 0] = "Sami's Place9"; //Sami
            array1[10, 0] = "Jack's Place10"; //Sami
            //Debug.Log("TEST=" + array1[tile_number, 16]);

            Debug.Log("tile1_name=" + array1[1, 0]);
            Debug.Log("tile2_name=" + array1[2, 0]);
            Debug.Log("tile3_name=" + array1[3, 0]);
            Debug.Log("tile4_name=" + array1[4, 0]);
            Debug.Log("tile5_name=" + array1[5, 0]);
            Debug.Log("tile6_name=" + array1[6, 0]);
            Debug.Log("tile7_name=" + array1[7, 0]);
            Debug.Log("tile8_name=" + array1[8, 0]);
            Debug.Log("tile9_name=" + array1[9, 0]);
            Debug.Log("tile10_name=" + array1[10, 0]);
            //array1[tile_number, 16] = "hello"; //Sami
            //Debug.Log("TEST=" + array1[tile_number, 16]);

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

        void RollDice ()
        {

            //if (Input.GetKeyDown(KeyCode.Space)) //Start of Space Bar Loop  
            //{ // START OF GETKEYDOWN LOOP (SPACE BAR)

                tile_number = Convert.ToInt16(array3[turn, 1]); //tells us where is player now!
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


                tile_name = array1[tile_number, 0];
                tile_cost = array1[tile_number, 4]; //added to fix error below. fixed now?

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
            //tile = Convert.ToInt16(array3[turn, 1]); //this should be moved here
            Debug.Log("BEFORE array3[0,1] = " + array3[0, 1]);
            RollDice();
            array3[0, 1] = tile_number.ToString(); //add string data
            //array3[0, 1] = "A"; //add string data
            Debug.Log("Player --A-- Rolled the Dice");
            Debug.Log("AFTER array3[0,1] = " + array3[0, 1]);
            ShowArray3();

        } //End of the A Loop

        if (Input.GetKeyDown(KeyCode.L)) //Start of L Loop  
        { // START OF GETKEYDOWN LOOP (L)

            ClearScreenGUI();
            //tile = Convert.ToInt16(array3[turn, 1]); //this should be moved here
            Debug.Log("BEFORE array3[1,1] = " + array3[1, 1]);
            RollDice();
            array3[1, 1] = tile_number.ToString(); //add string data
            //array3[1, 1] = tile.ToString(); //add string data
            //array3[1, 1] = "L"; //add string data
            Debug.Log("Player --L-- Rolled the Dice");
            Debug.Log("AFTER array3[1,1] = " + array3[1, 1]);
            ShowArray3();

        } //End of the L Loop
    }
}

