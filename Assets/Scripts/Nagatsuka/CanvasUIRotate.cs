using UnityEngine;

public class CanvasUIRotate : MonoBehaviour
{
    void LateUpdate()
    {
        //�@�J�����Ɠ��������ɐݒ�
        transform.rotation = Camera.main.transform.rotation;
    }
}
