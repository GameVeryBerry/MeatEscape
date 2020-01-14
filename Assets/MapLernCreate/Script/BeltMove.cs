using UnityEngine;

public class BeltMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigid;
    [SerializeField]
    private Vector3 speedForce;

    public void Move(Vector3 speed)
    {
        if (rigid.velocity.x <= 10)
        {
            rigid.AddForce(speed);
            //Debug.Log(rigid.velocity);
            //Debug.Log(speed);
        }
    }
}