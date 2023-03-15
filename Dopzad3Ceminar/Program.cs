Console.Clear();
Console.WriteLine("Введите количество кустов");
int s = Convert.ToInt32(Console.ReadLine());
int[] array = new int [s];
int poz =0;
while ( poz < s ) {
    array[poz]=new Random().Next(1, 1000);
    Console.Write($"{array[poz]}, ");
    poz++;
}
int sum = 0;
int maxsum = array[0]+array[s-1]+array[1];
int i=0;
for ( i=0 ;i < s; i++ ){
    if(i==0){
        sum = array[i]+array[i+1]+array[s-1];
            if(maxsum<sum){
                 maxsum = sum;
            }
    }
    else if (i == s-1){
        sum = array[0]+array[s-1]+array[i-1];
            if(maxsum<sum){
                 maxsum = sum;
        }
    }
    else {
        sum = array[i]+array[i+1]+array[i-1];
            if(maxsum<sum){
                 maxsum = sum;
        }
    }
}
Console.Write($"\nМаксимально число ягод за один заход : {maxsum}");


