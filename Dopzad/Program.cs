Console.Clear();
Console.WriteLine("Hello, World!");
int[] n = {25,45,68,468,45,98,94,97};
int a = n.Length;
int max = n[0];
int max2 = 0;
int index;
for (index = 1;index < a; index++){
    if(max < n [index]){
        max = n [index];
        n[index]= 0;
    }
}
for (index = 1;index < a; index++){
    if(max2 < n [index]){
        max2 = n [index];
    }
}
Console.WriteLine(max2);