using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public GameObject PrefabObject = null;

    public void SpawnPrefab()
    {
        //position over ground
        Renderer rGrd = this.GetComponent<Renderer>();
        Renderer rPrefab = PrefabObject.GetComponent<Renderer>();
        float X = Random.Range(rGrd.bounds.min.x + rPrefab.bounds.extents.x, rGrd.bounds.max.x - rPrefab.bounds.extents.x);
        float Y = rGrd.bounds.max.y + rPrefab.bounds.extents.y;
        float Z = Random.Range(rGrd.bounds.min.z + rPrefab.bounds.extents.z, rGrd.bounds.max.z - rPrefab.bounds.extents.z);

        //create prefab in scene
        GameObject box = Instantiate(PrefabObject, new Vector3(X, Y, Z), Quaternion.identity);
        box.GetComponent<Renderer>().material.color = Random.ColorHSV(); //rnadom color
    }
}
