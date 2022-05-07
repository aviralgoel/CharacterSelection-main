using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _model, TankView _view)
    {
        tankModel = _model;
        tankView = _view;
        GameObject.Instantiate(tankView.gameObject);
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }
}
