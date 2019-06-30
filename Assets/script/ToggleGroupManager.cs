using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToggleGroupManager : MonoBehaviour
{
    [SerializeField] ToggleGroup[] m_toggleGroups;

    public void OnClick()
    {
        // どの Toggle にチェックが入っているか調べる
        foreach (var g in m_toggleGroups)
        {
            GameObject go = g.ActiveToggles().FirstOrDefault().gameObject;    // go はチェックが入っている Toggle の GameObject
            Debug.Log("ToggleGroup: " + g.name + " の " + go.name + " がチェックされている");
        }
    }
}
