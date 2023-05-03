using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: make rockets/rocket positions more customizeable. for now we have simple rocket positions.
*/
/* TODO: make system to check for all needed components 
and to set the options of these components to the proper constant values
for now, we will assume the gameobject has a rigidbody and collider components (etc)
*/

/* TODO: 
    STEP 1:
        We should make some publicly accessible functions that can be called by a input manager or an AI module
    STEP 2:
        We make these functions capable of exerting force on the rigidbody the script is attatched to
    STEP 3:
        Add other modules as nessicary, but this is the basic design idea
*/

public class ShipController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
