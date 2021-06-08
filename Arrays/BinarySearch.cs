namespace Arrays
{
    public class BinarySearch
    {
        private int[] array;
        private int nelemens;
        public BinarySearch(int max)
        {
            array = new int[max];
        }

        //Inserting Element
        public void Insert(int element)
        {
            int i;
            for(i=0;i<nelemens;i++)
            {
                if (array[i] > array[i + 1])
                    break;
            }
            if (i == nelemens)
                array[nelemens] = element;
            else
                for (int k = nelemens; k > i; k--)
                    array[k] = array[k - 1]; 
        }
    }
}