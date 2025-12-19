public class FlowData
{
	public static string dialogue;
	public static string fullscreen;
	public static string options;
	public static string option;
	public static string background;

	public static string set_language(string lang)
	{
		switch (lang) {
			case "zh" or "CN":
				dialogue = "对话框";
				fullscreen = "全屏";
				options = "选项";
				option = "选择";
				background = "背景";
				break;
			case "en" or "EN":
				dialogue = "dialogue";
				fullscreen = "fullscreen";
				options = "options";
				option = "option";
				background = "background";
				break;
			case "jp" or "JP":
				dialogue = "ダイアログ";
            			fullscreen = "フルスクリーン";
            			options = "オプション";
            			option = "選択";
            			background = "背景";
				break;
			default:
				return $"Error: not found language: {lang}";
            			break;
		}
		return $"[True] Set language: {lang}";
	}

}

