using UnityEngine;
using UnityEngine.UI;

public class CommonDialog : MonoBehaviour
{
    [SerializeField] private Text textMassage = null;
    /// <summary>
    /// 初期設定
    /// </summary>
    /// <param name="message">メッセージ内容</param>
    public void Setup(string message)
    {
        textMassage.text = message;
    }

    public void XButtonDown()
    {
        Destroy(gameObject);
    }
}
