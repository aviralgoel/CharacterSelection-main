using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;
    private float movementSpeed;
    private float rotateSpeed;


    public TankController(TankModel _model, TankView _view)
    {
        tankModel = _model;
        // ? how does this line of code work? what is it example instantiating and which GameObject is being stated here?
        tankView = GameObject.Instantiate<TankView>(_view);
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        rb = tankView.GetRigidbody();
        tankView.ChangeMat(tankModel.tankMat);
        movementSpeed = tankModel.tankMovementSpeed;
        rotateSpeed = tankModel.tankRotationSpeed;
    }
    public void Move(float movement)
    {   
        rb.velocity = tankView.transform.forward * movementSpeed * movement;
    }
    public void Rotate(float rotate)
    {
        // Debug.Log("playerRotate:" + rotate +", rotateSpeed:" + rotateSpeed);
        /* - most of the times rotate will be either +1 or -1.
         *  - so rotate*RotateSpeed = 30 or -30 */
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        //Debug.Log("vector:" + vector);

        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        // Debug .Log(Time.deltaTime);
       
        // Debug.Log("deltaRotation:" + deltaRotation);
        rb.MoveRotation(rb.rotation * deltaRotation);
        // Debug.Log("moveRotationAmount" + rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
