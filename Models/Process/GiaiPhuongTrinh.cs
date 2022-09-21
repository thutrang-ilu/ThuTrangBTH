namespace LeThuTrangBTH.Models.Process
{
    public class GiaiPhuongTrinh
    {
        //xay dựng các pthuc
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            //khai báo 1 biến đe chứa dữ liệu muốn trả về
            string thongBao = "";
            //khai báo 1 biến để chứa giá trị nghiệm của ptrinh
            double x;
            //giai ptrinh
             if(heSoA == 0){
                if(heSoB == 0){
                    thongBao = "Phương trình có vô số nghiệm.";
                }
                else{
                    thongBao = "Phương trình vô nghiệm";
                }
            } else{
                //tính nghiệm của phương tình bậc nhất
                x = -heSoB/heSoA;
                thongBao = "Phương trình có nghiệm X = " + x;
            }
           //trả về dữ liệu
           return thongBao;
        }
         public string GiaiPhuongTrinhBacHai (double a,double b,double c)
        {
            string mess="";
            double denta, x1, x2;
            if(a==0)
            {
                mess= GiaiPhuongTrinhBacHai(b,c)
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