using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Calculator : MonoBehaviour {
    [SerializeField]
    Text inputField;
    string operatorSign;

    string buttonValue;
    double result = 0;
    int i;
    bool isOperationPerformed = false;
    double[] number = new double[3];
    int p;
    double w;


    public void buttonPressed()
    {
       
        if ((inputField.text == " 0"))
            inputField.text = "";
      
        // Which button has been pressed is requied
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        buttonValue = EventSystem.current.currentSelectedGameObject.name;
// End Which button

// When pressed . Code is finished
        if (buttonValue == ".")
        {
            if (inputField.text == "")
            {
                inputField.text += "0" + buttonValue;
            }

            if (!inputField.text.Contains("."))
                inputField.text = inputField.text + buttonValue;
        }
        // end When pressed . Code is finished

        if (buttonValue == "c")
        {
            inputField.text = " 0"; 
        }
        if (buttonValue == "-/+")
        {
            Debug.Log("-/+ if entered");
            if (!inputField.text.Contains("-"))
            {
                Debug.Log("set to minus");
                inputField.text = "-" + inputField.text;
                
            } else
            {
                w = double.Parse(inputField.text);
                Debug.Log("set to plus");
                w = w * -1;
                inputField.text = w.ToString();
            }
        }
        if (buttonValue == "1" || buttonValue == "2" || buttonValue == "3" || buttonValue == "4" || buttonValue == "5" || buttonValue == "6" || buttonValue == "7" || buttonValue == "8" || buttonValue == "9" || buttonValue == "0" && inputField.text != "")
        {
            if (!(isOperationPerformed == true))
            {
                inputField.text += buttonValue;
            }
            else
            {
                inputField.text = "";
                inputField.text += buttonValue;
                isOperationPerformed = false;
            }
            w = double.Parse(inputField.text);
        }

        if (buttonValue == "+" || buttonValue == "-" || buttonValue == "*" || buttonValue == "/" || buttonValue == "=") {

            number[i] = double.Parse(inputField.text);
            Debug.Log(number[i] + " has been saed under " + i);
            i++;
            Debug.Log("i = " + i);
            if (!(buttonValue == "=")){
                operatorSign = buttonValue;
                Debug.Log("operatpr = " + operatorSign);
                inputField.text = "";
            } else if(buttonValue == "=")
            {
                if (i == 2)
                {
                    Debug.Log("i in if condition = " + i);
                    Debug.Log(number[0]);
                    Debug.Log(number[1]);
                    switch (operatorSign)
                    {
                        case "+":
                            result = number[0] + number[1];
                            inputField.text = result.ToString();
                            isOperationPerformed = true;
                            break;
                        case "*":
                            result = number[0] * number[1];
                            inputField.text = result.ToString();
                            isOperationPerformed = true;
                            break;
                        case "-":
                            result = number[0] - number[1];
                            inputField.text = result.ToString();
                            isOperationPerformed = true;
                            break;
                        case "/":
                            result = number[0] / number[1];
                            inputField.text = result.ToString();
                            isOperationPerformed = true;
                            break;
                    }
                    i = 0;
                    Debug.Log("i = " + i);
                }

            }

        }

            
    }
        
   

    }

