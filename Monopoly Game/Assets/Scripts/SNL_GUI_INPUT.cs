using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SNL
{

    public class SNL_GUI_INPUT : MonoBehaviour
    {
        public static string thePlayers;
        public GameObject inputField;
        public GameObject textDisplay;
        public void StoreName()
        {
            thePlayers = inputField.GetComponent<Text>().text;
            textDisplay.GetComponent<Text>().text = thePlayers + " Players";
            Debug.Log("SNL_GUI_INPUT: thePlayers = " + thePlayers);
        }

    }
}