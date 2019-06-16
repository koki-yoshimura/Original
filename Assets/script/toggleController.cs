using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[RequireComponent(typeof(ToggleGroup))]
public class toggleController : MonoBehaviour
{
    public void OnClick()
    {
        // どの Toggle にチェックが入っているか調べる
        GameObject go = GetComponent<ToggleGroup>().ActiveToggles().FirstOrDefault().gameObject;    // go はチェックが入っている Toggle の GameObject
        Debug.Log(go.name + " がチェックされている");

        // 例えばチェックされている Toggle の名前で処理を分岐させる
        switch (go.name)
        {
            case "Toggle (0)":
                Debug.Log("ここにToggle (0)用の処理を書く");
                break;
            case "Toggle (1)":
                Debug.Log("ここにToggle (1)用の処理を書く");
                break;
            case "Toggle (2)":
                Debug.Log("ここにToggle (2)用の処理を書く");
                break;
            default:
                break;
        }
    }
}