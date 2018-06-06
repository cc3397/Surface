using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_load : MonoBehaviour {

    // Use this for initialization

    Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("Crouching", true);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                animator.SetBool("Running", true);
            }

    }

    public void LoadScene(int sceneID)
    {

        SceneManager.LoadScene(sceneID);
    }
}
