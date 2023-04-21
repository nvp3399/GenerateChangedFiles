
# GenerateChangedFiles - English Description

This is a Windows Forms application that allows users to copy changed files from one git repository to another folder.

## Features
- Read configuration from `appsettings.json` file
- Set values of text boxes on the form
- Get the current branch of the git repository
- Pull latest changes for source and chosen branches
- Get a list of changed files
- Copy changed files from source folder to destination folder
- Merge all files in each subdirectory of the destination folder into a single file with a `.sql` extension

## Usage
1. Enter the source and destination folders, source and chosen branches in the text boxes on the form.
2. Click the `CopyChangedFilesBtn` button to start the operation.
3. The application will display a message indicating that the operation has completed.
4. Refer to the log for more information.


# GenerateChangedFiles - Vietnamese Description

Đây là một ứng dụng Windows Forms cho phép người dùng sao chép các tệp đã thay đổi từ một kho lưu trữ git sang một thư mục khác.

## Tính năng
- Đọc cấu hình từ tệp `appsettings.json`
- Đặt giá trị của các hộp văn bản trên biểu mẫu
- Lấy nhánh hiện tại của kho lưu trữ git
- Kéo các thay đổi mới nhất cho các nhánh nguồn và được chọn
- Lấy danh sách các tệp đã thay đổi
- Sao chép các tệp đã thay đổi từ thư mục nguồn sang thư mục đích
- Hợp nhất tất cả các tệp trong mỗi thư mục con của thư mục đích thành một tệp duy nhất với phần mở rộng `.sql`

## Sử dụng
1. Nhập các thư mục nguồn và đích, nhánh nguồn và nhánh được chọn vào các hộp văn bản trên biểu mẫu.
2. Nhấp vào nút `CopyChangedFilesBtn` để bắt đầu hoạt động.
3. Ứng dụng sẽ hiển thị thông báo cho biết hoạt động đã hoàn thành.
4. Tham khảo nhật ký để biết thêm thông tin.

