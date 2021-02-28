using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndStuff : MonoBehaviour
{
    public static int endscore; 
    public static int endlives; 
    public Text end;
    
    
    void Awake()
    {
        endscore = Score.CurrentScore;
        endlives = Lives.CurrentLife;
    }
    void Start()
    {
        end.text = ("SCORE: " + endscore + "\n" + "Lives: " + endlives);
    }

    public void LoadBeginning()
    {
        SceneManager.LoadScene(0);
        IntroStuff.Mark = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
