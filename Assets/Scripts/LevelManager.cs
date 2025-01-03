using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> level;
    public int startIndex = 0;
    public GameObject windowBackground;
    public GameObject gameOverScreen;
    public GameObject howToPlayScreen;
    public TextMeshProUGUI levelText;
    public AudioSource goalSound;
    public AudioSource swingSound;
    public AudioSource gameOverSound;
    
    // Start is called before the first frame update
    void Start()
    {
        startIndex = 0;
        LoadLevel(startIndex);
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level : " + (startIndex+1);
    }

    public void LoadLevel(int levelIndex)
    {
        level[levelIndex].gameObject.SetActive(true);
    }

    public void CloseLevel(int levelIndex)
    {
        level[levelIndex].gameObject.SetActive(false);
    }

    public void NextLevelClick()
    {
        if(startIndex < level.Count)
        {
            CloseLevel(startIndex);
            startIndex++;
            
            if(startIndex < level.Count)
            {
                LoadLevel(startIndex);
            }
            
            else
            {
                Debug.Log("GAME OVER!");
                windowBackground.SetActive(true);
                gameOverScreen.SetActive(true);
                gameOverSound.Play();
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void HowToPlay()
    {
        windowBackground.SetActive(true);
        howToPlayScreen.SetActive(true);
    }

     public void CloseMessage()
    {
        howToPlayScreen.SetActive(false);
        windowBackground.SetActive(false);
    }

}
