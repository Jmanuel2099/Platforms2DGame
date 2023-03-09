using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelCheckpoint : MonoBehaviour
{
    // [SerializeField] private GameObject transition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && FruitManager.isAllFruitsCollected)
        {
            GetComponent<Animator>().enabled = true;
            // transition.SetActive(true);
            Invoke("LevelUp", 3);
        }

    }

    private void LevelUp()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}