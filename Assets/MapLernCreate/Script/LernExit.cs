using UnityEngine;
using UnityEngine.SceneManagement;

public class LernExit : MonoBehaviour
{
    // プレイヤーのタグ取得
    const string PLAYER = "player";


    // プレイヤーが当たったらゲームオーバーにする
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            //SceneManager.LoadScene("Gameover");
        }
    }
}