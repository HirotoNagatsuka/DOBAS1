using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestGManager : MonoBehaviour
{
    [SerializeField] Text HaveTimeText;
    float HaveTime;//�e�v���C���[�̎�������.
    
    // Start is called before the first frame update
    void Start()
    {
        HaveTime = 13;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeHaveTime();
    }

    private void ChangeHaveTime()
    {
        if (HaveTime > 0)//�c�莞�Ԃ��c���Ă���Ȃ�.
        {
            HaveTime -= Time.deltaTime;
            if (HaveTime <= 10)//10�b�ȉ��ɂȂ�����Ԃ�����.
            {
                HaveTimeText.color = Color.red;
            }
            HaveTimeText.text = HaveTime.ToString("0");//�����_�ȉ���\�����Ȃ�.
        }
        else//0�ȉ��ɂȂ�����.
        {
            HaveTime = 0;
            Debug.Log("�^�[�������I��");
        }        
    }

    /// <summary>
    /// �T�C�R����U��֐�.
    /// </summary>
    public void ShakeDice()
    {

    }
}
