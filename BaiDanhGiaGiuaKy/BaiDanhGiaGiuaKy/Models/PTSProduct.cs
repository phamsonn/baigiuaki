using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiDanhGiaGiuaKy.Models
{
    public class PTSProduct
    {
        [Key]
        public int PTSID { get; set; }
        [DisplayName("PTS:Họ và tên")]
        [Required(ErrorMessage = "PTS:Chưa nhập dữ liệu")]
        [RegularExpression(@"^[A-Za-z ]{2,25}$", ErrorMessage = "Họ tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "PTS:Họ và tên chỉ chứa tối thiểu 5 ký tự tối đa 100")]
        public string PTSName { get; set; }
        [DisplayName("PTS: Ảnh")]
        [Required(ErrorMessage = "PTS:Chưa nhập dữ liệu")]
        [DataType(DataType.ImageUrl, ErrorMessage = "PTS:Đây không phải là URL hình ảnh hợp lệ")]
        public string PTSImage { get; set; }
        [DisplayName("PTS: Số lượng")]
        [Required(ErrorMessage = "PTS:Chưa nhập dữ liệu")]
        [Range(1, 100, ErrorMessage = "PTS:Số lượng phải trong khoảng 1 đến 100")]
        public int PTSQuanlity { get; set; }
        [DisplayName("PTS: Giá")]
        [Required(ErrorMessage = "PTS:Chưa nhập dữ liệu")]
        [Range(1, int.MaxValue, ErrorMessage = "PTS: Giá phải lớn hơn 0")]
        public int PTSPrice { get; set; }
        public bool PTSIssActive { get; set; } = true;


    }
}