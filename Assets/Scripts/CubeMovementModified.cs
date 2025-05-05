using UnityEngine;

public class CubeMovementModified : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotationSpeed = 45f;
    [SerializeField] private float growthSpeed = 0.1f;
    [SerializeField] private float initialScale = 1f;

    private void Start()
    {
        transform.localScale = Vector3.one * initialScale;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        float newScale = transform.localScale.x + growthSpeed * Time.deltaTime;

        transform.localScale = Vector3.one * newScale;
    }
}
