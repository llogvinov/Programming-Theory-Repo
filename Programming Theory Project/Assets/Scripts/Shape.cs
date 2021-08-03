using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected bool _wasCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_wasCollided)
        {
            Collide();
            _wasCollided = true;
        }
    }

    protected abstract void Collide();

}
