using UnityEngine;
using UnityEngine.Events;

public class BadCodeBase : MonoBehaviour
{
    [Header("Some data")]
    public Vector3 startPostion;
    public Vector3 finishPosition;
    public float time;

    private UnityEvent _physicsEvent;
    private UnityEvent _logicEvent;

    private void Start()
    {
        startPostion = Vector3.zero;
    }

    private void FixedUpdate()
    {
        this.transform.position = Vector3.Lerp(startPostion, finishPosition, time * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
            _physicsEvent?.Invoke();
        //finishPosition = new Vector3(1, 1, 1);

        if (other.gameObject.tag == "Player")
            _logicEvent?.Invoke();
        //Destroy(gameObject);
    }
}
