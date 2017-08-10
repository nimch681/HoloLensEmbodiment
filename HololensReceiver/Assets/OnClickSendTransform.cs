using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSendTransform : MonoBehaviour {

    GameObject pointCloudReciever;
     GameObject referenceObject;

    public void Awake()
    {
        pointCloudReciever = GameObject.FindGameObjectWithTag("PointCloudR");
        referenceObject = GameObject.FindGameObjectWithTag("Target");
    }

    

    public void OnSelect()
    {
        /// Debug.Log(this.transform);
        // Debug.Log(pointCloudReciever.name);
        // Debug.Log(this.transform.rotation.y);

        // Quaternion rotation = this.transform.rotation;
        // Vector3 rot =  rotation.eulerAngles;
        //pointCloudReciever.transform.rotation = Quaternion.Euler(pointCloudReciever.transform.rotation.x, rot.y, rot.z);

        //pointCloudReciever.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+0.105f,  this.transform.position.z);
        
        referenceObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y,  this.transform.position.z);
        //pointCloudReciever.transform.position = referenceObject.transform.position;
    }
}
