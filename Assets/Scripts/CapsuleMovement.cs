using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float growthSpeed = 0.1f;
    [SerializeField] private float maxSize = 5f;
    [SerializeField] private float initialSize = 1f;

    private void Start()
    {
        transform.localScale = Vector3.one * initialSize;
    }

    private void Update()
    {
        float newSize = transform.localScale.x + growthSpeed * Time.deltaTime;

        if (newSize <= maxSize)
        {
            transform.localScale = Vector3.one * newSize;
        }
        else
        {
            transform.localScale = Vector3.one * maxSize;
        }
    }
}
