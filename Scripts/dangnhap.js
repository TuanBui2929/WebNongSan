function Dangnhap(form)
{
var hoten, email, password, password2;
hoten = form.hoten.value;
email = form.email.value;
password = form.password1.value;
password2 = form.password2.value;
if(hoten == ''){
    alert("Bạn chưa nhập họ tên!")
}
else
if(password != password2)
{
    alert("Mật khẩu xác nhận không phù hợp, vui lòng nhập lại!")
}
else 
if(email == ''){
    alert("Email trống!. Vui lòng nhập lại")
}
else 
if(password == '' || password2 ==''){
    alert("Chưa nhập password. Vui lòng nhập lại")
}
else 
if(password != '' || password2 !=''|| hoten !='' || email !=''){
    alert("Đăng ký thành công")
}
}