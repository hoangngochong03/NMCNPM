using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM
{
    public class BoardGame
    {
        private String maSanPham;
        private String tenSanPham;
        private int giaSanPham;
        private int soLuongSanPham;
        private String moTaSanPham;

        public BoardGame()
        {
            this.maSanPham = "NULL";
            this.tenSanPham = "NULL";
            this.giaSanPham = -1;
            this.soLuongSanPham = -1;
            this.moTaSanPham = "Khong co mo ta";
        }
        public BoardGame(String ma, String ten, int gia, int soluong, String mota)
        {
            this.maSanPham = ma;
            this.tenSanPham = ten;
            this.giaSanPham= gia;
            this.soLuongSanPham = soluong;
            this.moTaSanPham = mota;
        }
        
        public String getMaSanPham() { return this.maSanPham; }
        public void setMaSanPham(String maSanPham) { this.maSanPham = maSanPham; }
        public String getTenSanPham() { return this.tenSanPham; }
        public void setTenSanPham(String tenSanPham) { this.tenSanPham = tenSanPham; }

        public int getGiaSanPham() { return this.giaSanPham;}
        public void setGiaSanPham(int gia) { this.giaSanPham = gia; }

        public int getSoLuongSanPham() { return this.soLuongSanPham ; }
        public void setSoLuongSanPham(int soluong) { this.soLuongSanPham = soluong; }

        public String getMoTaSanPham() { return this.moTaSanPham; }
        public void setMoTaSanPham(String mota) { this.maSanPham = mota; }
    }
}
