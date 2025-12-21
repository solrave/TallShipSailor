using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform _ship;
    [SerializeField] private Transform _sails;
    [SerializeField] private Transform _wind;
    [SerializeField] private float _rotationSpeed;
    private InputHandler _inputHandler;
    private Rotator _rotator;
    private Mover _mover;
    private DotCalculator _dotCalculator;
    private float f;

    private void Start()
    {
        _inputHandler = new InputHandler();
        _rotator = new Rotator(_rotationSpeed);
        _mover = new Mover();
        _dotCalculator = new DotCalculator();
    }

    private void Update()
    {
        f = Input.GetAxis("Horizontal");
        _sails.Rotate(Vector3.up, f * _rotationSpeed);
    }

    private void RotateThings()
    {
        if (_inputHandler.SailRotated)
            _rotator.Rotate(_sails, _inputHandler.GetInput());

        if (_inputHandler.WindRotated)
            _rotator.Rotate(_wind, _inputHandler.GetInput());
    }
}