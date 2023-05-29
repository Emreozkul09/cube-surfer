using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private herocontroller heroInputController;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;
    private float newpositionX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() 
    {
        setHeroForwardMovement();
        setHeroHorizontalMovement();
    }
    private void setHeroForwardMovement(){
        transform.Translate(Vector3.down*forwardMovementSpeed*Time.fixedDeltaTime);
    }
    private void setHeroHorizontalMovement(){
        newpositionX=transform.position.x+heroInputController.HorizontalValue*horizontalMovementSpeed*Time.fixedDeltaTime;
        newpositionX=Mathf.Clamp(newpositionX,-horizontalLimitValue,horizontalLimitValue);
        transform.position=new Vector3(newpositionX,transform.position.y,transform.position.z);
    }
}
