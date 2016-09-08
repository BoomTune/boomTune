public class CubeController {

	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	public IMovementController IMovementController;
//	public Vector3 startPos;

	public void startPosition (float lane1x, float lane1y, float lane1z, float lane2x, float lane2y, float lane2z) {
		
		IMovementController.startingPosition (lane1x, lane1y, lane1z, lane2x, lane2y, lane2z);
	}

	public void moveSideToSide (string value) {

		IMovementController.MoveLane(value); 
	}
}
