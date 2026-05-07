package jumpingfrogproblem;
import java.util.*;
public class Simulation {
    public static String crossing(River river1, Jumpin jumpin1) {
        int lastOne = 0;
        
        for (int current : river1.getPositions()) {
            int distance = current - lastOne;
            
            if (!jumpin1.canJump(distance)) {
                return "Jumpin cannot cross the river.";
            }
            
            jumpin1.jumpApply(distance);
            
            if (jumpin1.getEnergy() == 0 && current != river1.getPositions().get(river1.getPositions().size() -1)) {
                return "Jumpin cannot cross the river.";
            }
            
            lastOne = current;
        }
        return "Jumpin it succed and still remaining his energy" + jumpin1.getEnergy();
    }
}
