using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{
    public InputField inputname;
    public Text Name;
    public static string username;

    public void CallInput()
    {
        username = inputname.text;
    }

    void Awake()
    {

        Name.text = ("NAME: " + username); 
    }

}
