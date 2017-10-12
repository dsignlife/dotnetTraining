import java.util.*;
import java.io.*;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;


public class Main {
    public static void main(String[] args) {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        PrintWriter out = new PrintWriter(new BufferedOutputStream(System.out));
        try {
            int n = Integer.parseInt(in.readLine());
            for (int b = 0; b < n; b++) {
                char[][] board = new char[5][5];
                for (int i = 0; i < 5; i++) {
                    String s = in.readLine();
                    for (int j = 0; j < 5; j++) {
                        board[i][j] = s.charAt(j) == '0' ? 'w' : s.charAt(j) == '1' ? 'b' : 'x';
                    }
                }
                int moves = new AStar(new State(board)).shortestPath();
                if (moves < 0 || moves > 10) {
                    out.println("Unsolvable in less than 11 move(s).");
                } else {
                    out.printf("Solvable in %d move(s).\n", moves);
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        out.close();
    }
}


class AStar {

    private Node goal;

    public AStar(State init) {
        goal = null;
        Set<State> closed = new HashSet<>();
        PriorityQueue<Node> open = new PriorityQueue<>(Comparator.comparingInt(n -> n.F));
        Map<State, Integer> openTracker = new HashMap<>();

        open.add(new Node(init, 0));
        openTracker.put(init, 0);

        while (!open.isEmpty()) {

            Node current = open.poll();
            openTracker.remove(current.getState());
            closed.add(current.getState());

            if (current.getState().isGoalState()) {
                goal = current;
                break;
            }

            if (current.G > 10) {
                break;
            }

            for (State child : current.getState().neighbors()) {
                if (!closed.contains(child)) {
                    Integer i = openTracker.get(child);
                    if (i == null) {
                        openTracker.put(child, current.G + 1);
                        open.add(new Node(child, current.G + 1));
                    } else if (i > current.G + 1) {
                        Node newNode = new Node(child, current.G + 1);
                        open.remove(newNode);
                        open.add(newNode);
                        openTracker.put(newNode.getState(), newNode.G);
                    }
                }
            }
        }
    }

    public int shortestPath() {
        return this.goal == null ? -1 : this.goal.G;
    }
}

class Node {
    private State state;
    public final int G;
    public final int F;

    public Node(State state, int G) {
        this.state = state;
        this.G = G;
        this.F = G + this.state.heuristic();
    }

    public State getState() {
        return this.state;
    }

    @Override
    public int hashCode() {
        return this.state.hashCode();
    }

    @Override
    public boolean equals(Object o) {
        return this.state.equals(((Node)o).state);
    }
}

class State {

    private static int movement[] = {-2,-1,1,2};
    private static char[][] goal = {
        {'b','b','b','b','b'},
        {'w','b','b','b','b'},
        {'w','w','x','b','b'},
        {'w','w','w','w','b'},
        {'w','w','w','w','w'}
    };

    private char[][] board;

    public State(char[][] board) {
        this.board = board;
    }

    public boolean isGoalState() {
        return Arrays.deepEquals(this.board, State.goal);
    }

    public int heuristic() {
        int counter = 0;
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (this.board[i][j] != 'x' && this.board[i][j] != State.goal[i][j]) {
                    counter++;
                }
            }
        }
        return counter;
    }

    public Iterable<State> neighbors() {
        Set<State> set = new HashSet<>();
        int[] x = findX();
        for (int i : movement) {
            for (int j : movement) {
                if (Math.abs(i) + Math.abs(j) == 3) {
                    if (validIndex(x[0] + i) && validIndex(x[1] + j)) {
                        State tmp = new State(this.copyBoard());
                        char knight = tmp.board[x[0] + i][x[1] + j];
                        tmp.board[x[0] + i][x[1] + j] = 'x';
                        tmp.board[x[0]][x[1]] = knight;
                        set.add(tmp);
                    }
                }
            }
        }
        return set;
    }

    private char[][] copyBoard() {
        return new char[][]{
                {board[0][0],board[0][1],board[0][2],board[0][3],board[0][4]},
                {board[1][0],board[1][1],board[1][2],board[1][3],board[1][4]},
                {board[2][0],board[2][1],board[2][2],board[2][3],board[2][4]},
                {board[3][0],board[3][1],board[3][2],board[3][3],board[3][4]},
                {board[4][0],board[4][1],board[4][2],board[4][3],board[4][4]}
        };
    }

    private boolean validIndex(int i) {
        return i >= 0 && i < 5;
    }

    private int[] findX() {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (board[i][j] == 'x') return new int[]{i,j};
            }
        }
        return new int[]{};
    }


    @Override
    public String toString() {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                str.append(this.board[i][j]);
            }
            str.append('\n');
        }
        return str.toString();
    }

    @Override
    public boolean equals(Object o) {
        return Arrays.deepEquals(this.board, ((State)o).board);
    }

    @Override
    public int hashCode() {
return Arrays.deepHashCode(this.board);
    }
}

