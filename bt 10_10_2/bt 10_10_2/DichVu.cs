namespace bt_10_10_2
{
    public class DichVu
    {
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }

        public DichVu(string tenDV, decimal donGia)
        {
            TenDV = tenDV;
            DonGia = donGia;
        }

        public override string ToString()
        {
            return $"{TenDV} - {DonGia:N0} VNĐ";
        }
    }
}
