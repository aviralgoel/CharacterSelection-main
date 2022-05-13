//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{   

    // ? Why does it not appear without System.Serializabale 
    [System.Serializable]
    public class TankStats
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes Tanktype;
        public Material tankMat;

    }

    public List<TankStats> tankList;
    // ? where  does this variable get its reference/value? 
    // ? is it from Unity Inspector when we drag and drop?
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {   
        // ? isnt tank view just empty variable at this moment?
        TankModel tankModel = new TankModel(tankList[0].movementSpeed,tankList[0].rotationSpeed, tankList[0].Tanktype, tankList[0].tankMat);
        TankController tankController = new TankController(tankModel, tankView);
    }

}
