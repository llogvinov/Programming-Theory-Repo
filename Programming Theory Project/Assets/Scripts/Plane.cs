using UnityEngine;

public class Plane : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Shape shape))
        {
            Debug.Log(shape.ObjectName);
        }
    }
}
