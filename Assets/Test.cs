using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        // ����1�j�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����
        int[] array = { 37, 22, 83, 46, 15 };

        // ����2�jfor�����g��
        for (int i = 0; i< array.Length; i++)
        {
            //�z��̗v�f�̒l�����Ԃɕ\������
            Debug.Log(array[i]);

        }
            
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
}