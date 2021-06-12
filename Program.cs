using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 1, 2, 1 };
            int[] nums2 = { 4, 2, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 2, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3, 3 };
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5

            Console.WriteLine("Question 5");
            string[,] cities = { { "London", "New York" }, { "New York", "Tampa" }, { "Delhi", "London" } };
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ma);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int[] costs = { 15, 10, 20 };
            int minCost = MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();

        }

        //Question 1
        /// <summary>
        //Given two integer arrays nums1 and nums2, return an array of their intersection.
        //Each element in the result must be unique and you may return the result in any order.
        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //nums1=[[1,2],[2,3]]
        //Output: [9,4]
        //
        /// </summary>

        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                //Declare a list - Create a final list where output elements will be stored if intersection is met between arrays.
                List<int> result = new List<int>();

                //Using a for loop, starting at 0 index which is the beginning of the array loop through elements in the first array (nums1).
                for (int i = 0; i < nums1.Length; i++)
                {
                    //If the element in the second array matches the element in the first array than store the elements within the list.
                    if (nums1.Contains(nums2[i]))
                    {
                        result.Add(nums2[i]);
                    }
                }
                //Increment the results list and return the results.
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //Note: You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        //Example 4:
        //Input: nums = [1, 3, 5, 6], target = 0
        //Output: 0
        /// </summary>

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {

                //Pseudocode Logic Below:
                //step 1: loop through array one by one and look for target.
                //step 2: if target is found then print the index of where target is in the array. 
                //step 3: if target is not found then print the index position of where target would be had it been placed in the array.

                //Loop through the array starting at index 0
                for (int i = 0; i < nums.Length; i++)
                {
                    //If the target is less than or equal to index, than return the index position.
                    if (nums[i] >= target)
                    {
                        return i;
                    }
                }

                //Below is another code for this question, but it was not getting the correct output result.

                //initialize a variable type bool called 'condition' which is set to false.
                //bool condition = false;

                //use a for loop to loop through the elements in the array starting at index 0.
                //for (int i = 0; i < nums.Length; i++)
                {
                    //check if array contains the target element. if the array contains the target element hen it will change the
                    //condition from false to true and will then return the index of the target element.
                    //    condition = nums.Contains(target);
                    //    if (condition)
                    //    {
                    //        return nums.Length;
                    //    }
                    //}

                    ////if the condition that was set in the code above in line 167 is not true, then
                    ////loop through the array again and this time return the index position that is less than target becuase that is where the target should be.
                    //if (!condition)
                    //{
                    //    for (int i = 0; i < nums.Length; i++)
                    //    {
                    //        if (nums[i] > target)
                    //        {
                    //            return i;
                    //        }
                    //    }
                    //}
                }
                //    for (int i = 0; i < nums.Length; i++)
                //    {
                //        if (nums[i] == target || nums[i] > target) return i;
                //    }
                //    return nums.Length;
                //}

                return -1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Question 3
        /// <summary>
        //Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
        //Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
        //Example 1:
        //Input: arr = [2, 2, 3, 4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        /// </summary>

        private static int LuckyNumber(int[] nums)
        {
            try
            {

                //Pseudocode Logic Below:
                //step 1: loop through the array and use count to count the total of any matching elements in the array.
                //step 2: If count of matching elemets are equal to the actual element than print that result in a list.
                //step 3: Once the list is populated with list of all matching elements loop through the array and 
                //print the largest element in the list. 
                //step 4: If there are no lukcy integers returned than return -1.

                //initialize a variable type bool called 'condition' which is set to false (this is known as 'Loop Operation with Sentinal Value')
                bool condition = false;

                //loop through the array starting at the first index.
                for (int i = 0; i < nums.Length; i++)
                {
                    //loop through the entire nums array and check if the element presented in the array
                    //is equal to the count frequency of that element in the array
                    condition = nums[i] == nums.Count(c => c == nums[i]);

                    //if the condition above is comes true (there match in array with element and its frequency)
                    //then return the index of the element.
                    if (condition)
                    {
                        return nums[i];
                    }
                }
                //if the condition is false, then return -1.
                if (!condition)
                {
                    return -1;
                }


                return -1;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        //You are given an integer n.An array nums of length n + 1 is generated in the following way:
        //•	nums[0] = 0
        //•	nums[1] = 1
        //•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
        //•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n]]

        // Return the maximum integer in the array nums.

        //Example 1:
        //Input: n = 7
        //Output: 3
        //Explanation: According to the given rules:
        //nums[0] = 0
        //nums[1] = 1
        //nums[(1 * 2) = 2] = nums[1] = 1
        //nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
        //nums[(2 * 2) = 4] = nums[2] = 1
        //nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
        //nums[(3 * 2) = 6] = nums[3] = 2
        //nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
        //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.

        /// </summary>
        private static int GenerateNums(int n)
        {
            try
            {
                //Pseudocode Logic Below:
                //step 1: initialize an array of size n+1
                //step 2: assign nums[0]=0 and nums[1]=1
                //step 3: going forward, divide the number by 2. and do nums[coefficient] if id divides by 2 else do nums[coefficient]+nums[coeff+1]

                //initialize an array of size n+1 size;
                int[] resultantArr = new int[n + 1];

                //enter into a for loop with the condition that if index is less than or equal to integer n. 
                //assign nums[0]=0 and nums[1]=1

                for (int i = 0; i <= n; i++)
                {
                    resultantArr[0] = 0;
                    resultantArr[1] = 1;

                    //if index is greater then 1, do nums[coefficient]
                    if (i > 1)
                    {
                        //if index does not divide by 2 and there is a remainder then it will
                        //go to the else statement and do nums[coefficient]+nums[coeff+1]
                        if (i % 2 == 0)
                            resultantArr[i] = resultantArr[1 / 2];
                        else
                            resultantArr[i] = resultantArr[i / 2] + resultantArr[(i / 2) + 1];
                    }

                }
                //returns the maximum value in the resultant array.
                return resultantArr.Max();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5
        /// <summary>
        //You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        //It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        //Example 1:
        //Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        //Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
        /// </summary>
        public static string DestCity(string[,] paths)
        {
            try
            {
                //Assuming that the first element within the array is the destination city.
                //For example, here we are assuming NY as the destination city. 
                string destcity = paths[0, 1];

                //Loop through the elements presented in the array's. GetLength is a method that will return the total legnth of the two-dimensional array.
                //We are starting at position 1 because the position at 0 will always be the starting location so we are assuming that
                //the starting location will not ever be the destination city.
                for (int i = 1; i < paths.GetLength(0); i++)
                {
                    //Compare destcity, which in example above would be NY, with the next city in the array,
                    //and checks if that next city (next destcity) in the array is equal to the destination city.
                    //If condition matches the destination city then it will start the loop again.  
                    if (destcity == paths[i, 0])
                    {
                        //Change the destination city to the next city in array
                        destcity = paths[i, 1];
                        //make i as zero to start from beginning again
                        i = 0;
                    }

                }

                //returns the destination city 
                return destcity;

                //Looked up and seems they use hash set (don't really know this)
                //Steps: My idea is you use the strings of cities and starting with the last one string you look
                //for matching string in the other sets, if matches than go to the next to last string and do the same
                //goal is to find a string that does not appear second time starting at the end 


            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6:
        /// <summary>
        //Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        //Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
        //You may not use the same element twice, there will be only one solution for a given array
        //Example 1:
        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        /// </summary>
        private static void targetSum(int[] nums, int target)
        {
            try
            {
                //Loop through the array
                for (int i = 0; i < nums.Length; i++)
                {
                    //Create differance variable which is set to be differance
                    //which is target value minus the elements indexed.
                    //Using example above the target is 9 and first index is 2 so 9-2 = 7. 
                    //If 7 exisits within the array then it will make the statement true. 
                    int difference = target - nums[i];
                    if (nums.Contains(difference))
                    {
                        //Finds the locations of the indexed elements and stores that in variable 'index' 
                        int index = Array.FindIndex(nums, c => c == difference);

                        //Prints the index of the element in the array with the differance 
                        Console.WriteLine(index);

                        //Prints i which is index 0
                        Console.WriteLine(i);

                        //Breaks out of the loop once index is found.
                        break;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                //Create a new dictionary
                Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

                //Loop through the array (use GetLength starting at index 0 since this is a two-dimensional array)
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    //Check the dictionary key items. Search for if the key exists, if the key exists then add the values to the dictionary.
                    //If if the key does not exist then add the key and value to the dictionary.
                    if (dict.ContainsKey(items[i, 0]))
                    {
                        //Adds elements into the dictionary
                        dict[items[i, 0]].Add(items[i, 1]);
                    }
                    else
                    {
                        //Adds elements into the dictionary
                        dict.Add(items[i, 0], new List<int>());
                        dict[items[i, 0]].Add(items[i, 1]);
                    }
                }
                //Loop through the dictionary 
                for (int i = 0; i < dict.Count(); i++)
                {
                    //Sorts the values presented in the dictionary in ascending order so will have the highest values presented first.
                    dict.ElementAt(i).Value.Sort();
                    dict.ElementAt(i).Value.Reverse();

                    //Takes the top 5 values in dictionary and stores in variable name top5
                    var top5 = dict.ElementAt(i).Value.Take(5);

                    //Prints the value/key pairs and computes the top average in the dictionary.
                    //Converts their values of averages into data type integer.
                    //The {0} and {1} are placeholders, so they will update with the presented key and value pair when code is run.
                    if (i == 0)
                    {
                        Console.Write("[{0},{1}],", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                    }
                    else if (i != dict.Count - 1)
                    {
                        Console.Write("[{0},{1}],", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                    }
                    else
                    {
                        Console.Write("[{0},{1}]", dict.ElementAt(i).Key, Convert.ToInt32(top5.Average()));
                    }
                }
            }
            catch (Exception)
            {

                throw;

            }
        }

        //Question 8
        /// <summary>
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Print the Final array after rotation.
        //Example 1:
        //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]
        //Example 2:
        //Input: nums = [-1,-100,3,99], k = 2
        //Output: [3,99,-1,-100]
        //Explanation: 
        //rotate 1 steps to the right: [99,-1,-100,3]
        //rotate 2 steps to the right: [3,99,-1,-100]
        /// </summary>

        private static void RotateArray(int[] arr, int n)
        {
            try
            {
                //Create final list we can use to display the results 
                List<int> finalList = new List<int>();

                //Compute the difference between Length of array and n (n is equal to the k steps).
                var difference = arr.Length - n;

                //Loop through array starting at the index given in computation of difference
                //(Note: arr.Length is 7 since we have 7 elements in the array for Q8)
                for (int i = difference; i < arr.Length; i++)
                {
                    //Adds the remaining elements (elements after the differance) in the final list 
                    finalList.Add(arr[i]);
                }

                //Loops through the array and adds the remaining elements to the list
                //These will be the elements of index is lower than the differance.
                for (int i = 0; i < difference; i++)
                {
                    finalList.Add(arr[i]);
                }
                //Displays output
                foreach (int val in finalList)
                {
                    Console.WriteLine(val);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum
        // Example:
        // Input: nums = [5,4,-1,7,8]
        //Output: 23
        /// </summary>

        private static int MaximumSum(int[] nums)
        {
            try
            {
                {
                    //Create 2 variables maxSum and maxCurrentArray.
                    //Starts at index 0 (first element in the array) and will be used to compare with other elements and to find the maximum element in the array.
                    //Using the array example presented above where Input: nums = [5,4,-1,7,8], 5 will be the value stored for both variables.
                    int maxSum = nums[0], maxCurrentArray = nums[0];

                    //Use a for loop & initialize starting position at 1 & loop through array
                    for (int i = 1; i < nums.Length; i++)
                    {

                        //Going through first the maxCurrentArray using formula where nums[i] which in our loop was initialized to start at index one
                        //Using the array example presented above where Input: nums = [5,4,-1,7,8], nums[i] = 4, then add maxCurrentArray variable
                        //which was 5 as in the first line of the code and add the value stored in the maxCurrent array to nums[i] which is 4.
                        //the fist set of values for maxCurrentArray will be (4, 5+4) therefore 9 is the maxCurrentArray value. 
                        //loop will continue on to the next element in the array in index 2 and do the same thing. Next to the code below 
                        //are values that will be output of the formula.

                        maxCurrentArray = Math.Max(nums[i], maxCurrentArray + nums[i]);//max(4,5+4)=9//max(-1,9+-1)=8//max(7,8+7)=15//max(8,15+8)=23


                        //Next going through maxSum using formula below, where value for maxSum was initialized to index 0 in the beginning
                        //so maxSum value first equals 5, and then compare this to the maxCurrentArray value which was populated in the above code
                        //after comparing these two values output will be the maximum value. 

                        //Continueing with our example from above, first values will be 5 (since this is index 0) and 9 (since this is the output 
                        //for first element in the maxCurrentArray shown above. Next betweent the 5 & 9 take the maximum value which is 9. 
                        //Next move to next sets of maxSum and maxCurrentArray. Now maxSum which now is 9, and maxCurrentArray which shown above is
                        //now 8, between 9 & 8 take the maximum value which is 9. Loop through the entire values while taking out the maximum value and 
                        //output will result in the maximum value between the maxSum and maxCurrentArray.

                        maxSum = Math.Max(maxSum, maxCurrentArray);//max(5,9)=9//max(9,8)=9//max(9,15)=15//max(15,23)=23//max=(23)

                    }

                    //return the maxSum value 
                    return maxSum;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
        //You can either start from the step with index 0, or the step with index 1.
        //Return the minimum cost to reach the top of the floor.
        //Example 1:
        //Input: cost = [10, 15, 20]
        //Output: 15
        //Explanation: Cheapest is: start on cost[1], pay that cost, and go to the top.

        /// </summary>

        private static int MinCostToClimb(int[] costs)
        {
            try
            {

                //Loop through the array starting at index 2
                for (int i = 2; i < costs.Length; i++)
                {
                    //Use a minimum math method to calculate the cost, this method will review the prior step and prior 2 steps
                    //whichever is less of the two will be the output
                    costs[i] += Math.Min(costs[i - 1], costs[i - 2]);
                }

                //returns minimum cost
                return costs.Min();


                //Pseudocode Logic Below:
                //This problem includes dynamic programming (programming that computes its solution by combining them from smaller subsolutions,
                //and trying many choices to figure out an optimal set of choices).

                //step 1: Loop through array.
                //step 2: There will be two options presented each time to get to the top while paying the cheapest price.
                //Option one = take first step and pay cost, skip second step
                //Option two = take second step and pay cost, skip first step
                //step 3: To solve, loop through the array and check for next two values in the array while choosing the step with the
                //lower value. This can be done with minimum value method
                //Also note that code will need to record which locations (indexes) it took the step to maintain a record of path)
                //step 4: return the lowest value and record 

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}