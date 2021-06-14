-Bỏ cái nút reset trong InvoiceDetail , nếu mà vô để view(trong FormAccoutant) thì bỏ nút OKE đi + cho t thêm cai label để hiện UserCode(hiện ở góc màn hình hay chi đó )
-Form Receiptionist dong 556 
-Thêm 2 cái DTB fromDate vs toDate + bỏ 2 cái button add vs edit đi chỗ FormAccountant 
-bỏ nút Invoice chỗ view,add,edit BookingDetail đi + nút checkin chỉ hiện chỗ update thôi +BookDate vs DueDate đừng hiện giờ
 

hello
-----------------------
Mục đích activeflag là khóa một đối tượng nào đó nhưng vẫn giữ thông tin lại cái các đối tượng khác truy vấn 
1.Muốn xóa roomtype(activeflag=0) ,yêu cầu user qua bên room update lại loại phòng khác 
2.thêm id roomtype vô bên bookingdetail nx (ko cần foreignkey) 
3.Xóa room : activeflag =0 , room name ko cho đổi 


4. User: activeflag =0  , xóa lun UserRole ko vấn đề chi 
5.Booking một khi đã complete thì ko xóa đc  --->khỏi cần activeflag
6.ko cho dat truc tiep , phai thong qua booking 
7.Booking sẽ có 4 trạng thái : Processed(khi client ms book xong và sẽ có 5 ngày để thay đổi) , Completed(sau 5 ngày fix booking ,ko đc
thay đổi hay xóa , nếu khách ko ts nhận thì tính vô deposit),Checkin(làm cái nút khi client ts nhận phòng thì chuyển sang trangk thái này) , Payed(thanh toán xong ) 
8.Cho TaskSchedule chạy mỗi ngày(lúc 0h) kiểm tra có tk booking mô trạng thái Process và duedate>GetDate() thì chuyển sang Completed
(Stored Procedure)
9.(Nếu lỡ khách đặt mà ko ts )Bên QLInvoice cho thêm chức năng tìm những booking có trạng thái Completed mà checkindate >getdate()--->tùy trường hợp
có thể thanh toán lun những booking đó (tùy thuộc vào nghiệp vụ ko phải do code) -->xem description của booking thử 
10. Nếu khách hủy sau khi thời hạn 5 ngày : có thể nhập mã Booking zô chỗ Invoice rồi tìm (ko cần tìm tự động vì tk client sẽ điện ts mình ns hủy) 

11. Booking : +search :(Cbb) 4 cai date fromDate , toDate ,(Cbb) 4 cai trang thai , search(bookCode , UserCode ,ClientCode)
	      + Order by : totalPrice ,
12.RoomType : Search name vs code , order by price ,
13.Room : tim theo name thoi , ko lam sap xep theo 
14. Nhớ làm cái tạo tự động dueDate ;



