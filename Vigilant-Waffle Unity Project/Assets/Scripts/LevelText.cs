using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    public GameObject levelText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(1));
    }

    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        levelText.SetActive(false);
    }

    // Update is called once per frame

}
