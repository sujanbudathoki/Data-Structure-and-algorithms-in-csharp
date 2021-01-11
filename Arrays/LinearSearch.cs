namespace Arrays
{
    public class LinearSearch
    {
        private int[] v;
        int nelemns=0;

        //Constructor
        public LinearSearch(int max)
        {
            v = new int[max];
        }

        //Inserting Element
        public void Insert(int item)
        {
            v[nelemns] = item;
            nelemns++;
                
        }
        //Searching Element
        public bool Find(int searchkey)
        {
            int j;
            for (j = 0; j < nelemns; j++)
                if (v[j] == searchkey)
                    break;
            if (j == nelemns)
                return false;
            else
                return true;

        }

        //Deleting Element
        public bool Delete(int searchkey)
        {
            int j;
            for (j = 0; j < nelemns; j++)
                if (v[j] == searchkey)
                    break;
            if (j == nelemns)
                return false;
            else
                for (int k = j; k < nelemns; k++)
                    v[k + 1] = v[k];
            nelemns--;
            return true;
            

            
        }
            

    }
}