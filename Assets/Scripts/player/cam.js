var target:Transform; 							// Target to follow
var targetHeight = 1.7; 						// Vertical offset adjustment
var distance = 12.0;							// Default Distance
var offsetFromWall = 0.1;						// Bring camera away from any colliding objects
var maxDistance = 20; 						// Maximum zoom Distance
var minDistance = 0.6; 						// Minimum zoom Distance
var xSpeed = 200.0; 							// Orbit speed (Left/Right)
var ySpeed = 200.0; 							// Orbit speed (Up/Down)
var yMinLimit = -80; 							// Looking up limit
var yMaxLimit = 80; 							// Looking down limit
var zoomRate = 40; 							// Zoom Speed
var rotationDampening = 3.0; 				// Auto Rotation speed (higher = faster)
var zoomDampening = 5.0; 					// Auto Zoom speed (Higher = faster)
var collisionLayers:LayerMask = -1;		// What the camera will collide with
var lockToRearOfTarget = false;				// Lock camera to rear of target
var allowMouseInputX = true;				// Allow player to control camera angle on the X axis (Left/Right)
var allowMouseInputY = true;				// Allow player to control camera angle on the Y axis (Up/Down)

private var xDeg = 0.0; 
private var yDeg = 0.0; 
private var currentDistance; 
private var desiredDistance; 
private var correctedDistance; 
private var rotateBehind = false;



function Start () 
{ 
    var angles:Vector3 = transform.eulerAngles; 
    xDeg = angles.x; 
    yDeg = angles.y; 
    currentDistance = distance; 
    desiredDistance = distance; 
    correctedDistance = distance; 
	    if (GetComponent.<Rigidbody>()) 
        GetComponent.<Rigidbody>().freezeRotation = true;
		
    if (lockToRearOfTarget)
        rotateBehind = true;
} 
    
function LateUpdate () 
{ 



    if (!target) 
        return;
	
    var vTargetOffset:Vector3;
    	
	 
    if (GUIUtility.hotControl == 0)
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)) 
        { 
            if (allowMouseInputX)
                xDeg += Input.GetAxis ("Mouse X") * xSpeed * 0.02; 
            else
                RotateBehindTarget();
            if (allowMouseInputY)
                yDeg -= Input.GetAxis ("Mouse Y") * ySpeed * 0.02; 
			
            if (!lockToRearOfTarget)
                rotateBehind = false;
        } 
		
        else if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0 || rotateBehind) 
        {
            //RotateBehindTarget();
        } 
    }
    yDeg = ClampAngle (yDeg, yMinLimit, yMaxLimit); 

    var rotation:Quaternion = Quaternion.Euler (yDeg, xDeg, 0); 

    desiredDistance -= Input.GetAxis ("Mouse ScrollWheel") * Time.deltaTime * zoomRate * Mathf.Abs (desiredDistance); 
    desiredDistance = Mathf.Clamp (desiredDistance, minDistance, maxDistance); 
    correctedDistance = desiredDistance; 

    vTargetOffset = Vector3 (0, -targetHeight, 0);
    var position:Vector3 = target.position - (rotation * Vector3.forward * desiredDistance + vTargetOffset); 

    var collisionHit:RaycastHit; 
    var trueTargetPosition:Vector3 = Vector3 (target.position.x, target.position.y + targetHeight, target.position.z); 

    var isCorrected = false; 
    if (Physics.Linecast (trueTargetPosition, position, collisionHit, collisionLayers)) 
    { 
        
        correctedDistance = Vector3.Distance (trueTargetPosition, collisionHit.point) - offsetFromWall; 
        isCorrected = true;
    }

    currentDistance = !isCorrected || correctedDistance > currentDistance ? Mathf.Lerp (currentDistance, correctedDistance, Time.deltaTime * zoomDampening) : correctedDistance; 

    currentDistance = Mathf.Clamp (currentDistance, minDistance, maxDistance); 

    position = target.position - (rotation * Vector3.forward * currentDistance + vTargetOffset); 
	
    transform.rotation = rotation; 
    transform.position = position; 
} 

function RotateBehindTarget()
{
    var targetRotationAngle:float = target.eulerAngles.y; 
    var currentRotationAngle:float = transform.eulerAngles.y; 
    xDeg = Mathf.LerpAngle (currentRotationAngle, targetRotationAngle, rotationDampening * Time.deltaTime);
	
    if (targetRotationAngle == currentRotationAngle)
    {
        if (!lockToRearOfTarget)
            rotateBehind = false;
    }
    else
        rotateBehind = true;

}


static function ClampAngle (angle : float, min : float, max : float)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp (angle, min, max);
    }