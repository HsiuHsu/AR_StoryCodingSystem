using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARRaycastManager))]
public class CopyController : MonoBehaviour
{
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hits ;
    public GameObject Prefab;
    private GameObject copyPrefab;
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        hits = new List<ARRaycastHit>();
    }
    void Update()
    {
        DetectHit();
    }
    private void DetectHit()
    {
        if(Input.touchCount>0)
        {
            Vector2 pose = Input.GetTouch(0).position;
            if (raycastManager.Raycast(pose, hits))
            {
                if(copyPrefab==null)
                {
                    copyPrefab = Instantiate(Prefab, hits[0].pose.position, Quaternion.identity);
                }
                else
                {
                    copyPrefab.transform.position = hits[0].pose.position;
                }
            }
        }
    }
}

