#TSV資料檔讀取程式（TSV File Reader Program）

##專案簡介
本專案使用 C# Windows Forms 開發，製作一個 TSV（Tab Separated Values）資料檔讀取系統。
使用者可以透過開啟功能選擇 TSV 資料檔，系統會自動讀取資料內容，並顯示於 ListView 清單中，方便進行資料瀏覽與管理。
本系統整合 OpenFileDialog、ListView、StatusStrip 與 Windows Forms 圖形介面，提升使用者互動體驗與資料檔管理便利性。

##功能說明

###開啟 TSV 檔案
使用 OpenFileDialog 選擇 `.tsv` 資料檔。

###TSV 資料讀取
讀取 TSV 檔內容並自動解析欄位資料。

###ListView 顯示資料
使用 ListView 呈現資料內容。

顯示欄位包含：
* 單字（Word）
* 音標（Phonogram）
* 音檔路徑（SoundPath）
* 解釋（Explain）

###狀態列顯示
讀取完成後會顯示載入筆數。
例如：
已載入 5 筆資料

###說明功能
提供「關於」視窗顯示程式資訊。

##執行說明

###開發環境
Visual Studio 2022
.NET Framework（Windows Forms）

###執行步驟
開啟專案（TSVFileReaderProgram.sln）
點擊「開始（Start）」執行程式
點選：
檔案 → 開啟
選擇 TSV 資料檔
系統自動讀取 TSV 檔案內容
資料會顯示於 ListView 清單中
狀態列顯示資料筆數
可透過：
說明 → 關於
查看程式資訊

##執行畫面（截圖）

###主畫面
<img width="1388" height="928" alt="image" src="https://github.com/user-attachments/assets/7ace38c7-e865-4f33-b488-923799234215" />

###開啟 TSV 檔案
<img width="732" height="508" alt="image" src="https://github.com/user-attachments/assets/cf9629f7-c4a6-4a8a-bfe7-7314e1ea0b9c" />
<img width="736" height="503" alt="image" src="https://github.com/user-attachments/assets/da167153-de5a-4e94-8727-500685e7b3bd" />
<img width="1347" height="922" alt="image" src="https://github.com/user-attachments/assets/6a35961d-ed7e-4dd6-aee9-499f476e57f9" />

###TSV 資料載入
<img width="742" height="497" alt="image" src="https://github.com/user-attachments/assets/14a6ebd4-4cd0-49fc-941a-45523f16628d" />

###ListView 顯示資料
<img width="742" height="497" alt="image" src="https://github.com/user-attachments/assets/c7d91f8c-21ac-483e-b093-26b04b3731fd" />

###狀態列顯示筆數
<img width="742" height="497" alt="image" src="https://github.com/user-attachments/assets/e9647ef0-f2bb-47c0-9abf-f1d1e9f17125" />

###關於視窗
<img width="734" height="498" alt="image" src="https://github.com/user-attachments/assets/e1784006-8763-4626-bb40-be6af8f6b25a" />
<img width="720" height="501" alt="image" src="https://github.com/user-attachments/assets/8887f837-f25f-4f01-9d9c-b2050a206f66" />
<img width="974" height="648" alt="image" src="https://github.com/user-attachments/assets/064a759b-a729-46dc-8ed5-546938f7a21c" />

###結束檔案
<img width="773" height="517" alt="image" src="https://github.com/user-attachments/assets/4925524d-01e9-4725-950f-b3d0d655b915" />
<img width="2879" height="1675" alt="image" src="https://github.com/user-attachments/assets/3f3f4112-5856-449f-8011-8695252682ba" />


##使用技術
C#
Windows Forms
ListView
OpenFileDialog
StatusStrip
ToolStripMenuItem
MessageBox
TSV（Tab Separated Values）
檔案讀取（File.ReadAllLines）
事件驅動（Click Event）


##專案架構
TSVFileReaderProgram
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── TSVFileReaderProgram.sln
├── README.md
│
└── Data
    └── Data.tsv

##TSV資料格式
Word	Phonogram	SoundPath	Explain
apple	ˈæpəl	apple.wav	蘋果
book	bʊk	book.wav	書本
cat	kæt	cat.wav	貓
dog	dɔg	dog.wav	狗

資料欄位使用 Tab 鍵分隔。


##開發紀錄
本專案透過 GitHub 進行版本控制，
提交紀錄清楚記錄以下開發過程：
* 建立 Windows Forms 介面
* 加入 MenuStrip 功能選單
* 建立 OpenFileDialog 開啟檔案功能
* 完成 TSV 檔案讀取功能
* 加入 ListView 顯示資料
* 完成狀態列資料筆數顯示
* 新增關於視窗功能
* 完成 TSV 資料解析功能
* 修正資料載入錯誤問題
* 完善使用者介面
* 撰寫 README 與截圖說明

