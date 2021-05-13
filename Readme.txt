hello
-----------------------
Mục đích activeflag là khóa một đối tượng nào đó nhưng vẫn giữ thông tin lại cái các đối tượng khác truy vấn 
1.Muốn xóa roomtype(activeflag=0) ,yêu cầu user qua bên room update lại loại phòng khác 
2.thêm id roomtype vô bên bookingdetail nx (ko cần foreignkey) 
3.Xóa room : activeflag =0 , room name ko cho đổi 


4. User: activeflag =0  , xóa lun UserRole ko vấn đề chi 
5.Booking một khi đã complete thì ko xóa đc  --->khỏi cần activeflag