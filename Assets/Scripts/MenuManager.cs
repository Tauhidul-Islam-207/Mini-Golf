using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public List<Button> starButton; 
    private Color defaultWhite = new Color(1.0f, 1.0f, 1.0f, 0.1176f);
    public GameObject windowBackground;
    public GameObject ratingPanel;
    public GameObject settingPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ExitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void RateClick()
    {
        windowBackground.SetActive(true);
        ratingPanel.SetActive(true);
    }

    public void Settings()
    {
        windowBackground.SetActive(true);
        settingPanel.SetActive(true);
    }

    public void CloseMessage()
    {
        ratingPanel.SetActive(false);
        settingPanel.SetActive(false);
        windowBackground.SetActive(false);
    }

    public void RatingClick(Button clickedButton)
    {
        for(int i=0; i<starButton.Count; i++)
        {
            if(clickedButton == starButton[i])
            {
                for(int j=0; j<=i; j++)
                {
                    starButton[j].image.color = Color.yellow;
                }

                for(int k=i+1; k<starButton.Count; k++)
                {
                    starButton[k].image.color = defaultWhite;
                }
            }
        }

        ratingPanel.transform.GetChild(1).gameObject.SetActive(true);
    }
}
