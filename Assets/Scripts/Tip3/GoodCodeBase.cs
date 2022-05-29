using UnityEngine;

public class GoodCodeBase : MonoBehaviour
{
    [Header("Some data")]
    public Vector3 startPostion;
    public Vector3 finishPosition;
    public float time;

    private BasePhysics basePhysics;
    private BaseLogic baseLogic;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        startPostion = Vector3.zero;

        basePhysics = new BasePhysics();
        baseLogic = new BaseLogic();
    }

    private void FixedUpdate()
    {
        Vector3 newPos = startPostion;
        newPos.x = basePhysics.NewPositionX(startPostion.x, startPostion.y, startPostion.z, finishPosition.x, finishPosition.y, finishPosition.z, time);
        this.transform.position = newPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        //do something with BaseLogic
    }
}
