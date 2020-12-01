using System;
public class Sorter
    {
        int[] nums;
        public Sorter(int[] nums)
        {
            this.nums = nums;
        }

        public String sort() 
        {
            bool bubbled = false;
            int qtt = 0;
            do
            {
                bubbled = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != nums.Length-1 && nums[i] > nums[i+1]) {
                        int temp = nums[i];
                        nums[i] = nums[i+1];
                        nums[i+1] = temp;
                        bubbled = true;
                    }
                }
                qtt++;
            } while (bubbled);
            string result = "Precisou " + qtt + " rodadas para ordenar\n";
            foreach (int i in nums) 
            {
                result += i + ", ";
            }
            return result.Substring(0, result.Length-2);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 7, 3 , 9, 4 , 1 , 2, 5, 8 , 0, 6};
            Sorter sorter = new Sorter(numbers);
            string result = sorter.sort();
            Console.Write(result);
        }
    }