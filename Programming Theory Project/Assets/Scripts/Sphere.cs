using UnityEngine;

public class Sphere : Shape
{
    [SerializeField] private float _force;

    private Rigidbody _rigidbody;

    private void Start()
    {
        ObjectName = "Sphere";
        _rigidbody = GetComponent<Rigidbody>();
    }

    protected override void Collide()
    {
        _rigidbody.AddForce(Vector3.up * _force);
    }
}
