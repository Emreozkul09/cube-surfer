using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CubeStackKontroller cubeStackKontroller;
    private Vector3 direction=Vector3.back;
    private bool isstack=false;
    private RaycastHit hit;
    void Start()
    {
        cubeStackKontroller=GameObject.FindObjectOfType<CubeStackKontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCubeRaycast();
    }
    private void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position,direction,out hit,1f))
        {
            if(!isstack)
            {
                isstack=true;
                cubeStackKontroller.IncreaseBlockStack(gameObject);
                SetDirection();
            }
            if(hit.transform.name=="aa")
            {
                cubeStackKontroller.DecreaseBlock(gameObject);
            }
        }
    }
    private void SetDirection()
    {
        direction=Vector3.forward;
    }
}
