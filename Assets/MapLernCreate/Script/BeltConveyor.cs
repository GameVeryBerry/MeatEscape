using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction=new Vector3(0,0,0);
    [SerializeField]
    private GameObject start=null;
    [SerializeField]
    private GameObject goal=null;
    [SerializeField]
    private BeltMove belt=null;

    void Start()
    {
        direction = goal.transform.position - start.transform.position;
    }

    void FixedUpdate()
    {
        belt.Move(direction);
        //Debug.Log(direction);
    }
}