//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{   

    // ? Q1. Why does it not appear without System.Serializabale 
    [System.Serializable]
    public class TankStats
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes Tanktype;
        public Material tankMat;

    }

    public List<TankStats> tankList;
    public TankView tankView;
    // Start is called before the first frame update
    
    public void SpawnTank(TankTypes _type)
    {
        int index = (int) _type;
        // Debug.Log("index from type is " + index);
        
        TankModel tankModel = new TankModel(tankList[index].movementSpeed,tankList[index].rotationSpeed, tankList[index].Tanktype, tankList[index].tankMat);
        TankController tankController = new TankController(tankModel, tankView);
    }

}
