using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetWorld : MonoBehaviour {

    public void OnSelect()
    {
        GameObject pointRenderer = GameObject.Find("PointCloudRenderer");
        Destroy(pointRenderer);
        SceneManager.LoadScene("scene");
    }
}
