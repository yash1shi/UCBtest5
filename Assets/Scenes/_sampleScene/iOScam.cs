using UnityEngine;
using UnityEngine.iOS;
using System.Collections;



public class iOScam : MonoBehaviour
{
    IEnumerator Start()
    {
        findWebCams();

        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            Debug.Log("webcam found");
        }
        else
        {
            Debug.Log("webcam not found");
        }



    void findWebCams()
    {
        foreach (var device in WebCamTexture.devices)
        {
            Debug.Log("Name: " + device.name);
        }
    }


}
