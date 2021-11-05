using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    private bool _dirtyFlag;

    private void Start()
    {
        _dirtyFlag = false;
    }

    private void Win()
    {
       
            SceneManager.LoadScene(3);
        
    }

    private void Update()
    {
        if (_dirtyFlag)
        Win();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            _dirtyFlag = true;
        }
    }
}
