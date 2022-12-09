using UnityEngine.SceneManagement;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public static bool  GameOver;
    public GameObject pauseMenuScreen;
    public void Completelevel()
    {
        Debug.Log("Level won!");
    }
    private void Awake()
    {
        GameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }
    public void gotomenu()
    {
        SceneManager.LoadScene("start");
    }
}
