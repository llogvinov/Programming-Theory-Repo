using UnityEngine;

public class Capsule : Shape
{
    [SerializeField] private Vector3 _newScale;

    protected override void Collide()
    {
        transform.localScale = _newScale;
    }
}
