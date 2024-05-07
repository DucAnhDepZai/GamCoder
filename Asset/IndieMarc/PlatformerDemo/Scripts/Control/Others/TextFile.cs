using Newtonsoft.Json;
using SimpleJSON;

using System.Collections.Generic;
using UnityEngine;

public class TextFile : MonoBehaviour
{ 
    private void Awake()
    {
        List<string> list = new List<string>();
        List<List<string>> lists = new List<List<string>>();

        list.Add("Chào mừng bạn đến với GameCoder.");
        list.Add("Bạn có muốn khám phá thế giới GamCoder này không?");
        list.Add("Nếu có thì bạn sẽ phải học vài cách để giao tiếp và tương tác với thế giới này.");
        list.Add("Nhưng đừng lo, tôi: Teacher sẽ là người hướng dẫn của bạn.");
        list.Add("Phía trước kia là người lính gác cổng thế giới. Anh ta sẽ không cho người xấu đi qua đâu!");
        list.Add("Nếu bạn muốn qua phía bên kia để lấy kho báu thì phải thể hiện bạn là một người lễ phép.");
        list.Add("Hãy ấn vào nút hình máy tính phía trên cùng của màn hình.");
        list.Add("Bạn thấy một cửa sổ hiện ra không! Đó sẽ là nơi bạn viết code vào.");
        list.Add("Tôi biết bạn đang có nhiều thắc mắc nhưng bạn đừng quan tâm tới các câu lệnh này vội, " +
            "hãy coi như những lệnh này là bắt buộc đối với 1 chương trình C++.");
        list.Add("Bạn thấy nút Submit bên dưới kia không? Hãy ấn thử vào đi. " +
            "Đó sẽ là nơi để nộp và chạy bài code xem nó hoạt động như thế nào.");
        list.Add("Câu lệnh cout này sẽ giúp nhân vật bạn nói chuyện đó!" +
        " Giờ hãy cout << " +
        '"' +
        "Hello World" +
        '"' +
        " để thể hiện sự ngoan ngoãn đi rồi anh ta sẽ cho bạn qua.");
        Subject b1 = new Subject { id = 1, scene = "A_Level1", done = false, chat = new List<string>(list) };
        list.Clear();
        list.Add("Để qua được màn chơi này thì tôi sẽ bắt bạn code một chút xíu!");
        list.Add("Để hiển thị lên màn hình dòng chữ nào đó ta có thể dùng câu lệnh: cout <<  ");
        list.Add("Hãy thử nói Up hoặc Right hoặc Down hoặc Left đi");
        list.Add("Gợi ý: Hãy thay câu lệnh cout << \"...\" thành cout << \"Up\" để nói ra từ Up");
        Subject b2 = new Subject { id = 2, scene = "A_Level2",done = false , chat = new List<string>(list) };
        list.Clear();
        list.Add("Hãy cẩn thận! Ngã xuống sông là tôi lại phải vớt bạn lên giờ.");
        list.Add("Mở cửa sổ code ra đi, màn này chúng ta sẽ học về biến và kiểu dữ liệu");
        list.Add("Biến trong lập trình đại diện cho một giá trị mà có thể thay đổi trong quá trình chạy");
        list.Add("Ví dụ như số tiền trong tài khoản, tuổi,... những giá trị này đều có thể thay đổi theo thời gian và cần sử dụng biến để lưu trữ.");
        list.Add("Ứng với mỗi kiểu số nguyên(int), số thực(float), xâu kí tự(string),... thì lại có một cách khai báo khác nhau");
        list.Add("VD Để khai báo một số nguyên (interger) ta dùng: int tên_biến = 1 Trong đó thì ta có vài quy tắc đặt tên biến cần tuân thủ.");
        list.Add("Cùng thực hành nhé! Bây giờ tôi đã khai báo một biến   int LogLength = 1;    và độ dài của khúc gỗ bây giờ là 1.");
        list.Add("Bạn hãy sửa số 1 thành một số khác rồi submit xem điều gì sảy ra nhé!");
        list.Add("Hãy sửa giá trị khúc gỗ sao cho giúp bạn có thể qua màn.");
        Subject b3 = new Subject { id = 3, scene = "A_Level3", done = false, chat = new List<string>(list) };
        list.Clear();
        Subject b4 = new Subject { id = 4, scene = "A_Level4", done = false, chat = new List<string>(list) };

        list.Add("Nhiệm vụ của bạn là qua được sông");
        list.Add("Các biến có sẵn trong cửa sổ code sẽ thay đổi giá trị độ cao của thanh gỗ");
        list.Add("Hãy cố gắng tìm cách qua màn này nhé.");       
        list.Clear();
        Subject b5 = new Subject { id = 5, scene = "A_Level5", done = false, chat = new List<string>(list) };
        list.Clear();
        Subject b6 = new Subject { id = 6, scene = "A_Level6", done = false, chat = new List<string>(list) };
        list.Add("Nhiệm vụ của bạn là ");
        list.Clear();
        Subject b7 = new Subject { id = 7, scene = "A_Level7", done = false, chat = new List<string>(list) };
        list.Clear();
        Subject b8 = new Subject { id = 8, scene = "A_Level8", done = false, chat = new List<string>(list) };
        list.Clear();
        Subject b9 = new Subject { id = 9, scene = "A_Level9", done = false, chat = new List<string>(list) };
        list.Clear();
        Subject b10 = new Subject { id = 10, scene = "A_Level10", done = false, chat = new List<string>(list) };
        list.Clear();
        Lesson l1 = new Lesson { id = 1 , name = "Variables and Datatypes", subjects = new List<Subject> { b1, b2, b3, b4, b5 } };
        Lesson l2 = new Lesson { id = 2 , name = "Selection statements",subjects = new List<Subject> {b6 , b7, b8 } };
        Lesson l3 = new Lesson { id = 3, name = "Loops", subjects = new List<Subject> {b9, b10 } };
        Course c1 = new Course { id = 1, name = "C++ Beginner", lessons = new List<Lesson> { l1,l2,l3 } };
       
        string json =  JsonConvert.SerializeObject(c1);
        StartCoroutine(DAO.UpdateJsonData(json));

    }




}
