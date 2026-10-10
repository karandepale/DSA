using DSA_Problems;

//(1) Find highest Element in the array:
int[] arr = {40,30,70,90,50,30,50};
HighestElement.HighestElementInArray(arr);

//(2) Find second Highest Element in the array:
int[] sendHighestArr = { 40, 30, 70, 90, 50 };
SecondHighest.secondHighestElement(arr);

//(3) Find smallest Element in the array:
int[] inputArray = { 50, 20, 60, 30, 70 };
SmallestElement.findSmallestElement(inputArray);

//(4) Second Smallest Element in the array:
SecondSmallest.secondSmallestElement(inputArray);

//(5) Find missing elemenet in the array1:
int[] missingElementArr = { 1,2,3,5,6};
MissingElement.findMissingElement(missingElementArr, 6);

//(6) Remove Duplicate Elements from array:
RemoveDuplicateElement.RemoveDuplicateItem(arr);
RemoveDuplicateElement.printDuplicate(arr);

//(7) MoveAlleroToEnd in the array:
int[] zeroEnd = { 2, 5, 0, 3, 0, 7, 0, 9 };
AllzeroToEnd.AllzeroEnd(zeroEnd);