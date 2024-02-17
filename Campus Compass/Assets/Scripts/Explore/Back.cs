using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadEditName()
    {
        SceneManager.LoadSceneAsync("EditName");

    }

    public void LoadExploreMain()
    {
        SceneManager.LoadSceneAsync("ExploreMain");

    }

    public void LoadSettings()
    {
        SceneManager.LoadSceneAsync("Settings");

    }

    public void MainAppScene()
    {
        SceneManager.LoadSceneAsync("Main");

    }

    public void SoundScene()
    {
        SceneManager.LoadSceneAsync("Sounds");

    }

    public void AvatarScene()
    {
        SceneManager.LoadSceneAsync("Avatar");

    }

    public void LoadMapUI()
    {
        SceneManager.LoadSceneAsync("Map UI");
    }


}
