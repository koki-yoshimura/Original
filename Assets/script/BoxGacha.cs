using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGacha : MonoBehaviour
{
    List<string> m_gachaItems = new List<string>() { "a", "b", "b", "c", "c", "d", "d", "e", "e", "e" };

    public void Lottery()
    {
        if (m_gachaItems.Count < 1)
        {
            Debug.Log("ガチャの中身がありません");
            return;
        }

        int i = Random.Range(0, m_gachaItems.Count);
        Debug.Log(m_gachaItems[i] + "を引きました");
        m_gachaItems.RemoveAt(i);   // 消す
    }
}
