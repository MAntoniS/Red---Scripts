using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Refactor the command Pattern. It is not working as it should...
public class InputReader : MonoBehaviour
{
   
    Rigidbody2D rigidbody;
    AbilityAssetHolder abilityAssets;
    PlayerController playerController;
    SetFacingDirection setFacingDirection;
    Vector2 facingDirection;
    float dashAmount = 4f;

    #region Buttons
    MoveCommand buttonWSAD;
    ICommand buttonK;
    ICommand button1;
    DashCommand spacebar;

    #endregion

    private void Start()
    {
        initializeDependencies();
        initializeCommands();
       

    }
    // Update is called once per frame
    void Update()
    {
        spacebar.setMovement(MovementInput());
        if (MovementInput() != Vector2.zero) 
        {
            facingDirection = MovementInput();
        }
        setFacingDirection.faceDirection(facingDirection);
        buttonWSAD.setMovement(MovementInput());
        setButton1();
        if(Input.GetKeyDown(KeyCode.K))
        { buttonK.Execute(); }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { button1.Execute();}
        
        
    }

    private void FixedUpdate()
    {
      
        buttonWSAD.Execute();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacebar.Execute(); 
        }
    }
    private void initializeCommands()
    {
        buttonWSAD = new MoveCommand(rigidbody);
        buttonK = new AbilityCommand(abilityAssets.arrow, this.gameObject);
        spacebar = new DashCommand(rigidbody,dashAmount,transform);
    }

    private void initializeDependencies()
    {
        playerController = GetComponent<PlayerController>();
        setFacingDirection = GetComponentInChildren<SetFacingDirection>();
        rigidbody = GetComponent<Rigidbody2D>();
        abilityAssets = GetComponentInChildren<AbilityAssetHolder>();
    }

    // TODO: Change the way of updating BUtton1
    private void setButton1()
    {
        button1 = null;
        button1 = new UseItemCommand(0,playerController);
    }

    private Vector2 MovementInput()
    {
        return new Vector2(
        Input.GetAxisRaw("Horizontal"),
        Input.GetAxisRaw("Vertical")
        );
    }

}
