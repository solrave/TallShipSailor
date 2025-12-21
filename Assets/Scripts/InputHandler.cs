public class InputHandler
{
    private readonly InputReader _inputReader;
    public InputHandler()
    {
        _inputReader = new InputReader();
    }

    public bool SailRotated => _inputReader.RotatingSail;
    public bool WindRotated => _inputReader.RotatingWind;
    public float GetInput() => _inputReader.RotationInput;
}