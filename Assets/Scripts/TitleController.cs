using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject gashaButton;
    [SerializeField] private GameObject shootingButton;
    [SerializeField] private GameObject title;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject goDialogRoot = null;
    [SerializeField] private CommonDialog commonDialog = null;


    private GameObject dialogObj = null;

    //スタートボタンを押すと非アクティブのボタンがアクティブとなる
    public void StartButtonDown()
    {
        audioSource.Play();

        startButton.SetActive(false);
        title.SetActive(false);
        shopButton.SetActive(true);
        gashaButton.SetActive(true);
        shootingButton.SetActive(true);

        //var dialog = (GameObject)Resources.Load("Prefabs/CommonDialog");
        commonDialog = Instantiate(commonDialog, goDialogRoot.transform, worldPositionStays: false);

        var message = "※こちらは初回のみ表示\n" +
            "◆Shooting\n" +
            "シューティングゲームをプレイできます。\n" +
            "◆Gasha\n" +
            "Shootingで使えるアイテムが手に入るガシャができます。\n" +
            "◆Shop\n" +
            "Shopで使えるアイテムが買えます。";

        // CommonDialogクラス側にSetup()メソッドを用意しておき、毎回テキスト内容を変えられるようにする。
        commonDialog.Setup(message);
    }

    //soubiボタンを押してsoubiシーンに遷移する
    public void ShootingButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Weapon");
    }

    //shopボタンを押してshopシーンに遷移する
    public void ShopButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Shop");
    }

    //gashaボタンを押してgashaシーンに遷移する
    public void GashaButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Gasha");
    }

}
