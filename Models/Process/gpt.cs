namespace LeThuTrangBTH.Models.Process
{
    public class gpt
    {
        public string ptbn(double heSoA, double heSoB)
        {
            string thongBao="";
            double x;
            if (heSoA==0 && heSoB==0)
            {
                thongBao="Phương trình vô số nghiệm";
            }
            if(heSoA!=0)
            {
                x=-heSoB/heSoA;
                thongBao="Phương trình có nghiệm"+x;
            }
            else{
                thongBao="Phương trình vô nghiệm";
            }
            return thongBao;
        }
        public string ptbh (double a, double b, double c)
        {
            string mess="";
            double denta, x1, x2;
            if(a==0)
            {
                mess= ptbh
            }
            else{
                denta=b*b-4*a*c;
                if(denta <0){
                    mess="Phương trình vô nghiệm";
                }
                if(denta==0)
                {
                    mess="PT có nghiệm kép x="+(-b/(2*a));
                }
                else{
                    x1=(-b+Math.Sqrt(denta))/(2*a);
                    x2=(-b-Math.Sqrt(denta))/(2*a);
                    mess="PT có 2 nghiệm: " + x1 + x2;
                }
            }
            return mess;
        }
        
    }
}