using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGameController : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isPaused = false;
    public Sprite resumeSprite;
    public Sprite pauseSprite;
    public Image uiImage;

    void Start()
    {
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
    }


    //Interaccion con tecla escape
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //si esta pausado, lo reaunuda
            if (isPaused)
            {
                ResumeGame();
            }

            //si no lo pausa
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        if (uiImage != null && resumeSprite != null)
        {
            uiImage.sprite = resumeSprite;
        }

        //GameObjtect de pausa
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
            if (!isPaused)
            {
                Pause();
            }
            else {
                resume();
            }
    }

    private void resume()
    {
        if (uiImage != null && pauseSprite != null)
        {
            uiImage.sprite = pauseSprite;
        }

        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
