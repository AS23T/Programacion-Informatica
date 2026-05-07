package jumpingfrogproblem;
import java.util.*;
public class Jumpin {
    private int energy;
    
    public Jumpin(int initialEnergy) {
        this.energy = initialEnergy;
    }
    
    public int getEnergy() {
        return energy;
    }
    
    public boolean canJump(int distance) {
        return distance <= energy;
    }
    
    public void jumpApply(int distance) {
        if (distance == energy) {
            energy--;
        }
    }
}
