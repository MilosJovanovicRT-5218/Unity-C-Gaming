using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscMenu : MonoBehaviour
{

    public GameObject menuEsc;
    public static bool gameIsPaused;


    public bool lockCursor = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockCursor = !lockCursor;
            ///Cursor.lockState = CursorLockMode.None;
            ///Cursor.visible = true;
            ///Cursor.lockState = CursorLockMode.None;
            //   Cursor.lockState = CursorLockMode.None;
            // Cursor.visible = true;
            menuEsc.gameObject.SetActive(!menuEsc.gameObject.activeSelf);
            ///Cursor.visible = true;
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //////void OnGUI()
    //////{
    //////    //Press this button to lock the Cursor
    //////    if (GUI.Button(new Rect(0, 0, 100, 50), "Lock Cursor"))
    //////    {
    //////        Cursor.lockState = CursorLockMode.Locked;
    //////    }

    //////    //Press this button to confine the Cursor within the screen
    //////    if (GUI.Button(new Rect(125, 0, 100, 50), "Confine Cursor"))
    //////    {
    //////        Cursor.lockState = CursorLockMode.Confined;
    //////    }
    //////}

}
