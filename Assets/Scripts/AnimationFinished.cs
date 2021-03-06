﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationFinished : StateMachineBehaviour {

    private GameObject UI;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        UI = GameObject.Find("Cam");
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Path_Boat_Default"))
        {
            //Activate return button
            UI.GetComponent<UpgradeUI_v2>().returnBoat.SetActive(true);      

            //Activate boat upgrade buttons
            UI.GetComponent<UpgradeUI_v2>().boatButtons.SetActive(true);

            //EventSystem.current.SetSelectedGameObject(GameObject.Find("Return Button Boat"));
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Path_Towers_Default"))
        {

            //Activate return button
            UI.GetComponent<UpgradeUI_v2>().returnTower.SetActive(true);

            //Activate highlighting
            UI.GetComponent<UpgradeUI_v2>().highlight.SetActive(true);

            //EventSystem.current.SetSelectedGameObject(GameObject.Find("Return Button Tower"));
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Path_Default"))
        {
            //Activate Menu buttons
            UI.GetComponent<UpgradeUI_v2>().Play.SetActive(true);
            UI.GetComponent<UpgradeUI_v2>().Menu.SetActive(true);
            UI.GetComponent<UpgradeUI_v2>().boatButton.SetActive(true);
            UI.GetComponent<UpgradeUI_v2>().towerButton.SetActive(true);
            //EventSystem.current.SetSelectedGameObject(GameObject.Find("Boat Button"));
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
