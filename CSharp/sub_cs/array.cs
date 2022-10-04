public static class array_example{
    public static void array_sample(){
        int[] a1 = new int[10];
        int[,] a2 = new int[10,20];
        int[,,] a3 = new int[1,2,3];

        int[][] a4 = new int[3][];
        a4[0] = new int[3];
        a4[1] = new int[3];
        a4[2] = new int[3];

        int[] a5 = new int[]{1,2,3};
        int[] a6 = {1,2,3};

        foreach (int item in a6){
            Console.WriteLine("item:"+item);
        }
    }
}