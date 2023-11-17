using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FixedRobotCounter : MonoBehaviour
{
    public static FixedRobotCounter instance { get; private set; }
    public int fixedRobots = 0;
    public TMP_Text fixedRobotText;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        fixedRobotText.text = "Fixed Robots: " + fixedRobots.ToString();
    }
    public void IncreaseRobotCounter()
    {
        fixedRobots++;
        fixedRobotText.text = "Fixed Robots: " + fixedRobots.ToString();
    }
}
