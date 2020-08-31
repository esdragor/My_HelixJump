using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] Text points;
    [SerializeField] Text Achievement;
    [SerializeField] GameObject pivotPoint;
    [SerializeField] GameObject NextLevel;

    int IndexPass = 0;
    int NbOfPoints = 0;
    float nbPass = 0;
    int nbofPlatform = 0;

    void Start()
    {
        nbofPlatform = pivotPoint.transform.childCount - 3;


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        IndexPass++;
        NbOfPoints += 30 * IndexPass;
        nbPass += (1.0f / nbofPlatform) * 100f;
        Achievement.text = ((int)nbPass).ToString() + "%";
        points.text = NbOfPoints.ToString();
        Destroy(other.gameObject);
    }

    void EndGame()
    {
        NextLevel.SetActive(true);
        Destroy(gameObject);
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            GameOver();
        }
        else if (collision.gameObject.tag == "Finish")
        {
            EndGame();
        }
        else if (IndexPass >= 3)
            Destroy(collision.gameObject);
        IndexPass = 0;
    }
}
