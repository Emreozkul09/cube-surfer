using UnityEngine;

public class herocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalValue;
    public float HorizontalValue
    {
        get{return horizontalValue;}
    }
    void Start()
    {
        
    }

    // Update is called once per framefeds
    void Update()
    {
        handleHeroHorizontalInput();
    }
    private void handleHeroHorizontalInput(){
        if(Input.GetMouseButton(0))
        {
            horizontalValue=Input.GetAxis("Mouse X");
        }
        else 
        {
            horizontalValue=0;
        }
    }
}
