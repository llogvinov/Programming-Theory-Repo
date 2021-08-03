using UnityEngine;

public class Capsule : Shape
{
    [SerializeField] private Vector3 _newScale;

    private void Start()
    {
        ObjectName = "Capsule";
    }

    protected override void Collide()
    {
        transform.localScale = _newScale;
    }
}
