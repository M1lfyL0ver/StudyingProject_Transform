using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float growthSpeed = 0.1f;

    private void Start()
    {
    }

    private void Update()
    {
        transform.localScale += new Vector3(growthSpeed, growthSpeed, growthSpeed) * Time.deltaTime;
    }
}
