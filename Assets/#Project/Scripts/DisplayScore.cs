using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    float time;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        time = PlayerPrefs.GetFloat("timer", 0.0f);
        score.text = "Time\n" + time.ToString("F2");

        animator = GetComponent<Animator>();
        if (time <= 15.0f){
            animator.SetBool("score15", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
