﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel, tankView);
    }

}
