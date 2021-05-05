INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 0, '/user-management', 'Manage Users', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 0, '/room', 'Manage Rooms', 2, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  1, '/user/list', 'List User', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  1, '/user/add', 'Add User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 1, '/user/edit', 'Edit User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 1, '/user/delete', 'Delete User', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  2, '/room-management/roomtype/list', 'List roomtype', 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/room/list', 'List rooms', 2, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/roomtype/add', 'Add Roomtype', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu(  menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES ( 2, '/room-management/roomtype/edit', 'Edit Roomtype', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.menu( menu_parentid, menu_url, menu_name, menu_orderindex, menu_activeflag, menu_createdate, menu_updatedate ) VALUES (  2, '/room-management/room/add', 'Add Room', -1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.role( role_name, role_description ) VALUES ( 'Admin', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES (  'Clerk', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES ( 'Service Staff', null);
INSERT INTO HotelManagementREAL.dbo.role(  role_name, role_description ) VALUES (  'Receptionist', null);
INSERT INTO HotelManagementREAL.dbo.room_type( roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES (  'single room', null, 1000000, 2);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 'double room', null, 2000000, 4);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ( 'king room', null, 5000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES (  'queen room', null, 5000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ('family room', null, 5000000, 7);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES (  'president room', null, 1000000, 1);
INSERT INTO HotelManagementREAL.dbo.room_type(  roty_name, roty_description, roty_currentprice, roty_capacity ) VALUES ('provipRoom', 'qua tot', 100, 2);
INSERT INTO HotelManagementREAL.dbo.[user](user_name, user_photo, user_gmail, user_phone, user_gender, user_activeflag, user_code ) VALUES (  'SuperAdmin', 1, 'cuong@gmail.com', '123456789', 1, 1, 'PVC20011');
INSERT INTO HotelManagementREAL.dbo.[user](user_name, user_photo, user_gmail, user_phone, user_gender, user_activeflag, user_code ) VALUES (  'cuong', 2, 'phanncuongg2001@gmail.com', '987654321', 0, 1, '2001PVC');
INSERT INTO HotelManagementREAL.dbo.user_role(  userol_iduser, userol_idrole, userol_activeflag ) VALUES (  1, 1, 1);
INSERT INTO HotelManagementREAL.dbo.user_role( userol_iduser, userol_idrole, userol_activeflag ) VALUES (  1, 2, 1);
INSERT INTO HotelManagementREAL.dbo.user_role(  userol_iduser, userol_idrole, userol_activeflag ) VALUES ( 2, 2, 1);
INSERT INTO HotelManagementREAL.dbo.user_role( userol_iduser, userol_idrole, userol_activeflag ) VALUES (  2, 3, 1);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  'hello', 1, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  '/home/cuong/Pictures/Images/cheems.jpg', 1, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  '/home/cuong/Pictures/cheemscuoi.jpeg', 2, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  '/home/cuong/Pictures/cheems_alert.jpg', null, 1);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  '/home/cuong/pro', 7, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  '/home/cuong/vip', 7, null);
INSERT INTO HotelManagementREAL.dbo.ImgStorage(  imgsto_url, imgsto_idrootyp, imgsto_iduser ) VALUES (  'sasda', 1, null);
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES ( 1, 1, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 2, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth( auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 3, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 4, 1, 1, '2021-04-18', '2021-04-18');
INSERT INTO HotelManagementREAL.dbo.auth(  auth_idrole, auth_idmenu, auth_permission, auth_activeflag, auth_createdate, auth_updatedate ) VALUES (  1, 5, 1, 1, '2021-04-18', '2021-04-18');

INSERT INTO HotelManagementREAL.dbo.room(  room_name, room_description, room_idroomtype ) VALUES (  'A101', null, 2);
INSERT INTO HotelManagementREAL.dbo.room(  room_name, room_description, room_idroomtype ) VALUES (  'A102', null, 5);
INSERT INTO HotelManagementREAL.dbo.room( room_name, room_description, room_idroomtype ) VALUES ( 'A103', null, 4);
INSERT INTO HotelManagementREAL.dbo.room (room_name, room_description, room_idroomtype ) VALUES ( 'A104', null, 1);
INSERT INTO HotelManagementREAL.dbo.room(  room_name, room_description, room_idroomtype ) VALUES ( 'A105', null, 2);
INSERT INTO HotelManagementREAL.dbo.room( room_name, room_description, room_idroomtype ) VALUES ( 'A106', null, 1);


insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Maintained','Room is maintained for better service');
insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Bookes','This room is being booked');
insert into HotelManagementREAL.dbo.status(sta_name , sta_description) values ('Occupied','Guests have already taken this room');

insert into client (cli_name,cli_gmail,cli_phone) values('Cuong','cuongit2k1@gmail.com','0912345678');
insert into client (cli_name,cli_gmail,cli_phone) values('Toan','Toanit2k1@gmail.com','1234567890');
insert into client (cli_name,cli_gmail,cli_phone) values('Nhat','Nhatit2k1@gmail.com','0987654321');

insert into HotelManagementREAL.dbo.status_time(statim_fromdate,statim_todate,statim_idroom,statim_idstatus) values ('03/15/2021','03/08/2021',1,1);
insert into HotelManagementREAL.dbo.status_time(statim_fromdate,statim_todate,statim_idroom,statim_idstatus) values ('03/01/2021','02/21/2021',2,2);