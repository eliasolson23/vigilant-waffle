using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
///Detects when the ball touches the goal, and then win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public string nextScene;
    public GameObject winText;
    private AudioSource audioSource;
    public GameObject destroyObject;
    public bool destroyed = false;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void FixedUpdate()
    {
        if (destroyed)
        {
            Destroy(destroyObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.tag == "Player")
        {
            winText.SetActive(true);

            audioSource.Play();

            destroyed = true;

            StartCoroutine(ExecuteAfterTime(2));
        }
    }

    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene(nextScene);
    }


}
