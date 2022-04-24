﻿using GenShin_Launcher_Plus.ViewModels;
using GenShin_Launcher_Plus.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenShin_Launcher_Plus.Core
{
    /// <summary>
    /// 用于初始化语言包
    /// </summary>
    public class LoadProgramCore
    {
        public LoadProgramCore()
        {
            App.Current.DataModel = new();
            App.Current.NoticeOverAllBase = new();
        }

        private const string Lang_CN = "{\"LangVersion\":\"1.4.3.0\",\"Languages\":\"简体中文\",\"SaveBtn\":\"保存\",\"Error\":\"错误\",\"Determine\":\"确定\",\"Cancel\":\"取消\",\"TipsStr\":\"提醒\",\"LanguageSetTitle\":\"程序语言设置\",\"AboutStr\":\"注意，启动器涉及到注册表修改和文件替换，部分杀毒软\\r\\n件可能会报毒，为了客户端数据完整建议关闭杀软后再运行\\r\\n本程序完全开源，并不会将用户数据公布到网络，\\r\\n本启动器需要联网部分的代码仅为版本检测和公告获取\\r\\n\\r\\n\\r\\n编写：DawnFz (ねねだん)\\r\\n联系邮箱：admin@dawnfz.com\\r\\n技术支持：Lightczx（Github）【Snap.Genshin作者】\\r\\n您可以跳转到Github以获取本项目源代码\\r\\n\\r\\n\\r\\n————————本程序用到的代码及参考————————\\r\\n[Snap.Genshin]\\r\\n项目地址：https://github.com/DGP-Studio/Snap.Genshin \\r\\n\",\"MainTitle\":\"原神启动器Plus \",\"ScreenPathErr\":\"本功能为打开游戏内截图照相保存目录\\r\\n没有检测到照相文件或者请先输入正确的游戏路径！\",\"AboutTitle\":\"关于\",\"RunGameBtn\":\"开始游戏\",\"UserNameLab\":\"账号\",\"GamePortLab\":\"客户端\",\"UserNameStr\":\"账号\",\"GameClientStr\":\"客户端\",\"GameClientTypePStr\":\"官方服务器\",\"GameClientTypeBStr\":\"哔哩哔哩服\",\"GameClientTypeMStr\":\"国际服务器\",\"GameClientTypeNullStr\":\"未知客户端\",\"PathErrorMessageStr\":\"游戏路径不存在或者游戏路径错误！请检查重新设置后再试！\",\"AddUsersPageTitle\":\"保存上次登录的账号数据\",\"AddUsersPageSubTitle\":\"输入一个文件名以保存数据\",\"AddUsersPageTextboxTips\":\"请勿输入特殊符号\",\"AddUsersErrorMessageStr\":\"未选择帐户所属的服务器或未输入保存的名字，此保存将不会生效！\",\"SettingsTitle\":\"设置\",\"CloseBtn\":\"关闭\",\"HeightStr\":\"窗口高度\",\"WitdhStr\":\"窗口宽度\",\"AttachTitle\":\"窗口及分辨率\",\"UserListTitle\":\"选择使用的账号[可选]\",\"PathBoxTips\":\"在这里填写游戏目录[默认为Genshin Impact Game]\",\"DelUserBtn\":\"删除所选账号\",\"SwitchBtn\":\"转换\",\"BorderlessCkB\":\"无边框窗口化\",\"UnlockFpsCkB\":\"解锁帧率上限\",\"FpsBoxTips\":\"帧上限\",\"BackgroundCkB\":\"不使用网络背景\",\"BackgroundXK\":\"使用每日一图\",\"StateIndicatorDefault\":\"状态：无状态\",\"StateIndicatorUning\":\"状态：解压PKG资源文件中\",\"StateIndicatorUpdate\":\"状态：PKG资源文件有更新\",\"StateIndicatorCheck\":\"状态：请检查PKG文件是否存在\",\"StateIndicatorUnErr\":\"状态：PKG解压失败，请检查PKG是否正常\",\"StateIndicatorBaking\":\"状态：备份原始客户端中\",\"StateIndicatorReping\":\"状态：正在替换新文件到客户端\",\"StateIndicatorRecover\":\"状态：正在还原原始客户端文件\",\"StateIndicatorCleaning\":\"状态：清理多余文件中\",\"ConvertingLogStr\":\"备用PKG转换资源下载地址及访问密码: etxd\\r\\nhttps://pan.baidu.com/s/1-5zQoVfE7ImdXrn8OInKqg\\r\\n\",\"WindowMode\":\"窗口启动\",\"Fullscreen\":\"全屏启动\",\"GameDirMsg\":\"请选择游戏目录[默认为Genshin Impact Game]\",\"AdaptiveStr\":\"自适应屏幕分辨率\",\"SevereWarning\":\"严重警告\",\"SevereWarningStr\":\"此操作涉及修改游戏客户端进程，目前不知道确切会不会出现封号风险，出现问题请自行承担后果！如之前没使用过UnlockFPS的建议不要使用！按下同意代表使用本功能后的一切后果由自己承担！怕就不要用，用就不要怕！【注意：启用本功能后拉起游戏会慢一点，为正常现象】\",\"Warning\":\"警告\",\"WarningDAW\":\"您确定删除这个账号：\",\"ErrorSA\":\"请选中一个账号再使用本功能！\",\"ErrorEYJ\":\"在上面随便一个框填上想要的宽或者高另一个框留空使用本按钮自动取21:9比例分辨率\",\"WarningCCStr\":\"转换或还原将会执行重命名，替换，删除等操作修改客户端文件，该过程大概率会触发杀软报毒！为了防止客户端损坏导致不完整，执行前检查杀软（包括 Windows Defender）是否完全关闭或将本启动器加入白名单，并检查游戏是否彻底关闭，否则可能将导致客户端文件缺失！！\\r\\n\\r\\n提示：如游戏大版本更新时请执行还原转换为国内服使用游戏自带启动器更新！\",\"ErrorPkgUnzip\":\"解压失败\",\"ErrorPkgNF\":\"请检查Pkg文件是否和本应用处于同一目录\\r\\n\",\"PkgNoUnError\":\"PKG文件不存在或解压失败\",\"NewPkgVer\":\"转换包有新版本，访问密码：etxd：\",\"ErrorFileNF\":\"文件不存在，启动器将尝试下一步操作，若无反应请重新下载资源文件！\",\"FileExist\":\"存在\",\"ErrorBakF\":\"备份失败：原因：\",\"BakSuccess\":\"备份成功\",\"BakFileNfSk\":\"文件不存在，备份失败，跳过\",\"RepSuccess\":\"替换成功\",\"SwitchSucessStr\":\"客户端转换完成，请留意输出日志，记得保存哦~！~\\r\\n如果转换过程中出现什么问题可以参阅帮助文档网站~\",\"CleanedStr\":\"清理完毕\",\"CleanSkipStr\":\"文件不存在，已跳过\",\"RestoreSucess\":\"还原成功\",\"RestoreSkipStr\":\"不存在，跳过还原\",\"RestoreOverTipsStr\":\"还原完毕\",\"RestoreNum\":\"成功数\",\"RestoreErrNum\":\"失败数\",\"RestoreEndStr\":\"转换完成，您可以启动游戏了~\",\"DownPageTips\":\"因CDN缓存问题下载可能会有点慢或者卡进度，请耐心等待\",\"UpdateSkipBtn\":\"暂不更新\",\"DownStartBtn\":\"开始更新\",\"DownFailedStr\":\"网络更新文件资源不存在或服务器网络错误\",\"RepWarnStr\":\"你正在进行更新操作，请勿重复操作\",\"DownloadComStr\":\"下载完成，是否现在进行更新操作\\r\\n确定后只需等待5秒将自动启动新版本\",\"DownProgress\":\"下载进度\",\"WelcomeTitle\":\"欢迎使用原神启动器Plus\",\"BootstrapTitle\":\"在开始前请先跟随引导熟悉一下使用方法和规范\",\"PathHintLabel\":\"游戏目录本体指Genshin Impact下的Genshin Impact Game目录\",\"FinalTipLabel\":\"输入或者点击右侧[···]按钮选择如上图所示的游戏目录\",\"GuideFinishBtn\":\"完成向导\",\"SaveAccountErr\":\"保存账号错误，请检查您的账号是否为已登录状态\",\"UseGlobalUrl\":\"使用Github链接\",\"CloseGameWaring\":\"请先关闭游戏再执行转换操作，如确定游戏已经完全关闭还是弹此提示请重启电脑再试或联系开发者！\",\"ConvertError\":\"转换失败，请留意输出日志\\r\\n您也可以参阅帮助文档网站\",\"GameSettingsBtn\":\"游戏设置\",\"GameClientSwitchBtn\":\"客户端转换\",\"AccountSettingsBtn\":\"账号设置\",\"ProgramSettingsBtn\":\"程序设置\",\"SetDisplaySizeLab\":\"自定义启动游戏分辨率\",\"ChooseDisplaySizeListLab\":\"选择预设启动时游戏分辨率\",\"SetGameClientLab\":\"选择启动的游戏客户端\",\"SetGameWindowModeLab\":\"选择游戏窗口的启动模式\",\"SetBorderlessLab\":\"是否启用无边框窗口化\",\"SetUnLockFpsLab\":\"是否启用解锁帧率上限\",\"StartedCloseCkb\":\"启动游戏后关闭本程序\",\"NoCheckUpdateCkb\":\"关闭非必要更新提醒\",\"CheckUpdateBtn\":\"检查更新\",\"OpenProgameFolderBtn\":\"打开程序目录\",\"ProgameLanguageSetBtn\":\"程序语言设置\",\"SetMainBackgroundBtn\":\"主页背景设置\",\"GetPkgFileBtn\":\"下载Pkg文件\",}";
        private const string Lang_TW = "{\"LangVersion\":\"1.4.2.0\",\"Languages\":\"簡體中文\",\"SaveBtn\":\"保存\",\"Error\":\"錯誤\",\"Determine\":\"確定\",\"Cancel\":\"取消\",\"TipsStr\":\"提醒\",\"LanguageSetTitle\":\"程序語言設置\",\"AboutStr\":\"注意，啟動器涉及到註冊表修改和文件替換，部分殺毒軟\\r\\n件可能會報毒，為了客戶端數據完整建議關閉殺軟後再運行\\r\\n本程序完全開源，並不會將用戶數據公佈到網絡，\\r\\n本啟動器需要聯網部分的代碼僅為版本檢測和公告獲取\\r\\n\\r\\n\\r\\n編寫：DawnFz (ねねだん)\\r\\n聯繫郵箱：admin@dawnfz.com\\r\\n技術支持：Lightczx（Github）【Snap.Genshin作者】\\r\\n您可以跳轉到Github以獲取本項目源代碼\\r\\n\\r\\n\\r\\n————————本程序用到的代碼及參考————————\\r\\n[Snap.Genshin]\\r\\n項目地址：https://github.com/DGP-Studio/Snap.Genshin \\r\\n\",\"MainTitle\":\"原神啟動器Plus \",\"ScreenPathErr\":\"本功能為打開遊戲內截圖照相保存目錄\\r\\n沒有檢測到照相文件或者請先輸入正確的遊戲路徑！\",\"AboutTitle\":\"關於\",\"RunGameBtn\":\"開始遊戲\",\"UserNameLab\":\"賬號\",\"GamePortLab\":\"客戶端\",\"UserNameStr\":\"賬號\",\"GameClientStr\":\"客戶端\",\"GameClientTypePStr\":\"官方服務器\",\"GameClientTypeBStr\":\"嗶哩嗶哩服\",\"GameClientTypeMStr\":\"國際服務器\",\"GameClientTypeNullStr\":\"未知客戶端\",\"PathErrorMessageStr\":\"遊戲路徑不存在或者遊戲路徑錯誤！請檢查重新設置後再試！\",\"AddUsersPageTitle\":\"保存上次登錄的賬號數據\",\"AddUsersPageSubTitle\":\"輸入一個文件名以保存數據\",\"AddUsersPageTextboxTips\":\"請勿輸入特殊符號\",\"AddUsersErrorMessageStr\":\"未選擇帳戶所屬的服務器或未輸入保存的名字，此保存將不會生效！\",\"SettingsTitle\":\"設置\",\"CloseBtn\":\"關閉\",\"HeightStr\":\"窗口高度\",\"WitdhStr\":\"窗口寬度\",\"AttachTitle\":\"窗口及分辨率\",\"UserListTitle\":\"選擇使用的賬號[可選]\",\"PathBoxTips\":\"在這裡填寫遊戲目錄[默認為Genshin Impact Game]\",\"DelUserBtn\":\"刪除所選賬號\",\"SwitchBtn\":\"轉換\",\"BorderlessCkB\":\"無邊框窗口化\",\"UnlockFpsCkB\":\"解鎖幀率上限\",\"FpsBoxTips\":\"幀上限\",\"BackgroundCkB\":\"不使用網絡背景\",\"BackgroundXK\":\"使用每日一圖\",\"StateIndicatorDefault\":\"狀態：無狀態\",\"StateIndicatorUning\":\"狀態：解壓PKG資源文件中\",\"StateIndicatorUpdate\":\"狀態：PKG資源文件有更新\",\"StateIndicatorCheck\":\"狀態：請檢查PKG文件是否存在\",\"StateIndicatorUnErr\":\"狀態：PKG解壓失敗，請檢查PKG是否正常\",\"StateIndicatorBaking\":\"狀態：備份原始客戶端中\",\"StateIndicatorReping\":\"狀態：正在替換新文件到客戶端\",\"StateIndicatorRecover\":\"狀態：正在還原原始客戶端文件\",\"StateIndicatorCleaning\":\"狀態：清理多余文件中\",\"ConvertingLogStr\":\"備用PKG轉換資源下載地址及訪問密碼: etxd\\r\\nhttps://pan.baidu.com/s/1-5zQoVfE7ImdXrn8OInKqg\\r\\n\",\"WindowMode\":\"窗口啟動\",\"Fullscreen\":\"全屏啟動\",\"GameDirMsg\":\"請選擇遊戲目錄[默認為Genshin Impact Game]\",\"AdaptiveStr\":\"自適應屏幕分辨率\",\"SevereWarning\":\"嚴重警告\",\"SevereWarningStr\":\"此操作涉及修改遊戲客戶端進程，目前不知道確切會不會出現封號風險，出現問題請自行承擔後果！如之前沒使用過UnlockFPS的建議不要使用！按下同意代表使用本功能後的一切後果由自己承擔！怕就不要用，用就不要怕！【注意：啟用本功能後拉起遊戲會慢一點，為正常現象】\",\"Warning\":\"警告\",\"WarningDAW\":\"您確定刪除這個賬號：\",\"ErrorSA\":\"請選中一個賬號再使用本功能！\",\"ErrorEYJ\":\"在上面隨便一個框填上想要的寬或者高另一個框留空使用本按鈕自動取21:9比例分辨率\",\"WarningCCStr\":\"轉換或還原將會執行重命名，替換，刪除等操作修改客戶端文件，該過程大概率會觸發殺軟報毒！為了防止客戶端損壞導致不完整，執行前檢查殺軟（包括 Windows Defender）是否完全關閉或將本啟動器加入白名單，並檢查遊戲是否徹底關閉，否則可能將導致客戶端文件缺失！！\\r\\n\\r\\n提示：如游戲大版本更新時請執行還原轉換為國內服使用遊戲自帶啟動器更新！\",\"ErrorPkgUnzip\":\"解壓失敗\",\"ErrorPkgNF\":\"請檢查Pkg文件是否和本應用處於同一目錄\\r\\n\",\"PkgNoUnError\":\"PKG文件不存在或解壓失敗\",\"NewPkgVer\":\"轉換包有新版本，訪問密碼：etxd：\",\"ErrorFileNF\":\"文件不存在，啟動器將嘗試下一步操作，若無反應請重新下載資源文件！\",\"FileExist\":\"存在\",\"ErrorBakF\":\"備份失敗：原因：\",\"BakSuccess\":\"備份成功\",\"BakFileNfSk\":\"文件不存在，備份失敗，跳過\",\"RepSuccess\":\"替換成功\",\"SwitchSucessStr\":\"客戶端轉換完成，請留意輸出日誌，記得保存哦~！~\\r\\n如果轉換過程中出現什麼問題可以參閱幫助文檔網站~\",\"CleanedStr\":\"清理完畢\",\"CleanSkipStr\":\"文件不存在，已跳過\",\"RestoreSucess\":\"還原成功\",\"RestoreSkipStr\":\"不存在，跳過還原\",\"RestoreOverTipsStr\":\"還原完畢\",\"RestoreNum\":\"成功數\",\"RestoreErrNum\":\"失敗數\",\"RestoreEndStr\":\"轉換完成，您可以啟動遊戲了~\",\"DownPageTips\":\"因CDN緩存問題下載可能會有點慢或者卡進度，請耐心等待\",\"UpdateSkipBtn\":\"暫不更新\",\"DownStartBtn\":\"開始更新\",\"DownFailedStr\":\"網絡更新文件資源不存在或服務器網絡錯誤\",\"RepWarnStr\":\"你正在進行更新操作，請勿重複操作\",\"DownloadComStr\":\"下載完成，是否現在進行更新操作\\r\\n確定後只需等待5秒將自動啟動新版本\",\"DownProgress\":\"下載進度\",\"WelcomeTitle\":\"歡迎使用原神啟動器Plus\",\"BootstrapTitle\":\"在開始前請先跟隨引導熟悉一下使用方法和規範\",\"PathHintLabel\":\"遊戲目錄本體指Genshin Impact下的Genshin Impact Game目錄\",\"FinalTipLabel\":\"輸入或者點擊右側[···]按鈕選擇如上圖所示的遊戲目錄\",\"GuideFinishBtn\":\"完成嚮導\",\"SaveAccountErr\":\"保存賬號錯誤，請檢查您的賬號是否為已登錄狀態\",\"UseGlobalUrl\":\"使用Github鏈接\",\"CloseGameWaring\":\"請先關閉遊戲再執行轉換操作，如確定遊戲已經完全關閉還是彈此提示請重啟電腦再試或聯繫開發者！\",\"ConvertError\":\"轉換失敗，請留意輸出日誌\\r\\n您也可以參閱幫助文檔網站\",\"GameSettingsBtn\":\"遊戲設置\",\"GameClientSwitchBtn\":\"客戶端轉換\",\"AccountSettingsBtn\":\"賬號設置\",\"ProgramSettingsBtn\":\"程序設置\",\"SetDisplaySizeLab\":\"自定義啟動遊戲分辨率\",\"ChooseDisplaySizeListLab\":\"選擇預設啟動時遊戲分辨率\",\"SetGameClientLab\":\"選擇啟動的遊戲客戶端\",\"SetGameWindowModeLab\":\"選擇遊戲窗口的啟動模式\",\"SetBorderlessLab\":\"是否啟用無邊框窗口化\",\"SetUnLockFpsLab\":\"是否啟用解鎖幀率上限\",\"StartedCloseCkb\":\"啟動遊戲後關閉本程序\",\"NoCheckUpdateCkb\":\"關閉非必要更新提醒\",\"CheckUpdateBtn\":\"檢查更新\",\"OpenProgameFolderBtn\":\"打開程序目錄\",\"ProgameLanguageSetBtn\":\"程序語言設置\",\"SetMainBackgroundBtn\":\"主頁背景設置\",\"GetPkgFileBtn\":\"下載Pkg文件\",}";
        private const string Lang_EN = "{\"LangVersion\":\"1.4.2.0\",\"Languages\":\"English\",\"SaveBtn\":\"Save\",\"Error\":\"Error\",\"Determine\":\"OK\",\"Cancel\":\"Cancel\",\"TipsStr\":\"Reminder\",\"LanguageSetTitle\":\"Language\",\"AboutStr\":\"Attention, the launther involvs registry modification and files replacement, some antivirus software might report virus, for the integrity of the client data it is recommended to kill the antivirus software before running. This program is competly open open source, and will not publish user data, the code in the networking section of this launcher is for version detection and announcement acquisition only, Writer: DawnFz (ねねだん), Email: admin@dawnfz.com. Technical support: Lightczx(Github)【Snap.Genshin's writer】\\r\\nYou can get our source via Github\\n\\r\\n\\r\\n————————The code used in this program and reference————————\\r\\n[Snap.Genshin]\\r\\nAddress: https://github.com/DGP-Studio/Snap.Genshin\\r\\n\",\"MainTitle\":\"Genshin Launcher Plus \",\"ScreenPathErr\":\"This function is to open the in-game screenshot save directory\\r\\nNo file detected or please enter the correct game path first!\",\"AboutTitle\":\"About\",\"RunGameBtn\":\"Start\",\"UserNameLab\":\"Account\",\"GamePortLab\":\"Client\",\"UserNameStr\":\"Account\",\"GameClientStr\":\"Client\",\"GameClientTypePStr\":\"Official Server\",\"GameClientTypeBStr\":\"Bilibili Server\",\"GameClientTypeMStr\":\"Global Server\",\"GameClientTypeNullStr\":\"Unknown Client\",\"PathErrorMessageStr\":\"The game path does not exist! Please try again!\",\"AddUsersPageTitle\":\"Last Login Account Data Saving\",\"AddUsersPageSubTitle\":\"Enter a name to save the account\",\"AddUsersPageTextboxTips\":\"Do not enter special sybols\",\"AddUsersErrorMessageStr\":\"No server selected or No saved account entered, this will not take effect!\",\"SettingsTitle\":\"Settings\",\"CloseBtn\":\"Close\",\"HeightStr\":\"Window Height\",\"WitdhStr\":\"Window Width\",\"AttachTitle\":\"Display settings\",\"UserListTitle\":\"Login Account[OPTIONAL]\",\"ClientSwitchTitle\":\"Game Client Conversion\",\"PathBoxTips\":\"Enter the game path here[Usually Genshin Impact Game]\",\"DelUserBtn\":\"delete selected account\",\"SwitchBtn\":\"convert\",\"BorderlessCkB\":\"Borderless window\",\"UnlockFpsCkB\":\"Unlock FPA limit\",\"FpsBoxTips\":\"FPS Cap\",\"BackgroundCkB\":\"Don't use web background\",\"BackgroundXK\":\"Daily Background\",\"StateIndicatorDefault\":\"States: NO status\",\"StateIndicatorUning\":\"Statue: Extracting PKG resource file\",\"StateIndicatorUpdate\":\"Status: PKG resource file can be updated\",\"StateIndicatorCheck\":\"Status: Please make sure PKG file exist\",\"StateIndicatorUnErr\":\"Status: Failed to extract PKG file, please make sure the file exist\",\"StateIndicatorBaking\":\"Status: Backing up\",\"StateIndicatorReping\":\"Status: Replacing\",\"StateIndicatorRecover\":\"Status: Restoring\",\"StateIndicatorCleaning\":\"Status: Cleaning\",\"ConvertingLogStr\":\"PKG Resource File Download URL and access password: etxd\\r\\nhttps://pan.baidu.com/s/1-5zQoVfE7ImdXrn8OInKqg\\r\\n\",\"WindowMode\":\"Windowed\",\"Fullscreen\":\"Fullscreen\",\"GameDirMsg\":\"Enter the game path here[Usually Genshin Impact Game]\",\"AdaptiveStr\":\"adaptive screen resolution\",\"SevereWarning\":\"Alert\",\"SevereWarningStr\":\"This operation involves modifying the game client process, there will be a risk of account baning, you shall be responsible for any sonsequance caused by using this feature! Recommended not to use 'UnlockFPS' if never used before! Cliking Argee means that you shall be responsible for any sonsequance caused by using this feature!【Attention: Enabling this function will slowe down polling up the game, it is normal】\",\"Warning\":\"Warnning\",\"WarningDAW\":\"Are you sure to delete this account: \",\"ErrorSA\":\"Please select an account before using this function!\",\"ErrorEYJ\":\"Fill in any of the boxes above with the window's width or height and leave the other one blank, press this button to automatically take the 21:9 ratio resolution\",\"WarningCCStr\":\"Converting or restoring will perform renaming, Replace, delete and other operations to modify client files, this might triger the antivirus software, to prevent client corruption resulting in incompleteness, please completly kill the anti-virus software (including Windows Defender), and make sure the game is closed, ontherwise it will result in missing client files!!\\r\\n\\r\\nTips: Please restore to the original sever to update the game!\",\"ErrorPkgUnzip\":\"Extract failed\",\"ErrorPkgNF\":\"Please make sure the PKG file and the launcher is in the same folder\\r\\n\",\"PkgNoUnError\":\"PKG file does not exist or failed to extract\",\"NewPkgVer\":\"New version of PKG file is ready, access password: etxd: \",\"ErrorFileNF\":\"file does not exist, the launcher will try the next step, please download the resouce file again if there is no response!\",\"FileExist\":\"Exist\",\"ErrorBakF\":\"Backup failed: Reason: \",\"BakSuccess\":\"Backup successful\",\"BakFileNfSk\":\"File does not exist, backup failed skip\",\"RepSuccess\":\"Replace successful\",\"SwitchSucessStr\":\"Client conversion successful, please pay attension to the log, don't forget to save!~\\r\\nVisit the help ducumentation website if you have any problems during the conversion process~\",\"CleanedStr\":\"Cleaned\",\"CleanSkipStr\":\"File does not exist, skiped\",\"RestoreSucess\":\"restore successful\",\"RestoreSkipStr\":\"does not exist, skip Restore\",\"RestoreOverTipsStr\":\"restore successful\",\"RestoreNum\":\"Numbers of successful\",\"RestoreErrNum\":\"Numbers of failure\",\"RestoreEndStr\":\"convertion successful, have fun~\",\"DownPageTips\":\"The download speed is determined by CDN, please be patient\",\"UpdateSkipBtn\":\"Don't Update\",\"DownStartBtn\":\"Update\",\"DownFailedStr\":\"File resource form the internet does not exist or server network error\",\"RepWarnStr\":\"Updating, please do not perform any operations\",\"DownloadComStr\":\"Donwloaded, update or not\\r\\nThe new version will be launched in 5 seconds after confirmation\",\"DownProgress\":\"Progress\",\"WelcomeTitle\":\"Welcome to the Genshin Launcher Plus\",\"BootstrapTitle\":\"Please follow the guide to learn the usage before start\",\"PathHintLabel\":\"Game path refers to Genshin Impact folder under Genshin Impact Game catalog\",\"FinalTipLabel\":\"Enter or right click[···]button to select the game path\",\"GuideFinishBtn\":\"Let's Go\",\"SaveAccountErr\":\"Failed to save the account, please make sure the account is logged in\",\"UseGlobalUrl\":\"Via Github\",\"CloseGameWaring\":\"Please completely close the ganme before convertion, please restart your computer and try again or contact the developer if you are sure that the game has been conpletely closed or this prompt still pops up!\",\"ConvertError\":\"Convertion failed, please pay attention to the log\\r\\nYou can also visit the help documentation website\",\"GameSettingsBtn\":\"Game\",\"GameClientSwitchBtn\":\"Convert\",\"AccountSettingsBtn\":\"Account\",\"ProgramSettingsBtn\":\"Program\",\"SetDisplaySizeLab\":\"Custom launch game resolution\",\"ChooseDisplaySizeListLab\":\"Choose preset game resolution\",\"SetGameClientLab\":\"Select the game client to startup\",\"SetGameWindowModeLab\":\"Select the window mode for startup\",\"SetBorderlessLab\":\"Enable borderless window mode\",\"SetUnLockFpsLab\":\"Enable the unlock frame rate limit\",\"StartedCloseCkb\":\"Close this program after Start\",\"NoCheckUpdateCkb\":\"Don't check updates\",\"CheckUpdateBtn\":\"Check Updates\",\"OpenProgameFolderBtn\":\"Program Folder\",\"ProgameLanguageSetBtn\":\"Language\",\"SetMainBackgroundBtn\":\"Background\",\"GetPkgFileBtn\":\"Get PkgFile\"}";
        public void LoadLanguageCore()
        {
            //从JSON字符串生成集合对象用于存放语言包列表
            string json = "[{\"LangID\":\"0001\",\"LangVersion\":\"1.4.2.0\",\"LangName\":\"简体中文\",\"LangFileName\":\"Lang_CN\"},{\"LangID\":\"0002\",\"LangVersion\":\"1.4.2.0\",\"LangName\":\"繁体中文\",\"LangFileName\":\"Lang_TW\"},{\"LangID\":\"0003\",\"LangVersion\":\"1.4.2.0\",\"LangName\":\"English\",\"LangFileName\":\"Lang_EN\"}]";
            App.Current.LangList = JsonConvert.DeserializeObject<List<LanguageListModel>>(json);
            string langjson;
            switch (App.Current.DataModel.ReadLang)
            {
                case "Lang_CN":
                    langjson = Lang_CN;
                    break;
                case "Lang_TW":
                    langjson = Lang_TW;
                    break;
                case "Lang_EN":
                    langjson = Lang_EN;
                    break;
                default:
                    langjson = Lang_CN;
                    break;
            }
            App.Current.Language = JsonConvert.DeserializeObject<LanguageModel>(langjson);
        }
    }
}
