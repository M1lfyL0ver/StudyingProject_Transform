using UnityEngine;

public class ForwardLoopMovementor : MonoBehaviour
{
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequency = 1f; 

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startingPosition + transform.forward * movement;
    }
}
