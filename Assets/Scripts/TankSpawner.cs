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
    
    public void SpawnTank(TankTypes _type)
    {
        int index = (int) _type;
        Debug.Log("index from type is " + index);
        // ? isnt tank view just empty variable at this moment?
        TankModel tankModel = new TankModel(tankList[index].movementSpeed,tankList[index].rotationSpeed, tankList[index].Tanktype, tankList[index].tankMat);
        TankController tankController = new TankController(tankModel, tankView);
    }

}
