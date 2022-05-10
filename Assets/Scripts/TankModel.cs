using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float tankMovementSpeed;
    public float tankRotationSpeed;

    public TankModel(float _tankMovementSpeed, float _tankRotationSpeed)
    {
        tankMovementSpeed = _tankMovementSpeed;
        tankRotationSpeed = _tankRotationSpeed;
    }
    public void SetTankController(TankController _controller)
    {
        tankController = _controller;
    }

}
