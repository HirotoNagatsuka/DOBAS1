using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
class Player
{
    public string Name;//���O���i�[.
    public int HP;//HP���i�[.
    public int Attack;//�U���͂��i�[.
}

public class PlayerManager : MonoBehaviour
{
    #region �萔�錾
    const int PLAYER_UI = 0;
    const int NAME_UI = 0;
    const int HP_UI = 1;
    #endregion

    public int TestAddHP;

    [SerializeField]
    Player Player;//Player�̃N���X���C���X�y�N�^�[��Ō����悤�ɂ���.

    GameObject PlayerUI;//�q���̃L�����o�X���擾���邽�߂̕ϐ��錾.

    #region Unity�C�x���g(Start�EUpdate)
    private void Start()
    {
        PlayerUI = gameObject.transform.GetChild(PLAYER_UI).gameObject;//�q���̃L�����o�X���擾.
        PlayerUI.gameObject.transform.GetChild(NAME_UI).GetComponent<Text>().text = Player.Name.ToString();//���O�̕\��.
        PlayerUI.gameObject.transform.GetChild(HP_UI).GetComponent<Text>().text = Player.HP.ToString();//HP�̕\��.
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))//�e�X�g�p��HP�𑝌�.
        {
            ChangeHP(TestAddHP);
        }
    }

    #endregion

    /// <summary>
    /// HP���ω�����Ƃ��ɌĂяo���֐�
    /// �ω��ʂ������ɂ��AHP��ς�����UI�ɂ����f����.
    /// </summary>
    public void ChangeHP(int addHP)
    {
        if(Player.HP == 0)//HP��0�ɂȂ�����.
        {
            Player.HP = 0;
            Debug.Log("�Q�[���I�[�o�[");
        }
        else Player.HP += addHP;//0�łȂ��Ȃ�ω�������.
        PlayerUI.gameObject.transform.GetChild(HP_UI).GetComponent<Text>().text = Player.HP.ToString();//HP�̕\��.
    }

}
