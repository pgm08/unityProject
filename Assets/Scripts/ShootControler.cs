using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControler : MonoBehaviour
{
    public GameObject tiroPrefab;
    public float forceSpeedFile;
    public bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire1") && isPlayer)
        {

        }
    }

    public void Atirar()
    {
        GameObject tempoTiro = Instantiate(tiroPrefab) as GameObject;
        tempoTiro.transform.position = transform.position;


    }
}
