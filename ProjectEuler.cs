using System;

namespace ConsoleApplication
{
    public class Problem12
    {
        public void Execute()
        {
            int DivNum = 0;
            int TrimNum = 0;
            int zNdx = 1;
            do{
                TrimNum = FindTriNum(zNdx);
                DivNum = DivisorNum(TrimNum);
                Console.WriteLine("Index - " + zNdx + " | Num - " + TrimNum + " | DivNum - " + DivNum);
                zNdx++;
            }while(DivNum < 500);
            Console.WriteLine("Result - " + FindTriNum(zNdx));
        }

        //Function for determining if a number is even
        private bool IsEven(int pNum){
            if(pNum % 2 == 0){return true;}
            else{return false;}
        }

        //Function for finding the next triangle number
        private int FindTriNum(int pNdx){
            int sum = 0;
            int zNdx = pNdx;
            while(true){
                sum += zNdx;
                zNdx--;
                if(zNdx == 0){return sum;}
            }
        }

        //Function for determining the number of divisors for a given number
        private int DivisorNum(int pNum){
            int zDivNum = 1;
            if(IsEven(pNum)){
                for(int i=1; i <= pNum / 2; i++){
                    if(pNum % i == 0){zDivNum++;}
                }
            }
            else{
                for(int i=1; i <= pNum / 3; i++){
                    if(pNum % i == 0){zDivNum++;}
                }

            }
            return zDivNum;
        }
        
        

    }
}
