using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Pantalla en negro
    public Image blackBG;

    // Funcion para cargar una escena
    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(FadeOut(sceneIndex));
    }

    // Funcion para salir del juego
    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator FadeIn()
    {
        Color c = blackBG.color;
        for(float alpha = 1f; alpha >= 0f; alpha -= 2f * Time.deltaTime)
        {
            c.a = alpha;
            blackBG.color = c;
            yield return null;
        }
    }

    IEnumerator FadeOut(int sceneIndex)
    {
        Color c = blackBG.color;
        for (float alpha = 0f; alpha <= 1f; alpha += 2f * Time.deltaTime)
        {
            c.a = alpha;
            blackBG.color = c;
            yield return null;
        }

        // Cambio de escena
        SceneManager.LoadScene(sceneIndex);
    }
}
