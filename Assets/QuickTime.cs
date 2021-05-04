using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTime : MonoBehaviour
{
    public float timeLimit = 1.0f;
    public float minTime = 2.0f;
    public float maxTime = 4.0f;

    public GameObject prompt;

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));

        prompt.SetActive(true);
        bool pressed = false;

        while (timeLimit > 0.0f)
        {
            timeLimit -= Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                pressed = true;
                break;
            }
            yield return null;
        }

        prompt.SetActive(false);

        if (pressed)
        {
            Debug.Log("Well done!");
        }
        else
        {
            Debug.Log("oops");
        }
    }
}
