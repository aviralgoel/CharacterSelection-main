using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;



    public TankController(TankModel _model, TankView _view)
    {
        tankModel = _model;
        tankView = GameObject.Instantiate<TankView>(_view);
    
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        rb = tankView.GetRigidbody();
    }
    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movementSpeed * movement;
    }
    public void Rotate(float rotate, float rotateSpeed)
    {
        Debug.Log("playerRotate:" + rotate +", rotateSpeed:" + rotateSpeed);
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Debug.Log("vector:" + vector);

        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime); 
        // how does Time.deltaTime make rotation frameless independent?
        // what would happen if it was frame dependent? 
        // what is frame dependent? 
        Debug.Log("deltaRotation:" + deltaRotation);
        rb.MoveRotation(rb.rotation * deltaRotation);
        Debug.Log("moveRotationAmount" + rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
