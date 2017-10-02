using UnityEngine;
using System.Collections;

public class ChangeBinds: MonoBehaviour {

    private Variables var;

    private void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
    }

    // Update is called once per frame
    void Update () {
        //var.moveForward = KeyAction.forward;

        if (KeyBindingManager.GetKeyDown(KeyAction.forward))
        {

        }
    }
}
