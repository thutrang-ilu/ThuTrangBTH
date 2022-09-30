using System;
namespace MvcMovie.Models.Process
{
    public class StringProcess
    {
        public string Remove(string strInput)
        {
            string strResult = "";
            // Code xu ly cac ky tu trang o dau va cuoi
            //xoa o dau va cuoi
            strInput = strInput.Trim();
            //xoa cac ky tu trang o giua
            int index = strInput.IndexOf("  ");
            while(strInput.IndexOf("  ")>0)
            {
                strInput = strInput.Replace("  "," ");
            }
            strResult = strInput;
            return strResult;
        }
    }
    public class StringProcess1
    {
        public string LowerToUpper(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
            return strResult;
        }
    }
    public class StringProcess2
    {
        public string UpperToLower(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToLower();
            strResult = strInput;
            return strResult;
        }
    }        

     public class StringProcess3
    {
        public string CapitalizeOneFirstCharacter(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
            return strResult;
        }
    }        
}