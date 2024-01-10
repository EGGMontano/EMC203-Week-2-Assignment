using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDK : MonoBehaviour
{
    public GameObject cubePrefab;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-30,31),3,0);
            Instantiate(cubePrefab,randomSpawnPosition,Quaternion.identity);
        }
    }
}
