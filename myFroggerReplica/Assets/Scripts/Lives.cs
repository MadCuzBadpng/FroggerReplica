using UnityEngine.UI;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static int CurrentLife = IntroStuff.StartLife;
    public Text lifeText;
    
    

    void Start()
    {
        lifeText.text = ("LIVES: " + CurrentLife.ToString());
    }

}
