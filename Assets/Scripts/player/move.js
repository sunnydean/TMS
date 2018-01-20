public var jumpSpeed:float = 30.0;
private var gravity:float = 32.0;
public var runSpeed:float = 15.0;
public var walkSpeed:float = 45.0;
private var rotateSpeed:float = 150.0;

private var grounded:boolean = false;
private var moveDirection:Vector3 = Vector3.zero;
private var isWalking:boolean = false;
private var moveStatus:String = "idle";
static var dead : boolean = false;
private var jumped = false;
private var jumpdir:Vector3 = Vector3.zero;
public var animat:Animator;
public var mause : GameObject;
function Awake ()
{
    var animat:Animator = GetComponent(Animator);
}
function Update ()
{

    if(dead == false) {


        if(grounded) {

            moveDirection = new Vector3(0, 0, 0);

         

            if (Input.GetMouseButton(1)&& Input.GetMouseButton(0)){
                moveDirection = new Vector3(0,0,1);
                Cursor.visible = false; 
                animat.SetBool("walk",true);
                moveStatus = "walking";
               


            }

            else {
                Cursor.visible = true;
                animat.SetBool("walk",false);
                moveStatus = "ídle";


            }
           

            //moveDirection = new Vector3();
            //   if(Input.GetMouseButton(1) ) {
            // moveDirection *= .7;
			
            //         }
		
            moveDirection = transform.TransformDirection(moveDirection);
   
            

            moveDirection *= isWalking ? walkSpeed : runSpeed;
		
            if(moveDirection == Vector3.zero){
                moveStatus =  "idle";
                animat.SetBool("run",false);
                mause.SetActive (true);
                       
            }
            moveStatus = "idle";
            if(moveDirection != Vector3.zero){
                mause.SetActive (false);

                moveStatus = isWalking ? "running" : "walking";
                if (moveStatus == "running"){animat.SetBool("run",true); }
                if (moveStatus != "running"){animat.SetBool("run",false);}           
            }
		
            if (Input.GetKeyDown(KeyCode.Space))
		
                moveDirection.y = jumpSpeed;
        }

        if(Input.GetMouseButton(1)) {
            Cursor.visible = false; 

            transform.rotation = Quaternion.Euler(0,Camera.main.transform.eulerAngles.y,0);
        } 
        else{
            Cursor.visible = true;
        }
        
    }
    

    //else {
    //  transform.Rotate(0,Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
		
    //}
       
    if(Input.GetKeyDown("caps lock"))
        isWalking = !isWalking;

    moveDirection.y -= gravity * Time.deltaTime;

    var controller:CharacterController = GetComponent(CharacterController);
    var flags = controller.Move(moveDirection * Time.deltaTime);
    grounded = (flags & CollisionFlags.Below) != 0;
	

}
	



@script RequireComponent(CharacterController)