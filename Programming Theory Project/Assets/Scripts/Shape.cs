using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string _objectName;
    public string ObjectName
    {
        get { return _objectName; }
        protected set { _objectName = value; }
    }

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
