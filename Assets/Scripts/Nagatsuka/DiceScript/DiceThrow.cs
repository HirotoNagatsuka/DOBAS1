using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceThrow : MonoBehaviour
{
    public GameObject Dice;
    public int num;
    private int rotateX;
    private int rotateY;
    private int rotateZ;

    private void Start()
    {
        for(int i = 0; i < num; i++)
        {
            rotateX = Random.Range(0, 360);
            rotateY = Random.Range(0, 360);
            rotateZ = Random.Range(0, 360);
            GameObject dice = GameObject.Instantiate(Dice) as GameObject;
            dice.transform.position = new Vector3(8, 8, 0);
            dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
            dice.transform.Rotate(rotateX, rotateY, rotateZ);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rotateX = Random.Range(0, 360);
            rotateY = Random.Range(0, 360);
            rotateZ = Random.Range(0, 360);
            GameObject dice = GameObject.Instantiate(Dice) as GameObject;
            dice.transform.position = new Vector3(8, 8, 0);
            dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
            dice.transform.Rotate(rotateX, rotateY, rotateZ);
        }
    }
}
