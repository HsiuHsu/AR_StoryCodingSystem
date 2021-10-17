using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
public class ARReferencePointController : MonoBehaviour
{
    ARAnchorManager pointManager;
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hits;
    List<ARAnchor> refPoints;
    Button cleanUp;

    private void OnEnable()
    {
        pointManager = GetComponent<ARAnchorManager>();
        raycastManager = GetComponent<ARRaycastManager>();
        hits = new List<ARRaycastHit>();
        refPoints = new List<ARAnchor>();
        cleanUp = FindObjectOfType<Button>();
        
    }
    void Update()
    {
        if (Input.touchCount == 0) return;
        CreateObj();
        cleanUp.onClick.AddListener(cleanUpObj);
    }
    private void CreateObj()
    {
        Vector2 pos = Input.GetTouch(0).position;
        if (raycastManager.Raycast(pos, hits))
        {
            refPoints.Add(pointManager.AddAnchor(hits[0].pose));
        }
    }

    private void cleanUpObj()
    {
        foreach(var point in refPoints)
        {
            pointManager.RemoveAnchor(point);
        }
        refPoints.Clear();
    }

    
}
