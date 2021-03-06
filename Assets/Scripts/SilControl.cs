using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

#region Notes

//add a dash

//make sure to add a state so that the player can jump vertically along walls while pressing into the wall

#endregion

public class SilControl : MonoBehaviour
{
    #region variables
    [Header("General Variables")]
    //General Variables
    public GameObject sil;
    private SilInput input;
    [HideInInspector] public Rigidbody2D silRb;
    private bool dontSetFriction;
    private int testTimer;
    public int setTestTimer;
    public float rayLength;
    public float kbDist;
    private bool invincible;
    public float setIFrameTimer;
    private float iFrameTimer;


    [Header("Ability Variables")]
    //item/ability variables 
    public int climbDigClaws; //stores whether Sil has the climbing claws or the digging claws or neither
                              //(0 = neither, 1 = climbing claws, and 2 = both the climbing claws and the digging claws)
    public int multiJump; //stores how many extra air jumps the player has

    [Header("Collision Variables")]
    [HideInInspector] public bool onFloor = false; //notes whether Sil is touching a floor object
    [HideInInspector] public bool onWall = false; //notes whether sil is touching a wall

    [Header("Walk Variables")]
    //walk variables
    public float setWalkMoveSpeed; //set the speed at which Sil walks
    public float walkDecel; //used to detrmine how fast sil decelerates after the player stops inputting for walking movement

    [Header("Jump Variables")]
    //jump variables
    public float jumpHeight; //determines the height of a jump in general
    private bool startJump = false; //starts the jump when true
    private bool endJump = false; //ends the jump when true
    public float resetGravScale; //sets the gravScale to normal
    public float jumpGravScale; //jumping gravity scale
    public float setJumpTimer; //the number to which the jump timer is reset to
    private float jumpTimer; //the variable that governs the jump timer, ending the jump early if the jump button is not pressed
    private bool startJumpTimer = false; //starts the jump timer if true
    private int airJumpCount; //used to dynamically determine the number of air jumps sil has to use at the moment
    private int wallCoyoteTime;
    private int floorCoyoteTime;
    public int setWallCoyoteTime;
    public int setFloorCoyoteTime;

    [Header("Dash Variables")]
    //dash variables
    public int maxDash;
    private int dashCount;
    public float dashSpeed;
    private Vector2 dashDir;
    public float dashLength;
    private bool startDash;
    private bool endDash;
    private float setDashTimer;
    private float dashTimer;
    private bool startDashTimer;
    public float longJumpDistance;

    [Header("Tether Variables")]
    //tether variables
    public float bashSpeed;
    private bool canBash;
    private Rigidbody2D bashTarget;
    private bool bashing;
    public float bashVOffset;
    private RaycastHit2D tetherHit;
    public float maxTetherDist;
    private bool grappling;
    private Vector2 grappleTargetPassive;
    private Vector2 grappleTargetActive;
    private bool grappleTargetExists;
    public float grappleSpeed;
    private Vector2 grappleDir;
    int tetherLayerMask = 1 << 6;
    public int tetherCheckFlipLength;

    [Header("Speed Limits")]
    //various speed limits
    public float speedLimitX; //limits sil's horizontal speed
    public float speedLimitY; //limits sil's vertical speed
    public float normFallSpeed; //normal speed when falling under no other conditions such as wall sliding or gliding
    public float wallSlideSpeed; //speed while sliding down a wall
    public float wallJumpSpeed; //limits the speed at which the player can jump up a wall
    public float normUpSpeedLimit; //allow the player to have high positive vertical speed while on a wall
                                   //while still limiting negative speed
    public float baseGlideFallSpeed; //falling speed while gliding and not pressing any vertical inputs
    public float upGlideFallSpeed; //falling speed while gliding while also pressing the up button
    public float downGlideFallSpeed; //falling speed while gliding and also pressing the down button

    [Header("Climb Variables")]
    //climb variables
    public float climbFriction;
    public float noClimbFriction;

    [Header("Attack Variables")]
    //attack variables
    public GameObject sword;
    private bool swordAttacking = false;
    public float swordDuration;
    private float swordTimer;

    //hazard reset variables
    private Vector2 hazardResetPos;

    //Input Variables
    //private Vector2 leftStick;
    //private Vector2 rightStick;
    private float right;
    private float left;
    private float up;
    private float down;
    private Vector2 mousePos;
    [HideInInspector] public Vector2 aim;

    private float jump;
    private float glide;
    private float dash;
    private float tether;
    private float attack;

    #endregion



    #region input
    private void Awake()
    {
        //initialise all inputs
        input = new SilInput();

        //input.Normal.LeftStick.performed += context => leftStick = context.ReadValue<Vector2>();
        //input.Normal.RightStick.performed += context => rightStick = context.ReadValue<Vector2>();
        


        //input.Normal.Right.performed += RightPerformed;
        //input.Normal.Right.canceled += RightCanceled;
        input.Normal.Right.performed += context => right = context.ReadValue<float>();
        input.Normal.Right.canceled += context => right = 0;

        //input.Normal.Left.performed += LeftPerformed;
        //input.Normal.Left.canceled += LeftCanceled;
        input.Normal.Left.performed += context => left = context.ReadValue<float>();
        input.Normal.Left.canceled += context => left = 0;

        //input.Normal.Up.performed += UpPerformed;
        //input.Normal.Up.canceled += UpCanceled;
        input.Normal.Up.performed += context => up = context.ReadValue<float>();
        input.Normal.Up.canceled += context => up = 0;

        //input.Normal.Down.performed += DownPerformed;
        //input.Normal.Down.canceled += DownCanceled;
        input.Normal.Down.performed += context => down = context.ReadValue<float>();
        input.Normal.Down.canceled += context => down = 0;


        input.Normal.Jump.performed += JumpPerformed;
        input.Normal.Jump.canceled += JumpCanceled;
        input.Normal.Jump.performed += context => jump = context.ReadValue<float>();
        input.Normal.Jump.canceled += context => jump = 0;


        //input.Normal.Glide.performed += GlidePerformed;
        //input.Normal.Glide.canceled += GlideCanceled;
        input.Normal.Glide.performed += context => glide = context.ReadValue<float>();
        input.Normal.Glide.canceled += context => glide = 0;

        input.Normal.Dash.performed += DashPerformed;
        //input.Normal.Dash.canceled += DashCanceled;
        input.Normal.Dash.performed += context => dash = context.ReadValue<float>();
        input.Normal.Dash.canceled += context => dash = 0;

        input.Normal.Tether.performed += TetherPerformed;
        input.Normal.Tether.canceled += TetherCanceled;
        input.Normal.Tether.performed += context => tether = context.ReadValue<float>();
        input.Normal.Tether.canceled += context => tether = 0;

        input.Normal.Attack.performed += AttackPerformed;
        input.Normal.Attack.canceled += AttackCanceled;
        input.Normal.Attack.performed += context => attack = context.ReadValue<float>();
        input.Normal.Attack.canceled += context => attack = 0;

    }

    private void AttackCanceled(InputAction.CallbackContext obj)
    {



    }


    private void AttackPerformed(InputAction.CallbackContext obj)
    {

        SwordAttack();

    }


    private void TetherCanceled(InputAction.CallbackContext obj)
    {

        if (bashing == true)
        {

            bashing = false;
            
            silRb.velocity = new Vector2((right - left) * bashSpeed, ((up - down) * bashSpeed) * bashVOffset);
            silRb.gravityScale = resetGravScale;

        }

        grappling = false;

    }

    private void TetherPerformed(InputAction.CallbackContext obj)
    {
        if (Input.GetJoystickNames().Length > 0)
        {
            
            tetherHit = Physics2D.Raycast(silRb.position, aim, maxTetherDist, tetherLayerMask);

            
            


        }
        else
        {

            tetherHit = Physics2D.Raycast(silRb.position, mousePos - silRb.position, maxTetherDist, tetherLayerMask);
            

        }


        if (tetherHit.collider.gameObject.tag == "NotGrappleable")
        {

            grappling = false;
            grappleTargetExists = false;
            grappleTargetPassive = new Vector2(silRb.position.x, silRb.position.y);

        }
        else if (tetherHit.collider.gameObject.tag == "Grappleable")
        {

            grappleTargetPassive = tetherHit.point;
            grappleTargetExists = true;
            grappling = true;
            airJumpCount = multiJump;
            dashCount = maxDash;

        }
        else
        {

            grappleTargetPassive = new Vector2(silRb.position.x, silRb.position.y);
            grappleTargetExists = false;

        }
        
        

        /*
        if (grappleTargetExists)
        {

            
            grappling = true;

        }
        */

    }
    

    
    private void DashCanceled(InputAction.CallbackContext obj)
    {

        if (grappling == true)
        {
            grappling = false;
        }

    }
    

    private void DashPerformed(InputAction.CallbackContext obj)
    {
        

        if (dashCount > 0)
        {
            startDash = true;
            dashCount -= 1;
        }

    }

    /*
    private void GlideCanceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void GlidePerformed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }
    */

    private void JumpCanceled(InputAction.CallbackContext obj)
    {
        endJump = true;

    }

    private void JumpPerformed(InputAction.CallbackContext obj)
    {


        if ((onFloor == true || floorCoyoteTime > 0) || ((onWall == true || wallCoyoteTime > 0) && climbDigClaws >= 1))
        {
            startJump = true;
            floorCoyoteTime = 1;
            wallCoyoteTime = 1;
        }

        if (airJumpCount > 0 && floorCoyoteTime <= 0 && wallCoyoteTime <= 0)
        {
            startJump = true;
            airJumpCount -= 1;
        }

        if (startDashTimer == true)
        {
            silRb.velocity = new Vector2(silRb.velocity.x * longJumpDistance, silRb.velocity.y);
        }

    }

    /*
    private void DownCanceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void DownPerformed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void UpCanceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void UpPerformed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void LeftCanceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void LeftPerformed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void RightCanceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void RightPerformed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }
    */

    private void OnEnable()
    {
        input.Enable(); //enable the input
    }

    private void OnDisable()
    {
        input.Disable(); //disable the input
    }

    // Start is called before the first frame update
    void Start()
    {

        //initializes the jump timer
        silRb = sil.GetComponent<Rigidbody2D>();
        jumpTimer = setJumpTimer;

        //initializes dashes
        dashCount = maxDash;
        dashTimer = dashLength;

        //initializes iFrames
        iFrameTimer = setIFrameTimer;

    }
    #endregion


    private void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        aim = new Vector2(right - left, up - down);

        //invincibility frames
        if (invincible == true)
        {

            iFrameTimer -= Time.deltaTime;

            sil.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 0);

            if (iFrameTimer <= 0)
            {

                invincible = false;
                sil.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);

            }

        }

        #region tether code
        /*
        if (Input.GetJoystickNames().Length > 0)
        {

            tetherHit = Physics2D.Raycast(silRb.position, aim, maxTetherDist);

        }
        else
        {

            tetherHit = Physics2D.Raycast(silRb.position, mousePos, maxTetherDist);

        }
        

        if (tetherHit.collider.tag == "Grappleable")
        {

            grappleTargetPassive = new Vector2(tetherHit.point.x, tetherHit.point.y);
            grappleTargetExists = true;

        }
        else
        {

            grappleTargetPassive = new Vector2(silRb.position.x, silRb.position.y);
            grappleTargetExists = false;

        }
        */

        #endregion

        #region ability checks
        //adjusts sil's stats when sil has the climbing claws to allow sil to cling to and jump off walls
        if (climbDigClaws == 0)
        {
            sil.GetComponent<Collider2D>().sharedMaterial.friction = noClimbFriction;
        }
        if (climbDigClaws >= 1)
        {
            sil.GetComponent<Collider2D>().sharedMaterial.friction = climbFriction;
        }
        #endregion

        #region jump checks
        //ends the jump after a predetermined amount of time
        if (startJumpTimer)
        {
            jumpTimer -= Time.deltaTime;
            if (jumpTimer <= 0)
            {
                endJump = true;
            }
        }

        //do floor and wall checks to help implement coyote time
        if (onWall == true)
        {
            wallCoyoteTime = setWallCoyoteTime;
        }
        if (onFloor == true)
        {
            floorCoyoteTime = setFloorCoyoteTime;
        }

        if (wallCoyoteTime > 0)
        {
            wallCoyoteTime -= 1;
        }
        if (floorCoyoteTime > 0)
        {
            floorCoyoteTime -= 1;
        }
        #endregion

        #region dash stuff

        dashDir = new Vector2(Mathf.Sign(right - left), Mathf.Sign(up - down));

        if (startDashTimer)
        {
            dashTimer -= Time.deltaTime;
            if (dashTimer <= 0)
            {
                endDash = true;
            }
        }

        #region tether stuff

        if (tether > 0)
        {
            if (canBash == true && bashTarget != null)
            {

                bashing = true;
                airJumpCount = multiJump;
                dashCount = maxDash;

            }
        }

        grappleDir = new Vector2(grappleTargetPassive.x - silRb.position.x, grappleTargetPassive.y - silRb.position.y).normalized;



        #endregion

        #endregion

        #region speed limits
        //limit sil's vertical speed depending on state
        if (glide > 0)
        {
            if (up > 0)
            {
                speedLimitY = upGlideFallSpeed;
                silRb.velocity = new Vector2(silRb.velocity.x, Mathf.Clamp(silRb.velocity.y, -speedLimitY, normUpSpeedLimit));
            }
            else if (down > 0)
            {
                speedLimitY = downGlideFallSpeed;
                silRb.velocity = new Vector2(silRb.velocity.x, Mathf.Clamp(silRb.velocity.y, -speedLimitY, normUpSpeedLimit));
            }
            else
            {
                speedLimitY = baseGlideFallSpeed;
                silRb.velocity = new Vector2(silRb.velocity.x, Mathf.Clamp(silRb.velocity.y, -speedLimitY, normUpSpeedLimit));
            }
        }
        else if (onWall == true && climbDigClaws > 0)
        {
            speedLimitY = wallSlideSpeed;
            silRb.velocity = new Vector2(silRb.velocity.x, Mathf.Clamp(silRb.velocity.y, -speedLimitY, normUpSpeedLimit));
        }
        
        else
        {
            speedLimitY = normFallSpeed;
            silRb.velocity = new Vector2(silRb.velocity.x, Mathf.Clamp(silRb.velocity.y, -speedLimitY, normUpSpeedLimit));
        }

        #endregion

        #region Attacks

        if (swordAttacking == true)
        {


            swordTimer += Time.deltaTime;

            if (swordTimer >= swordDuration)
            {

                swordAttacking = false;
                swordTimer = 0;
                sword.GetComponent<PolygonCollider2D>().enabled = false;
                sword.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);

            }


        }

        #endregion

        testTimer -= 1;

        /*
        if (testTimer <= 0)
        {
            Debug.Log("Insert Variable Here");
            testTimer = setTestTimer;
        }
        */

        //test ray
        Debug.DrawRay(silRb.position, aim.normalized * rayLength, Color.magenta);

    }

    void FixedUpdate()
    {

        #region walking/midair movement
        //do side to side movement while walking and falling
        
        if (right > 0)
        {
            if (silRb.velocity.x < speedLimitX)
            {
                silRb.velocity = new Vector2(silRb.velocity.x + setWalkMoveSpeed, silRb.velocity.y);
            }
        }
        
        if (left > 0)
        {

            if (silRb.velocity.x > -speedLimitX)
            {
                silRb.velocity = new Vector2(silRb.velocity.x - setWalkMoveSpeed, silRb.velocity.y);
            }
        }
        
        if (silRb.velocity.x > 0.1)
        {
            silRb.velocity = new Vector2(silRb.velocity.x - walkDecel, silRb.velocity.y);
        }
        if (silRb.velocity.x < -0.1)
        {
            silRb.velocity = new Vector2(silRb.velocity.x + walkDecel, silRb.velocity.y);
        }
        #endregion

        #region jump mechanics
        //start the jump
        if (startJump == true)
        {
            startJumpTimer = true;
            silRb.gravityScale = jumpGravScale;
            silRb.velocity = new Vector2(silRb.velocity.x, jumpHeight);
            startJump = false;
        }
        //end the jump
        if (endJump == true)
        {
            silRb.gravityScale = resetGravScale;
            endJump = false;
            jumpTimer = setJumpTimer;
            startJumpTimer = false;
        }
        #endregion

        #region Dash Mechanics

        //start dash
        if (startDash == true)
        {
            startDashTimer = true;
            silRb.gravityScale = 0;
            silRb.velocity = new Vector2(dashDir.x * dashSpeed, 0);
            startDash = false;
        }
        //end dash
        if (endDash == true)
        {
            endDash = false;
            silRb.gravityScale = resetGravScale;
            dashTimer = dashLength;
            startDashTimer = false;
        }

        #endregion

        #region tether mechanics

        if (bashing == true)
        {

            silRb.velocity = new Vector2(0, 0);
            silRb.gravityScale = 0;

        }
        else if (grappling == true)
        {

            silRb.velocity = new Vector2(grappleDir.x * grappleSpeed, grappleDir.y * grappleSpeed);

        }

        #endregion

    }

    #region collisions

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //reset the player's position to the last quicksave point they touched when they touch an environmental hazard
        if (collision.gameObject.tag == "Hazard")
        {
            silRb.position = hazardResetPos;
            silRb.velocity = new Vector2(0, 0);
            grappling = false;
        }

        

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //set onFloor to true when Sil touches the floor
        if (collision.gameObject.tag == ("Floor"))
        {
            onFloor = true;
            airJumpCount = multiJump;
            dashCount = maxDash;
        }
        if (collision.gameObject.tag == ("Wall"))
        {
            onWall = true;
            airJumpCount = multiJump;
            dashCount = maxDash;
        }
        if (collision.gameObject.tag == ("Grappleable"))
        {
            onWall = true;
            airJumpCount = multiJump;
            dashCount = maxDash;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        //set onFloor to false when Sil stops touching the floor
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = false;
        }
        
        if (collision.gameObject.tag == "Wall")
        {
            onWall = false;
        }
        if (collision.gameObject.tag == ("Grappleable"))
        {
            onWall = false;
        }


    }

    //check whether sil is inside a Hazard Reset Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ResetTrigger")
        {

            hazardResetPos = collision.gameObject.GetComponent<ResetTriggerScript>().respawnPos;
            

        }

        if (collision.gameObject.tag == "Bashable")
        {

            canBash = true;
            bashTarget = GetComponentInParent<Rigidbody2D>();

        }
        if (collision.gameObject.tag == "Grappleable")
        {

            grappling = false;

        }

        if (collision.gameObject.tag == "Enemy")
        {

            if (invincible == false)
            {
                silRb.velocity = new Vector2(collision.GetComponent<Rigidbody2D>().position.x - silRb.position.x, collision.GetComponent<Rigidbody2D>().position.y - silRb.position.y).normalized * -kbDist;
                invincible = true;
                iFrameTimer = setIFrameTimer;
            }

        }

    }

    //manage collision checks with bashable objects
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Bashable")
        {

            canBash = false;
            bashTarget = null;

        }

    }


    #endregion

    #region attacks

    private void SwordAttack()
    {

        swordAttacking = true;
        sword.GetComponent<PolygonCollider2D>().enabled = true;
        sword.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);

    }

    #endregion

}
