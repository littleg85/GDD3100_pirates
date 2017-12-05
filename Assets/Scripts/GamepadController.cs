using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GamepadController : MonoBehaviour {

    public int xbox = 0;
    public int ps = 0;

    private Vector2 JoystickCursor;
    private float joyX = 0;
    private float joyY = 0;
    private bool canClick = true;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        //Select which controller
        string[] names = Input.GetJoystickNames();
        for (int x = 0; x < names.Length; x++)
        {
            print(names[x].Length);
            if (names[x].Length == 19)
            {
                print("PS4 CONTROLLER IS CONNECTED");
                ps = 1;
                xbox = 0;
            }
            if (names[x].Length == 33)
            {
                print("XBOX ONE CONTROLLER IS CONNECTED");
                //set a controller bool to true
                ps = 0;
                xbox = 1;

            }
        }

        JoystickCursor = new Vector2(Screen.width/2, Screen.height/2);
    }

    private void Update()
    {
        if (xbox == 1 && SceneManager.GetActiveScene().name != "Game")
        {
            if (Input.GetAxis("A Button") == 1 && canClick)
            {
                CursorControl.SimulateLeftClick();
                canClick = false;
                StartCoroutine(ClickDelay());
            }

            joyX += Input.GetAxis("Mouse X") * 500 * Time.deltaTime;
            joyY += Input.GetAxis("Mouse Y") * 500 * Time.deltaTime;

            JoystickCursor = new Vector2(joyX, joyY);

            CursorControl.SetLocalCursorPos(JoystickCursor);
        }
    }

    IEnumerator ClickDelay()
    {
        yield return new WaitForSeconds(1.0f);
        canClick = true;
    }
}
