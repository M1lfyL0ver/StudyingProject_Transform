using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
