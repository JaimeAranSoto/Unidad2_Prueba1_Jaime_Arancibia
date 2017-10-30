public class HiWorld : MonoBehaviour {
  
 +	private string message;
 +	
      public Text text;
  
  	// Use this for initialization
 @@ -16,4 +18,12 @@ public class HiWorld : MonoBehaviour {
  	void Update () {
  		
  	}
 +	
 +	public string HolaMundo(){
 +		//Me voy a tomar un cafe, que el hola mundo entregue la hora actual y 
 +		//según la hora, diga buenos días mundo, 
 +		//buenas tarde o buenas noches
 +		message="";
 +		return message;
 +	}
  }
