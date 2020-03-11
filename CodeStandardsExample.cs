//Remove unused using to preserve the speed of your IDE and compile times https://stackoverflow.com/questions/1162766/how-is-performance-affected-by-an-unused-using-directive
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
    using UnityEditor;
#endif

// Meta fields on classes
public class #SCRIPTNAME#
{
}

// Class without interface
public class #SCRIPTNAME# : MonoBehaviour
{
}

// Class with interface
[Serializable]
public class #SCRIPTNAME# : MonoBehaviour
    , IIterable
    , IEnumerable
{

	// -- TYPES


    public enum MyEnumName
    {
        Value1 = 0,
        Value2,
        Count,
        None = -1
    }

	public struct DataHolder
	{
		public int Counter;
		public string Name;
	}

	// -- PROPERTIES


    public string MyAttribute { get; set; }

    public int Var
    {
        get
        {
            return var;
        }
        private set
        {
            if ( var != value )
            {
                var = value;
            }
        }
    }

	// -- FIELDS


    public string TestThing;

	protected VeryCoolClass VeryCoolField;

	[SerializeField] private UnityAction myFirstAction;
    private string value1;
    private string values2;

	// Write your script as if there is no Editor, use SerializeField instead of public where you can.
    [SerializeField] private string value1;
    [SerializeField] private string value2;

	// Avoid abbreviations in variables to avoid confusion
    private int var;

    private List<string> stringTable = new List<string>();

    private SkeletalMesh skeletalMeshComponent;

    // When using link, it means the component does not come from your gameobject.
    private Transform transformComponentLink;

    // :( Prefer using components or interfaces over GameObject
    private GameObject myTemplatePrefab;

	// -- METHODS


    public #SCRIPTNAME#()
    {
        myFirstAction += OnFirstActionDone;
    }

    public string GetName()
    {
        return name;
    }

    public bool MyFunctionWithoutArguments()
    {
        return true;
    }

    public void MyFunctionWithArguments( string sample1, float sample2 )
    {
    }

    public void MyFunctionWithArguments(
        string sample1,
        float sample2,
        Object another_arg,
        bool and_another_one,
        string very_wow,
        List<Int> bla_list
        )
    {
        int var1;
        int var2;
        Object var3;

        var name_map = new Dictionary< string, List<XXX> );
    }

    private string GetNameInternal()
    {
        return name;
    }

    // For delegates, start with on, end with verb.
    private bool OnFirstActionDone()
    {

    }

	private void GameManager_OnEventHappened()
	{

	}

	// Try to early out ASAP to reduce nesting and to preserve the readability
	private void DoSomething( bool should_continue, bool should_still_continue )
	{
		if(!should_continue)
		{
			return;
		}

		if(!should_still_continue)
		{
			return;
		}
	}

	// Avoid bool arguments when it's not obvious
	private void DoSomethingToo()
	{
		// Example of obvious meaning of the bool
		transformComponentLink.gameobject.SetActive( true );
		// Add the name of the parameter if it's not obvious but needed
		DoSomething( should_continue: true, should_still_continue: true );
	}

	// -- UNITY


	// Use Awake instead of the constructor for initialization https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
    public void Awake()
    {
		GameManager.Instance.EventHappened += GameManager_OnEventHappened;
    }

	private void OnDestroy()
	{
		// Balance your event subscriptions
		GameManager.Instance.EventHappened -= GameManager_OnEventHappened;
	}

    protected void Start()
    {
    }

    private void Update()
    {
    	switch( value )
        {
        	case 0:
            {
            	// Code indented.
            }
            break;
        }
    }
}