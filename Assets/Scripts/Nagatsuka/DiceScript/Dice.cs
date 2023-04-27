using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
    #region �萔�錾
    const int DICE_UI = 0;
    #endregion
    Rigidbody rbody;
    private int number;//�o�ڂ�����.
    [SerializeField] GameObject Stage;//�X�e�[�W�ɓ��������o�ڂ𔻒肷�邽�߂̕ϐ��錾.
    GameObject DiceUI;//�q���̃L�����o�X���擾���邽�߂̕ϐ��錾.
    #region Start�EUpdate�֐�
    void Start()
    {
        number = 0;//������.
        rbody = GetComponent<Rigidbody>();
        Stage = GameObject.Find("DiceStage");//�X�e�[�W���擾����.
        DiceUI = gameObject.transform.GetChild(DICE_UI).gameObject;//�q���̃L�����o�X���擾.
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Destroy(gameObject);
        //}
    }
    #endregion

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Stage")//�������Ă�����̂��X�e�[�W������.
        {
            if (rbody.velocity.magnitude == 0)//�}�O�j�`���[�h��0�̏ꍇ�i��������j.
            {
                Stage.GetComponent<DiceStage>().ConfirmNumber();//�X�e�[�W�ōs���Ă���o�ڔ����Ԃ�.
                DiceUI.gameObject.transform.GetChild(0).GetComponent<Text>().text = number.ToString();//�o�ڂ�UI�\��.
                switch (number)//�o�ڂɂ����UI�̕\����ύX����.
                {
                    case 1:
                        DiceUI.transform.localPosition = new Vector3(0, 0, 3);
                        break;
                    case 2:
                        DiceUI.transform.localPosition = new Vector3(0, 3, 0);
                        break;
                    case 3:
                        DiceUI.transform.localPosition = new Vector3(-3, 0, 0);
                        break;
                    case 4:
                        DiceUI.transform.localPosition = new Vector3(3, 0, 0);
                        break;
                    case 5:
                        DiceUI.transform.localPosition = new Vector3(0, -3, 0);
                        break;
                    case 6:
                        DiceUI.transform.localPosition = new Vector3(0, 0, -3);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
