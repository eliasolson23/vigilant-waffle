using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
 

    // Update is called once per frame
    public GameObject loseText;
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
            loseText.SetActive(true);

            audioSource.Play();

            destroyed = true;

            StartCoroutine(ExecuteAfterTime(2));
        }
    }

    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("MainMenu");
    }
}
