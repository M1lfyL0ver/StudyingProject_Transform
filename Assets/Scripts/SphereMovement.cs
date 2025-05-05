using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequency = 1f; 

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startPos + transform.forward * movement;
    }
}
