using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botton1_Click : MonoBehaviour
{
    public Button mButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = mButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel(1);
    }

}
