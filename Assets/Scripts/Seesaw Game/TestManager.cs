using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField]
    private List<Interactable> buttons;

    [SerializeField]
    private List<GameObject> cubes;

    [SerializeField]
    private GameObject balance;

    [SerializeField]
    private RoomController controller;

    private int step = 0;
    [SerializeReference]
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        balance.GetComponent<Rotate>().RotateTo(0f);
        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        switch (step)
        {
            case 0:
                if (timer <= 0)
                {
                    step = 1;
                    timer = 1;
                }
                break;

            case 1:
                cubes[0].SetActive(true);
                balance.GetComponent<Rotate>().RotateTo(10f);
                if (timer <= 0) { step = 2; }
                
                break;
            case 2:
                buttons[0].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    timer = 5;
                    cubes[1].SetActive(true);
                    buttons[0].gameObject.SetActive(false);
                    step = 3;
                }
                break;
            case 3:
                balance.GetComponent<Rotate>().RotateTo(0f);

                if (timer <= 0) { step = 4; }
                break;



            case 4:
                cubes[2].SetActive(true);
                balance.GetComponent<Rotate>().RotateTo(-10f);
                if (timer <= 0) { step = 5; }
                break;
            case 5:
                buttons[1].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    timer = 5;
                    cubes[3].SetActive(true);
                    buttons[1].gameObject.SetActive(false);
                    step = 6;
                }
                break;
            case 6:
                balance.GetComponent<Rotate>().RotateTo(0f);

                if (timer <= 0) { step = 7; }
                break;



            case 7:
                cubes[4].SetActive(true);
                balance.GetComponent<Rotate>().RotateTo(10f);
                if (timer <= 0) { step = 8; }
                break;
            case 8:
                buttons[2].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    timer = 5;
                    cubes[5].SetActive(true);
                    buttons[2].gameObject.SetActive(false);
                    step = 9;
                }
                break;
            case 9:
                balance.GetComponent<Rotate>().RotateTo(0f);

                if (timer <= 0) { step = 10; }
                break;

            case 10:
                controller.InteractableClicked("balanceRoomEnd");
                break;
        }
    }
}
