# .NetCore3.0-WinForm_TestWork
Приложение написано на .Net Core 3.0 с использованием WinForm.
Для сериализации в json используется пакет newtonsoft json


<b>Текст тестового задания</b>
<br>
Тестовое задание.

Язык реализации: c#
Платформа: .net core
OS: Windows, Linux

Исходные данные:
1) Путь к директории с файлами «*.infile». Если не задан то по умолчанию использовать «input». Файлы могут быть более 500 мб, кодировка utf8.
2) Путь к директории для сохранения результатов. Если не задан, то по умолчанию использовать «output».
3) Количество мест в top. Если не задано, то по умолчанию использовать 10.

Требуется прочитать файлы из директории с исходными данными, посчитать количество слов и «топ слов» используемых слов для каждого файла.

Результат:
Результат сохранить в директории для результатов в файлах («*.outfile», кодировка utf8) в следующем формате:
{
  "count": 0,
  "top": {
    "1": "Слово 1",
    "2": "Слово 2",
    …
    "10": "Слово 10"
  }
}
Count – количество слов,
Top – top n слов
В качестве имён файлов результатов использовать имена исходных файлов.
