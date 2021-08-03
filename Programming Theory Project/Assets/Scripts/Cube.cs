using UnityEngine;

public class Cube : Shape
{
    [SerializeField] private Color _newColor;

    protected override void Collide()
    {
        GetComponent<MeshRenderer>().material.color = _newColor;
    }
}
