# BÁO CÁO THỰC HÀNH 4 - LẬP TRÌNH TRỰC QUAN
*Nguyễn Gia Hưng - 24520604*
## I. Tổng quan bài thực hành

## II. Video minh họa
Playlist youtube [Báo cáo thực hành 4](https://www.youtube.com/playlist?list=PLdcN3QW0mt2ztll-Q2WIMQAlpz6zYrxj8)
## III. Nội dung thực hành
### 1. Sự kiện bàn phím và chuột
- Yêu cầu: Xử lý sự kiện khi người dùng click chuột vào form hoặc nhấn phím khi form đang mở
    - Viết chương trình chặn các thông điệp bàn phím và thông điệp chuột 
    - Khi nhấn phím bất kỳ thì xuất các thông tin: Mã ASCII, key code,... 
-  Hướng xử lý: 
    - Tạo một label để thông báo sự kiện xảy ra 
    - Xử lý sự kiện `MouseClick` và `KeyPress` của form, lấy thông tin từ `MouseEventArgs e` và `KeyPressEventArgs e` để in ra thông tin ra theo yêu cầu


### 2. Đồng hồ đơn giản
-  Yêu cầu: Tạo chương trình hiển thị giờ trên hệ thống theo thời gian hiện tại 
-  Hướng xử lý:
    -  Tạo một timer clock và sự kiện tick của clock để cập nhật thời gian theo giây. Chạy timer ngay khi Load form 
    -  Dùng Datetime.Now để lấy thời gian hiện tại, thông báo trên label mỗi khi sự 
kiện tick xảy ra


### 3. Media Player
-  Yêu cầu: 
    -Ứng  dụng  chứa  Windows  Media  Player  control  cho phép  Play  các  file video/sound theo nhiều dạng format:(*.avi *.mpeg *.wav *.midi *.mp4 *.mp3) 
    -  Menu Bar có 1 Menu File và 2 Sub Menu Open và Exit 
    -  Khi chọn Sub Menu Exit sẽ thoát ứng dụng 
    -  Khi chọn Sub Menu Open sẽ mở hộp thoại Open File để chọn mở file Media 
    -  Control Multi Media sẽ phát file Media đã chọn. 
    -  StatusStrip hiện thị: Ngày giờ hệ thống và thay đổi giờ theo mỗi giây. 
-  Hướng xử lý: 
    -  Tạo  Timer  và  sự  kiện Tick để  cập  nhật  ngày  giờ  hiện  tại  lên  StatusStrip  mỗi giây. Kích hoạt Timer ngay khi khởi tạo Form 
    -  Xử lý sự kiện Open: Dùng OpenFileDialog để chọn file media với bộ lọc định dạng,  gán  đường  dẫn  file  vào  thuộc  tính  URL  của  Windows  Media  Player control để phát 
    -  Xử lý sự kiện Exit: Gọi lệnh Application.Exit() để thoát ứng dụng


### 4. Soạn thảo văn bản
-  Yêu cầu: 
    -  Chương trình soạn  thảo văn bản  có  chức năng soạn  thảo, lưu –  mở  file, định dạng font chữ 
    -  Sử dụng RichTextBox để thiết kế điều khiển hiện thị và nhập nội dung văn bản 
    -  Sử dụng công cụ MenuStrip để tạo Hệ Thống và Định Dạng 
        +  Trong menu Hệ thống có chức năng tạo văn bản (Ctrl + N), mở file, lưu nội dung (Ctrl + S) và Thoát chương trình. 
        +  Click vào menu Định dạng sẽ gọi form FontDialogue có sẵn của windows 
    -  Sử dụng công cụ ToolStrip để tạo thanh công cụ chứa các button và image 
    -  Khi mới mở Form Soạn thảo văn bản, thực hiện: 
        +  Tạo dữ liệu cho ComboBox Font: chứa tất cả các Font chữ của hệ thống. 
        +  Tạo dữ liệu cho ComboBox Size: chứa các giá trị từ 8 → 72 ( 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72) 
        +  Tạo giá trị mặc định là Font Tahoma, Size 14 
    -  Khi chọn Tạo văn bản mới (hoặc nhấn nút Tạo mới): Xóa nội dung hiện có trên RichTextBox và khởi tạo các giá trị mặc định như Font, Size, ... 
    -  Khi  chọn  Mở  tập  tin  (hoặc  nhấn  nút  Mở):  Hiển  thị  hộp  thoại  mở  tập  tin (OpenFileDialog) cho phép người dùng chọn tập tin văn bản (*.txt hoặc *.rtf) để mở. 
    -  Khi chọn Lưu nội dung văn bản (hoặc nhấn nút Lưu): Lưu nội dung văn bản trên RichTextBox xuống tập tin. Nếu là văn bản mới và trước đó chưa lưu lần nào  thì  hiển  thị  hộp  thoại lưu tập tin (SaveFileDialog) cho phép người  dùng chọn thư mục cần lưu tập tin với kiểu tập tin cần lưu là *.rtf. 
    -  Nếu là văn bản đã được mở trước đó thì thông báo cho người dùng lưu văn bản thành công. 
    -  Xử lý các chức năng B, I, U 
-  Hướng xử lý:  
    -  Thiết kế giao diện theo yêu cầu, thiết lập các giá trị mặc định khi khởi tạo form 
    -  Chức năng định dạng: 
        +  Khi chọn văn bản, sự kiện Selection Change  của Rich Text Box được gọi, xử lý hiển thị font hiện tại của chữ được chọn lên tool bar. 
        +  Xử lý định dạng chữ khi chọn bằng FontDialogue 
        +  Xử lý sự kiện TextChange cho combo box Font và Size cùng thực hiện định dạng font nếu 1 trong 2 thay đổi. 
        +  Thêm và xóa định dạng khi Click vào nút B, I và U 
    -  Chức năng hệ thống: 
        +  Trước khi tạo mới file (New), kiểm tra nếu có văn bản đã soạn thảo thì hỏi cần lưu văn bản đã soạn không.  Nếu người  dùng chọn  "Yes"  thì thực hiện lưu, sau đó làm sạch khung soạn thảo (RichTextBox), đặt lại tiêu đề form về mặc định ("Untitled.txt") và reset các biến trạng thái 
        +  Xử lý sự kiện Save: 
            -  Kiểm tra biến lưu đường dẫn file (textFile). Nếu biến rỗng (chưa từng lưu) thì gọi hàm SaveAs. 
            -  Nếu  đã  có  đường  dẫn,  khởi  tạo  StreamWriter  để  ghi  đè  nội  dung  từ RichTextBox vào file đó. 
        +  Xử lý hàm SaveAs: 
            -  Hiển thị hộp thoại SaveFileDialog để người dùng chọn nơi lưu và đặt tên. 
            -  Nếu người dùng ấn OK, cập nhật đường dẫn file, cập nhật tiêu đề Form và 
            thực hiện ghi nội dung vào file mới. 
        +  Xử lý sự kiện Open: 
            -  Hiển thị hộp thoại OpenFileDialog. 
            -  Nếu người dùng chọn file và ấn OK: Trước khi mở, kiểm tra xem văn bản 
            hiện tại có thay đổi không để hỏi lưu (tương tự chức năng New). 
            -  Sau đó, đọc toàn bộ nội dung file được chọn bằng File.ReadAllText, hiển 
            thị lên RichTextBox và cập nhật tiêu đề Form. Có bắt lỗi (try-catch) khi 
            đọc file. 
        +  Xử lý sự kiện Exit: 
            -  Kiểm tra khung soạn thảo có dữ liệu không. Nếu có, hiển thị MessageBox 
            với 3 lựa chọn (Yes/No/Cancel): 
            -  Yes: Lưu file rồi thoát. 
            -  No: Thoát không lưu. 
            -  Cancel: Hủy lệnh thoát, quay lại chương trình. 
            -  Cách xử lý tương tự khi chọn chức năng Thoát trong Hệ thống, hoặc nhất 
            X trực tiếp để đóng form


### 5. Quản lý sinh viên
-  Yêu cầu: 
    -  Form Quản lý sinh viên có Menu Chức năng gồm 2 SubMenu là Thêm mới và 
    Thoát 
    -  Sử dụng MenuStrip để tạo menu 
    -  Sử dụng ToolStrip để tạo hình và nút bấm Thêm mới, Tìm kiếm theo tên 
    -  Khi  click  vào  menu  thêm  mới  (Ctrl  +  N)  hoặc  ở  icon  hình  thêm  mới  trên 
    toolStrip thì gọi Form nhập liệu sinh viên 
    -  Ở phần tìm kiếm theo tên sinh viên, khi Textbox tìm kiếm thay đổi thì luôn luôn 
    tìm lại dữ liệu chứa tên tìm kiếm (không phân biệt hoa thường) 
-  Hướng xử lý: 
    -  Thiết kế giao diện và khởi tạo: 
        +  Thiết kế Form chính với MenuStrip, ToolStrip và DataGridView. 
        +  Thiết kế Form nhập liệu (AddNewForm) để nhận thông tin sinh viên. 
    -  Chức năng Thêm mới (Quản lý luồng dữ liệu giữa 2 Form): 
        +  Tại Form chính: Khi click menu "Thêm mới" hoặc nút Add trên ToolStrip, 
        khởi tạo và gọi AddNewForm dưới dạng hộp thoại (ShowDialog). 
        +  Tại Form nhập liệu (AddNewForm): 
            -  Hàm kiểm tra (ValidInfo): Duyệt từng ký tự để đảm bảo MSSV chỉ chứa 
            số, Tên không chứa số, và Điểm phải là số thực từ 0-10. 
            -  Nút Thêm: Gọi hàm kiểm tra. Nếu dữ liệu đúng, khởi tạo đối tượng Student 
            và đóng form trả về kết quả. Nếu sai, hiển thị thông báo lỗi. 
            -  Nút Thoát (Form con): Kiểm tra các ô nhập liệu, nếu đang có dữ liệu thì     hiển thị MessageBox hỏi xác nhận trước khi đóng. 
        +  Nhận dữ liệu về Form chính: Sau khi Form con đóng, kiểm tra nếu có đối 
    tượng sinh viên mới trả về thì thêm dòng vào DataGridView và gọi hàm cập 
    nhật số thứ tự (UpdateTT). 
    -  Chức năng Tìm kiếm: 
        +  Xử lý sự kiện TextChanged trên ô tìm kiếm của ToolStrip. 
        +  Lấy  từ  khóa,  chuyển  về  chữ  thường  (ToLower)  và  tạm  dừng  vẽ  lưới 
        (SuspendLayout). 
        +  Duyệt qua từng dòng của DataGridView: 
            -  Lấy giá trị cột Tên (Cells[2]), so sánh chứa chuỗi ký tự tìm kiếm. 
            IT008 – LẬP TRÌNH TRỰC QUAN 
            
            -  Thiết lập thuộc tính Visible = true nếu tìm thấy, ngược lại gán false để ẩn     dòng. 
        +  Gọi lại hàm UpdateTT để đánh lại số thứ tự liên tục cho các kết quả tìm được. 
    -  Chức năng Hệ thống & Tiện ích: 
        +  Hàm UpdateTT: Duyệt lại lưới, đánh số thứ tự (STT) tăng dần cho các dòng 
        đang hiển thị (Visible = true). 
        +  Sắp xếp: Khi người dùng sắp xếp cột (Sorted), tự động gọi lại UpdateTT để 
        giữ đúng thứ tự hiển thị. 
        +  Menu Thoát: Gọi lệnh Application.Exit() để tắt chương trình.


### 6. Sao chép thư mục
-  Yêu cầu: 
    -  Chương trình có thể chọn đường dẫn thư mục nguồn và đích 
    -  Khi nhấn Sao chép sẽ copy toàn bộ nội dung trong thư mục nguồn vào thư mục 
    đích 
    -  Tiến trình sao chép thể hiện trên  process bar, các file đang sao chép thể hiện 
    trên thanh statusTrip và toolTip khi hover vào thanh process bar 
    -  Chức năng các button được thể hiện bởi toolTip khi hover chuột vào 
-  Hướng xử lý: 
    -  Thiết kế giao diện và cấu hình theo yêu cầu 
    -  Tạo và cấu hình một BackgroundWorker để thực hiện tác vụ sao chép file trên     luồng phụ, giúp giao diện không bị treo 
        +  Khi  người  dùng  nhấn  nút  Sao  chép,  chương  trình  kiểm  tra  đường  dẫn 
        nguồn/đích  hợp lệ, khóa nút bấm  để tránh  xung  đột, và gọi lệnh 
        RunWorkerAsync để bắt đầu luồng xử lý nền. 
        +  Worker thực hiện tính toán tổng dung lượng thư mục nguồn trước. Sau đó, 
        nó chạy thuật toán đệ quy để duyệt vào từng thư mục con. Quá trình copy 
    file sử dụng FileStream để đọc/ghi từng khối dữ liệu (buffer). Sau mỗi khối 
    dữ liệu  được ghi, Worker tính toán phần  trăm  hoàn  thành  và  gọi 
    ReportProgress để gửi kèm tên file hiện tại về luồng chính. 
    -  Tại luồng giao diện chính, chương trình nhận thông tin từ Worker để thực hiện: 
    Tăng giá trị của ProgressBar, Hiển thị tên file đang chép lên thanh StatusStrip, 
    Thực hiện gán Tooltip động cho ProgressBar, giúp hiển thị tên file ngay tại vị 
    trí chuột khi người dùng hover vào thanh tiến trình. 
    -  Khi quá trình kết thúc hoặc bị hủy,  chương  trình  hiển thị thông báo 
    (MessageBox), đặt lại thanh tiến trình và mở lại (Enable) các nút chức năng để 
    người dùng tiếp tục thao tác.
