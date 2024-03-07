int[] array = { 1, 2, 3, 4, 5 };
int k = 2;

RotateArray(array, k);

Console.WriteLine("Rotated array:");
foreach (int num in array)
{
    Console.Write(num + " ");
}

static void RotateArray(int[] nums, int k)
{
    if (nums == null || nums.Length == 0)
    {
        return;
    }

    k = k % nums.Length; // Handle cases where k is greater than the length of the array

    Reverse(nums, 0, nums.Length - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, nums.Length - 1);
}

static void Reverse(int[] nums, int start, int end)
{
    while (start < end)
    {
        int temp = nums[start];
        nums[start] = nums[end];
        nums[end] = temp;
        start++;
        end--;
    }
}