class GFG {
    
    static bool checkLuhn(String cardNo)
    {
        int nDigits = cardNo.Length;
     
        int nSum = 0;
        bool isSecond = false;
        for (int i = nDigits - 1; i >= 0; i--)
        {
     
             int d = cardNo[i] - '0';
     
            if (isSecond == true)
                d = d * 2;
            
            nSum += d / 10;
            nSum += d % 10;
     
            isSecond = !isSecond;
        }
        return (nSum % 10 == 0);
    }
     
        static public void Main()
        {
            int i = 0;
            while (i < 10000)
            {
                long Num = 8406040000 + i;
                string PrNum = Num.ToString();
                char[] ch = new char[PrNum.Length];
                string girl = "";
                for (int X = 0; X < PrNum.Length; X++)
                {
                    ch[X] = PrNum[X];
                } 
                foreach  (char c in ch)
                {
                    int hentai = int.Parse(c.ToString());
                    if (hentai % 8 == 0)
                    {
                        if (hentai != 0)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(hentai);
                            if (checkLuhn(PrNum))
                            {
                                Console.WriteLine("This is a valid card: " + PrNum);
                            }
                            else
                            {
                               continue;
                            }
                            
                        }
                        
                    }
                }

                i++;
            }
            
        }
}