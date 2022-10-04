string[] arr1 = new string[3] {"final", "progect", "text"};
string[] arr2 = new string[arr1.Length];
void method(string[] arr1, string[] arr2){
    int count = 0;
    for (int i = 0; i< arr1.Length; i++){
        if (arr1[i].Length <= 3){
            arr2[count] = arr1[i];
            count = count +1;
        }
    }
}

void printarr(string[] arr){
    for (int i = 0; i < arr.Length; i++){
      Console.Write($"{arr[i]} ");    
    }
    System.Console.WriteLine();
}
method(arr1, arr2);
printarr(arr2);
