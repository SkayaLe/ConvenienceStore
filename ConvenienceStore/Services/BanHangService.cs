using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BanHangService
    {
        public BanHangService()
        {

        }

        // Lấy số hóa đơn hiện có
        // cộng thêm 1
        // tạo chuỗi HD + padding các số 0 + ID mới
        public string AutoCreateNewHoaDon(string maNVBH)
        {
            int count = ModelEntity.db.HoaDon.Count();
            count++;
            string maHD = "HD" + count.ToString().PadLeft(6, '0');

            /*Model.HoaDon hoaDon = new Model.HoaDon()
            {
                maHD = "HD" + count.ToString().PadLeft(6, '0'),
                maNVBH = maNVBH,
                maCN = ModelEntity.db.NhanVienBanHang.Where(x => x.maNVBH == maNVBH).Single().maCN
            };
            
            ModelEntity.db.HoaDon.Add(hoaDon);
            ModelEntity.db.SaveChanges();*/

            return maHD;
        }

        // Hủy hóa đơn trong table HoaDon và các sản phẩm đã chọn trong HoaDonSanPham
        public bool HuyHoaDon(string maHD)
        {
            //ModelEntity.db.HoaDon.Remove(ModelEntity.db.HoaDon.Where(x => x.maHD == maHD).Single());
            //ModelEntity.db.HoaDonSanPham.Remove(ModelEntity.db.HoaDonSanPham.Where(x => x.maHD == maHD);
            //ModelEntity.db.SaveChanges();
            return true;
        }
    }
}
