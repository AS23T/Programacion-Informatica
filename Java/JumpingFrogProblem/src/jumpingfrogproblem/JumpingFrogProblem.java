package jumpingfrogproblem;
import java.util.*;
public class JumpingFrogProblem {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        //Integer positive number for the energy onto the jump (0 < E < 100)
        int E = input.nextInt();
        //Jumping positions (1 <= N < 5000), with (N - 1) when he jumps
        int N = input.nextInt();
        
        List<Integer> positions = new ArrayList<>();
        for (int i = 0; i < N; i++) {
            positions.add(input.nextInt());
        }
        
        Jumpin jumpin1 = new Jumpin(E);
        River river1 = new River(positions);
        
        String result = Simulation.crossing(river1, jumpin1);
        System.out.println(result);
    }
}
