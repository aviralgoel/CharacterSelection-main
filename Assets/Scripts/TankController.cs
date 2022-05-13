using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;



    public TankController(TankModel _model, TankView _view)
    {
        tankModel = _model;
        // ? how does this line of code work? what is it example instantiating and which GameObject is being stated here?
        tankView = GameObject.Instantiate<TankView>(_view);
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        rb = tankView.GetRigidbody();
        tankView.ChangeMat(tankModel.tankMat);
    }
    public void Move(float movement, float movementSpeed)
    {   
        rb.velocity = tankView.transform.forward * movementSpeed * movement;
    }
    public void Rotate(float rotate, float rotateSpeed)
    {
        // Debug.Log("playerRotate:" + rotate +", rotateSpeed:" + rotateSpeed);
        /* - most of the times rotate will be either +1 or -1.
         *  - so rotate*RotateSpeed = 30 or -30 */
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        //Debug.Log("vector:" + vector);

        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        // Debug .Log(Time.deltaTime);
        // ?  how does Time.deltaTime make rotation frameless independent?
       
        // Debug.Log("deltaRotation:" + deltaRotation);
        rb.MoveRotation(rb.rotation * deltaRotation);
        // Debug.Log("moveRotationAmount" + rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
