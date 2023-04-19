using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceStage : MonoBehaviour
{
    [SerializeField] GameObject DiceNumText;
    private int number;
    private int diceSum;//サイコロの目の合計値.

    void Start()
    {
        number = 0;
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "Attack")
            {
                number = 6;
            }
            else if (collider.gameObject.name == "Doubt")
            {
                number = 5;
            }
            else if (collider.gameObject.name == "3")
            {
                number = 4;
            }
            else if (collider.gameObject.name == "4")
            {
                number = 3;
            }
            else if (collider.gameObject.name == "5")
            {
                number = 2;
            }
            else if (collider.gameObject.name == "6")
            {
                number = 1;
            }
        }
    public int ReturnNumber()
    {
        return number;
    }
}
