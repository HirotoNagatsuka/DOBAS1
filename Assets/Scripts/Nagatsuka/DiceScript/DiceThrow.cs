using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrow : MonoBehaviour
{
    public GameObject DicePrefab;//�T�C�R���̃v���t�@�u������.
    private GameObject Dice;//�T�C�R���p�̕\���E��\�����J��Ԃ��p.
    public int num;
    #region �����_���ɉ�]������p�̕ϐ��錾.
    private int rotateX;
    private int rotateY;
    private int rotateZ;
    #endregion


    [SerializeField] GameObject DiceCamera;
    //[SerializeField] Text DiceNumText;
    Vector3 CameraPos;
    public GameObject oya;    //�e�I�u�W�F�N�g
    public Transform kodomo; //�q�I�u�W�F�N�g.
    private bool DiceFlg;//�T�C�R���쐬�t���O.

    private void Start()
    {
        Dice = GameObject.Instantiate(DicePrefab, CameraPos, Quaternion.identity, kodomo);
        Dice.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShakeDice();
        }
    }

    /// <summary>
    /// �T�C�R����U��p�̊֐�
    /// �T�C�R���̃v���t�@�u��������΍쐬���A�L��Ε\���E��\�����J��Ԃ�.
    /// </summary>
    public void ShakeDice()
    {
        DiceCamera.SetActive(true);
        Dice.SetActive(true);
        Dice.transform.position = CameraPos;
        CameraPos = DiceCamera.transform.position;
        CameraPos.x += 3;
        CameraPos.y -= 3;
        rotateX = Random.Range(0, 360);
        rotateY = Random.Range(0, 360);
        rotateZ = Random.Range(0, 360);
        Dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
        Dice.transform.Rotate(rotateX, rotateY, rotateZ);
    }

    /// <summary>
    /// �T�C�R�����\���ɂ��A�T�C�R����U�鏈�����I��点��.
    /// </summary>
    public void HiddenDice()
    {
        StartCoroutine(HiddenDiceCoroutine());
    }

    // �R���[�`���{��
    private IEnumerator HiddenDiceCoroutine()
    {
        // 2�b�ԑ҂�
        yield return new WaitForSeconds(2);
        DiceCamera.SetActive(false);
        Dice.SetActive(false);
        Debug.Log("�R���[�`���Ăяo���I��");
    }
}
