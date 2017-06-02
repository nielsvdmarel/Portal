using UnityEngine;
using System.Collections;
//using UnityEditor;
using UnityEngine.SceneManagement;

public class TextureSetup : MonoBehaviour {

    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;
    public Camera camera10;
    public Camera camera11;
    public Camera camera12;
    public Camera camera13;
    public Camera camera14;
    

    public Material camera1Mat;
    public Material camera2Mat;
    public Material camera3Mat;
    public Material camera4Mat;
    public Material camera5Mat;
    public Material camera6Mat;
    public Material camera7Mat;
    public Material camera8Mat;
    public Material camera9Mat;
    public Material camera10Mat;
    public Material camera11Mat;
    public Material camera12Mat;
    public Material camera13Mat;
    public Material camera14Mat;
    

    // When game starts remove current camera textures and set new textures with the dimensions of the players screen
    void Start()
    {
        if (camera1.targetTexture != null)
        {
            camera1.targetTexture.Release();
        }
        camera1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera1Mat.mainTexture = camera1.targetTexture;

        if (camera2.targetTexture != null)
        {
            camera2.targetTexture.Release();
        }
        camera2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera2Mat.mainTexture = camera2.targetTexture;
        
        if (camera3.targetTexture != null)
        {
            camera3.targetTexture.Release();
        }
        camera3.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera3Mat.mainTexture = camera3.targetTexture;
        
        if (camera4.targetTexture != null)
        {
            camera4.targetTexture.Release();
        }
        camera4.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera4Mat.mainTexture = camera4.targetTexture;
        
        if (camera5.targetTexture != null)
        {
             camera5.targetTexture.Release();
        }
           camera5.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
           camera5Mat.mainTexture = camera5.targetTexture;
        
        if (camera6.targetTexture != null)
        {
            camera6.targetTexture.Release();
        }
        camera6.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera6Mat.mainTexture = camera6.targetTexture;
        
        if (camera7.targetTexture != null)
        {
            camera7.targetTexture.Release();
        }
        camera7.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera7Mat.mainTexture = camera7.targetTexture;
        
        if (camera8.targetTexture != null)
        {
            camera8.targetTexture.Release();
        }
        camera8.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera8Mat.mainTexture = camera8.targetTexture;
        
        if (camera9.targetTexture != null)
        {
            camera9.targetTexture.Release();
        }
        camera9.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera9Mat.mainTexture = camera9.targetTexture;
        
        if (camera10.targetTexture != null)
        {
            camera10.targetTexture.Release();
        }
        camera10.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera10Mat.mainTexture = camera10.targetTexture;
        
        if (camera11.targetTexture != null)
        {
            camera11.targetTexture.Release();
        }
        camera11.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera11Mat.mainTexture = camera11.targetTexture;
        
        if (camera12.targetTexture != null)
        {
            camera12.targetTexture.Release();
        }
        camera12.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera12Mat.mainTexture = camera12.targetTexture;
        
        if (camera13.targetTexture != null)
        {
            camera13.targetTexture.Release();
        }
        camera13.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera13Mat.mainTexture = camera13.targetTexture;
        
        if (camera14.targetTexture != null)
        {
            camera14.targetTexture.Release();
        }
        camera14.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera14Mat.mainTexture = camera14.targetTexture;


    }

}
