using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    private GameObject start;
    [SerializeField]
    private GameObject goal;
    [SerializeField]
    private BeltMove belt;

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