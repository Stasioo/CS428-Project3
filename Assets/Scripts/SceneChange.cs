using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void loadPlaysetVersion()
    {
        SceneManager.LoadScene("PlaysetVersion");
    }

    public void loadOriginalVersion()
    {
        SceneManager.LoadScene("ScareCoOffices");
    }
    public void loadGiantVersion()
    {
        Debug.Log("Loaded giant version scene");
    }

    public void loadCeilingVersion()
    {
        Debug.Log("Loaded ceiling version scene");
    }
}
