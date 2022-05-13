using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
   public void BlueTankSelected()
    {
        Debug.Log("Blue tank clicked!");
        tankSpawner.SpawnTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }
    public void GreenTankSelected()
    {
        Debug.Log("Blue tank clicked!");
        tankSpawner.SpawnTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);

    }
    public void RedTankSelected()   
    {
        Debug.Log("Blue tank clicked!");
        tankSpawner.SpawnTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
