mô tả API 
GET https://localhost:7084/api/Auth/login cho phép người dùng đăng nhập vào hệ thống với tên đăng nhập và mật khẩu 
POST 'https://localhost:7084/api/Auth/logout'  khi người dùng click vào giao diện front end đăng xuất hệ thống sẽ thông báo đăng xuất
GET https://localhost:7084/api/Categories lấy ra tất cả các phần loại trong danh mục 
POST https://localhost:7084/api/Categories người dùng thêm danh mục với các trường như: name, phân loại danh mục lớn , phân loại danh mục nhỏ , chi tết phân loại 
PUT https://localhost:7084/api/Categories người dùng cập nhật lại thông tin phân loại 
DELETE https://localhost:7084/api/Categories người dùng xóa thông tin phân loại 
GET https://localhost:7084/api/Posts' cho phép người dùng lấy ra tất cả thông tin bài viết 
POST https://localhost:7084/api/Posts' cho người dùng dùng thêm thông tin bài viết với các trường: tên, phân loại, mô tả, phân loại con 
PUT  https://localhost:7084/api/Posts' cho em người dùng cập nhật lại thông tin bài viết 
delete https://localhost:7084/api/Posts' xóa bài viết 
Đạt công việc: 
  - tạo crud danh mục
  - tạo bài viết
Phúc công việc
-  tạo cấu trúc file mvc data, model, contrel, tạo domain trong model
-  login, logout, phân quyền  
