using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadController : MonoBehaviour {

    public int xbox = 0;
    public int ps = 0;

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


        if (xbox == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
