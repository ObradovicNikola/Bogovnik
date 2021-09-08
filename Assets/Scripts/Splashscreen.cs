using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        img.canvasRenderer.SetAlpha(0.0f);
        Invoke("LoadMainScene", 2.1f);

        img.CrossFadeAlpha(1, 2, false);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
