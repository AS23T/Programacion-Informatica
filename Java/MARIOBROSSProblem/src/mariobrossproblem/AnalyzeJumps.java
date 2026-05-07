package mariobrossproblem;

import java.util.*;

public class AnalyzeJumps {
    //Public method of the Result class that uses analyze to retrieve data from my integer array elevations in the Main
    public Result analyze(int[] elevations){
        //I assign initializers
        int up = 0;
        int down = 0;
        
        //For the integer i (index) equal to 0, i must be less than the length of my array minus 1 times the number of walls already crossed (N walls - 1), incrementing i by 1 each cycle
        for (int i = 0; i < elevations.length - 1; i++) {
            //If the elevations in i plus 1 are greater than the elevations in i, then skip and add 1
            if (elevations[i + 1] > elevations[i]) {
                up++;
            }
            //Another one, elevations in i plus 1 are less than elevations in i minus 1
            else if (elevations[i + 1] < elevations[i]) {
                down++;
            }
        }
        //Constructor to return from the Result class with up and down
        return new Result(up, down);
    }
}
