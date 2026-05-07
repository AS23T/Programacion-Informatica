package mariobrossproblem;

import java.util.*;

public class Result {
    //I create private variables in the class, whose values are assigned only once and cannot be changed with final
    private final int upJumps;
    private final int downJumps;
    
    //Constructor that initializes the result values to receive integer values such as up and down from the AnalizeJumps class, which are then assigned to the attributes
    public Result(int up, int down){
        this.upJumps = up;
        this.downJumps = down;
    }
    //An integer get method named getUpJumps, which returns the variables that have already been used in a clean and separate
    public int getUpJumps(){
        return upJumps;
    }
    //An integer get method named getDownJumps, which cleanly returns the variables that have already been used
    public int getDownJumps(){
        return downJumps;
    }
}
