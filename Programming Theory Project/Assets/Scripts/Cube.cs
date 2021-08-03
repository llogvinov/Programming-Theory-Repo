using UnityEngine;

public class Cube : Shape
{
    [SerializeField] private Color _newColor;

    private void Start()
    {
        ObjectName = "Cube";
    }

    protected override void Collide()
    {
        GetComponent<MeshRenderer>().material.color = _newColor;
    }
}
