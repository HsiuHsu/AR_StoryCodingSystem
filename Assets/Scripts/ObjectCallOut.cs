using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCallOut : MonoBehaviour
{
    public GameObject[] Furniture;
    public Transform SpawnPos;
    public Transform SpawnPos2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FurSpawn0()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[0], SpawnPos2.position, q);
    }
    public void FurSpawn1()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[1], SpawnPos2.position, q);
    }
    public void FurSpawn2()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[2], SpawnPos2.position, q);
    }
    public void FurSpawn3()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[3], SpawnPos2.position, q);
    }
    public void FurSpawn4()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[4], SpawnPos2.position, q);
    }
    public void FurSpawn5()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[5], SpawnPos2.position, q);
    }
    public void FurSpawn6()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[6], SpawnPos2.position, q);
    }
    public void FurSpawn7()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[7], SpawnPos2.position, q);
    }
    public void FurSpawn8()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[8], SpawnPos2.position, q);
    }
    public void FurSpawn9()
    {
        var rot = SpawnPos2.transform.rotation.eulerAngles;
        Quaternion q = Quaternion.Euler(0, rot.y, 0);
        GameObject Fur = Instantiate(Furniture[9], SpawnPos2.position, q);
    }
}
