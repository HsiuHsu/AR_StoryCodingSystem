using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class FurnitureSpawner : MonoBehaviour
{
    public List<GameObject> furnitures;
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private string furName;
    private GameObject tempG;
    Camera cam;
    Transform catchObj;
    private bool isRotateObj = false;
    // Start is called before the first frame update
    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isRotateObj)
        {
            PlaceFurniture();
        }
        else
        {
            RotateFurniture();
        }
    }

    public void SetFurnitureName(string Name)
    {
        furName = Name;
    }
    private void PlaceFurniture()
    {

            if (Input.touchCount == 0) return;

            Vector2 tempPos = Input.GetTouch(0).position;
            if (Input.GetTouch(0).phase == TouchPhase.Began && raycastManager.Raycast(tempPos, hits))
            {
                  switch (furName)
                {
                    case "boyfourclapping":
                    furnitures[0].SetActive(true);
                    furnitures[0].transform.position = hits[0].pose.position;
                    //tempG = Instantiate(furnitures[0], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "dadhug":
                    furnitures[1].SetActive(true);
                    furnitures[1].transform.position = hits[0].pose.position;
                    //tempG = Instantiate(furnitures[1], hits[0].pose.position, Quaternion.identity, transform);
                        furName = null;
                        break;
                    case "momhug":
                    furnitures[2].SetActive(true);
                    furnitures[2].transform.position = hits[0].pose.position;
                    //tempG = Instantiate(furnitures[2], hits[0].pose.position, Quaternion.identity, transform);
                        furName = null;
                        break;
                    case "Shakehand1":
                    furnitures[3].SetActive(true);
                    furnitures[3].transform.position = hits[0].pose.position;
                    // tempG = Instantiate(furnitures[3], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "4wavinghand":
                    furnitures[4].SetActive(true);
                    furnitures[4].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[4], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "turnwave4":
                    furnitures[5].SetActive(true);
                    furnitures[5].transform.position = hits[0].pose.position;
                    // tempG = Instantiate(furnitures[5], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "holdhanddad":
                    furnitures[6].SetActive(true);
                    furnitures[6].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[6], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "holdmom":
                    furnitures[7].SetActive(true);
                    furnitures[7].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[7], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "pathboy":
                    furnitures[8].SetActive(true);
                    furnitures[8].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[8], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "pathgirl":
                    furnitures[9].SetActive(true);
                    furnitures[9].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[8], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "momclap":
                    furnitures[10].SetActive(true);
                    furnitures[10].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[8], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                    case "hugmom":
                    furnitures[11].SetActive(true);
                    furnitures[11].transform.position = hits[0].pose.position;
                    //  tempG = Instantiate(furnitures[8], hits[0].pose.position, Quaternion.identity, transform);
                    furName = null;
                        break;
                   default:
                        return;
                }

            }
            else if (Input.GetTouch(0).phase == TouchPhase.Moved && raycastManager.Raycast(tempPos, hits))
            {
                tempG.transform.position = hits[0].pose.position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                tempG = null;
            }
        
    }
    private void RotateFurniture()
    {
        if (Input.touchCount == 0) return;
        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit pHit;
        if(Physics.Raycast(ray, out pHit,Mathf.Infinity) && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            catchObj = pHit.transform;
        }
        if(catchObj!=null)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                float y = Input.GetTouch(0).deltaPosition.y;
                Vector3 rot = new Vector3(0, y, 0);
                catchObj.Rotate(rot);
            }
        }
    }
    public void SwitchRotate()
    {
        isRotateObj = !isRotateObj;
    }
    public void ClearFurniture()
    {
        var i = 0;
        while(i < transform.childCount)
        {
            Destroy(transform.GetChild(i).gameObject);
            i++;
        }
    }
}
