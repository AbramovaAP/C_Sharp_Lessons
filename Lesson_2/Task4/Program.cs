int N = 10;

int[] array = { 58, 2, 3, 4, 5, 168, 7, 8, 9, 13 };
int i = 0;
int max  = array[0];

while(i < N) {
    if(array[i] > max) {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);