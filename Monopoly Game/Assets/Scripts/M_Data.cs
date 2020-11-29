using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MNPLY
{

    public class M_Data : MonoBehaviour
    {

        //public static string test;

        //create database
        public static string[,] array1 = new string[40, 18] //array of Monopoly data from the original version of the game
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

        public static string[,] array2 = new string[,]  //array of "monopolies" (ownership of all properties in a particular group)
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
        public static string[,] array3 = new string[4, 4] //array of Monopoly data from the original version of the game
        {
        { "1","0","0","0"},     //not used
        { "2","0","0","0"},     //player # //tile #
        { "3","0","0","0"},     //player # //tile #
        { "4","0","0","0"}      //not used
        };

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { 
        
        }

    }
 
}