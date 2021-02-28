using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntroStuff : MonoBehaviour
{
    public Dropdown dropdown;
    public bool check = false;
    public static bool Mark = false;
    public Slider slider;
    public static int StartLife;
    private int droplife;
    public Text lifeText;


    public void Awake()
    {
        slider = GameObject.FindWithTag("speed").GetComponent<Slider>();

    }
    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }
    public void sliderCallBack(Slider slider)
    {
        Car.maxSpeed = slider.value;
    }

    public void Play()
    {
        if(check == false)
        {
            StartLife = droplife;
        }
        else
        {
            StartLife = droplife;
        }
        SceneManager.LoadScene(1);
    }

    public void Drop()
    {
        switch (dropdown.value)
        {
            default:
                droplife = 3;
                check = true;
                break;
            case 1:
                droplife = 1;
                check = true;
                break;
            case 2:
                droplife = 2;
                check = true;
                break;
            case 3:
                droplife = 3;
                check = true;
                break;
        }
    }

    void Update()
    {
        lifeText.text = ("LIVES: " + droplife.ToString());
        if (Lives.CurrentLife == 0)
        {
            Lives.CurrentLife = droplife;
            Score.CurrentScore = 0;
        }
        if (Mark == true)
        {
            Lives.CurrentLife = droplife;
            Score.CurrentScore = 0;
            Mark = false;
        }
    }
    
}
