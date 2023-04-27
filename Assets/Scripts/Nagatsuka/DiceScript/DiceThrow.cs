using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrow : MonoBehaviour
{
    public GameObject Dice;
    public int num;
    private int rotateX;
    private int rotateY;
    private int rotateZ;
    [SerializeField] GameObject DiceCamera;
    private GameObject parent;
    Vector3 CameraPos;
    public GameObject oya;    //親オブジェクト
    public Transform kodomo; //子オブジェクト.

    private void Start()
    {
        ShakeDice();
        //DiceCamera.SetActive(true);
        //CameraPos = DiceCamera.transform.position;
        //CameraPos.x += 3;
        //CameraPos.y -= 3;
        //for(int i = 0; i < num; i++)
        //{
        //    rotateX = Random.Range(0, 360);
        //    rotateY = Random.Range(0, 120);
        //    rotateZ = Random.Range(0, 360);
        //    GameObject dice = GameObject.Instantiate(Dice) as GameObject;
        //    dice.transform.position = CameraPos;
        //    dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
        //    dice.transform.Rotate(rotateX, rotateY, rotateZ);
        //}
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

    public void ShakeDice()
    {
        DiceCamera.SetActive(true);
        CameraPos = DiceCamera.transform.position;
        CameraPos.x += 3;
        CameraPos.y -= 3;
        rotateX = Random.Range(0, 360);
        rotateY = Random.Range(0, 120);
        rotateZ = Random.Range(0, 360);
        GameObject dice = GameObject.Instantiate(Dice, CameraPos,Quaternion.identity,kodomo);
        dice.transform.SetParent(kodomo, true);
        dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
        dice.transform.Rotate(rotateX, rotateY, rotateZ);
    }
}
