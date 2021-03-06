using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vaporbook.UnityTools {

    // CenteredTerrain will create a terrain and center it in the view
    public static class CenteredTerrain
    {
        // Start is called before the first frame update
        public static void spawn()
        {
            GameObject map = Terrain.CreateTerrainGameObject(new TerrainData());
            Vector3 TS = map.GetComponent<Terrain>().terrainData.size;
            Vector3 vector3 = new Vector3(-TS.x / 2, 0, -TS.z / 2);
            map.transform.position = vector3;
        }
    }

    public static class Transforms
    {
        public static GameObject centerInWorld(GameObject gameObject)
        {
            Vector3 offsetCoords = new Vector3(-gameObject.size.x / 2, -gameObject.size.z / 2);
            gameObject.transform.position = offsetCoords;
            return gameObject;
        }
    }

    public static class Utils
    {
        public static void doStuff()
        {
            return;
        }
    }
}
