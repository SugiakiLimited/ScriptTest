using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; // mp

    //���@�U���p�̊֐�
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
   
    } 

    
}

public class Test : MonoBehaviour
{
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        for(int i = 0; i < 11; i++)
        {
            // ���@�U���p�̊֐����Ăяo��
            lastboss.Magic();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}