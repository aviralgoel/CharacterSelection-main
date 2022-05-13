using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float tankMovementSpeed;
    public float tankRotationSpeed;
    // ? how does this script know about the existance of TankTypes enum?
    public TankTypes tankTypes;
    public Material tankMat;

    public TankModel(float _tankMovementSpeed, float _tankRotationSpeed, TankTypes _type, Material _mat)
    {
        tankMovementSpeed = _tankMovementSpeed;
        tankRotationSpeed = _tankRotationSpeed;
        tankTypes = _type;
        tankMat = _mat;
    }
    public void SetTankController(TankController _controller)
    {
        tankController = _controller;
    }

}
