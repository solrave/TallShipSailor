using UnityEngine;

public class Rotator
{
    private float _rotationSpeed;
    public Rotator(float rotationSpeed)
    {
        _rotationSpeed = rotationSpeed;
    }
    
    public void Rotate(Transform obj2Rotate, float input)
    {
        obj2Rotate.Rotate(Vector3.up, input * _rotationSpeed);
    }
}