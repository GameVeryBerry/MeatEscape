using UnityEngine;

public class MapLernExitPoint : MonoBehaviour
{
    // プレイヤーが当たったらゲームオーバーにする
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("AAAAAAAAA");
        if (collision.gameObject.tag == "player")
        {
            // TODO : SceneManager.LoadScene("GameOver");
        }
    }
}
