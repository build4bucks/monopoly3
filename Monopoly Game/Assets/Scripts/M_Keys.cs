using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MNPLY
{
    public class M_Keys : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.P))
            { //Start of the P Loop

                Debug.Log("Hello from 'P' Key!");
                //Check4monopolies();

            } //End of the P Loop

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

        }
    }

}
