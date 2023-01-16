using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class Calculator : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI InputField;

    string InputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;

    // Start is called before the first frame update




    public void ButtonPressed()
    {
        
        if(displayedResults == true)
        {
            InputField.text = "";
            InputString = "";
            displayedResults = false;
        }
        
        
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;

        InputString += buttonValue;


        
        int arg;
        if(int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i = i + 1;
        }

        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                    }

                    displayedResults = true;
                    InputString = result.ToString();
                    number = new int[2];
                    break;
            }
        }


        







        InputField.text = InputString;
    }
}
