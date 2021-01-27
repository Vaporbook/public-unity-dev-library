using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenteredTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject map = Terrain.CreateTerrainGameObject(new TerrainData());
        Vector3 TS = map.GetComponent<Terrain>().terrainData.size;
        Vector3 vector3 = new Vector3(-TS.x / 2, 0, -TS.z / 2);
        map.transform.position = vector3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
