using UnityEngine;

public class BeltRestart : MonoBehaviour
{
    [SerializeField]
    GameObject startPos = null;
    GameObject m_belt = null;

    void OnTriggerEnter(Collider collider)
    {
        Restart();
    }

    void Restart()
    {
        // スタート地点へ瞬間移動
        m_belt.transform.position = startPos.transform.position;
    }
}