using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public GameObject winText; // วัตถุข้อความ "You Win"
    public GameObject playAgainButton; // วัตถุปุ่ม "Play Again"
    public GameObject exitButton; // วัตถุปุ่ม "Exit"

    private void Start()
    {
        winText.SetActive(false); // ซ่อนข้อความและปุ่มเมื่อเริ่มเกม
        playAgainButton.SetActive(false);
        exitButton.SetActive(false); // ซ่อนปุ่ม Exit ด้วย
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") // ตรวจสอบว่าผู้เล่นชนธง
        {
            winText.SetActive(true); // แสดงข้อความ "You Win"
            playAgainButton.SetActive(true); // แสดงปุ่ม "Play Again"
            exitButton.SetActive(true); // แสดงปุ่ม "Exit"
            Time.timeScale = 0; // หยุดเวลา
        }
    }

    // ฟังก์ชันสำหรับรีสตาร์ทเกมและกลับไปที่ Scene1
    public void RestartGame()
    {
        Time.timeScale = 1; // ตั้งค่าเวลาให้กลับมาเป็นปกติ
        SceneManager.LoadScene("Scene1"); // โหลด Scene1 ใหม่
    }

    // ฟังก์ชันสำหรับออกจากเกม
    public void ExitGame()
    {
        Application.Quit(); // ออกจากเกม
        Debug.Log("Game is exiting"); // ใช้ Debug.Log เพื่อทดสอบใน Unity Editor
    }
}
