#pragma strict

function Start () {

}

function Update () {
    if(Input.GetKeyDown(KeyCode.Space))
    {
        rigidbody.velocity.y = 7;
    }
}