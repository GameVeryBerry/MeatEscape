using UnityEngine;

public class GirochinMove : MonoBehaviour
{
    Vector3 objPosition;    // オブジェクトの位置を記録
    float count;              // 時間

    void Start()
    {
        // 最初に置かれた場所を代入 
        objPosition = this.transform.position;
        // カウンタの初期化
        count = 0;
    }

    void Update()
    {
        // カウントを足していく
        count += 0.2f;
        // Sinを使ってY軸方向い移動させる 
        transform.position = new Vector3(objPosition.x, Mathf.Sin(count) * -0.5f + objPosition.y, objPosition.z);
   }
}