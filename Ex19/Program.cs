long SizeArray(long size){ //метод для определения размера массива
    long count = 0;
    while(size > 0){
    size/=10;
    count++;
    }
    return count;
}
void CreateArray(long[] arr, long size, long num){ //метод для заполнения массива в обратном порядке
    for(long i = size - 1; i >= 0; i--){
    arr[i] = num % 10;
    num /= 10;
    //Console.Write($"{arr[i]} "); для проверки, что всё правильно заполнилось
    }
}
void PrintArray(long[] arr, long size){ //метод для вывода массива, если надо посмотреть
    for (long i = 0; i < size; i++){
    Console.Write($"{arr[i]} ");
    }
}
void Polindrome(long[] arr, long size){ //метод проверки на полиндромность
    bool poli = true;
    for (long i = 0; i < size; i++){
    if(arr[i]==arr[size-1]){
        size--;
        poli = true;
        }
    else {
        poli = false;
        break; //если не полиндром, прекращаем проверку, делаем переменную фолс, так срабатывает елсе ниже
        }
    }
    if(poli) Console.WriteLine("Полиндром");
    else Console.WriteLine("Не полиндром");
}
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());
long size = SizeArray(num);
long[] arr = new long[size];
CreateArray(arr, size, num);
PrintArray(arr, size);
Console.WriteLine();
Polindrome(arr, size);
