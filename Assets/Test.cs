using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        // 条件1）要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 37, 22, 83, 46, 15 };

        // 条件2）for文を使い
        for (int i = array.Length - 1; i>= 0 ; i--)
        {
            //配列の要素の値を逆順に表示する
            Debug.Log(array[i]);

        }
            
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
}