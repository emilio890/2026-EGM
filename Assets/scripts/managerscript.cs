using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class managerscript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoretext;
    [SerializeField]
    private GameObject lose;
    [SerializeField]
    private int score;
    void Start()
    {
        Time.timeScale = 1;
    }
    
    public void gameover()
    {
        lose.SetActive(true);
    }
    public void addscore()
    {
        score += 50;
        scoretext.text = "Score: " + score.ToString();
    }
    public void resetlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
   
    void Update()
    {
        
    }
}
